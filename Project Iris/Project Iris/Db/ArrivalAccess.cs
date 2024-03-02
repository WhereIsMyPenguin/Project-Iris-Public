using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project_Iris
{
    class ArrivalAccess
    {
        // メソッド名:GetArrivalData()
        // 引　数　　:なし
        // 戻り値　　:入荷データ
        // 機能　　　:入荷データの取得
        public List<T_Arrival> GetArrivalData()
        {
            List<T_Arrival> exist = null;
            try
            {
                var context = new SalesManagement_DevContext();
                exist = context.T_Arrivals.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "入荷DBエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return exist;
        }

        // メソッド名:GetArrivalDisplay()
        // 引　数　　:な
        // 戻り値　　:入荷(表示)データ
        // 機能　　　:表示用入荷データの取得
       
        public List<T_ArrivalDsp> GetArrivalDisplay()
        {
            List<T_ArrivalDsp> ArrivalDsp = new List<T_ArrivalDsp>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.T_Arrivals
                            join t3 in context.M_Clients
                            on t1.ClID equals t3.ClID
                            join t4 in context.M_SalesOffices
                            on t1.SoID equals t4.SoID
                            where (t1.ArFlag == 0 && t1.ArStateFlag == 0)
                            select new
                            {
                                t1.ArID,
                                t1.ClID,
                                t3.ClName,
                                t1.OrID,
                                t1.SoID,
                                t4.SoName
                            };
                foreach (var p in table)
                {
                    ArrivalDsp.Add(new T_ArrivalDsp()
                    {
                        ArID = p.ArID,
                        ClID = p.ClID,
                        ClName = p.ClName,
                        SoID = p.SoID,
                        OrID = p.OrID,
                        SoName = p.SoName
                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "入荷表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ArrivalDsp;
        }
        public List<T_ArrivalDetailDsp> GetArrivalDetail(string ID)
        {
            List<T_ArrivalDetailDsp> ArrivalDetailDsp = new List<T_ArrivalDetailDsp>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.T_ArrivalDetails
                            join t2 in context.M_Products
                            on t1.PrID equals t2.PrID
                            where (t1.ArID.ToString() == ID)
                            select new
                            {
                                t1.ArDetailID,
                                t2.PrID,
                                t2.PrName,
                                t2.PrColor,
                                t2.Price,
                                t1.ArQuantity,
                            };
                foreach (var p in table)
                {
                    ArrivalDetailDsp.Add(new T_ArrivalDetailDsp()
                    {
                        ArDetailID = p.ArDetailID,
                        PrID = p.PrID,
                        PrName = p.PrName,
                        PrColor = p.PrColor,
                        Price = p.Price,
                        ArQuantity = p.ArQuantity,
                    }); ;
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "入荷詳細表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ArrivalDetailDsp;
        }
        // メソッド名:GetArrivalDisplay()
        // 引　数　　:なし
        // 戻り値　　入荷(表示)データ
        // 機能　　　:表示用入荷データの取得
        
        public List<T_ArrivalDspHidden> GetArrivalHiddenDisplay()
        {
            List<T_ArrivalDspHidden> ArrivalDsp = new List<T_ArrivalDspHidden>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.T_Arrivals
                            join t2 in context.M_Employees
                           on t1.EmID equals t2.EmID into t2list
                            from t2 in t2list.DefaultIfEmpty()
                            join t3 in context.M_Clients
                            on t1.ClID equals t3.ClID
                            join t4 in context.M_SalesOffices
                            on t1.SoID equals t4.SoID
                            join t5 in context.T_Orders
                            on t1.OrID equals t5.OrID
                            where (t1.ArFlag == 1 || t1.ArStateFlag == 1)
                            select new
                            {
                                t1.ArID,
                                t1.EmID,
                                t2.EmName,
                                t1.ClID,
                                t3.ClName,
                                t1.SoID,
                                t4.SoName,
                                t5.OrID,
                                t1.ArDate,
                                t1.ArStateFlag,
                                t1.ArFlag,
                                t1.ArHidden
                            };
                foreach (var p in table)
                {
                    ArrivalDsp.Add(new T_ArrivalDspHidden()
                    {
                        ArID = p.ArID,
                        EmID = p.EmID,
                        EmName = p.EmName,
                        ClID = p.ClID,
                        ClName = p.ClName,
                        SoID = p.SoID,
                        SoName = p.SoName,
                        OrID = p.OrID,
                        ArDate = p.ArDate,
                        ArStateFlag = p.ArStateFlag,
                        ArFlag = p.ArFlag,
                        ArHidden = p.ArHidden

                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "入荷表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ArrivalDsp;
        }
        // メソッド名:DefaultSearch()
        // 引　数　　:なし
        // 戻り値　　:受注データ
        // 機能　　　:検索する
        public List<T_ArrivalDsp> DefaultSearch(string search, int type)
        {
            List<T_ArrivalDsp> table = GetArrivalDisplay();
            {
                try
                {
                    var context = new SalesManagement_DevContext();
                    switch (type)
                    {
                        case 0:
                            table = table.Where(x => (x.ArID.ToString().Contains(search) || x.SoName.Contains(search) ||
                               x.ClName.Contains(search) || x.OrID.ToString().Contains(search))).ToList();
                            break;
                        case 1:
                            table = table.Where(x => x.ArID.ToString().Contains(search)).ToList();
                            break;
                        case 2:
                            table = table.Where(x => x.SoName.Contains(search)).ToList();
                            break;
                        //case 3:
                        //    table = table.Where(x => x.EmName.Contains(search)).ToList();
                        // break;
                        case 4:
                            table = table.Where(x => x.ClName.Contains(search)).ToList();
                            break;
                        case 5:
                            table = table.Where(x => x.OrID.ToString().Contains(search)).ToList();
                            break;
                    }
                    context.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "入荷検索エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return table;
            }
        }
        // メソッド名:HiddenSearch()
        // 引　数　　:なし
        // 戻り値　　:非表示化された受注データ
        // 機能　　　:検索する
        public List<T_ArrivalDspHidden> HiddenSearch(string search, int type, DateTime From, DateTime To, bool DateCheck)
        {
            List<T_ArrivalDspHidden> table = GetArrivalHiddenDisplay();
            {
                try
                {
                    var context = new SalesManagement_DevContext();
                    if (!DateCheck)
                    {
                        switch (type)
                        {
                            case 0:
                                table = table.Where(x => x.ArID.ToString().Contains(search) || x.SoName.Contains(search) ||
                                  x.EmName.Contains(search) || x.ClName.Contains(search) || x.OrID.ToString().Contains(search)).ToList();
                                break;
                            case 1:
                                table = table.Where(x => x.ArID.ToString().Contains(search)).ToList();
                                break;
                            case 2:
                                table = table.Where(x => x.SoName.Contains(search)).ToList();
                                break;
                            case 3:
                                table = table.Where(x => x.EmName.Contains(search)).ToList();
                                break;
                            case 4:
                                table = table.Where(x => x.ClName.Contains(search)).ToList();
                                break;
                            case 5:
                                table = table.Where(x => x.OrID.ToString().Contains(search)).ToList();
                                break;
                        }
                    }
                    else
                    {
                        switch (type)
                        {
                            case 0:
                                table = table.Where(x => (x.ArID.ToString().Contains(search) || x.SoName.Contains(search) ||
                                  x.EmName.Contains(search) || x.ClName.Contains(search) || x.OrID.ToString().Contains(search)) && (x.ArDate >= From.Date && x.ArDate <= To.Date)).ToList();
                                break;
                            case 1:
                                table = table.Where(x => x.ArID.ToString().Contains(search) && (x.ArDate >= From.Date && x.ArDate <= To.Date)).ToList();
                                break;
                            case 2:
                                table = table.Where(x => x.SoName.Contains(search) && (x.ArDate >= From.Date && x.ArDate <= To.Date)).ToList();
                                break;
                            case 3:
                                table = table.Where(x => x.EmName.Contains(search) && (x.ArDate >= From.Date && x.ArDate <= To.Date)).ToList();
                                break;
                            case 4:
                                table = table.Where(x => x.ClName.Contains(search) && (x.ArDate >= From.Date && x.ArDate <= To.Date)).ToList();
                                break;
                            case 5:
                                table = table.Where(x => x.OrID.ToString().Contains(search) && (x.ArDate >= From.Date && x.ArDate <= To.Date)).ToList();
                                break;
                        }
                    }
                    context.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "入荷検索エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return table;
            }
        }
        // メソッド名BravoSixGoingDark()
        // 引　数　　:なし
        // 戻り値　　:Bool
        // 機能　　　:入荷データの非表示
        public bool BravoSixGoingDark(int ArID,string reason)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var modify = context.T_Arrivals.Single(x => x.ArID == ArID);
                modify.ArFlag = 1;
                modify.ArHidden = reason;
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "入荷非表示化エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // メソッド名SnapBackToReality()
        // 引　数　　:なし
        // 戻り値　　:Bool
        // 機能　　　:受注データの表示化
        public bool SnapBackToReality(int ID)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var modify = context.T_Arrivals.Single(x => x.ArID == ID);
                modify.ArStateFlag = 0;
                modify.ArFlag = 0;
                modify.ArHidden = "";
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "入荷表示化エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool KingsCross(T_Arrival ticket)
        {
            var context = new SalesManagement_DevContext();
            T_Shipment HogwartsExpress = new T_Shipment()
            {
                SoID = ticket.SoID,
                ClID = ticket.ClID,
                OrID = ticket.OrID,
                ShStateFlag = 0
            };
            context.T_Shipments.Add(HogwartsExpress);
            context.SaveChanges();
            int HeresYourTicket = HogwartsExpress.ShID;
            int HarryPotter = ticket.ArID;
            context.Dispose();
            ShipmentDetail(HeresYourTicket, HarryPotter);
            return true;
        }
        // メソッド名:ArrivalDetail()
        // 引　数　　:なし
        // 戻り値　　:なし
        // 機能　　　:注文にデータを追加する
        public bool ShipmentDetail(int Key, int ArKey)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                List<T_ShipmentDetail> ShipmentDetail = new List<T_ShipmentDetail>();
                var loadDetail = from t1 in context.T_ArrivalDetails
                                 where (t1.ArID ==ArKey)
                                 select new
                                 {
                                     t1.PrID,
                                     t1.ArQuantity,
                                 };
                foreach (var p in loadDetail)
                {
                    T_ShipmentDetail AddDetail = new T_ShipmentDetail()
                    {
                        ShID = Key,
                        PrID = p.PrID,
                        ShQuantity = p.ArQuantity
                    };
                    context.T_ShipmentDetails.Add(AddDetail);

                }
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "入荷詳細作成エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
