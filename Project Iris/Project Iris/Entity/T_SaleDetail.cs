using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Project_Iris
{
    class T_SaleDetail
    {
        [Key]
        public int SaDetailID { get; set; }         //売上明細ID
        public int SaID { get; set; }               //売上ID
        public int PrID { get; set; }               //商品ID
        public int SaQuantity { get; set; }         //個数
        public int SaPrTotalPrice { get; set; }	    //合計金額

    }
    class T_SaleDetailDsp
    {
        [DisplayName("売上明細ID")]
        public int SaDetailID { get; set; }
        [DisplayName("売上ID")]
        public int SaID { get; set; }
        public int PrID { get; set; }
        [DisplayName("商品名")]
        public String PrName { get; set; }
        [DisplayName("個数")]
        public int SaQuantity { get; set; }
        [DisplayName("合計金額")]
        public int SaPrTotalPrice { get; set; }
    }
}
