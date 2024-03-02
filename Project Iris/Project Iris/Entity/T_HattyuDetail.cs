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
    class T_HattyuDetail
    {
        [Key]

        [Column("HaDetailID", TypeName = "int", Order = 0)]
        [DisplayName("発注詳細ID")]
        public int HaDetailID { get; set; }     //発注詳細ID

        [Column("HaID", TypeName = "int", Order = 1)]
        [DisplayName("発注ID")]
        public int HaID { get; set; }           //発注ID

        [Column("PrID", TypeName = "int", Order = 2)]
        [DisplayName("商品ID")]
        public int PrID { get; set; }           //商品ID

        [Required]
        [Column("HaQuantity", TypeName = "int", Order = 3)]
        [DisplayName("数量")]
        public int HaQuantity { get; set; }	    //数量

        [Required]
        [Column("HaTotalPrice", TypeName = "int", Order = 4)]
        [DisplayName("合計金額")]
        public int HaTotalPrice { get; set; }	//合計金額
    }
    class T_HattyuDetailDsp
    {
        [DisplayName("商品ID")]
        public int PrID { get; set; }
        [DisplayName("商品名")]
        public String PrName { get; set; }
        [DisplayName("色")]
        public String PrColor { get; set; }
        [DisplayName("単品価格")]
        public int Price { get; set; }
        [DisplayName("数量")]
        public int HaQuantity { get; set; }
        [DisplayName("合計金額")]
        public int HaTotalPrice { get; set; }
    }
}
