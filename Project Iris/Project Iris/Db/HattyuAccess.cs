using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Iris
{
    class HattyuAccess
    {
        // メソッド名:GetHattyuData()
        // 引　数　　:なし
        // 戻り値　　:発注データ
        // 機能　　　:発注データの取得
        public List<T_Hattyu> GetHattyuData()
        {
            List<T_Hattyu> exist = null;
            try
            {
                var context = new SalesManagement_DevContext();
                exist = context.T_Hattyus.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "発注DBエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return exist;
        }
        // メソッド名:GetHattyuDisplay()
        // 引　数　　:なし
        // 戻り値　　:発注データ(表示用)
        // 機能　　　:表示用注文データの取得
        public List<T_HattyuDsp> GetHattyuDisplay()
        {
            List<T_HattyuDsp> HattyuDsp = new List<T_HattyuDsp>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.T_Hattyus
                            join t2 in context.M_Makers
                            on t1.MaID equals t2.MaID
                            join t3 in context.M_Employees
                            on t1.EmID equals t3.EmID
                            where (t1.HaFlag == 0 && t1.WaWarehouseFlag == 0)
                            select new
                            {
                                t1.HaID,
                                t1.MaID,
                                t2.MaName,
                                t1.EmID,
                                t3.EmName,
                                t1.HaDate
                            };
                foreach (var p in table)
                {
                    HattyuDsp.Add(new T_HattyuDsp()
                    {
                        HaID = p.HaID,
                        MaID = p.MaID,
                        MaName = p.MaName,
                        EmID = p.EmID,
                        EmName = p.EmName,
                        HaDate = p.HaDate
                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "発注表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return HattyuDsp;
        }
        // メソッド名:GetHattyuHiddenDisplay()
        // 引　数　　:なし
        // 戻り値　　:非表示された発注データ(表示用)
        // 機能　　　:表示用注文データの取得
        public List<T_HattyuDspHidden> GetHattyuHiddenDisplay()
        {
            List<T_HattyuDspHidden> HattyuDsp = new List<T_HattyuDspHidden>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.T_Hattyus
                            join t2 in context.M_Makers
                            on t1.MaID equals t2.MaID
                            join t3 in context.M_Employees
                            on t1.EmID equals t3.EmID
                            where (t1.HaFlag == 1 || t1.WaWarehouseFlag == 1)
                            select new
                            {
                                t1.HaID,
                                t1.MaID,
                                t2.MaName,
                                t1.EmID,
                                t3.EmName,
                                t1.HaDate,
                                t1.HaFlag,
                                t1.WaWarehouseFlag,
                                t1.HaHidden
                            };
                foreach (var p in table)
                {
                    HattyuDsp.Add(new T_HattyuDspHidden()
                    {
                        HaID = p.HaID,
                        MaName = p.MaName,
                        EmName = p.EmName,
                        HaDate = p.HaDate,
                        HaFlag = p.HaFlag,
                        WaWarehouseFlag = p.WaWarehouseFlag,
                        HaHidden = p.HaHidden
                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "受注表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return HattyuDsp;
        }
        // メソッド名:GetHattyuDetail()
        // 引　数　　:なし
        // 戻り値　　:発注詳細データ
        // 機能　　　:発注詳細データの取得
        public List<T_HattyuDetailDsp> GetHattyuDetail(string ID)
        {
            List<T_HattyuDetailDsp> HattyuDetailDsp = new List<T_HattyuDetailDsp>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.T_HattyuDetails
                            join t2 in context.M_Products
                            on t1.PrID equals t2.PrID
                            where (t1.HaID.ToString() == ID)
                            select new
                            {
                                t2.PrID,
                                t2.PrName,
                                t2.PrColor,
                                t2.Price,
                                t1.HaQuantity,
                                t1.HaTotalPrice
                            };
                foreach (var p in table)
                {
                    HattyuDetailDsp.Add(new T_HattyuDetailDsp()
                    {
                        PrID = p.PrID,
                        PrName = p.PrName,
                        PrColor = p.PrColor,
                        Price = p.Price,
                        HaQuantity = p.HaQuantity,
                        HaTotalPrice = p.HaTotalPrice
                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "発注詳細表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return HattyuDetailDsp;
        }
        // メソッド名:CreateDetails()
        // 引　数　　:なし
        // 戻り値　　:Bool
        // 機能　　　:発注詳細を作成
        public bool CreateDetails(T_HattyuDetail hattyuDetail)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var refine = new T_HattyuDetail()
                {
                    HaID = hattyuDetail.HaID,
                    PrID = hattyuDetail.PrID,
                    HaQuantity = hattyuDetail.HaQuantity,
                    HaTotalPrice = hattyuDetail.HaTotalPrice
                };
                context.T_HattyuDetails.Add(refine);
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "発注詳細作成エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // メソッド名:ModifyDetails()
        // 引　数　　:なし
        // 戻り値　　:Bool
        // 機能　　　:発注詳細を変更
        public bool ModifyDetails(T_HattyuDetail hattyuDetail)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var modify = context.T_HattyuDetails.Single(x => x.HaDetailID == hattyuDetail.HaDetailID);
                modify.PrID = hattyuDetail.PrID;
                modify.HaQuantity = hattyuDetail.HaQuantity;
                modify.HaTotalPrice = hattyuDetail.HaTotalPrice;
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "発注詳細更新エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // メソッド名:DeleteDetails()
        // 引　数　　:なし
        // 戻り値　　:Bool
        // 機能　　　:発注詳細の削除
        public bool DeleteDetails(int where)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                int count = context.T_HattyuDetails.Count(x => x.HaID == where);
                context.T_HattyuDetails.RemoveRange(context.T_HattyuDetails.Where(x => x.HaID == where)); ;
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "発注詳細更新エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // メソッド名:ModifyOrder()
        // 引　数　　:なし
        // 戻り値　　:Bool
        // 機能　　　:発注データの変更
        public bool ModifyHattyu(T_Hattyu hattyu)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var modify = context.T_Hattyus.Single(x => x.HaID == hattyu.HaID);
                modify.HaID = hattyu.HaID;
                modify.MaID = hattyu.MaID;
                modify.EmID = hattyu.EmID;
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "発注更新エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // メソッド名BravoSixGoingDark()
        // 引　数　　:なし
        // 戻り値　　:Bool
        // 機能　　　:発注データの非表示
        public bool BravoSixGoingDark(T_Hattyu hattyu)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var modify = context.T_Hattyus.Single(x => x.HaID == hattyu.HaID);
                modify.HaFlag = hattyu.HaFlag;
                modify.HaHidden = hattyu.HaHidden;
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "発注非表示化エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // メソッド名SnapBackToReality()
        // 引　数　　:なし
        // 戻り値　　:Bool
        // 機能　　　:発注データの表示化
        public bool SnapBackToReality(T_Hattyu hattyu)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var modify = context.T_Hattyus.Single(x => x.HaID == hattyu.HaID);
                modify.HaFlag = hattyu.HaFlag;
                modify.HaHidden = "";
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "発注表示化エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // メソッド名:DefaultSearch()
        // 引　数　　:なし
        // 戻り値　　:発注データ
        // 機能　　　:検索する
        public List<T_HattyuDsp> WhereAreYou(T_HattyuDsp search, int type)
        {
            List<T_HattyuDsp> Execute = new List<T_HattyuDsp>();
            {
                try
                {
                    var context = new SalesManagement_DevContext();
                    var table = from t1 in context.T_Hattyus
                                join t2 in context.M_Makers
                                on t1.MaID equals t2.MaID
                                join t3 in context.M_Employees
                                on t1.EmID equals t3.EmID
                                where (t1.HaFlag == 0 && t1.WaWarehouseFlag == 0)
                                select new
                                {
                                    t1.HaID,
                                    t2.MaName,
                                    t3.EmName,
                                    t1.HaDate
                                };
                    switch (type)
                    {
                        case 0:
                            table = table.Where(x => (x.HaID.ToString().Contains(search.MaName) || x.MaName.Contains(search.MaName) ||
                    x.EmName.Contains(search.EmName)));
                            break;
                        case 1:
                            table = table.Where(x => x.HaID.ToString().Contains(search.MaName));
                            break;
                        case 2:
                            table = table.Where(x => x.MaName.Contains(search.MaName));
                            break;
                        case 3:
                            table = table.Where(x => x.EmName.Contains(search.EmName));
                            break;
                    }
                    foreach (var p in table)
                    {
                        Execute.Add(new T_HattyuDsp()
                        {
                            HaID = p.HaID,
                            MaName = p.MaName,
                            EmName = p.EmName,
                            HaDate = p.HaDate
                        });
                    }
                    context.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "発注検索エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return Execute;
            }
        }
        // メソッド名:HiddenSearch()
        // 引　数　　:なし
        // 戻り値　　:発注データ
        // 機能　　　:検索する
        public List<T_HattyuDsp> WhenAndWhere(T_HattyuDsp search, DateTime From, DateTime To, int type)
        {
            List<T_HattyuDsp> Execute = new List<T_HattyuDsp>();
            {
                try
                {
                    var context = new SalesManagement_DevContext();
                    var FromThisTime = From.Date; var ToThisTime = To.Date;
                    var table = from t1 in context.T_Hattyus
                                join t2 in context.M_Makers
                                on t1.MaID equals t2.MaID
                                join t3 in context.M_Employees
                                on t1.EmID equals t3.EmID
                                where (t1.HaFlag == 0 && t1.WaWarehouseFlag == 0)
                                select new
                                {
                                    t1.HaID,
                                    t2.MaName,
                                    t3.EmName,
                                    t1.HaDate
                                };
                    switch (type)
                    {
                        case 0:
                            table = table.Where(x => (x.HaID.ToString().Contains(search.MaName) || x.MaName.Contains(search.MaName) ||
                x.EmName.Contains(search.EmName)) && (x.HaDate >= FromThisTime && x.HaDate <= ToThisTime));
                            break;
                        case 1:
                            table = table.Where(x => (x.HaDate >= FromThisTime && x.HaDate <= ToThisTime) && x.HaID.ToString().Contains(search.MaName));
                            break;
                        case 2:
                            table = table.Where(x => (x.HaDate >= FromThisTime && x.HaDate <= ToThisTime) && x.MaName.Contains(search.MaName));
                            break;
                        case 3:
                            table = table.Where(x => (x.HaDate >= FromThisTime && x.HaDate <= ToThisTime) && x.EmName.Contains(search.EmName));
                            break;
                    }

                    foreach (var p in table)
                    {
                        Execute.Add(new T_HattyuDsp()
                        {
                            HaID = p.HaID,
                            MaName = p.MaName,
                            EmName = p.EmName,
                            HaDate = p.HaDate
                        });
                    }
                    context.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "発注検索エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return Execute;
            }
        }
        // メソッド名:When()
        // 引　数　　:なし
        // 戻り値　　:発注データ
        // 機能　　　:検索する
        public List<T_HattyuDsp> When(DateTime From, DateTime To)
        {
            var FromThisTime = From.Date; var ToThisTime = To.Date;
            List<T_HattyuDsp> HattyuDsp = new List<T_HattyuDsp>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.T_Hattyus
                            join t2 in context.M_Makers
                            on t1.MaID equals t2.MaID
                            join t3 in context.M_Employees
                            on t1.EmID equals t3.EmID
                            where (t1.HaFlag == 0 && t1.WaWarehouseFlag == 0 && (t1.HaDate >= FromThisTime && t1.HaDate <= ToThisTime))
                            select new
                            {
                                t1.HaID,
                                t2.MaName,
                                t3.EmName,
                                t1.HaDate
                            };
                foreach (var p in table)
                {
                    HattyuDsp.Add(new T_HattyuDsp()
                    {
                        HaID = p.HaID,
                        MaName = p.MaName,
                        EmName = p.EmName,
                        HaDate = p.HaDate
                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "発注表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return HattyuDsp;
        }
        // メソッド名:WhereAreYouHiding()
        // 引　数　　:なし
        // 戻り値　　:非表示化された発注データ
        // 機能　　　:検索する
        public List<T_HattyuDspHidden> WhereAreYouHiding(T_HattyuDspHidden search, int type)
        {
            List<T_HattyuDspHidden> Execute = new List<T_HattyuDspHidden>();
            {
                try
                {
                    var context = new SalesManagement_DevContext();
                    var table = from t1 in context.T_Hattyus
                                join t2 in context.M_Makers
                                on t1.MaID equals t2.MaID
                                join t3 in context.M_Employees
                                on t1.EmID equals t3.EmID
                                where (t1.HaFlag == 1 || t1.WaWarehouseFlag == 1)
                                select new
                                {
                                    t1.HaID,
                                    t2.MaName,
                                    t3.EmName,
                                    t1.HaDate,
                                    t1.HaFlag,
                                    t1.WaWarehouseFlag,
                                    t1.HaHidden
                                };
                    switch (type)
                    {
                        case 0:
                            table = table.Where(x => (x.HaID.ToString().Contains(search.MaName) || x.MaName.Contains(search.MaName) ||
                    x.EmName.Contains(search.EmName)));
                            break;
                        case 1:
                            table = table.Where(x => x.HaID.ToString().Contains(search.MaName));
                            break;
                        case 2:
                            table = table.Where(x => x.MaName.Contains(search.MaName));
                            break;
                        case 3:
                            table = table.Where(x => x.EmName.Contains(search.EmName));
                            break;
                    }
                    foreach (var p in table)
                    {
                        Execute.Add(new T_HattyuDspHidden()
                        {
                            HaID = p.HaID,
                            MaName = p.MaName,
                            EmName = p.EmName,
                            HaDate = p.HaDate,
                            HaFlag = p.HaFlag,
                            WaWarehouseFlag = p.WaWarehouseFlag,
                            HaHidden = p.HaHidden
                        });
                    }
                    context.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "発注検索エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return Execute;
            }
        }
        // メソッド名:WhenAndWhere()
        // 引　数　　:なし
        // 戻り値　　:発注データ
        // 機能　　　:検索する
        public List<T_HattyuDspHidden> WhenAndWhereHiding(T_HattyuDspHidden search, DateTime From, DateTime To, int type)
        {
            List<T_HattyuDspHidden> Execute = new List<T_HattyuDspHidden>();
            {
                try
                {
                    var context = new SalesManagement_DevContext();
                    var FromThisTime = From.Date; var ToThisTime = To.Date;
                    var table = from t1 in context.T_Hattyus
                                join t2 in context.M_Makers
                                on t1.MaID equals t2.MaID
                                join t3 in context.M_Employees
                                on t1.EmID equals t3.EmID
                                where (t1.HaFlag == 1 || t1.WaWarehouseFlag == 1)
                                select new
                                {
                                    t1.HaID,
                                    t2.MaName,
                                    t3.EmName,
                                    t1.HaDate,
                                    t1.HaFlag,
                                    t1.WaWarehouseFlag,
                                    t1.HaHidden
                                };
                    switch (type)
                    {
                        case 0:
                            table = table.Where(x => (x.HaID.ToString().Contains(search.MaName) || x.MaName.Contains(search.MaName) ||
                x.EmName.Contains(search.EmName)) && (x.HaDate >= FromThisTime && x.HaDate <= ToThisTime));
                            break;
                        case 1:
                            table = table.Where(x => (x.HaDate >= FromThisTime && x.HaDate <= ToThisTime) && x.HaID.ToString().Contains(search.MaName));
                            break;
                        case 2:
                            table = table.Where(x => (x.HaDate >= FromThisTime && x.HaDate <= ToThisTime) && x.MaName.Contains(search.MaName));
                            break;
                        case 3:
                            table = table.Where(x => (x.HaDate >= FromThisTime && x.HaDate <= ToThisTime) && x.EmName.Contains(search.EmName));
                            break;
                    }

                    foreach (var p in table)
                    {
                        Execute.Add(new T_HattyuDspHidden()
                        {
                            HaID = p.HaID,
                            MaName = p.MaName,
                            EmName = p.EmName,
                            HaDate = p.HaDate,
                            HaFlag = p.HaFlag,
                            WaWarehouseFlag = p.WaWarehouseFlag,
                            HaHidden = p.HaHidden
                        });
                    }
                    context.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "発注検索エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return Execute;
            }
        }
        // メソッド名:When()
        // 引　数　　:なし
        // 戻り値　　:発注データ(非表示)
        // 機能　　　:検索する
        public List<T_HattyuDspHidden> WhenHiding(DateTime From, DateTime To)
        {
            var FromThisTime = From.Date; var ToThisTime = To.Date;
            List<T_HattyuDspHidden> HattyuDsp = new List<T_HattyuDspHidden>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.T_Hattyus
                            join t2 in context.M_Makers
                            on t1.MaID equals t2.MaID
                            join t3 in context.M_Employees
                            on t1.EmID equals t3.EmID
                            where (t1.HaFlag == 1 || t1.WaWarehouseFlag == 1 && (t1.HaDate >= FromThisTime && t1.HaDate <= ToThisTime))
                            select new
                            {
                                t1.HaID,
                                t2.MaName,
                                t3.EmName,
                                t1.HaDate,
                                t1.HaFlag,
                                t1.WaWarehouseFlag,
                                t1.HaHidden
                            };
                foreach (var p in table)
                {
                    HattyuDsp.Add(new T_HattyuDspHidden()
                    {
                        HaID = p.HaID,
                        MaName = p.MaName,
                        EmName = p.EmName,
                        HaDate = p.HaDate,
                        HaFlag = p.HaFlag,
                        WaWarehouseFlag = p.WaWarehouseFlag,
                        HaHidden = p.HaHidden
                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "発注表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return HattyuDsp;
        }
        // メソッド名:KingsCross()
        // 引　数　　:なし
        // 戻り値　　:なし
        // 機能　　　:入庫にデータを追加する
        public bool KingsCross(T_Hattyu ticket)
        {
            //try
            //{
            var context = new SalesManagement_DevContext();
            var date = DateTime.Now;
            T_Warehousing mistExpress = new T_Warehousing()
            {
                WaID = ticket.HaID,
                HaID = ticket.HaID,
                WaDate = date.Date
            };
            context.T_Warehousings.Add(mistExpress);
            context.SaveChanges();
            int HeresYourTicket = mistExpress.WaID;
            int HarryPotter = ticket.HaID;
            context.Dispose();
            WarehousingDetail(HeresYourTicket, HarryPotter);
            return true;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "発注作成エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
        }
        // メソッド名:WarehousingDetail()
        // 引　数　　:なし
        // 戻り値　　:なし
        // 機能　　　:入庫にデータを追加する
        public bool WarehousingDetail(int Key, int WaKey)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                List<T_WarehousingDetail> WarehousingDetail = new List<T_WarehousingDetail>();
                var loadDetail = from t1 in context.T_HattyuDetails
                                 where (t1.HaID == WaKey)
                                 from t2 in context.M_Products
                                 where (t1.PrID == t2.PrID)
                                 select new
                                 {
                                     t1.HaDetailID,
                                     t1.HaID,
                                     t2.PrID,
                                     t1.HaQuantity,
                                     t1.HaTotalPrice
                                 };
                foreach (var p in loadDetail)
                {
                    T_WarehousingDetail AddDetail = new T_WarehousingDetail()
                    {
                        WaDetailID = Key,
                        PrID = p.PrID,
                        WaQuantity = p.HaQuantity
                    };
                    context.T_WarehousingDetails.Add(AddDetail);

                }
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "発注詳細作成エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}

