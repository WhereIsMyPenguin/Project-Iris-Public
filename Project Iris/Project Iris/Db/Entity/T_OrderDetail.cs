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
    class T_OrderDetail
    {
        [Key]
        
        [Column("OrDetailID", TypeName = "int", Order = 0)]
        [DisplayName("受注詳細ID")]
        public int OrDetailID { get; set; }     //受注詳細ID

        [Column("OrID", TypeName = "int", Order = 1)]
        [DisplayName("受注ID")]
        public int OrID { get; set; }           //受注ID

        [Column("PrID", TypeName = "int", Order = 2)]
        [DisplayName("商品ID")]
        public int PrID { get; set; }           //商品ID

        [Required]
        [Column("OrQuantity",TypeName = "int", Order = 3)]
        [DisplayName("数量")]
        public int OrQuantity { get; set; }	    //数量

        [Required]
        [Column("OrTotalPrice", TypeName = "int", Order = 4)]
        [DisplayName("合計金額")]
        public int OrTotalPrice { get; set; }	//合計金額
    }
    class T_OrderDetailDsp
    {
        [DisplayName("受注詳細ID")]
        public int OrDetailID { get; set; }
        [DisplayName("商品ID")]
        public int PrID { get; set; }
        [DisplayName("商品名")]
        public String PrName { get; set; }
        [DisplayName("色")]
        public String PrColor { get; set; }
        [DisplayName("単品価格")]
        public int Price { get; set; }
        [DisplayName("数量")]
        public int OrQuantity { get; set; }
        [DisplayName("合計金額")]
        public int OrTotalPrice { get; set; }
    }
}
