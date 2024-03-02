using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Iris
{
    class WarehousingAccess
    {
        // メソッド名:GetWarehousingData()
        // 引　数　　:なし
        // 戻り値　　:入庫データ
        // 機能　　　:入庫データの取得
        public List<T_Warehousing> GetWarehousingData()
        {
            List<T_Warehousing> exist = null;
            try
            {
                var context = new SalesManagement_DevContext();
                exist = context.T_Warehousings.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "注文DBエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return exist;
        }
        // メソッド名:GetWarehousingDisplay()
        // 引　数　　:なし
        // 戻り値　　:入庫データ(表示用)
        // 機能　　　:表示用入庫データの取得
        public List<T_WarehousingDsp> GetWarehousingDisplay()
        {
            List<T_WarehousingDsp> WarehousingDsp = new List<T_WarehousingDsp>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.T_Warehousings
                            join t2 in context.T_Hattyus
                            on t1.HaID equals t2.HaID
                            join t3 in context.M_Employees
                            on t1.EmID equals t3.EmID
                            where (t1.WaFlag == 0)
                            select new
                            {
                                t1.WaID,
                                t2.HaID,
                                t3.EmName,
                                t1.WaDate
                            };
                foreach (var p in table)
                {
                    WarehousingDsp.Add(new T_WarehousingDsp()
                    {
                        WaID = p.WaID,
                        HaID = p.HaID,
                        EmName = p.EmName,
                        WaDate = p.WaDate
                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "入庫表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return WarehousingDsp;
        }
        // メソッド名:GetWarehousingHiddenDisplay()
        // 引　数　　:なし
        // 戻り値　　:非表示された入庫データ(表示用)
        // 機能　　　:表示用入庫データの取得
        public List<T_WarehousingDspHidden> GetWarehousingHiddenDisplay()
        {
            List<T_WarehousingDspHidden> WarehousingDsp = new List<T_WarehousingDspHidden>();
            {
                try
                {
                    var context = new SalesManagement_DevContext();
                    var table = from t1 in context.T_Warehousings
                                join t2 in context.T_Hattyus
                                on t1.HaID equals t2.HaID
                                join t3 in context.M_Employees
                                on t1.EmID equals t3.EmID
                                where (t1.WaFlag == 1 || t1.WaShelfFlag == 1)
                                select new
                                {
                                    t1.WaID,
                                    t2.HaID,
                                    t3.EmName,
                                    t1.WaDate,
                                    t1.WaShelfFlag,
                                    t1.WaFlag,
                                    t1.WaHidden
                                };
                    foreach (var p in table)
                    {
                        WarehousingDsp.Add(new T_WarehousingDspHidden()
                        {
                            WaID = p.WaID,
                            HaID = p.HaID,
                            EmName = p.EmName,
                            WaDate = p.WaDate,
                            WaShelfFlag = p.WaShelfFlag,
                            WaFlag = p.WaFlag,
                            WaHidden = p.WaHidden
                        });
                    }
                    context.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "入庫表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return WarehousingDsp;
            }
        }
        // メソッド名:GetWarehousingDetail()
        // 引　数　　:なし
        // 戻り値　　:入庫詳細データ
        // 機能　　　:入庫詳細データの取得
        public List<T_WarehousingDetailDsp> GetWarehousingDetail(string ID)
        {
            List<T_WarehousingDetailDsp> WarehousingDetailDsp = new List<T_WarehousingDetailDsp>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.T_WarehousingDetails
                            join t2 in context.M_Products
                            on t1.PrID equals t2.PrID
                            where (t1.WaDetailID.ToString() == ID)
                            select new
                            {
                                t1.PrID,
                                t2.PrName,
                                t2.Price,
                                t2.PrColor,
                                t1.WaQuantity,
                            };
                foreach (var p in table)
                {
                    WarehousingDetailDsp.Add(new T_WarehousingDetailDsp()
                    {
                        PrID = p.PrID,
                        PrName = p.PrName,
                        Price = p.Price,
                        PrColor = p.PrColor,
                        WaQuantity = p.WaQuantity,
                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "入庫詳細表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return WarehousingDetailDsp;
        }
        // メソッド名BravoSixGoingDark()
        // 引　数　　:なし
        // 戻り値　　:Bool
        // 機能　　　:入庫データの非表示
        public bool BravoSixGoingDark(T_Warehousing warehousing)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var modify = context.T_Warehousings.Single(x => x.WaID == warehousing.WaID);
                modify.WaFlag = warehousing.WaFlag;
                modify.WaHidden = warehousing.WaHidden;
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "入庫非表示化エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // メソッド名SnapBackToReality()
        // 引　数　　:なし
        // 戻り値　　:Bool
        // 機能　　　:発注データの表示化
        public bool SnapBackToReality(int ID)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var modify = context.T_Warehousings.Single(x => x.WaID == ID);
                modify.WaShelfFlag = 0;
                modify.WaFlag = 0;
                modify.WaHidden = "";
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "入庫表示化エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // メソッド名:WhereAreYou()
        // 引　数　　:なし
        // 戻り値　　:注文データ
        // 機能　　　:検索する
        public List<T_WarehousingDsp> WhereAreYou(T_WarehousingDsp search, int type)
        {
            List<T_WarehousingDsp> Execute = new List<T_WarehousingDsp>();
            {
                try
                {
                    var context = new SalesManagement_DevContext();
                    var table = from t1 in context.T_Warehousings
                                join t2 in context.T_Hattyus
                                on t1.HaID equals t2.HaID
                                join t3 in context.M_Employees
                                on t1.EmID equals t3.EmID
                                where (t1.WaFlag == 0 && t1.WaShelfFlag == 0)
                                select new
                                {
                                    t1.WaID,
                                    t2.HaID,
                                    t3.EmName,
                                    t1.WaDate
                                };
                    switch (type)
                    {
                        case 0:
                            table = table.Where(x => (x.WaID.ToString().Contains(search.EmName) || x.HaID.ToString().Contains(search.EmName) ||
                              x.EmName.Contains(search.EmName)));
                            break;
                        case 1:
                            table = table.Where(x => x.WaID.ToString().Contains(search.EmName));
                            break;
                        case 2:
                            table = table.Where(x => x.HaID.ToString().Contains(search.EmName));
                            break;
                        case 3:
                            table = table.Where(x => x.EmName.Contains(search.EmName));
                            break;
                    }
                    foreach (var p in table)
                    {
                        Execute.Add(new T_WarehousingDsp()
                        {
                            WaID = p.WaID,
                            HaID = p.HaID,
                            EmName = p.EmName,
                            WaDate = p.WaDate
                        });
                    }
                    context.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "入庫検索エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return Execute;
            }
        }
        // メソッド名:WhereAreYouHiding()
        // 引　数　　:なし
        // 戻り値　　:非表示化された発注データ
        // 機能　　　:検索する
        public List<T_WarehousingDspHidden> WhereAreYouHiding(T_WarehousingDspHidden search, int type)
        {
            List<T_WarehousingDspHidden> Execute = new List<T_WarehousingDspHidden>();
            {
                try
                {
                    var context = new SalesManagement_DevContext();
                    var table = from t1 in context.T_Warehousings
                                join t2 in context.T_Hattyus
                                on t1.HaID equals t2.HaID
                                join t3 in context.M_Employees
                                on t1.EmID equals t3.EmID
                                where (t1.WaFlag == 1 || t1.WaShelfFlag == 1)
                                select new
                                {
                                    t1.WaID,
                                    t2.HaID,
                                    t3.EmName,
                                    t1.WaDate,
                                    t1.WaShelfFlag,
                                    t1.WaFlag,
                                    t1.WaHidden
                                };
                    switch (type)
                    {
                        case 0:
                            table = table.Where(x => x.WaID.ToString().Contains(search.EmName) || x.HaID.ToString().Contains(search.EmName) || x.EmName.Contains(search.EmName));
                            break;
                        case 1:
                            table = table.Where(x => x.WaID.ToString().Contains(search.EmName));
                            break;
                        case 2:
                            table = table.Where(x => x.HaID.ToString().Contains(search.EmName));
                            break;
                        case 3:
                            table = table.Where(x => x.EmName.Contains(search.EmName));
                            break;
                    }
                    foreach (var p in table)
                    {
                        Execute.Add(new T_WarehousingDspHidden()
                        {
                            WaID = p.WaID,
                            HaID = p.HaID,
                            EmName = p.EmName,
                            WaDate = p.WaDate,
                            WaShelfFlag = p.WaShelfFlag,
                            WaFlag = p.WaFlag,
                            WaHidden = p.WaHidden
                        });
                    }
                    context.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "入庫検索エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return Execute;
            }
        }
        // メソッド名:WhenAndWhere()
        // 引　数　　:なし
        // 戻り値　　:注文データ
        // 機能　　　:検索する
        public List<T_WarehousingDsp> WhenAndWhere(T_WarehousingDsp search, DateTime From, DateTime To, int type)
        {
            List<T_WarehousingDsp> Execute = new List<T_WarehousingDsp>();
            {
                try
                {
                    var context = new SalesManagement_DevContext();
                    var FromThisTime = From.Date; var ToThisTime = To.Date;
                    var table = from t1 in context.T_Warehousings
                                join t2 in context.T_Hattyus
                                on t1.HaID equals t2.HaID
                                join t3 in context.M_Employees
                                on t1.EmID equals t3.EmID
                                where (t1.WaFlag == 0 && t1.WaShelfFlag == 0)
                                select new
                                {
                                    t1.WaID,
                                    t2.HaID,
                                    t3.EmName,
                                    t1.WaDate
                                };
                    switch (type)
                    {
                        case 0:
                            table = table.Where(x => (x.WaID.ToString().Contains(search.EmName) || x.HaID.ToString().Contains(search.EmName) ||x.EmName.Contains(search.EmName) && (x.WaDate >= FromThisTime && x.WaDate <= ToThisTime)));
                            break;
                        case 1:
                            table = table.Where(x => (x.WaDate >= FromThisTime && x.WaDate <= ToThisTime) && x.WaID.ToString().Contains(search.EmName));
                            break;
                        case 2:
                            table = table.Where(x => (x.WaDate >= FromThisTime && x.WaDate <= ToThisTime) && x.HaID.ToString().Contains(search.EmName));
                            break;
                        case 3:
                            table = table.Where(x => (x.WaDate >= FromThisTime && x.WaDate <= ToThisTime) && x.EmName.Contains(search.EmName));
                            break;
                        case 4:
                            table = table.Where(x => (x.WaDate >= FromThisTime && x.WaDate <= ToThisTime));
                            break;
                    }

                    foreach (var p in table)
                    {
                        Execute.Add(new T_WarehousingDsp()
                        {
                            WaID = p.WaID,
                            HaID = p.HaID,
                            EmName = p.EmName,
                            WaDate = p.WaDate
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
        // メソッド名:WhenAndWhereHidding()
        // 引　数　　:なし
        // 戻り値　　:受注データ
        // 機能　　　:検索する
        public List<T_WarehousingDspHidden> WhenAndWhereHiding(T_WarehousingDspHidden search, DateTime From, DateTime To, int type)
        {
            List<T_WarehousingDspHidden> Execute = new List<T_WarehousingDspHidden>();
            {
                try
                {
                    var context = new SalesManagement_DevContext();
                    var FromThisTime = From.Date; var ToThisTime = To.Date;
                    var table = from t1 in context.T_Warehousings
                                join t2 in context.T_Hattyus
                                on t1.HaID equals t2.HaID
                                join t3 in context.M_Employees
                                on t1.EmID equals t3.EmID
                                where (t1.WaFlag == 1 && t1.WaShelfFlag == 1)
                                select new
                                {
                                    t1.WaID,
                                    t2.HaID,
                                    t3.EmName,
                                    t1.WaDate,
                                    t1.WaShelfFlag,
                                    t1.WaFlag,
                                    t1.WaHidden
                                };
                    switch (type)
                    {
                        case 0:
                            table = table.Where(x => (x.WaID.ToString().Contains(search.EmName) || x.HaID.ToString().Contains(search.EmName) ||
                x.EmName.Contains(search.EmName) && (x.WaDate >= FromThisTime && x.WaDate <= ToThisTime)));
                            break;
                        case 1:
                            table = table.Where(x => (x.WaDate >= FromThisTime && x.WaDate <= ToThisTime) && x.WaID.ToString().Contains(search.EmName));
                            break;
                        case 2:
                            table = table.Where(x => (x.WaDate >= FromThisTime && x.WaDate <= ToThisTime) && x.HaID.ToString().Contains(search.WaID.ToString()));
                            break;
                        case 3:
                            table = table.Where(x => (x.WaDate >= FromThisTime && x.WaDate <= ToThisTime) && x.EmName.Contains(search.EmName));
                            break;
                        case 4:
                            table = table.Where(x => (x.WaDate >= FromThisTime && x.WaDate <= ToThisTime));
                            break;
                    }
                    foreach (var p in table)
                    {
                        Execute.Add(new T_WarehousingDspHidden()
                        {
                            WaID = p.WaID,
                            HaID = p.HaID,
                            EmName = p.EmName,
                            WaDate = p.WaDate,
                            WaShelfFlag = p.WaShelfFlag,
                            WaFlag = p.WaFlag,
                            WaHidden = p.WaHidden
                        });
                    }
                    context.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "入庫検索エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return Execute;
            }
        }
        // メソッド名:When()
        // 引　数　　:なし
        // 戻り値　　:発注データ
        // 機能　　　:検索する
        public List<T_WarehousingDsp> When(DateTime From, DateTime To)
        {
            var FromThisTime = From.Date; var ToThisTime = To.Date;
            List<T_WarehousingDsp> WarehousingDsp = new List<T_WarehousingDsp>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.T_Warehousings
                            join t2 in context.T_Hattyus
                            on t1.HaID equals t2.HaID
                            join t3 in context.M_Employees
                            on t1.EmID equals t3.EmID
                            where ((t1.WaDate >= FromThisTime && t1.WaDate <= ToThisTime))
                            select new
                            {
                                t1.WaID,
                                t2.HaID,
                                t3.EmName,
                                t1.WaDate
                            };
                foreach (var p in table)
                {
                    WarehousingDsp.Add(new T_WarehousingDsp()
                    {
                        WaID = p.WaID,
                        HaID = p.HaID,
                        EmName = p.EmName,
                        WaDate = p.WaDate
                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "入庫表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return WarehousingDsp;
        }
        // メソッド名:KingsCross()
        // 引　数　　:なし
        // 戻り値　　:なし
        // 機能　　　:在庫にデータを追加する
        public bool KingsCross(T_Warehousing ticket)
        {
            var context = new SalesManagement_DevContext();
            T_Stock HogwartsExpress = new T_Stock()
            {
                StID = ticket.WaID,
                PrID = ticket.WaID
            };
            context.T_Stocks.Add(HogwartsExpress);
            context.SaveChanges();
            context.Dispose();
            return true;
        }
    }
}
