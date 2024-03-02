using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Iris
{
    class SyukkoAccess
    {
        // メソッド名:GetSyukkoData()
        // 引　数　　:なし
        // 戻り値　　:入庫データ
        // 機能　　　:入庫データの取得
        public List<T_Syukko> GetSyukkoData()
        {
            List<T_Syukko> exist = null;
            try
            {
                var context = new SalesManagement_DevContext();
                exist = context.T_Syukkos.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "出庫DBエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return exist;
        }

        // メソッド名:GetSyukkoDisplay()
        // 引　数　　:なし
        // 戻り値　　:出庫(表示)データ
        // 機能　　　:表示用出庫データの取得
        // 機能　　　:表示用注文データの取得
        public List<T_SyukkoDsp> GetSyukkoDisplay()
        {
            List<T_SyukkoDsp> SyukkoDsp = new List<T_SyukkoDsp>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.T_Syukkos
                            join t3 in context.M_Clients
                            on t1.ClID equals t3.ClID
                            join t4 in context.M_SalesOffices
                            on t1.SoID equals t4.SoID
                            where (t1.SyFlag == 0 && t1.SyStateFlag == 0)
                            select new
                            {
                                t1.SyID,
                                t1.SoID,
                                t1.ClID,
                                t3.ClName,
                                t4.SoName,
                                t1.SyDate,
                                t1.OrID
                            };
                foreach (var p in table)
                {
                    SyukkoDsp.Add(new T_SyukkoDsp()
                    {
                        SyID = p.SyID,
                        ClName = p.ClName,
                        SoName = p.SoName,
                        SyDate = p.SyDate,
                        SoID = p.SoID,
                        ClID = p.ClID,
                        OrID = p.OrID
                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "出庫表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return SyukkoDsp;
        }
        public List<T_SyukkoDetailDsp> GetSyukkoDetail(string ID)
        {
            List<T_SyukkoDetailDsp> SyukkoDetailDsp = new List<T_SyukkoDetailDsp>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.T_SyukkoDetails
                            join t2 in context.M_Products
                            on t1.PrID equals t2.PrID
                            where (t1.SyID.ToString() == ID)
                            select new
                            {
                                t1.SyDetailID,
                                t2.PrID,
                                t2.PrName,
                                t2.PrColor,
                                t2.Price,
                                t1.SyQuantity,
                             };
                foreach (var p in table)
                {
                    SyukkoDetailDsp.Add(new T_SyukkoDetailDsp()
                    {
                        SyDetailID = p.SyDetailID,
                        PrID = p.PrID,
                        PrName = p.PrName,
                        PrColor = p.PrColor,
                        Price = p.Price,
                        SyQuantity = p.SyQuantity,
                    }); ;
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "出庫詳細表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return SyukkoDetailDsp;
        }
        // メソッド名:GetSyukkoDisplay()
        // 引　数　　:なし
        // 戻り値　　:出庫(表示)データ
        // 機能　　　:表示用出庫データの取得
        // メソッド名:GetChumonDisplay()
        // 引　数　　:なし
        // 戻り値　　:注文データ(表示用)
        // 機能　　　:表示用注文データの取得
        public List<T_SyukkoDspHidden> GetSyukkoHiddenDisplay()
        {
            List<T_SyukkoDspHidden> SyukkoDsp = new List<T_SyukkoDspHidden>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.T_Syukkos
                            join t2 in context.M_Employees
                            on t1.EmID equals t2.EmID into t2list
                            from t2 in t2list.DefaultIfEmpty()
                            join t3 in context.M_Clients
                            on t1.ClID equals t3.ClID
                            join t4 in context.M_SalesOffices
                            on t1.SoID equals t4.SoID
                            join t5 in context.T_Orders
                            on t1.OrID equals t5.OrID
                            where (t1.SyFlag == 1 || t1.SyStateFlag == 1)
                            select new
                            {
                                t1.SyID,
                                t1.EmID,
                                t2.EmName,
                                t3.ClName,
                                t1.ClID,
                                t1.SoID,
                                t4.SoName,
                                t5.OrID,
                                t1.SyDate,
                                t1.SyStateFlag,
                                t1.SyFlag,
                                t1.SyHidden
                            };
                foreach (var p in table)
                {
                    SyukkoDsp.Add(new T_SyukkoDspHidden()
                    {
                        SyID = p.SyID,
                        EmID = p.EmID,
                        EmName = p.EmName,
                        ClID = p.ClID,
                        ClName = p.ClName,
                        SoName = p.SoName,
                        SoID = p.SoID,
                        OrID = p.OrID,
                        SyDate = p.SyDate,
                        SyStateFlag = p.SyStateFlag,
                        SyFlag = p.SyFlag,
                        SyHidden = p.SyHidden

                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "出庫表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return SyukkoDsp;
        }
        // メソッド名BravoSixGoingDark()
        // 引　数　　:なし
        // 戻り値　　:Bool
        // 機能　　　:注文データの非表示
        public bool BravoSixGoingDark(int ID,string Reason)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var modify = context.T_Syukkos.Single(x => x.SyID == ID);
                modify.SyFlag = 1;
                modify.SyHidden = Reason;
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "出庫非表示化エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                var modify = context.T_Syukkos.Single(x => x.SyID == ID);
                modify.SyStateFlag = 0;
                modify.SyFlag = 0;
                modify.SyHidden = "";
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "出庫表示化エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool KingsCross(T_Syukko ticket)
        {
            var context = new SalesManagement_DevContext();
            T_Arrival HogwartsExpress = new T_Arrival()
            {
                SoID = ticket.SoID,
                ClID = ticket.ClID,
                OrID = ticket.OrID,
                ArStateFlag = 0
            };
            context.T_Arrivals.Add(HogwartsExpress);
            context.SaveChanges();
            int HeresYourTicket = HogwartsExpress.ArID;
            int HarryPotter = ticket.SyID;
            context.Dispose();
            ArrivalDetail(HeresYourTicket, HarryPotter);
            return true;
        }
        // メソッド名:SyukkoDetail()
        // 引　数　　:なし
        // 戻り値　　:なし
        // 機能　　　:注文にデータを追加する
        public bool ArrivalDetail(int Key, int SyKey)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                List<T_ArrivalDetail> ArrivalDetail = new List<T_ArrivalDetail>();
                var loadDetail = from t1 in context.T_SyukkoDetails
                                 where (t1.SyID == SyKey)
                                 select new
                                 {
                                     t1.PrID,
                                     t1.SyQuantity,
                                 };
                foreach (var p in loadDetail)
                {
                    T_ArrivalDetail AddDetail = new T_ArrivalDetail()
                    {
                        ArID = Key,
                        PrID = p.PrID,
                        ArQuantity = p.SyQuantity
                    };
                    context.T_ArrivalDetails.Add(AddDetail);

                }
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "出庫詳細作成エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    public List<T_SyukkoDsp> DefaultSearch(string search,int type)
        {
            List<T_SyukkoDsp> table = GetSyukkoDisplay();
            try
            {
                var context = new SalesManagement_DevContext();
                switch(type)
                {
                    case 0:
                        table = table.Where(x => (x.SyID.ToString().Contains(search) || x.SoName.Contains(search) ||
                           x.ClName.Contains(search) || x.OrID.ToString().Contains(search))).ToList();
                        break;
                    case 1:
                        table = table.Where(x => x.SyID.ToString().Contains(search)).ToList();
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
                MessageBox.Show(ex.Message, "出庫検索エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return table;
        }
        public List<T_SyukkoDspHidden> HiddenSearch(string search, int type, bool DateCheck, DateTime From, DateTime To)
        {
            List<T_SyukkoDspHidden> table = GetSyukkoHiddenDisplay();
            {
                try
                {
                    var context = new SalesManagement_DevContext();
                    if (!DateCheck)
                    {
                        switch (type)
                        {
                            case 0:
                                table = table.Where(x => x.SyID.ToString().Contains(search) || x.SoName.Contains(search) ||
                                  x.EmName.Contains(search) || x.ClName.Contains(search) || x.OrID.ToString().Contains(search)).ToList();
                                break;
                            case 1:
                                table = table.Where(x => x.SyID.ToString().Contains(search)).ToList();
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
                                table = table.Where(x => (x.SyID.ToString().Contains(search) || x.SoName.Contains(search) ||
                                  x.EmName.Contains(search) || x.ClName.Contains(search) || x.OrID.ToString().Contains(search)) && (x.SyDate >= From.Date && x.SyDate <= To.Date)).ToList();
                                break;
                            case 1:
                                table = table.Where(x => x.SyID.ToString().Contains(search) && (x.SyDate >= From.Date && x.SyDate <= To.Date)).ToList();
                                break;
                            case 2:
                                table = table.Where(x => x.SoName.Contains(search) && (x.SyDate >= From.Date && x.SyDate <= To.Date)).ToList();
                                break;
                            case 3:
                                table = table.Where(x => x.EmName.Contains(search) && (x.SyDate >= From.Date && x.SyDate <= To.Date)).ToList();
                                break;
                            case 4:
                                table = table.Where(x => x.ClName.Contains(search) && (x.SyDate >= From.Date && x.SyDate <= To.Date)).ToList();
                                break;
                            case 5:
                                table = table.Where(x => x.OrID.ToString().Contains(search) && (x.SyDate >= From.Date && x.SyDate <= To.Date)).ToList();
                                break;
                        }
                    }
                    context.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "出庫検索エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return table;
            }
        }
    }
}
