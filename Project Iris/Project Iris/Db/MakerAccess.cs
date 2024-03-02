using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Iris
{
    class MakerAccess
    {
        // メソッド名:GetMakerCombo()
        // 引　数　　:なし
        // 戻り値　　:メーカデータ
        // 機能　　　:メーカデータの取得
        public List<M_MakerCombo> GetMakerCombo()
        {
            List<M_MakerCombo> exist = new List<M_MakerCombo>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.M_Makers
                            where t1.MaFlag == 0
                            select new { 
                                t1.MaID,
                                t1.MaName
                            };
                foreach(var p in table)
                {
                    exist.Add(new M_MakerCombo()
                    {
                        Display = p.MaID + " " + p.MaName,
                        Value = p.MaID.ToString()
                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "メーカDBエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return exist;
        }
        // メソッド名:GetMakerDisplay()
        // 引　数　　:なし
        // 戻り値　　:メーカ(表示)データ
        // 機能　　　:メーカ表示データの取得
        public List<M_MakerDsp> GetMakerDisplay()
        {
            List<M_MakerDsp> MakerDsp = new List<M_MakerDsp>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.M_Makers
                            where (t1.MaFlag == 0)
                            select new
                            {
                                t1.MaID,
                                t1.MaName,
                                t1.MaAdress,
                                t1.MaPhone,
                                t1.MaPostal,
                                t1.MaFAX
                            };
                foreach (var p in table)
                {
                    MakerDsp.Add(new M_MakerDsp()
                    {
                        MaID = p.MaID,
                        MaName = p.MaName,
                        MaAdress = p.MaAdress,
                        MaPhone = p.MaPhone,
                        MaPostal = p.MaPostal,
                        MaFAX = p.MaFAX
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "メーカ表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return MakerDsp;
        }
        public List<M_MakerDsp> DefaultSearch(int type, string search)
        {
            List<M_MakerDsp> Execute = new List<M_MakerDsp>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.M_Makers
                            where (t1.MaFlag == 0)
                            select new
                            {
                                t1.MaID,
                                t1.MaName,
                                t1.MaAdress,
                                t1.MaPhone,
                                t1.MaPostal,
                                t1.MaFAX
                            };
                switch (type)
                {
                    case 0:
                        table = table.Where(x => x.MaID.ToString().Contains(search) || x.MaName.Contains(search)
                || x.MaAdress.Contains(search) || x.MaPhone.Contains(search) || x.MaPostal.Contains(search));
                        break;
                    case 1:
                        table = table.Where(x => x.MaID.ToString().Contains(search));
                        break;
                    case 2:
                        table = table.Where(x => x.MaName.Contains(search));
                        break;
                    case 3:
                        table = table.Where(x => x.MaAdress.Contains(search));
                        break;
                    case 4:
                        table = table.Where(x => x.MaPhone.Contains(search));
                        break;
                    case 5:
                        table = table.Where(x => x.MaPostal.Contains(search));
                        break;
                    case 6:
                        table = table.Where(x => x.MaFAX.Contains(search));
                        break;
                }
                foreach (var p in table)
                {
                    Execute.Add(new M_MakerDsp()
                    {
                        MaID = p.MaID,
                        MaName = p.MaName,
                        MaAdress = p.MaAdress,
                        MaPhone = p.MaPhone,
                        MaFAX = p.MaFAX,
                        MaPostal = p.MaPostal
                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "メーカ検索エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Execute;
        }
        public List<M_MakerDspHidden> HiddenSearch(int type, string search)
        {
            List<M_MakerDspHidden> Execute = new List<M_MakerDspHidden>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.M_Makers
                            where (t1.MaFlag == 1)
                            select new
                            {
                                t1.MaID,
                                t1.MaName,
                                t1.MaAdress,
                                t1.MaPhone,
                                t1.MaPostal,
                                t1.MaFAX,
                                t1.MaFlag,
                                t1.MaHidden
                            };
                switch (type)
                {
                    case 0:
                        table = table.Where(x => x.MaID.ToString().Contains(search) || x.MaName.Contains(search)
                || x.MaAdress.Contains(search) || x.MaPhone.Contains(search) || x.MaPostal.Contains(search));
                        break;
                    case 1:
                        table = table.Where(x => x.MaID.ToString().Contains(search));
                        break;
                    case 2:
                        table = table.Where(x => x.MaName.Contains(search));
                        break;
                    case 3:
                        table = table.Where(x => x.MaAdress.Contains(search));
                        break;
                    case 4:
                        table = table.Where(x => x.MaPhone.Contains(search));
                        break;
                    case 5:
                        table = table.Where(x => x.MaPostal.Contains(search));
                        break;
                    case 6:
                        table = table.Where(x => x.MaFAX.Contains(search));
                        break;
                }
                foreach (var p in table)
                {
                    Execute.Add(new M_MakerDspHidden()
                    {
                        MaID = p.MaID,
                        MaName = p.MaName,
                        MaAdress = p.MaAdress,
                        MaPhone = p.MaPhone,
                        MaFAX = p.MaFAX,
                        MaPostal = p.MaPostal,
                        MaFlag = p.MaFlag,
                        MaHidden = p.MaHidden
                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "メーカ検索エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Execute;
        }
        public bool AddNew(M_Maker AddThis)
        {
            try
            {
                SalesManagement_DevContext context = new SalesManagement_DevContext();
                context.M_Makers.Add(AddThis);
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "メーカ追加エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        public bool Modify(M_Maker ChangeThis, int ID)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var modify = context.M_Makers.Single(x => x.MaID == ID);
                modify.MaName = ChangeThis.MaName;
                modify.MaPhone = ChangeThis.MaPhone;
                modify.MaAdress = ChangeThis.MaAdress;
                modify.MaPostal = ChangeThis.MaPostal;
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "メーカ更新エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool BravoSixGoingDark(M_Maker reason)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var modify = context.M_Makers.Single(x => x.MaID == reason.MaID);
                modify.MaFlag = reason.MaFlag;
                modify.MaHidden = reason.MaHidden;
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "メーカ非表示化エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool SnapBackToReality(int ID)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var modify = context.M_Makers.Single(X => X.MaID == ID);
                modify.MaFlag = 0;
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "メーカ表示化エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}