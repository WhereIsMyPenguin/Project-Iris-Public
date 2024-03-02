using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_Iris
{
    class T_WarehousingDetail
    {
        [Key]
        public int WaDetailID { get; set; }     //入庫詳細ID
        public int HaID { get; set; }           //注文ID
        public int PrID { get; set; }           //商品ID
        public int WaQuantity { get; set; }     //数量

    }
    class T_WarehousingDetailDsp
    {
        [DisplayName("商品ID")]
        public int PrID { get; set; }
        [DisplayName("商品名")]
        public string PrName { get; set; }
        [DisplayName("色")]
        public string PrColor
        { get; set; }
        [DisplayName("単品価格")]
        public int Price { get; set; }
        [DisplayName("数量")]
        public int WaQuantity { get; set; }
    }
}
