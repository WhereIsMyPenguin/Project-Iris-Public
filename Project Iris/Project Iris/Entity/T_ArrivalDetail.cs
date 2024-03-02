using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Project_Iris
{
    class T_ArrivalDetail
    {
        [Key]
        [Column("ArDetailID", TypeName = "int", Order = 0)]
        [DisplayName("出荷詳細ID")]
        public int ArDetailID { get; set; }     //入荷詳細ID
        [Column("ArID", TypeName = "int", Order = 1)]
        [DisplayName("出荷ID")]
        public int ArID { get; set; }           //入荷ID
        [Column("PrID", TypeName = "int", Order = 2)]
        [DisplayName("商品ID")]
        public int PrID { get; set; }           //商品ID
        [Required]
        [Column("ArQuantity", TypeName = "int", Order = 3)]
        [DisplayName("ArQuantity")]
        public int ArQuantity { get; set; }	    //数量

    }
    class T_ArrivalDetailDsp 
    {
        [DisplayName("出荷詳細ID")]
        public int ArDetailID { get; set; }
        [DisplayName("商品ID")]
        public int PrID { get; set; }
        [DisplayName("商品名")]
        public string PrName { get; set; }
        [DisplayName("色")]
        public string PrColor { get; set; }
        [DisplayName("単品価格")]
        public int Price { get; set; }
        [DisplayName("数量")]
        public int ArQuantity { get; set; }
    }

}
