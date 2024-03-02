using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Iris
{
    class OrderAccess
    {
        // メソッド名:GetOrderData()
        // 引　数　　:なし
        // 戻り値　　:受注データ
        // 機能　　　:受注データの取得
        public List<T_Order> GetOrderData()
        {
            List<T_Order> exist = null;
            try
            {
                var context = new SalesManagement_DevContext();
                exist = context.T_Orders.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "受注DBエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return exist;
        }
        // メソッド名:GetOrderDisplay()
        // 引　数　　:なし
        // 戻り値　　:受注データ(表示用)
        // 機能　　　:表示用注文データの取得
        public List<T_OrderDsp> GetOrderDisplay()
        {
            List<T_OrderDsp> OrderDsp = new List<T_OrderDsp>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.T_Orders
                            join t2 in context.M_SalesOffices
                            on t1.SoID equals t2.SoID
                            join t3 in context.M_Employees
                            on t1.EmID equals t3.EmID
                            join t4 in context.M_Clients
                            on t1.ClID equals t4.ClID
                            where(t1.OrFlag == 0 && t1.OrStateFlag == 0)
                            select new
                            {
                                t1.OrID,
                                t1.SoID,
                                t2.SoName,
                                t1.EmID,
                                t3.EmName,
                                t1.ClID,
                                t4.ClName,
                                t1.ClCharge,
                                t1.OrDate
                            };
                foreach (var p in table)
                {
                    OrderDsp.Add(new T_OrderDsp(){
                        OrID = p.OrID,
                        SoID = p.SoID,
                        SoName = p.SoName,
                        EmID = p.EmID,
                        EmName = p.EmName,
                        ClID = p.ClID,
                        ClName = p.ClName,
                        ClCharge = p.ClCharge,
                        OrDate = p.OrDate
                    });    
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "受注表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OrderDsp;
        }
        // メソッド名:GetOrderHiddenDisplay()
        // 引　数　　:なし
        // 戻り値　　:非表示された受注データ(表示用)
        // 機能　　　:表示用注文データの取得
        public List<T_OrderDspHidden> GetOrderHiddenDisplay()
        {
            List<T_OrderDspHidden> OrderDsp = new List<T_OrderDspHidden>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.T_Orders
                            join t2 in context.M_SalesOffices
                            on t1.SoID equals t2.SoID
                            join t3 in context.M_Employees
                            on t1.EmID equals t3.EmID
                            join t4 in context.M_Clients
                            on t1.ClID equals t4.ClID
                            where (t1.OrFlag == 1 || t1.OrStateFlag == 1)
                            select new
                            {
                                t1.OrID,
                                t1.SoID,
                                t2.SoName,
                                t3.EmName,
                                t4.ClName,
                                t1.ClCharge,
                                t1.OrDate,
                                t1.OrFlag,
                                t1.OrStateFlag,
                                t1.OrHidden
                            };
                foreach (var p in table)
                {
                    OrderDsp.Add(new T_OrderDspHidden()
                    {
                        OrID = p.OrID,
                        SoID = p.SoID,
                        SoName = p.SoName,
                        EmName = p.EmName,
                        ClName = p.ClName,
                        ClCharge = p.ClCharge,
                        OrDate = p.OrDate,
                        OrFlag = p.OrFlag,
                        OrStateFlag = p.OrStateFlag,
                        OrHidden = p.OrHidden
                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "受注表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OrderDsp;
        }
        // メソッド名:GetOrderDetail()
        // 引　数　　:なし
        // 戻り値　　:受注詳細データ
        // 機能　　　:受注詳細データの取得
        public List<T_OrderDetailDsp> GetOrderDetail(string ID)
        {
            List<T_OrderDetailDsp> OrderDetailDsp = new List<T_OrderDetailDsp>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.T_OrderDetails
                            join t2 in context.M_Products
                            on t1.PrID equals t2.PrID
                            where (t1.OrID.ToString() == ID)
                            select new
                            {
                                t1.OrDetailID,
                                t2.PrID,
                                t2.PrName,
                                t2.PrColor,
                                t2.Price,
                                t1.OrQuantity,
                                t1.OrTotalPrice
                            };
                foreach(var p in table)
                {
                    OrderDetailDsp.Add(new T_OrderDetailDsp()
                    {
                        OrDetailID = p.OrDetailID,
                        PrID = p.PrID,
                        PrName = p.PrName,
                        PrColor = p.PrColor,
                        Price = p.Price,
                        OrQuantity = p.OrQuantity,
                        OrTotalPrice = p.OrTotalPrice
                    }); ;
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "受注詳細表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OrderDetailDsp;
        }
        // メソッド名:CreateDetails()
        // 引　数　　:なし
        // 戻り値　　:Bool
        // 機能　　　:受注詳細を作成
        public bool CreateDetails(T_OrderDetail orderDetail)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                if (context.T_OrderDetails.Any(x => x.OrID == -1) == true)
                {
                    var modify = context.T_OrderDetails.Where(x => x.OrID == -1).First();
                    modify.OrID = orderDetail.OrID;
                    modify.PrID = orderDetail.PrID;
                    modify.OrQuantity = orderDetail.OrQuantity;
                    modify.OrTotalPrice = orderDetail.OrTotalPrice;
                }
                else
                {
                    var refine = new T_OrderDetail()
                    {
                        OrID = orderDetail.OrID,
                        PrID = orderDetail.PrID,
                        OrQuantity = orderDetail.OrQuantity,
                        OrTotalPrice = orderDetail.OrTotalPrice
                    };
                    context.T_OrderDetails.Add(refine);
                }
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "受注詳細作成エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // メソッド名:ModifyDetails()
        // 引　数　　:なし
        // 戻り値　　:Bool
        // 機能　　　:受注詳細を変更
        public bool ModifyDetails(T_OrderDetail orderDetail)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var modify = context.T_OrderDetails.Single(x => x.OrDetailID == orderDetail.OrDetailID);
                modify.PrID = orderDetail.PrID;
                modify.OrQuantity = orderDetail.OrQuantity;
                modify.OrTotalPrice = orderDetail.OrTotalPrice;
                context.SaveChanges();
                context.Dispose();
                return true;
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "受注詳細更新エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
}
        // メソッド名:DeleteDetails()
        // 引　数　　:なし
        // 戻り値　　:Bool
        // 機能　　　:受注詳細の削除
        public bool DeleteDetails(int where)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var DeleteHere = context.T_OrderDetails.Where(x => x.OrID == where).ToList();
                DeleteHere.ForEach(x => x.OrID = -1);
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "受注詳細更新エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // メソッド名:ModifyOrder()
        // 引　数　　:なし
        // 戻り値　　:Bool
        // 機能　　　:受注データの変更
        public bool ModifyOrder(T_Order order)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var modify = context.T_Orders.Single(x => x.OrID == order.OrID);
                modify.SoID = order.SoID;
                modify.EmID = order.EmID;
                modify.ClID = order.ClID;
                modify.ClCharge = order.ClCharge;
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "受注更新エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // メソッド名BravoSixGoingDark()
        // 引　数　　:なし
        // 戻り値　　:Bool
        // 機能　　　:受注データの非表示
        public bool BravoSixGoingDark(T_Order order)
        {




            try
            {
                var context = new SalesManagement_DevContext();
                var modify = context.T_Orders.Single(x => x.OrID == order.OrID);
                modify.OrFlag = order.OrFlag;
                modify.OrHidden = order.OrHidden;
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "受注非表示化エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // メソッド名SnapBackToReality()
        // 引　数　　:なし
        // 戻り値　　:Bool
        // 機能　　　:受注データの表示化
        public bool SnapBackToReality(T_Order order)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var modify = context.T_Orders.Single(x => x.OrID == order.OrID);
                modify.OrFlag = order.OrFlag;
                modify.OrHidden = "";
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "受注表示化エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // メソッド名:DefaultSearch()
        // 引　数　　:なし
        // 戻り値　　:受注データ
        // 機能　　　:検索する
        public List<T_OrderDsp> DefaultSearch(string search, int type, DateTime From, DateTime To, bool DateSearch)
        {
            List<T_OrderDsp> Execute = new List<T_OrderDsp>();
            {
                try
                {
                    var context = new SalesManagement_DevContext();
                    var FromThisTime = From.Date; var ToThisTime = To.Date;
                    var table = from t1 in context.T_Orders
                                join t2 in context.M_SalesOffices
                                on t1.SoID equals t2.SoID
                                join t3 in context.M_Employees
                                on t1.EmID equals t3.EmID
                                join t4 in context.M_Clients
                                on t1.ClID equals t4.ClID
                                where (t1.OrFlag == 0 && t1.OrStateFlag == 0)
                                select new
                                {
                                    t1.OrID,
                                    t1.SoID,
                                    t2.SoName,
                                    t1.EmID,
                                    t3.EmName,
                                    t1.ClID,
                                    t4.ClName,
                                    t1.ClCharge,
                                    t1.OrDate
                                };
                    if (!DateSearch)
                    {
                        switch (type)
                        {
                            case 0:
                                table = table.Where(x => (x.OrID.ToString().Contains(search) || x.SoName.Contains(search) ||
                        x.EmName.Contains(search) || x.ClName.Contains(search) || x.ClCharge.Contains(search)));
                                break;
                            case 1:
                                table = table.Where(x => x.OrID.ToString().Contains(search));
                                break;
                            case 2:
                                table = table.Where(x => x.SoName.Contains(search));
                                break;
                            case 3:
                                table = table.Where(x => x.EmName.Contains(search));
                                break;
                            case 4:
                                table = table.Where(x => x.ClName.Contains(search));
                                break;
                            case 5:
                                table = table.Where(x => x.ClCharge.Contains(search));
                                break;
                        }
                    }
                    else
                    {
                        switch (type)
                        {
                            case 0:
                                table = table.Where(x => (x.OrID.ToString().Contains(search) || x.SoName.Contains(search) ||
                    x.EmName.Contains(search) || x.ClName.Contains(search) || x.ClCharge.Contains(search)) && (x.OrDate >= FromThisTime && x.OrDate <= ToThisTime));
                                break;
                            case 1:
                                table = table.Where(x => (x.OrDate >= FromThisTime && x.OrDate <= ToThisTime) && x.OrID.ToString().Contains(search));
                                break;
                            case 2:
                                table = table.Where(x => (x.OrDate >= FromThisTime && x.OrDate <= ToThisTime) && x.SoName.Contains(search));
                                break;
                            case 3:
                                table = table.Where(x => (x.OrDate >= FromThisTime && x.OrDate <= ToThisTime) && x.EmName.Contains(search));
                                break;
                            case 4:
                                table = table.Where(x => (x.OrDate >= FromThisTime && x.OrDate <= ToThisTime) && x.ClName.Contains(search));
                                break;
                            case 5:
                                table = table.Where(x => (x.OrDate >= FromThisTime && x.OrDate <= ToThisTime) && x.ClCharge.Contains(search));
                                break;
                        }
                    }
                    foreach (var p in table)
                    {
                        Execute.Add(new T_OrderDsp()
                        {
                            OrID = p.OrID,
                            SoID = p.SoID,
                            SoName = p.SoName,
                            EmID = p.EmID,
                            EmName = p.EmName,
                            ClID = p.ClID,
                            ClName = p.ClName,
                            ClCharge = p.ClCharge,
                            OrDate = p.OrDate,
                        });
                    }
                    context.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "受注検索エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return Execute;
            }
        }
        // メソッド名:HiddenSearch()
        // 引　数　　:なし
        // 戻り値　　:非表示化された受注データ
        // 機能　　　:検索する
        public List<T_OrderDspHidden> HiddenSearch(string search, int type, DateTime From, DateTime To, bool DateSearch)
        {
            List<T_OrderDspHidden> Execute = new List<T_OrderDspHidden>();
            {
                try
                {
                    var context = new SalesManagement_DevContext();
                    var FromThisTime = From.Date; var ToThisTime = To.Date;
                    var table = from t1 in context.T_Orders
                                join t2 in context.M_SalesOffices
                                on t1.SoID equals t2.SoID
                                join t3 in context.M_Employees
                                on t1.EmID equals t3.EmID
                                join t4 in context.M_Clients
                                on t1.ClID equals t4.ClID
                                where (t1.OrFlag == 1 || t1.OrStateFlag == 1)
                                select new
                                {
                                    t1.OrID,
                                    t1.SoID,
                                    t2.SoName,
                                    t1.EmID,
                                    t3.EmName,
                                    t1.ClID,
                                    t4.ClName,
                                    t1.ClCharge,
                                    t1.OrDate,
                                    t1.OrFlag,
                                    t1.OrStateFlag,
                                    t1.OrHidden
                                };
                    if(!DateSearch)
                    {
                        switch (type)
                        {
                            case 0:
                                table = table.Where(x => (x.OrID.ToString().Contains(search) || x.SoName.Contains(search) ||
                        x.EmName.Contains(search) || x.ClName.Contains(search) || x.ClCharge.Contains(search)));
                                break;
                            case 1:
                                table = table.Where(x => x.OrID.ToString().Contains(search));
                                break;
                            case 2:
                                table = table.Where(x => x.SoName.Contains(search));
                                break;
                            case 3:
                                table = table.Where(x => x.EmName.Contains(search));
                                break;
                            case 4:
                                table = table.Where(x => x.ClName.Contains(search));
                                break;
                            case 5:
                                table = table.Where(x => x.ClCharge.Contains(search));
                                break;
                        }
                    }
                    else
                    {
                        switch (type)
                        {
                            case 0:
                                table = table.Where(x => (x.OrID.ToString().Contains(search) || x.SoName.Contains(search) ||
                    x.EmName.Contains(search) || x.ClName.Contains(search) || x.ClCharge.Contains(search)) && (x.OrDate >= FromThisTime && x.OrDate <= ToThisTime));
                                break;
                            case 1:
                                table = table.Where(x => (x.OrDate >= FromThisTime && x.OrDate <= ToThisTime) && x.OrID.ToString().Contains(search));
                                break;
                            case 2:
                                table = table.Where(x => (x.OrDate >= FromThisTime && x.OrDate <= ToThisTime) && x.SoName.Contains(search));
                                break;
                            case 3:
                                table = table.Where(x => (x.OrDate >= FromThisTime && x.OrDate <= ToThisTime) && x.EmName.Contains(search));
                                break;
                            case 4:
                                table = table.Where(x => (x.OrDate >= FromThisTime && x.OrDate <= ToThisTime) && x.ClName.Contains(search));
                                break;
                            case 5:
                                table = table.Where(x => (x.OrDate >= FromThisTime && x.OrDate <= ToThisTime) && x.ClCharge.Contains(search));
                                break;
                        }
                    }
                    
                    foreach (var p in table)
                    {
                        Execute.Add(new T_OrderDspHidden()
                        {
                            OrID = p.OrID,
                            SoID = p.SoID,
                            SoName = p.SoName,
                            EmID = p.EmID,
                            EmName = p.EmName,
                            ClID = p.ClID,
                            ClName = p.ClName,
                            ClCharge = p.ClCharge,
                            OrDate = p.OrDate,
                            OrFlag = p.OrFlag,
                            OrStateFlag = p.OrStateFlag,
                            OrHidden = p.OrHidden
                        });
                    }
                    context.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "受注検索エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return Execute;
            }
        }
        // メソッド名:KingsCross()
        // 引　数　　:なし
        // 戻り値　　:なし
        // 機能　　　:注文にデータを追加する
        public bool KingsCross(T_Order ticket)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var date = DateTime.Now ;
                T_Chumon HogwartsExpress = new T_Chumon()
                {
                    SoID = ticket.SoID,
                    ClID = ticket.ClID,
                    OrID = ticket.OrID,
                    ChStateFlag = 0
                };
                context.T_Chumons.Add(HogwartsExpress);
                context.SaveChanges();
                int HeresYourTicket = HogwartsExpress.ChID;
                int HarryPotter = ticket.OrID;
                context.Dispose();
                ChumonDetail(HeresYourTicket,HarryPotter);
                return true;
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "注文作成エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
}
        // メソッド名:ChumonDetail()
        // 引　数　　:なし
        // 戻り値　　:なし
        // 機能　　　:注文にデータを追加する
        public bool ChumonDetail(int ChKey,int OrKey)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                List<T_ChumonDetail> ChumonDetail = new List<T_ChumonDetail>();
                var loadDetail = from t1 in context.T_OrderDetails
                                 where (t1.OrID == OrKey)
                                 select new
                                 {
                                     t1.PrID,
                                     t1.OrQuantity
                                 };
                foreach(var p in loadDetail)
                {
                    T_ChumonDetail AddDetail = new T_ChumonDetail()
                    {
                        ChID = ChKey,
                        PrID = p.PrID,
                        ChQuantity = p.OrQuantity
                    };
                    context.T_ChumonDetails.Add(AddDetail);

                }
                context.SaveChanges();
                context.Dispose();
                return true;
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "注文詳細作成エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
}
    }
}
