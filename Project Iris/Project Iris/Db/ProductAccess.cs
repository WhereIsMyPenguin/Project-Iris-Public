using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Iris
{
    class ProductAccess
    {
        // メソッド名:GetProductData()
        // 引　数　　:なし
        // 戻り値　　:商品データ
        // 機能　　　:商品データの取得
        public List<M_ProductDsp> GetProductByMa(int ID)
        {
            List<M_ProductDsp> Product = GetProductDisplay();
            try
            {
                Product = Product.Where(x => x.MaID == ID).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "商品表出力エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Product;
        }
        // メソッド名:SearchProductDisplayForOrder()
        // 引　数　　:なし
        // 戻り値　　:商品データ
        // 機能　　　:表示用商品データの検索(受注向け)
        public List<M_ProductForOrder> SearchProductDisplayForOrder(string search)
        {
            List<M_ProductForOrder> View = new List<M_ProductForOrder>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.M_Products
                            join t2 in context.M_Makers
                            on t1.MaID equals t2.MaID
                            where (t1.PrFlag == 0)
                            select new
                            {
                                t1.PrID,
                                t2.MaName,
                                t1.PrName,
                                t1.Price
                            };
                table = table.Where(x => x.PrName.Contains(search));
                foreach (var p in table)
                {
                    View.Add(new M_ProductForOrder()
                    {
                        PrID = p.PrID,
                        MaName = p.MaName,
                        PrName = p.PrName,
                        Price = p.Price
                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "商品表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return View;
        }
        // メソッド名:GetProductDisplay()
        // 引　数　　:なし
        // 戻り値　　:商品データ
        // 機能　　　:表示用商品データの検索
        public List<M_ProductDsp> GetProductDisplay()
        {
            List<M_ProductDsp> tb = new List<M_ProductDsp>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.M_Products
                            join t2 in context.M_Makers
                            on t1.MaID equals t2.MaID
                            join t3 in context.M_SmallClassifications
                            on t1.ScID equals t3.ScID
                            where t1.PrFlag == 0
                            select new
                            {
                                t1.PrID,
                                t1.PrName,
                                t1.MaID,
                                t2.MaName,
                                t1.Price,
                                t1.PrSafetyStock,
                                t1.ScID,
                                t3.ScName,
                                t1.PrColor,
                                t1.PrModelNumber,
                                t1.PrReleaseDate
                            };
                foreach (var p in table)
                {
                    tb.Add(new M_ProductDsp()
                    {
                        PrID = p.PrID,
                        PrName = p.PrName,
                        MaID = p.MaID,
                        MaName = p.MaName,
                        Price = p.Price,
                        PrSafetyStock = p.PrSafetyStock,
                        ScID = p.ScID,
                        ScName = p.ScName,
                        PrColor = p.PrColor,
                        PrModelNumber = p.PrModelNumber,
                        PrReleaseDate = p.PrReleaseDate
                    });
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "商品表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tb;
        }
        public List<M_ProductDspHidden> GetProductHiddenDisplay()
        {
            List<M_ProductDspHidden> tb = new List<M_ProductDspHidden>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.M_Products
                            join t2 in context.M_Makers
                            on t1.MaID equals t2.MaID
                            join t3 in context.M_SmallClassifications
                            on t1.ScID equals t3.ScID
                            where t1.PrFlag == 1
                            select new
                            {
                                t1.PrID,
                                t1.PrName,
                                t1.MaID,
                                t2.MaName,
                                t1.Price,
                                t1.PrSafetyStock,
                                t1.ScID,
                                t3.ScName,
                                t1.PrColor,
                                t1.PrModelNumber,
                                t1.PrReleaseDate,
                                t1.PrFlag,
                                t1.PrHidden
                            };
                foreach (var p in table)
                {
                    tb.Add(new M_ProductDspHidden()
                    {
                        PrID = p.PrID,
                        PrName = p.PrName,
                        MaID = p.MaID,
                        MaName = p.MaName,
                        Price = p.Price,
                        PrSafetyStock = p.PrSafetyStock,
                        ScID = p.ScID,
                        ScName = p.ScName,
                        PrColor = p.PrColor,
                        PrModelNumber = p.PrModelNumber,
                        PrReleaseDate = p.PrReleaseDate,
                        PrFlag = p.PrFlag,
                        PrHidden = p.PrHidden
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "商品表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tb;
        }
        public bool AddProduct(M_Product AddThis)
        {
            try
            {
                SalesManagement_DevContext context = new SalesManagement_DevContext();
                context.M_Products.Add(AddThis);
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "商品追加エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool Modify(M_Product ChangeThis, int ID)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var modify = context.M_Products.Single(x => x.PrID == ID);
                modify.PrName = ChangeThis.PrName;
                modify.MaID = ChangeThis.MaID;
                modify.Price = ChangeThis.Price;
                modify.PrSafetyStock = ChangeThis.PrSafetyStock;
                modify.PrColor = ChangeThis.PrColor;
                modify.PrModelNumber = ChangeThis.PrModelNumber;
                modify.PrReleaseDate = ChangeThis.PrReleaseDate;
                modify.ScID = ChangeThis.ScID;
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "商品更新エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public List<M_ProductDsp> DefaultSearch(string search,int type,bool DateCheck,DateTime From,DateTime To)
        {
            List<M_ProductDsp> Product = GetProductDisplay();
            try
            {
                if(!DateCheck)
                {
                    switch(type)
                    {
                        case 0:
                            Product = Product.Where(x => x.PrID.ToString().Contains(search) || x.PrName.Contains(search) || x.MaName.Contains(search)
                            || x.Price.ToString().Contains(search) || x.PrSafetyStock.ToString().Contains(search) || x.PrModelNumber.Contains(search)
                            || x.ScName.Contains(search) || x.PrColor.Contains(search)).ToList();
                            break;
                        case 1:
                            Product = Product.Where(x => x.PrID.ToString().Contains(search)).ToList();
                            break;
                        case 2:
                            Product = Product.Where(x => x.PrName.Contains(search)).ToList();
                            break;
                        case 3:
                            Product = Product.Where(x => x.MaID.ToString().Contains(search)).ToList();
                            break;
                        case 4:
                            Product = Product.Where(x => x.Price.ToString().Contains(search)).ToList();
                            break;
                        case 5:
                            Product = Product.Where(x => x.PrSafetyStock.ToString().Contains(search)).ToList();
                            break;
                        case 6:
                            Product = Product.Where(x => x.PrModelNumber.Contains(search)).ToList();
                            break;
                        case 7:
                            Product = Product.Where(x => x.ScName.Contains(search)).ToList();
                            break;
                        case 8:
                            Product = Product.Where(x => x.PrColor.Contains(search)).ToList();
                            break;
                    }
                }
                else
                {
                    switch (type)
                    {
                        case 0:
                            Product = Product.Where(x => (x.PrID.ToString().Contains(search) || x.PrName.Contains(search) || x.MaName.Contains(search)
                            || x.Price.ToString().Contains(search) || x.PrSafetyStock.ToString().Contains(search) || x.PrModelNumber.Contains(search)
                            || x.ScName.Contains(search) || x.PrColor.Contains(search)) && (x.PrReleaseDate.Date >= From.Date && x.PrReleaseDate.Date <= To.Date)).ToList();
                            break;
                        case 1:
                            Product = Product.Where(x => x.PrID.ToString().Contains(search) && (x.PrReleaseDate.Date >= From.Date && x.PrReleaseDate.Date <= To.Date)).ToList();
                            break;
                        case 2:
                            Product = Product.Where(x => x.PrName.Contains(search) && (x.PrReleaseDate.Date >= From.Date && x.PrReleaseDate.Date <= To.Date)).ToList();
                            break;
                        case 3:
                            Product = Product.Where(x => x.MaID.ToString().Contains(search) && (x.PrReleaseDate.Date >= From.Date && x.PrReleaseDate.Date <= To.Date)).ToList();
                            break;
                        case 4:
                            Product = Product.Where(x => x.Price.ToString().Contains(search) && (x.PrReleaseDate.Date >= From.Date && x.PrReleaseDate.Date <= To.Date)).ToList();
                            break;
                        case 5:
                            Product = Product.Where(x => x.PrSafetyStock.ToString().Contains(search) && (x.PrReleaseDate.Date >= From.Date && x.PrReleaseDate.Date <= To.Date)).ToList();
                            break;
                        case 6:
                            Product = Product.Where(x => x.PrModelNumber.Contains(search) && (x.PrReleaseDate.Date >= From.Date && x.PrReleaseDate.Date <= To.Date)).ToList();
                            break;
                        case 7:
                            Product = Product.Where(x => x.ScName.Contains(search) && (x.PrReleaseDate.Date >= From.Date && x.PrReleaseDate.Date <= To.Date)).ToList();
                            break;
                        case 8:
                            Product = Product.Where(x => x.PrColor.Contains(search) && (x.PrReleaseDate.Date >= From.Date && x.PrReleaseDate.Date <= To.Date)).ToList();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "商品検索エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Product;
        }

        public List<M_ProductDspHidden> HiddenSearch(string search, int type, bool DateCheck, DateTime From, DateTime To)
        {
            List<M_ProductDspHidden> Product = GetProductHiddenDisplay();
            try
            {
                if (!DateCheck)
                {
                    switch (type)
                    {
                        case 0:
                            Product = Product.Where(x => x.PrID.ToString().Contains(search) || x.PrName.Contains(search) || x.MaName.Contains(search)
                            || x.Price.ToString().Contains(search) || x.PrSafetyStock.ToString().Contains(search) || x.PrModelNumber.Contains(search)
                            || x.ScName.Contains(search) || x.PrColor.Contains(search)).ToList();
                            break;
                        case 1:
                            Product = Product.Where(x => x.PrID.ToString().Contains(search)).ToList();
                            break;
                        case 2:
                            Product = Product.Where(x => x.PrName.Contains(search)).ToList();
                            break;
                        case 3:
                            Product = Product.Where(x => x.MaID.ToString().Contains(search)).ToList();
                            break;
                        case 4:
                            Product = Product.Where(x => x.Price.ToString().Contains(search)).ToList();
                            break;
                        case 5:
                            Product = Product.Where(x => x.PrSafetyStock.ToString().Contains(search)).ToList();
                            break;
                        case 6:
                            Product = Product.Where(x => x.PrModelNumber.Contains(search)).ToList();
                            break;
                        case 7:
                            Product = Product.Where(x => x.ScName.Contains(search)).ToList();
                            break;
                        case 8:
                            Product = Product.Where(x => x.PrColor.Contains(search)).ToList();
                            break;
                    }
                }
                else
                {
                    switch (type)
                    {
                        case 0:
                            Product = Product.Where(x => (x.PrID.ToString().Contains(search) || x.PrName.Contains(search) || x.MaName.Contains(search)
                            || x.Price.ToString().Contains(search) || x.PrSafetyStock.ToString().Contains(search) || x.PrModelNumber.Contains(search)
                            || x.ScName.Contains(search) || x.PrColor.Contains(search)) && (x.PrReleaseDate.Date >= From.Date && x.PrReleaseDate.Date <= To.Date)).ToList();
                            break;
                        case 1:
                            Product = Product.Where(x => x.PrID.ToString().Contains(search) && (x.PrReleaseDate.Date >= From.Date && x.PrReleaseDate.Date <= To.Date)).ToList();
                            break;
                        case 2:
                            Product = Product.Where(x => x.PrName.Contains(search) && (x.PrReleaseDate.Date >= From.Date && x.PrReleaseDate.Date <= To.Date)).ToList();
                            break;
                        case 3:
                            Product = Product.Where(x => x.MaID.ToString().Contains(search) && (x.PrReleaseDate.Date >= From.Date && x.PrReleaseDate.Date <= To.Date)).ToList();
                            break;
                        case 4:
                            Product = Product.Where(x => x.Price.ToString().Contains(search) && (x.PrReleaseDate.Date >= From.Date && x.PrReleaseDate.Date <= To.Date)).ToList();
                            break;
                        case 5:
                            Product = Product.Where(x => x.PrSafetyStock.ToString().Contains(search) && (x.PrReleaseDate.Date >= From.Date && x.PrReleaseDate.Date <= To.Date)).ToList();
                            break;
                        case 6:
                            Product = Product.Where(x => x.PrModelNumber.Contains(search) && (x.PrReleaseDate.Date >= From.Date && x.PrReleaseDate.Date <= To.Date)).ToList();
                            break;
                        case 7:
                            Product = Product.Where(x => x.ScName.Contains(search) && (x.PrReleaseDate.Date >= From.Date && x.PrReleaseDate.Date <= To.Date)).ToList();
                            break;
                        case 8:
                            Product = Product.Where(x => x.PrColor.Contains(search) && (x.PrReleaseDate.Date >= From.Date && x.PrReleaseDate.Date <= To.Date)).ToList();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "商品検索エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Product;
        }
        public bool BravoSixGoingDark(int ID,string Reason)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var hidethis = context.M_Products.Single(x => x.PrID == ID);
                hidethis.PrFlag = 1;
                hidethis.PrHidden = Reason;
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "商品非表示化エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool SnapBackToReality(int ID)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var showthis = context.M_Products.Single(x => x.PrID == ID);
                showthis.PrFlag = 0;
                showthis.PrHidden = "";
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "商品表示化エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
