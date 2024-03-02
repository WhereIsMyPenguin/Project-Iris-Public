using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Iris
{
    class EmployeeAccess
    {
        // メソッド名:GetEmployeeCombo()
        // 引　数　　:なし
        // 戻り値　　:コンボボックス用社員データ
        // 機能　　　:コンボボックス用社員データの取得
        public List<M_EmployeeCombo> GetEmployeeCombo(int SoID)
        {
            List<M_EmployeeCombo> exist = new List<M_EmployeeCombo>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.M_Employees.AsEnumerable()
                            join t2 in context.M_Positions.AsEnumerable()
                            on t1.PoID equals t2.PoID
                            where (t1.SoID == SoID && t1.EmFlag == 0 && t2.Positions.Split(',')[5] == "RW")
                            select new { 
                            t1.EmID,
                            t1.EmName
                            };
                foreach(var p in table)
                {
                    exist.Add(new M_EmployeeCombo() { 
                        Display = p.EmID.ToString() + " " + p.EmName,
                        Value = p.EmID.ToString()
                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "社員DBエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return exist;
        }
        // メソッド名:GetEmployeeDisplay()
        // 引　数　　:なし
        // 戻り値　　:社員データ(表示用)
        // 機能　　　:表示用社員データの取得
        public List<M_EmployeeDsp> GetEmployeeDisplay()
        {
            List<M_EmployeeDsp> EmployeeDsp = new List<M_EmployeeDsp>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.M_Employees
                            join t2 in context.M_SalesOffices
                            on t1.SoID equals t2.SoID
                            join t3 in context.M_Positions
                            on t1.PoID equals t3.PoID
                            where (t1.EmFlag == 0)
                            select new {
                                t1.EmID,
                                t1.EmName,
                                t1.SoID,
                                t2.SoName,
                                t1.PoID,
                                t3.PoName,
                                t1.EmHiredate,
                                t1.EmPhone
                            };
                foreach(var p in table)
                {
                    EmployeeDsp.Add(new M_EmployeeDsp() { 
                        EmID = p.EmID,
                        EmName = p.EmName,
                        SoID = p.SoID,
                        SoName = p.SoName,
                        PoID = p.PoID,
                        PoName = p.PoName,
                        EmHireDate = p.EmHiredate,
                        EmPhone = p.EmPhone
                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "社員表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return EmployeeDsp;
        }
        public List<M_EmployeeDspHidden> GetEmployeeDisplayHidden()
        {
            List<M_EmployeeDspHidden> EmployeeDsp = new List<M_EmployeeDspHidden>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.M_Employees
                            join t2 in context.M_SalesOffices
                            on t1.SoID equals t2.SoID
                            join t3 in context.M_Positions
                            on t1.PoID equals t3.PoID
                            where (t1.EmFlag == 1)
                            select new
                            {
                                t1.EmID,
                                t1.EmName,
                                t1.SoID,
                                t2.SoName,
                                t1.PoID,
                                t3.PoName,
                                t1.EmHiredate,
                                t1.EmPhone,
                                t1.EmFlag,
                                t1.EmHidden
                            };
                foreach (var p in table)
                {
                    EmployeeDsp.Add(new M_EmployeeDspHidden()
                    {
                        EmID = p.EmID,
                        EmName = p.EmName,
                        SoID = p.SoID,
                        SoName = p.SoName,
                        PoID = p.PoID,
                        PoName = p.PoName,
                        EmHireDate = p.EmHiredate,
                        EmPhone = p.EmPhone,
                        EmFlag = p.EmFlag,
                        EmHidden = p.EmHidden
                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "社員表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return EmployeeDsp;
        }
        public bool BravoSixGoingDark(M_Employee reason)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var modify = context.M_Employees.Single(x => x.EmID == reason.EmID);
                modify.EmFlag = reason.EmFlag;
                modify.EmHidden = reason.EmHidden;
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "社員非表示化エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool SnapBackToReality(M_Employee reason)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var modify = context.M_Employees.Single(x => x.EmID == reason.EmID);
                modify.EmFlag = reason.EmFlag;
                modify.EmHidden = "";
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "社員表示化エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool AddNew(M_Employee AddThis)
        {
            try
            {
                SalesManagement_DevContext context = new SalesManagement_DevContext();
                context.M_Employees.Add(AddThis);
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "社員追加エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool Modify(M_Employee ChangeThis,int ID)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var modify = context.M_Employees.Single(x => x.EmID == ID);
                modify.EmName = ChangeThis.EmName;
                modify.EmPhone = ChangeThis.EmPhone;
                modify.PoID = ChangeThis.PoID;
                modify.SoID = ChangeThis.SoID;
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "社員更新エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool ModifyPass(M_Employee ChangeThis,int ID)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var modify = context.M_Employees.Single(x => x.EmID == ID);
                modify.EmPassword = ChangeThis.EmPassword;
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "社員更新エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public List<M_EmployeeDsp> DefaultSearch(int type, string search, bool DateCheck,DateTime From,DateTime To)
        {
            List<M_EmployeeDsp> Execute = new List<M_EmployeeDsp>();
            try
            {
                SalesManagement_DevContext context = new SalesManagement_DevContext();
                var table = from t1 in context.M_Employees
                            join t2 in context.M_SalesOffices
                            on t1.SoID equals t2.SoID
                            join t3 in context.M_Positions
                            on t1.PoID equals t3.PoID
                            where (t1.EmFlag == 0)
                            select new
                            {
                                t1.EmID,
                                t1.EmName,
                                t1.SoID,
                                t2.SoName,
                                t1.PoID,
                                t3.PoName,
                                t1.EmPhone,
                                t1.EmHiredate
                            };
                if(!DateCheck)
                {
                    switch (type)
                    {
                        case 0:
                            table = table.Where(x => x.EmID.ToString().Contains(search) || x.EmName.Contains(search) || x.SoName.Contains(search)
                    || x.PoName.Contains(search));
                            break;
                        case 1:
                            table = table.Where(x => x.EmID.ToString().Contains(search));
                            break;
                        case 2:
                            table = table.Where(x => x.EmName.Contains(search));
                            break;
                        case 3:
                            table = table.Where(x => x.SoName.Contains(search));
                            break;
                        case 4:
                            table = table.Where(x => x.PoName.Contains(search));
                            break;

                    }
                }
                else
                {
                    switch (type)
                    {
                        case 0:
                            table = table.Where(x => (x.EmID.ToString().Contains(search) || x.EmName.Contains(search) || x.SoName.Contains(search)
                    || x.PoName.Contains(search)) && (x.EmHiredate >= From.Date && x.EmHiredate <= To.Date));
                            break;
                        case 1:
                            table = table.Where(x => x.EmID.ToString().Contains(search) && (x.EmHiredate >= From.Date && x.EmHiredate <= To.Date));
                            break;
                        case 2:
                            table = table.Where(x => x.EmName.Contains(search) && (x.EmHiredate >= From.Date && x.EmHiredate <= To.Date));
                            break;
                        case 3:
                            table = table.Where(x => x.SoName.Contains(search) && (x.EmHiredate >= From.Date && x.EmHiredate <= To.Date));
                            break;
                        case 4:
                            table = table.Where(x => x.PoName.Contains(search) && (x.EmHiredate >= From.Date && x.EmHiredate <= To.Date));
                            break;

                    }
                }
                
                foreach (var p in table)
                {
                    Execute.Add(new M_EmployeeDsp()
                    {
                        EmID = p.EmID,
                        EmName = p.EmName,
                        EmHireDate = p.EmHiredate,
                        PoID = p.PoID,
                        PoName = p.PoName,
                        EmPhone = p.EmPhone,
                        SoName = p.SoName,
                        SoID = p.SoID
                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "社員検索エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Execute;
        }
        public List<M_EmployeeDspHidden> HiddenSearch(int type, string search, bool DateCheck, DateTime From, DateTime To)
        {
            List<M_EmployeeDspHidden> Execute = new List<M_EmployeeDspHidden>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.M_Employees
                            join t2 in context.M_SalesOffices
                            on t1.SoID equals t2.SoID
                            join t3 in context.M_Positions
                            on t1.PoID equals t3.PoID
                            where (t1.EmFlag == 1)
                            select new
                            {
                                t1.EmID,
                                t1.EmName,
                                t1.SoID,
                                t2.SoName,
                                t1.PoID,
                                t3.PoName,
                                t1.EmHiredate,
                                t1.EmPhone,
                                t1.EmFlag,
                                t1.EmHidden
                            };
                if(!DateCheck)
                {
                    switch (type)
                    {
                        case 0:
                            table = table.Where(x => x.EmID.ToString().Contains(search) || x.EmName.Contains(search) || x.SoName.Contains(search)
                    || x.PoName.Contains(search));
                            break;
                        case 1:
                            table = table.Where(x => x.EmID.ToString().Contains(search));
                            break;
                        case 2:
                            table = table.Where(x => x.EmName.Contains(search));
                            break;
                        case 3:
                            table = table.Where(x => x.SoName.Contains(search));
                            break;
                        case 4:
                            table = table.Where(x => x.PoName.Contains(search));
                            break;

                    }
                }
                else
                {
                    switch (type)
                    {
                        case 0:
                            table = table.Where(x => (x.EmID.ToString().Contains(search) || x.EmName.Contains(search) || x.SoName.Contains(search)
                    || x.PoName.Contains(search) && (x.EmHiredate >= From.Date && x.EmHiredate <= To.Date)));
                            break;
                        case 1:
                            table = table.Where(x => x.EmID.ToString().Contains(search) && (x.EmHiredate >= From.Date && x.EmHiredate <= To.Date));
                            break;
                        case 2:
                            table = table.Where(x => x.EmName.Contains(search) && (x.EmHiredate >= From.Date && x.EmHiredate <= To.Date));
                            break;
                        case 3:
                            table = table.Where(x => x.SoName.Contains(search) && (x.EmHiredate >= From.Date && x.EmHiredate <= To.Date));
                            break;
                        case 4:
                            table = table.Where(x => x.PoName.Contains(search) && (x.EmHiredate >= From.Date && x.EmHiredate <= To.Date));
                            break;

                    }
                }
                
                foreach (var p in table)
                {
                    Execute.Add(new M_EmployeeDspHidden()
                    {
                        EmID = p.EmID,
                        EmName = p.EmName,
                        EmHireDate = p.EmHiredate,
                        PoID = p.PoID,
                        PoName = p.PoName,
                        SoID = p.SoID,
                        SoName = p.SoName,
                        EmPhone = p.EmPhone,
                        EmFlag = p.EmFlag,
                        EmHidden = p.EmHidden
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
    }
}
