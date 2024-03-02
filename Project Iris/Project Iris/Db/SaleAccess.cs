using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Iris
{
    class SaleAccess
    {
        // メソッド名:GetSaleData()
        // 引　数　　:なし
        // 戻り値　　:売上データ
        // 機能　　　:売上データの取得
        public List<T_Sale> GetSaleData()
        {
            List<T_Sale> exist = null;
            try
            {
                var context = new SalesManagement_DevContext();
                exist = context.T_Sale.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "売上DBエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return exist;
        }

        // メソッド名:GetSaleDisplay()
        // 引　数　　:なし
        // 戻り値　　:売上(表示)データ
        // 機能　　　:表示用売上データの取得
        public List<T_Sale> GetSaleDisplay()
        {

            List<T_Sale> exist = null;
            try
            {
                var context = new SalesManagement_DevContext();
                exist = context.T_Sale.Where(x => x.SaFlag == 0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "売上表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return exist;
        }
        // メソッド名:GetSaleDetail()
        // 引　数　　:なし
        // 戻り値　　:売上詳細データ
        // 機能　　　:売上詳細データの取得
        public List<T_SaleDetail> GetSaleDetail()
        {
            List<T_SaleDetail> exist = null;
            try
            {
                var context = new SalesManagement_DevContext();
                exist = context.T_SaleDetails.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "売上詳細DBエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return exist;
        }
    }
}
