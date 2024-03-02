using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Iris
{
    class ClientAccess
    {
        // メソッド名:GetClientData()
        // 引　数　　:なし
        // 戻り値　　:顧客データ
        // 機能　　　:顧客データの取得
        public List<M_Client> GetClientData()
        {
            List<M_Client> exist = null;
            try
            {
                var context = new SalesManagement_DevContext();
                exist = context.M_Clients.Where(x => x.ClFlag == 0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "顧客DBエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return exist;
        }
        // メソッド名:GetClientDisplay()
        // 引　数　　:なし
        // 戻り値　　:顧客(表示)データ
        // 機能　　　:顧客表示データの取得
        public List<M_ClientDsp> GetClientDisplay()
        {
            List<M_ClientDsp> ClientDsp = new List<M_ClientDsp>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.M_Clients
                            join t2 in context.M_SalesOffices
                            on t1.SoID equals t2.SoID
                            where (t1.ClFlag == 0)
                            select new
                            {
                                t1.ClID,
                                t1.SoID,
                                t2.SoName,
                                t1.ClName,
                                t1.ClAddress,
                                t1.ClPhone,
                                t1.ClPostal,
                                t1.ClFAX
                            };
                foreach (var p in table)
                {
                    ClientDsp.Add(new M_ClientDsp()
                    {
                        ClID = p.ClID,
                        SoID=p.SoID,
                        SoName = p.SoName,
                        ClName = p.ClName,
                        ClAddress = p.ClAddress,
                        ClPhone = p.ClPhone,
                        ClPostal = p.ClPostal,
                        ClFAX = p.ClFAX
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "顧客表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ClientDsp;
        }
    
        // メソッド名:GetClientCombo()
        // 引　数　　:なし
        // 戻り値　　:顧客データ(コンボボックス用)
        // 機能　　　:コンボボックス用顧客データの取得
        public List<M_ClientCombo> GetEmployeeCombo(int command)
        {
            List<M_ClientCombo> DataSource = new List<M_ClientCombo>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.M_Clients
                            where (t1.ClFlag == 0 && t1.SoID == command)
                            select new { 
                                t1.ClID,
                                t1.ClName
                            };
                foreach(var p in table)
                {
                    DataSource.Add(new M_ClientCombo()
                    {
                        Display = p.ClID + " " + p.ClName,
                        Value = p.ClID.ToString()
                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "顧客コンボボックスエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return DataSource;
        }
        public bool BravoSixGoingDark(M_Client reason)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var modify = context.M_Clients.Single(x => x.ClID == reason.ClID);
                modify.ClFlag = reason.ClFlag;
                modify.ClHidden = reason.ClHidden;
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "顧客非表示化エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool SnapBackToReality(int ID)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var modify = context.M_Clients.Single(X => X.ClID == ID);
                modify.ClFlag = 0;
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "顧客表示化エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
            public List<M_ClientDsp> DefaultSearch(int type, string search)
            {
                List<M_ClientDsp> Execute = new List<M_ClientDsp>();
                try
                {
                    var context = new SalesManagement_DevContext();
                    var table = from t1 in context.M_Clients
                                join t2 in context.M_SalesOffices
                                on t1.SoID equals t2.SoID
                                where (t1.ClFlag == 0)
                                select new
                                {
                                    t1.ClID,
                                    t1.SoID,
                                    t2.SoName,
                                    t1.ClName,
                                    t1.ClAddress,
                                    t1.ClPhone,
                                    t1.ClPostal,
                                    t1.ClFAX
                                };
                    switch (type)
                    {
                        case 0:
                        table = table.Where(x => x.ClID.ToString().Contains(search) || x.SoName.Contains(search)
                || x.ClName.Contains(search) || x.ClAddress.Contains(search)||x.ClPhone.Contains(search) || x.ClPostal.Contains(search)||x.ClFAX.Contains(search));
                            break;
                        case 1:
                            table = table.Where(x => x.SoName.Contains(search));
                            break;
                        case 2:
                        table = table.Where(x => x.ClID.ToString().Contains(search));
                            break;
                        case 3:
                            table = table.Where(x => x.ClName.Contains(search));
                            break;
                        case 4:
                            table = table.Where(x => x.ClAddress.Contains(search));
                            break;
                        case 5:
                            table = table.Where(x => x.ClPhone.Contains(search));
                            break;
                        case 6:
                            table = table.Where(x => x.ClPostal.Contains(search));
                            break;
                        case 7:
                            table = table.Where(x => x.ClFAX.Contains(search));
                            break;
                    }
                    foreach (var p in table)
                    {
                        Execute.Add(new M_ClientDsp()
                        {
                            ClID = p.ClID,
                            SoID=   p.SoID,
                            SoName = p.SoName,
                            ClName = p.ClName,
                            ClAddress = p.ClAddress,
                            ClPhone = p.ClPhone,
                            ClFAX = p.ClFAX,
                            ClPostal = p.ClPostal
                        });
                    }
                    context.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "顧客検索エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return Execute;
            }
        public List<M_ClientDspHidden> HiddenSearch(int type, string search)
        {
            List<M_ClientDspHidden> Execute = new List<M_ClientDspHidden>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.M_Clients
                            join t2 in context.M_SalesOffices
                            on t1.SoID equals t2.SoID
                            where (t1.ClFlag == 1)
                            select new
                            {
                                t1.ClID,
                                t1.SoID,
                                t2.SoName,
                                t1.ClName,
                                t1.ClAddress,
                                t1.ClPhone,
                                t1.ClPostal,
                                t1.ClFAX,
                                t1.ClFlag,
                                t1.ClHidden
                            };
                switch (type)
                {
                    case 0:
                        table = table.Where(x => x.ClID.ToString().Contains(search) ||x.SoName.Contains(search)|| x.ClName.Contains(search)
                || x.ClAddress.Contains(search) || x.ClPhone.Contains(search) || x.ClPostal.Contains(search)||x.ClFAX.Contains(search));
                        break;
                    case 1:
                        table = table.Where(x => x.SoName.Contains(search));
                        break;
                    case 2:
                        table = table.Where(x => x.ClID.ToString().Contains(search));
                        break;
                    case 3:
                        table = table.Where(x => x.ClName.Contains(search));
                        break;
                    case 4:
                        table = table.Where(x => x.ClAddress.Contains(search));
                        break;
                    case 5:
                        table = table.Where(x => x.ClPhone.Contains(search));
                        break;
                    case 6:
                        table = table.Where(x => x.ClPostal.Contains(search));
                        break;
                    case 7:
                        table = table.Where(x => x.ClFAX.Contains(search));
                        break;
                }
                foreach (var p in table)
                {
                    Execute.Add(new M_ClientDspHidden()
                    { 
                        ClID = p.ClID,
                        SoID=p.SoID,
                        SoName = p.SoName,
                        ClName = p.ClName,
                        ClAddress = p.ClAddress,
                        ClPhone = p.ClPhone,
                        ClFAX = p.ClFAX,
                        ClPostal = p.ClPostal,
                        ClFlag = p.ClFlag,
                        ClHidden = p.ClHidden
                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "顧客検索エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Execute;
        }
        public bool AddNew(M_Client AddThis)
        {
            try
            {
                SalesManagement_DevContext context = new SalesManagement_DevContext();
                context.M_Clients.Add(AddThis);
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "顧客追加エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        public bool Modify(M_Client ChangeThis, int ID)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var modify = context.M_Clients.Single(x => x.ClID == ID);
                modify.ClName = ChangeThis.ClName;
                modify.ClPhone = ChangeThis.ClPhone;
                modify.ClAddress = ChangeThis.ClAddress;
                modify.ClPostal = ChangeThis.ClPostal;
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "顧客更新エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
    }
