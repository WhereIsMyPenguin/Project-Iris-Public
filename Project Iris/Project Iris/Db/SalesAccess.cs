using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Iris
{
    class SalesAccess
    {
        public List<T_SaleDsp> GetSaleDisplay()
        {
            List<T_SaleDsp> tb = new List<T_SaleDsp>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.T_Sale
                            join t2 in context.M_Clients
                            on t1.ClID equals t2.ClID
                            join t3 in context.M_SalesOffices
                            on t1.SoID equals t3.SoID
                            join t4 in context.M_Employees
                            on t1.EmID equals t4.EmID
                            select new
                            {
                                t1.SaID,
                                t1.ClID,
                                t2.ClName,
                                t1.SoID,
                                t3.SoName,
                                t1.EmID,
                                t4.EmName,
                                t1.OrID,
                                t1.SaDate
                            };
                foreach(var p in table)
                {
                    tb.Add(new T_SaleDsp() { 
                        SaID = p.SaID,
                        ClID = p.ClID,
                        ClName = p.ClName,
                        SoID = p.SoID,
                        SoName = p.SoName,
                        EmID = p.EmID,
                        EmName = p.EmName,
                        OrID = p.OrID,
                        SaDate = p.SaDate                    
                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "売上表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tb;
        }
        public List<T_SaleDetailDsp> GetSaleDetailDisplay (int ID)
        {
            List<T_SaleDetailDsp> tb = new List<T_SaleDetailDsp>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.T_SaleDetails
                            join t2 in context.M_Products
                            on t1.PrID equals t2.PrID
                            where t1.SaID == ID
                            select new
                            {
                                t1.SaDetailID,
                                t1.SaID,
                                t1.PrID,
                                t2.PrName,
                                t1.SaQuantity,
                                t1.SaPrTotalPrice
                            };
                foreach(var p in table)
                {
                    tb.Add(new T_SaleDetailDsp() { 
                        SaDetailID = p.SaDetailID,
                        SaID = p.SaID,
                        PrID = p.PrID,
                        PrName = p.PrName,
                        SaQuantity = p.SaQuantity,
                        SaPrTotalPrice = p.SaPrTotalPrice
                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "売上明細表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tb;
        }
        public List<T_SaleDsp> Search(string search,int type,bool DateCheck, DateTime From,DateTime To)
        {
            List<T_SaleDsp> tb = GetSaleDisplay();
            try
            {
                if(!DateCheck)
                {
                    switch(type)
                    {
                        case 0: tb = tb.Where(x => x.SaID.ToString().Contains(search) || x.ClName.Contains(search) 
                        || x.SoName.Contains(search) || x.EmName.Contains(search) || x.OrID.ToString().Contains(search)).ToList();
                            break;
                        case 1: tb = tb.Where(x => x.SaID.ToString().Contains(search)).ToList();
                            break;
                        case 2: tb = tb.Where(x => x.ClName.Contains(search)).ToList();
                            break;
                        case 3: tb = tb.Where(x => x.SoName.Contains(search)).ToList();
                            break;
                        case 4: tb = tb.Where(x => x.EmName.Contains(search)).ToList();
                            break;
                        case 5:tb = tb.Where(x => x.OrID.ToString().Contains(search)).ToList();
                            break;
                    }
                }
                else
                {
                    switch (type)
                    {
                        case 0:
                            tb = tb.Where(x => (x.SaID.ToString().Contains(search) || x.ClName.Contains(search)
                    || x.SoName.Contains(search) || x.EmName.Contains(search) || x.OrID.ToString().Contains(search)) && (x.SaDate.Date >= From.Date && x.SaDate.Date <= To.Date)).ToList();
                            break;
                        case 1:
                            tb = tb.Where(x => x.SaID.ToString().Contains(search) && (x.SaDate.Date >= From.Date && x.SaDate.Date <= To.Date)).ToList();
                            break;
                        case 2:
                            tb = tb.Where(x => x.ClName.Contains(search) && (x.SaDate.Date >= From.Date && x.SaDate.Date <= To.Date)).ToList();
                            break;
                        case 3:
                            tb = tb.Where(x => x.SoName.Contains(search) && (x.SaDate.Date >= From.Date && x.SaDate.Date <= To.Date)).ToList();
                            break;
                        case 4:
                            tb = tb.Where(x => x.EmName.Contains(search) && (x.SaDate.Date >= From.Date && x.SaDate.Date <= To.Date)).ToList();
                            break;
                        case 5:
                            tb = tb.Where(x => x.OrID.ToString().Contains(search) && (x.SaDate.Date >= From.Date && x.SaDate.Date <= To.Date)).ToList();
                            break;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "売上検索エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tb;
        }
    }
}
