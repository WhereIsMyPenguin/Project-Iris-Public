using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Iris
{
    class ClassificationAccess
    {
        // メソッド名:GetMajorClassCombo()
        // 引　数　　:なし
        // 戻り値　　:大分類データ
        // 機能　　　:大分類データの取得
        public List<M_MajorClassificationCombo> GetMajorClassCombo(int? small)
        {
            List<M_MajorClassificationCombo> exist = new List<M_MajorClassificationCombo>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.M_MajorClassifications
                            where (t1.McFlag == 0)
                            select new
                            {
                                t1.McID,
                                t1.McName
                            };
                if (small != null)
                    table = table.Where(x => x.McID == small);
                foreach(var p in table)
                {
                    exist.Add(new M_MajorClassificationCombo() { 
                        Display = p.McID + " " + p.McName,
                        Value = p.McID.ToString()
                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "大分類DBエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return exist;
        }
        // メソッド名:GetSmallClassData()
        // 引　数　　:なし
        // 戻り値　　:小分類データ
        // 機能　　　:小分類データの取得
        public List<M_SmallClassificationCombo> GetSmallClassCombo(int? major)
        {
            List<M_SmallClassificationCombo> exist = new List<M_SmallClassificationCombo>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.M_SmallClassifications
                            where (t1.ScFlag == 0)
                            select new
                            {
                                t1.ScID,
                                t1.McID,
                                t1.ScName
                            };
                if (major != null)
                    table = table.Where(x => x.McID == major);
                foreach(var p in table)
                {
                    exist.Add(new M_SmallClassificationCombo()
                    {
                        Display = p.ScID + " " + p.ScName,
                        Value = p.ScID.ToString()
                    });
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "小分類DBエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return exist;
        }

        // メソッド名:GetMajorClassDisplay()
        // 引　数　　:なし
        // 戻り値　　:大分類データ(表示用)
        // 機能　　　:表示用大分類データの取得
        public List<M_MajorClassificationDsp> GetMajorClassDisplay()
        {
            List<M_MajorClassificationDsp> dsp = new List<M_MajorClassificationDsp>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.M_MajorClassifications
                            where (t1.McFlag == 0)
                            select new
                            {
                                t1.McID,
                                t1.McName,
                            };
                foreach (var p in table)
                {
                    dsp.Add(new M_MajorClassificationDsp()
                    {
                        McID = p.McID,
                        McName = p.McName
                    });
                }
                context.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "大分類表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dsp;
        }
        // メソッド名:GetSmallClassDisplay()
        // 引　数　　:なし
        // 戻り値　　:小分類データ(表示用)
        // 機能　　　:表示用小分類データの取得
        public List<M_SmallClassificationDsp> GetSmallClassDisplay(int ID)
        {
            List<M_SmallClassificationDsp> dsp = new List<M_SmallClassificationDsp>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.M_SmallClassifications
                            where (t1.ScFlag == 0 && t1.McID == ID)
                            select new
                            {
                                t1.ScID,
                                t1.ScName,
                            };
                foreach (var p in table)
                {
                    dsp.Add(new M_SmallClassificationDsp()
                    {
                        ScID = p.ScID,
                        ScName = p.ScName
                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "小分類表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dsp;
        }
        // メソッド名:AddMajor()
        // 引　数　　:なし
        // 戻り値　　:大分類データの追加
        // 機能　　　:大分類データの追加
        public bool AddMajor(string Major)
        {
            try
            {
                using(var context = new SalesManagement_DevContext())
                {
                    M_MajorClassification AddThis = new M_MajorClassification()
                    {
                        McName = Major
                    };
                    context.M_MajorClassifications.Add(AddThis);
                    context.SaveChanges();
                }
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "大分類追加エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // メソッド名:AddSmall()
        // 引　数　　:なし
        // 戻り値　　:小分類データの追加
        // 機能　　　:小分類データの追加
        public bool AddSmall(string Small,int Major)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    if(context.M_SmallClassifications.Any(x => x.ScFlag == 1) == true)
                    {
                        var modify = context.M_SmallClassifications.Where(x => x.ScFlag == 1).First();
                        modify.McID = Major;
                        modify.ScName = Small;
                        modify.ScFlag = 0;
                        modify.ScHidden = "";
                        context.SaveChanges();
                    }
                    else
                    {
                        M_SmallClassification AddThis = new M_SmallClassification()
                        {
                            McID = Major,
                            ScName = Small,
                            ScFlag = 0
                        };
                        context.M_SmallClassifications.Add(AddThis);
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "小分類追加エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // メソッド名:ModifyMajor()
        // 引　数　　:なし
        // 戻り値　　:大分類データの更新
        // 機能　　　:大分類データの更新
        public bool ModifyMajor (M_MajorClassification mod)
        {
            try
            {
                using(var context = new SalesManagement_DevContext())
                {
                    var modify = context.M_MajorClassifications.Single(x => x.McID == mod.McID);
                    modify.McName = mod.McName;
                    context.SaveChanges();
                }
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "大分類更新エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // メソッド名:ModifySmall()
        // 引　数　　:なし
        // 戻り値　　:小分類データの更新
        // 機能　　　:小分類データの更新
        public bool ModifySmall(M_SmallClassification mod)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    var modify = context.M_SmallClassifications.Single(x => x.ScID == mod.ScID);
                    modify.ScName = mod.ScName;
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "小分類更新エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // メソッド名:BravoSixGoingDarkMajor()
        // 引　数　　:なし
        // 戻り値　　:大分類データの非表示
        // 機能　　　:大分類データの非表示
        public bool BravoSixGoingDarkMajor(M_MajorClassification Delete)
        {
            try
            {
                using(var context = new SalesManagement_DevContext())
                {
                    var DeleteThis = context.M_MajorClassifications.Single(x => x.McID == Delete.McID);
                    DeleteThis.McFlag = 1;
                    DeleteThis.McHidden = Delete.McHidden;
                    context.SaveChanges();
                }
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "大分類非表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // メソッド名:BravoSixGoingDarkSmall()
        // 引　数　　:なし
        // 戻り値　　:小分類データの非表示
        // 機能　　　:小分類データの非表示
        public bool BravoSixGoingDarkSmall(M_SmallClassification Delete)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    var DeleteThis = context.M_SmallClassifications.Single(x => x.ScID == Delete.ScID);
                    DeleteThis.ScFlag = 1;
                    DeleteThis.ScHidden = Delete.ScHidden;
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "小分類非表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // メソッド名:SearchMajor()
        // 引　数　　:なし
        // 戻り値　　:大分類データの検索
        // 機能　　　:大分類データの検索
        public List<M_MajorClassificationDsp> DefaultSearchMajor(string search)
        {
            List<M_MajorClassificationDsp> Execute = new List<M_MajorClassificationDsp>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.M_MajorClassifications
                            where (t1.McFlag == 0 && (t1.McName.Contains(search) || t1.McID.ToString().Contains(search)))
                            select new
                            { 
                                t1.McID,
                                t1.McName
                            };
                foreach(var p in table)
                {
                    Execute.Add(new M_MajorClassificationDsp()
                    {
                        McID = p.McID,
                        McName = p.McName
                    });
                }
                context.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "大分類検索エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Execute;
        }
        // メソッド名:HiddenSearch()
        // 引　数　　:なし
        // 戻り値　　:大分類データの検索（非表示されたもの）
        // 機能　　　:大分類データの検索（非表示されたもの）
        public List<M_MajorClassificationHiddenDsp> HiddenSearch(string search)
        {
            List<M_MajorClassificationHiddenDsp> Execute = new List<M_MajorClassificationHiddenDsp>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.M_MajorClassifications
                            where (t1.McFlag == 1 && (t1.McName.Contains(search) || t1.McID.ToString().Contains(search)))
                            select new
                            {
                                t1.McID,
                                t1.McName,
                                t1.McHidden
                            };
                foreach (var p in table)
                {
                    Execute.Add(new M_MajorClassificationHiddenDsp()
                    {
                        McID = p.McID,
                        McName = p.McName,
                        McHidden = p.McHidden
                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "大分類検索エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Execute;
        }
        // メソッド名:SearchSmall()
        // 引　数　　:なし
        // 戻り値　　:小分類データの検索
        // 機能　　　:小分類データの検索
        public List<M_SmallClassificationDsp> SearchSmall(string search, int id)
        {
            List<M_SmallClassificationDsp> Execute = new List<M_SmallClassificationDsp>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.M_SmallClassifications
                            where (t1.ScFlag == 0 && (t1.ScName.Contains(search) || t1.ScID.ToString().Contains(search)) && t1.McID == id)
                            select new
                            {
                                t1.ScID,
                                t1.ScName
                            };
                foreach (var p in table)
                {
                    Execute.Add(new M_SmallClassificationDsp()
                    {
                        ScID = p.ScID,
                        ScName = p.ScName
                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "大分類検索エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Execute;
        }
    }
}
