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
    class T_Stock
    {
        [Key]
        public int StID { get; set; }           //在庫ID
        public int PrID { get; set; }           //商品ID
        public int StQuantity { get; set; }     //在庫数
        public int StFlag { get; set; }	        //在庫管理フラグ
    }
    class T_StockDsp
    {
        public int StID { get; set; }
        [DisplayName("商品ID")]
        public int PrID { get; set; }
        [DisplayName("商品名")]
        public String PrName { get; set; }
        [DisplayName("在庫状態")]
        public String StStat { get; set; }
        [DisplayName("在庫数")]
        public String StQuantity { get; set; }
    }
}
