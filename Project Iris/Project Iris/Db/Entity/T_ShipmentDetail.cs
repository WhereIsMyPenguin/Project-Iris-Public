using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Project_Iris
{
    class T_ShipmentDetail
    {
        [Key]
        [Column("ShDetailID", TypeName = "int", Order = 0)]
        [DisplayName("出荷詳細ID")]
        public int ShDetailID { get; set; }//出荷詳細ID

        [Column("ShID", TypeName = "int", Order = 1)]
        [DisplayName("出荷ID")]
        public int ShID { get; set; }           //出荷ID

        [Column("PrID", TypeName = "int", Order = 2)]
        [DisplayName("商品ID")]
        public int PrID { get; set; }           //商品ID

        [Required]
        [Column("ShQuantity", TypeName = "int", Order = 3)]
        public int ShQuantity { get; set; }	    //数量
     }
    class T_ShipmentDetailDsp
    {
        [DisplayName("出荷詳細ID")]
        public int ShDetailID { get; set; }
        [DisplayName("商品ID")]
        public int PrID { get; set; }
        [DisplayName("商品名")]
        public string PrName { get; set; }
        [DisplayName("色")]
        public string PrColor { get; set; }
        [DisplayName("単品価格")]
        public int Price { get; set; }
        [DisplayName("数量")]
        public int ShQuantity { get; set; }
    }
}
