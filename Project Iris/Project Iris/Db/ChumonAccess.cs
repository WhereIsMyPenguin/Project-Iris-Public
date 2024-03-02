using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Iris
{
    class ChumonAccess
    {
        // メソッド名:GetChumonData()
        // 引　数　　:なし
        // 戻り値　　:注文データ
        // 機能　　　:注文データの取得
        public List<T_Chumon> GetChumonData()
        {
            List<T_Chumon> exist = null;
            try
            {
                var context = new SalesManagement_DevContext();
                exist = context.T_Chumons.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "注文DBエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return exist;
        }
        // メソッド名:GetChumonDisplay()
        // 引　数　　:なし
        // 戻り値　　:注文データ(表示用)
        // 機能　　　:表示用注文データの取得
        public List<T_ChumonDsp> GetChumonDisplay()
        {
            List<T_ChumonDsp> ChumonDsp = new List<T_ChumonDsp>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.T_Chumons
                            join t2 in context.M_SalesOffices
                            on t1.SoID equals t2.SoID
                            join t3 in context.M_Clients
                            on t1.ClID equals t3.ClID
                            where (t1.ChFlag == 0 && t1.ChStateFlag == 0)
                            select new
                            {
                                t1.ChID,
                                t1.SoID,
                                t2.SoName,
                                t3.ClID,
                                t3.ClName,
                                t1.OrID,
                                t1.ChDate
                            };
                foreach (var p in table)
                {
                    ChumonDsp.Add(new T_ChumonDsp()
                    {
                        ChID = p.ChID,
                        SoID = p.SoID,
                        SoName = p.SoName,
                        ClID = p.ClID,
                        ClName = p.ClName,
                        OrID = p.OrID
                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "注文表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ChumonDsp;
        }
        // メソッド名:GetChumonHiddenDisplay()
        // 引　数　　:なし
        // 戻り値　　:非表示された注文データ(表示用)
        // 機能　　　:表示用注文データの取得
        public List<T_ChumonDspHidden> GetChumonHiddenDisplay()
        {
            List<T_ChumonDspHidden> ChumonDsp = new List<T_ChumonDspHidden>();
            {
                try
                {
                    var context = new SalesManagement_DevContext();
                    var table = from t1 in context.T_Chumons
                                join t2 in context.M_SalesOffices
                                on t1.SoID equals t2.SoID
                                join t4 in context.M_Clients
                                on t1.ClID equals t4.ClID
                                join t5 in context.T_Orders
                                on t1.OrID equals t5.OrID
                                join t3 in context.M_Employees
                                on t1.EmID equals t3.EmID into t3list from t3 in t3list.DefaultIfEmpty()
                                where (t1.ChFlag == 1 || t1.ChStateFlag == 1)
                                select new
                                {
                                    t1.ChID,
                                    t1.SoID,
                                    t2.SoName,
                                    t1.EmID,
                                    t3.EmName,
                                    t1.ClID,
                                    t4.ClName,
                                    t5.OrID,
                                    t1.ChDate,
                                    t1.ChStateFlag,
                                    t1.ChFlag,
                                    t1.ChHidden
                                };
                    foreach (var p in table)
                    {
                        ChumonDsp.Add(new T_ChumonDspHidden()
                        {
                            ChID = p.ChID,
                            SoID = p.SoID,
                            SoName = p.SoName,
                            EmID = p.EmID,
                            EmName = p.EmName,
                            ClID = p.ClID,
                            ClName = p.ClName,
                            OrID = p.OrID,
                            ChDate = p.ChDate,
                            ChStateFlag = p.ChStateFlag,
                            ChFlag = p.ChFlag,
                            ChHidden = p.ChHidden
                        });
                    }
                    context.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "注文表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return ChumonDsp;
            }
        }
                // メソッド名:GetChumonDetail()
                // 引　数　　:なし
                // 戻り値　　:注文詳細データ
                // 機能　　　:注文詳細データの取得
                public List<T_ChumonDetailDsp> GetChumonDetail(string ID)
        {
            List<T_ChumonDetailDsp> ChumonDetailDsp = new List<T_ChumonDetailDsp>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.T_ChumonDetails
                            join t2 in context.M_Products
                            on t1.PrID equals t2.PrID
                            where (t1.ChID.ToString() == ID)
                            select new
                            {
                                t1.ChID,
                                t1.PrID,
                                t2.PrName,
                                t2.Price,
                                t2.PrColor,
                                t1.ChQuantity,
                            };
                foreach (var p in table)
                {
                    ChumonDetailDsp.Add(new T_ChumonDetailDsp()
                    {
                        ChID = p.ChID,
                        PrID = p.PrID,
                        PrName = p.PrName,
                        Price = p.Price,
                        PrColor=p.PrColor,
                        ChQuantity = p.ChQuantity,
                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "注文詳細表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ChumonDetailDsp;
        }
        // メソッド名BravoSixGoingDark()
        // 引　数　　:なし
        // 戻り値　　:Bool
        // 機能　　　:注文データの非表示
        public bool BravoSixGoingDark(int ChID,string Reason)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var modify = context.T_Chumons.Single(x => x.ChID == ChID);
                modify.ChFlag = 1;
                modify.ChHidden = Reason;
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "注文非表示化エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // メソッド名SnapBackToReality()
        // 引　数　　:なし
        // 戻り値　　:Bool
        // 機能　　　:受注データの表示化
        public bool SnapBackToReality(int ChID)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var modify = context.T_Chumons.Single(x => x.ChID == ChID);
                modify.ChStateFlag = 0;
                modify.ChFlag = 0;
                modify.ChHidden = "";
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "注文表示化エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // メソッド名:DefaultSearch()
        // 引　数　　:なし
        // 戻り値　　:注文データ
        // 機能　　　:検索する
        public List<T_ChumonDsp> DefaultSearch(string search, int type)
        {
            List<T_ChumonDsp> table = GetChumonDisplay();
            {
                try
                {
                    var context = new SalesManagement_DevContext();
                    switch (type)
                    {
                        case 0:
                            table = table.Where(x => (x.ChID.ToString().Contains(search) || x.SoName.Contains(search) ||
                               x.ClName.Contains(search) || x.OrID.ToString().Contains(search))).ToList();
                            break;
                        case 1:
                            table = table.Where(x => x.ChID.ToString().Contains(search)).ToList();
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
                    MessageBox.Show(ex.Message, "注文検索エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return table;
            }
        }
        // メソッド名:HiddenSearch()
        // 引　数　　:なし
        // 戻り値　　:非表示化された受注データ
        // 機能　　　:検索する
        public List<T_ChumonDspHidden> HiddenSearch(string search, int type, bool DateCheck, DateTime From, DateTime To)
        {
            List<T_ChumonDspHidden> table = GetChumonHiddenDisplay();
            {
                try
                {
                    var context = new SalesManagement_DevContext();
                    if(!DateCheck)
                    {
                        switch (type)
                        {
                            case 0:
                                table = table.Where(x => x.ChID.ToString().Contains(search) || x.SoName.Contains(search) ||
                                  x.EmName.Contains(search) || x.ClName.Contains(search) || x.OrID.ToString().Contains(search)).ToList();
                                break;
                            case 1:
                                table = table.Where(x => x.ChID.ToString().Contains(search)).ToList();
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
                                table = table.Where(x => (x.ChID.ToString().Contains(search) || x.SoName.Contains(search) ||
                                  x.EmName.Contains(search) || x.ClName.Contains(search) || x.OrID.ToString().Contains(search)) && (x.ChDate >= From.Date && x.ChDate <= To.Date)).ToList();
                                break;
                            case 1:
                                table = table.Where(x => x.ChID.ToString().Contains(search) && (x.ChDate >= From.Date && x.ChDate <= To.Date)).ToList();
                                break;
                            case 2:
                                table = table.Where(x => x.SoName.Contains(search) && (x.ChDate >= From.Date && x.ChDate <= To.Date)).ToList();
                                break;
                            case 3:
                                table = table.Where(x => x.EmName.Contains(search) && (x.ChDate >= From.Date && x.ChDate <= To.Date)).ToList();
                                break;
                            case 4:
                                table = table.Where(x => x.ClName.Contains(search) && (x.ChDate >= From.Date && x.ChDate <= To.Date)).ToList();
                                break;
                            case 5:
                                table = table.Where(x => x.OrID.ToString().Contains(search) && (x.ChDate >= From.Date && x.ChDate <= To.Date)).ToList();
                                break;
                        }
                    }
                    context.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "注文検索エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return table;
            }
        }
        // メソッド名:KingsCross()
        // 引　数　　:なし
        // 戻り値　　:なし
        // 機能　　　:注文にデータを追加する
        public bool KingsCross(T_Chumon ticket)
        {
            var context = new SalesManagement_DevContext();
            T_Syukko HogwartsExpress = new T_Syukko()
            {
                SoID = ticket.SoID,
                ClID = ticket.ClID,
                OrID = ticket.OrID,
                SyStateFlag = 0
            };
            context.T_Syukkos.Add(HogwartsExpress);
            context.SaveChanges();
            int HeresYourTicket = HogwartsExpress.SyID;
            int HarryPotter = ticket.ChID;
            context.Dispose();
            SyukkoDetail(HeresYourTicket, HarryPotter);
            return true;
        }
        // メソッド名:ChumonDetail()
        // 引　数　　:なし
        // 戻り値　　:なし
        // 機能　　　:注文にデータを追加する
        public bool SyukkoDetail(int SyKey, int ChKey)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                List<T_SyukkoDetail> ChumonDetail = new List<T_SyukkoDetail>();
                var loadDetail = from t1 in context.T_ChumonDetails
                                 where (t1.ChID == ChKey)
                                 select new
                                 {
                                     t1.PrID,
                                     t1.ChQuantity
                                 };
                foreach (var p in loadDetail)
                {
                    T_SyukkoDetail AddDetail = new T_SyukkoDetail()
                    {
                        SyID = SyKey,
                        PrID = p.PrID,
                        SyQuantity = p.ChQuantity
                    };
                    context.T_SyukkoDetails.Add(AddDetail);
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