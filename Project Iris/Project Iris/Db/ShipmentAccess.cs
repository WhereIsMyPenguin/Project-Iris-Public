using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Iris
{
    class ShipmentAccess
    {
        // メソッド名:GetShipmentData()
        // 引　数　　:なし
        // 戻り値　　:出荷データ
        // 機能　　　:出荷データの取得
        public List<T_Shipment> GetShipmentData()
        {
            List<T_Shipment> exist = null;
            try
            {
                var context = new SalesManagement_DevContext();
                exist = context.T_Shipments.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "出荷DBエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return exist;
        }

        // メソッド名:GetSyukkoDisplay()
        // 引　数　　:なし
        // 戻り値　　:出荷(表示)データ
        // 機能　　　:表示用出荷データの取得
        public List<T_ShipmentDsp> GetShipmentDisplay()
        {
            List<T_ShipmentDsp> ShipmentDsp = new List<T_ShipmentDsp>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.T_Shipments
                            join t3 in context.M_Clients
                            on t1.ClID equals t3.ClID
                            join t4 in context.M_SalesOffices
                            on t1.SoID equals t4.SoID
                            where (t1.ShFlag == 0 && t1.ShStateFlag == 0)
                            select new
                            {
                                t1.ShID,
                                t1.ClID,
                                t3.ClName,
                                t1.OrID,
                                t1.SoID,
                                t4.SoName
                            };
                foreach (var p in table)
                {
                    ShipmentDsp.Add(new T_ShipmentDsp()
                    {
                        ShID = p.ShID,
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
                MessageBox.Show(ex.Message, "出荷表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ShipmentDsp;
        }
        // メソッド名:GetShipmentDetail()
        // 引　数　　:なし
        // 戻り値　　:出荷詳細データ
        // 機能　　　:出荷詳細データの取得
        public List<T_ShipmentDetailDsp> GetShipmentDetail(string ID)
        {
            List<T_ShipmentDetailDsp> ShipmentDetailDsp = new List<T_ShipmentDetailDsp>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.T_ShipmentDetails
                            join t2 in context.M_Products
                            on t1.PrID equals t2.PrID
                            where (t1.ShID.ToString() == ID)
                            select new
                            {
                                t1.ShDetailID,
                                t2.PrID,
                                t2.PrName,
                                t2.PrColor,
                                t2.Price,
                                t1.ShQuantity,
                            };
                foreach (var p in table)
                {
                    ShipmentDetailDsp.Add(new T_ShipmentDetailDsp()
                    {
                        ShDetailID = p.ShDetailID,
                        PrID = p.PrID,
                        PrName = p.PrName,
                        PrColor = p.PrColor,
                        Price = p.Price,
                        ShQuantity = p.ShQuantity,
                    }); ;
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "出荷詳細表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ShipmentDetailDsp;
        }

        public List<T_ShipmentDspHidden> GetShipmentHiddenDisplay()
        {
            List<T_ShipmentDspHidden> ArrivalDsp = new List<T_ShipmentDspHidden>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.T_Shipments
                            join t2 in context.M_Employees
                           on t1.EmID equals t2.EmID into t2list
                            from t2 in t2list.DefaultIfEmpty()
                            join t3 in context.M_Clients
                            on t1.ClID equals t3.ClID
                            join t4 in context.M_SalesOffices
                            on t1.SoID equals t4.SoID
                            join t5 in context.T_Orders
                            on t1.OrID equals t5.OrID
                            where (t1.ShFlag == 1 || t1.ShStateFlag == 1)
                            select new
                            {
                                t1.ShID,
                                t1.EmID,
                                t2.EmName,
                                t1.ClID,
                                t3.ClName,
                                t1.SoID,
                                t4.SoName,
                                t5.OrID,
                                t1.ShFinishDate,
                                t1.ShStateFlag,
                                t1.ShFlag,
                                t1.ShHidden
                            };
                foreach (var p in table)
                {
                    ArrivalDsp.Add(new T_ShipmentDspHidden()
                    {
                        ShID = p.ShID,
                        EmID = p.ShID,
                        EmName = p.EmName,
                        ClID = p.ClID,
                        ClName = p.ClName,
                        SoID = p.SoID,
                        SoName = p.SoName,
                        OrID = p.OrID,
                        ShFinishDate = p.ShFinishDate,
                        ShStateFlag = p.ShStateFlag,
                        ShFlag = p.ShFlag,
                        ShHidden = p.ShHidden

                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "出荷表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ArrivalDsp;
        }
        // メソッド名:DefaultSearch()
        // 引　数　　:なし
        // 戻り値　　:出荷データ
        // 機能　　　:検索する
        public List<T_ShipmentDsp> DefaultSearch(string search, int type)
        {
            List<T_ShipmentDsp> table = GetShipmentDisplay();
            {
                try
                {
                    var context = new SalesManagement_DevContext();
                    switch (type)
                    {
                        case 0:
                            table = table.Where(x => (x.ShID.ToString().Contains(search) || x.SoName.Contains(search) ||
                               x.ClName.Contains(search) || x.OrID.ToString().Contains(search))).ToList();
                            break;
                        case 1:
                            table = table.Where(x => x.ShID.ToString().Contains(search)).ToList();
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
                    MessageBox.Show(ex.Message, "出荷検索エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return table;
            }
        }
        // メソッド名:HiddenSearch()
        // 引　数　　:なし
        // 戻り値　　:非表示化された出荷データ
        // 機能　　　:検索する
        public List<T_ShipmentDspHidden> HiddenSearch(string search, int type, DateTime From, DateTime To, bool DateCheck)
        {
            List<T_ShipmentDspHidden> table = GetShipmentHiddenDisplay();
            {
                try
                {
                    var context = new SalesManagement_DevContext();
                    if (!DateCheck)
                    {
                        switch (type)
                        {
                            case 0:
                                table = table.Where(x => x.ShID.ToString().Contains(search) || x.SoName.Contains(search) ||
                                  x.EmName.Contains(search) || x.ClName.Contains(search) || x.OrID.ToString().Contains(search)).ToList();
                                break;
                            case 1:
                                table = table.Where(x => x.ShID.ToString().Contains(search)).ToList();
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
                                table = table.Where(x => (x.ShID.ToString().Contains(search) || x.SoName.Contains(search) ||
                                  x.EmName.Contains(search) || x.ClName.Contains(search) || x.OrID.ToString().Contains(search)) && (x.ShFinishDate >= From.Date && x.ShFinishDate <= To.Date)).ToList();
                                break;
                            case 1:
                                table = table.Where(x => x.ShID.ToString().Contains(search) && (x.ShFinishDate >= From.Date && x.ShFinishDate <= To.Date)).ToList();
                                break;
                            case 2:
                                table = table.Where(x => x.SoName.Contains(search) && (x.ShFinishDate >= From.Date && x.ShFinishDate <= To.Date)).ToList();
                                break;
                            case 3:
                                table = table.Where(x => x.EmName.Contains(search) && (x.ShFinishDate >= From.Date && x.ShFinishDate <= To.Date)).ToList();
                                break;
                            case 4:
                                table = table.Where(x => x.ClName.Contains(search) && (x.ShFinishDate >= From.Date && x.ShFinishDate <= To.Date)).ToList();
                                break;
                            case 5:
                                table = table.Where(x => x.OrID.ToString().Contains(search) && (x.ShFinishDate >= From.Date && x.ShFinishDate <= To.Date)).ToList();
                                break;
                        }
                    }
                    context.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "出荷検索エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return table;
            }
        }
        // メソッド名BravoSixGoingDark()
        // 引　数　　:なし
        // 戻り値　　:Bool
        // 機能　　　:出荷データの非表示
        public bool BravoSixGoingDark(int ID, string Reason)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var modify = context.T_Shipments.Single(x => x.ShID == ID);
                modify.ShFlag = 1;
                modify.ShHidden = Reason;
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "出荷非表示化エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // メソッド名SnapBackToReality()
        // 引　数　　:なし
        // 戻り値　　:Bool
        // 機能　　　:出荷データの表示化
        public bool SnapBackToReality(int ID)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var modify = context.T_Shipments.Single(x => x.ShID == ID);
                modify.ShStateFlag = 0;
                modify.ShFlag = 0;
                modify.ShHidden = "";
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "出荷表示化エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // メソッド名:KingsCross()
        // 引　数　　:なし
        // 戻り値　　:なし
        // 機能　　　:売上にデータを追加する
        public bool KingsCross(T_Shipment ticket,int EmID)
        {
            var context = new SalesManagement_DevContext();
            T_Sale HogwartsExpress = new T_Sale()
            {
                SoID = ticket.SoID,
                ClID = ticket.ClID,
                OrID = ticket.OrID,
                EmID = EmID,
                SaDate = DateTime.Now.Date,
                SaFlag = 0
            };
            context.T_Sale.Add(HogwartsExpress);
            context.SaveChanges();
            int HeresYourTicket = HogwartsExpress.SaID;
            int HarryPotter = ticket.ShID;
            context.Dispose();
            SaleDetail(HeresYourTicket, HarryPotter);
            return true;
        }
        // メソッド名:SaleDetail()
        // 引　数　　:なし
        // 戻り値　　:なし
        // 機能　　　:注文にデータを追加する
        public bool SaleDetail(int SaKey, int ShKey)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                List<T_SaleDetail> SaleDetail = new List<T_SaleDetail>();
                var loadDetail = from t1 in context.T_ShipmentDetails
                                 where (t1.ShID == ShKey)
                                 select new
                                 {
                                     t1.PrID,
                                     t1.ShQuantity,
                                 };
                foreach (var p in loadDetail)
                {
                    T_SaleDetail AddDetail = new T_SaleDetail()
                    {
                        SaID = SaKey,
                        PrID = p.PrID,
                        SaQuantity = p.ShQuantity
                    };
                    context.T_SaleDetails.Add(AddDetail);

                }
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "売上詳細作成エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
