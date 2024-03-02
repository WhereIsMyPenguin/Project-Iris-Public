using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Project_Iris
{
    class T_SyukkoDetail
    {
        [Key]
        [Column("SyDetailID", TypeName = "int", Order = 0)]
        [DisplayName("出庫詳細ID")]
        public int SyDetailID { get; set; }//出庫詳細ID

        [Column("SyID", TypeName = "int", Order = 1)]
        [DisplayName("出庫ID")]
        public int SyID { get; set; }           //出庫ID

        [Column("PrID",TypeName ="int",Order =2)]
        [DisplayName("商品ID")]   
        public int PrID { get; set; }           //商品ID

        [Required]
        [Column("SyQuantity",TypeName ="int", Order =3)]
        public int SyQuantity { get; set; }	    //数量
    }
    class T_SyukkoDetailDsp
    {
        [DisplayName("出庫詳細ID")]
        public int SyDetailID { get; set; }
        [DisplayName("商品ID")]
        public int PrID { get; set; }
        [DisplayName("商品名")]
        public string PrName { get; set; }
        [DisplayName("色")]
        public string PrColor { get; set; }
        [DisplayName("単品価格")]
        public int Price { get; set; }
        [DisplayName("数量")]
        public int SyQuantity { get; set; }
    }
}
