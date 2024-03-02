using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Iris
{
    class StockAccess
    {
        // メソッド名:GetStockData()
        // 引　数　　:なし
        // 戻り値　　:在庫データ
        // 機能　　　:在庫データの取得
        public List<T_Stock> GetStockData()
        {
            List<T_Stock> exist = null;
            try
            {
                var context = new SalesManagement_DevContext();
                exist = context.T_Stocks.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "在庫DBエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return exist;
        }

        // メソッド名:GetStockDisplay()
        // 引　数　　:なし
        // 戻り値　　:在庫(表示)データ
        // 機能　　　:表示用在庫データの取得
        public List<T_Stock> GetStockDisplay()
        {

            List<T_Stock> exist = null;
            try
            {
                var context = new SalesManagement_DevContext();
                exist = context.T_Stocks.Where(x => x.StFlag == 0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "在庫表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return exist;
        }
    }
}
