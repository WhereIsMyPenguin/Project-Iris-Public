using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project_Iris
{
    
    class SalesOfficeAccess
    {
        // メソッド名:GetSalesOfficeCombos()
        // 引　数　　:なし
        // 戻り値　　:営業所データ
        // 機能　　　:営業所データの取得
        public List<M_SalesOfficeCombo> GetSalesOfficeCombos()
        {
            List<M_SalesOfficeCombo> cmb = new List<M_SalesOfficeCombo>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.M_SalesOffices
                            where (t1.SoFlag == 0)
                            select new
                            {
                                t1.SoID,
                                t1.SoName
                            };
                foreach(var p in table)
                {
                    cmb.Add(new M_SalesOfficeCombo()
                    {
                        Display = p.SoID.ToString() + " " + p.SoName,
                        Value = p.SoID.ToString()
                    });
                }

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "営業所コンボボックス読み込みエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return cmb;
        }
        // メソッド名:GetSalesOfficeDisplay()
        // 引　数　　:なし
        // 戻り値　　:営業所(表示)データ
        // 機能　　　:表示用営業所データの取得
        public List<M_SalesOfficeDsp> GetSalesOfficeDisplay()
        {

            List<M_SalesOfficeDsp> SalesOfficeDsp = new List<M_SalesOfficeDsp>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.M_SalesOffices
                            where(t1.SoFlag == 0)
                            select new
                            {
                                t1.SoID,
                                t1.SoName,
                                t1.SoAddress,
                                t1.SoPhone,
                                t1.SoPostal,
                                t1.SoFAX
                            };
                foreach(var p in table)
                {
                    SalesOfficeDsp.Add(new M_SalesOfficeDsp() {
                        SoID = p.SoID,
                        SoName = p.SoName,
                        SoAddress = p.SoAddress,
                        SoPhone = p.SoPhone,
                        SoPostal = p.SoPostal,
                        SoFAX = p.SoFAX
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "営業所表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return SalesOfficeDsp;
        }
        public bool AddNew(M_SalesOffice AddThis)
        {
            try
            {
                SalesManagement_DevContext context = new SalesManagement_DevContext();
                context.M_SalesOffices.Add(AddThis);
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "営業所追加エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        public bool Modify(M_SalesOffice ChangeThis, int ID)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var modify = context.M_SalesOffices.Single(x => x.SoID == ID);
                modify.SoName = ChangeThis.SoName;
                modify.SoPhone = ChangeThis.SoPhone;
                modify.SoAddress = ChangeThis.SoAddress;
                modify.SoPostal = ChangeThis.SoPostal;
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "営業所更新エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool BravoSixGoingDark(M_SalesOffice reason)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var modify = context.M_SalesOffices.Single(x => x.SoID == reason.SoID);
                modify.SoFlag = reason.SoFlag;
                modify.SoHidden = reason.SoHidden;
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "営業所非表示化エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool SnapBackToReality(int ID)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var modify = context.M_SalesOffices.Single(X => X.SoID == ID);
                modify.SoFlag = 0;
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "営業所表示化エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public List<M_SalesOfficeDsp> DefaultSearch (int type, string search)
        {
            List<M_SalesOfficeDsp> Execute = new List<M_SalesOfficeDsp>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.M_SalesOffices
                            where (t1.SoFlag == 0)
                            select new
                            {
                                t1.SoID,
                                t1.SoName,
                                t1.SoAddress,
                                t1.SoPhone,
                                t1.SoPostal,
                                t1.SoFAX
                            };
                switch (type)
                {
                    case 0:
                        table = table.Where(x => x.SoID.ToString().Contains(search) || x.SoName.Contains(search)
                || x.SoAddress.Contains(search) || x.SoPhone.Contains(search) || x.SoPostal.Contains(search));
                        break;
                    case 1:
                        table = table.Where(x => x.SoID.ToString().Contains(search));
                        break;
                    case 2:
                        table = table.Where(x => x.SoName.Contains(search));
                        break;
                    case 3:
                        table = table.Where(x => x.SoAddress.Contains(search));
                        break;
                    case 4:
                        table = table.Where(x => x.SoPhone.Contains(search));
                        break;
                    case 5:
                        table = table.Where(x => x.SoPostal.Contains(search));
                        break;
                    case 6:
                        table = table.Where(x => x.SoFAX.Contains(search));
                        break;
                }
                foreach (var p in table)
                {
                    Execute.Add(new M_SalesOfficeDsp()
                    {
                        SoID = p.SoID,
                        SoName = p.SoName,
                        SoAddress = p.SoAddress,
                        SoPhone = p.SoPhone,
                        SoFAX = p.SoFAX,
                        SoPostal = p.SoPostal
                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "営業所検索エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Execute;
        }
        public List<M_SalesOfficeDspHidden> HiddenSearch(int type, string search)
        {
            List<M_SalesOfficeDspHidden> Execute = new List<M_SalesOfficeDspHidden>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.M_SalesOffices
                            where (t1.SoFlag == 1)
                            select new
                            {
                                t1.SoID,
                                t1.SoName,
                                t1.SoAddress,
                                t1.SoPhone,
                                t1.SoPostal,
                                t1.SoFAX,
                                t1.SoFlag,
                                t1.SoHidden
                            };
                switch (type)
                {
                    case 0:
                        table = table.Where(x => x.SoID.ToString().Contains(search) || x.SoName.Contains(search)
                || x.SoAddress.Contains(search) || x.SoPhone.Contains(search) || x.SoPostal.Contains(search));
                        break;
                    case 1:
                        table = table.Where(x => x.SoID.ToString().Contains(search));
                        break;
                    case 2:
                        table = table.Where(x => x.SoName.Contains(search));
                        break;
                    case 3:
                        table = table.Where(x => x.SoAddress.Contains(search));
                        break;
                    case 4:
                        table = table.Where(x => x.SoPhone.Contains(search));
                        break;
                    case 5:
                        table = table.Where(x => x.SoPostal.Contains(search));
                        break;
                    case 6:
                        table = table.Where(x => x.SoFAX.Contains(search));
                        break;
                }
                foreach (var p in table)
                {
                    Execute.Add(new M_SalesOfficeDspHidden()
                    {
                        SoID = p.SoID,
                        SoName = p.SoName,
                        SoAddress = p.SoAddress,
                        SoPhone = p.SoPhone,
                        SoFAX = p.SoFAX,
                        SoPostal = p.SoPostal,
                        SoFlag = p.SoFlag,
                        SoHidden = p.SoHidden
                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "営業所検索エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Execute;
        }
        // メソッド名:GetSalesOfficeCombo()
        // 引　数　　:なし
        // 戻り値　　:営業所データ(コンボボックス用)
        // 機能　　　:コンボボックス用営業所データの取得
        public List<M_SalesOffice> GetSalesOfficeCombo(int command)
        {
            List<M_SalesOffice> DataSource = null;
            try
            {
                var context = new SalesManagement_DevContext();
                DataSource = context.M_SalesOffices.Where(x => x.SoID == command && x.SoFlag == 0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "営業所コンボボックスエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return DataSource;
        }
    }
}
