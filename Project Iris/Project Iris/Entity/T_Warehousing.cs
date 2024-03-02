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
    class T_Warehousing
    {
        [Key]
        public int WaID { get; set; }               //入庫ID	
        public int HaID { get; set; }               //発注ID	
        public int EmID { get; set; }               //社員ID	
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime? WaDate { get; set; }       //入庫年月日
        public int WaShelfFlag { get; set; }    //入庫状態フラグ
        public int WaFlag { get; set; }	//入庫管理フラグ
        public String WaHidden { get; set; }        //非表示理由	


    }
    class T_WarehousingDsp
    {
        [DisplayName("入庫ID")]
        public int WaID { get; set; }               //入庫ID
        [DisplayName("発注ID")]
        public int HaID { get; set; }               //発注ID
        [DisplayName("社員名")]
        public String EmName { get; set; }               //社員ID
        [DisplayName("入庫年月日")]
        public DateTime? WaDate { get; set; }       //入庫年月日
    }
    class T_WarehousingDspHidden
    {
        [DisplayName("入庫ID")]
        public int WaID { get; set; }               //入庫ID
        [DisplayName("発注ID")]
        public int HaID { get; set; }               //発注ID
        [DisplayName("社員名")]
        public String EmName { get; set; }               //社員ID
        [DisplayName("入庫年月日")]
        public DateTime? WaDate { get; set; }       //入庫年月日
        public int? WaShelfFlag { get; set; }    //入庫状態フラグ
        [NotMapped]
        [DisplayName("入庫済フラグ")]
        public bool _WaShelfFlag
        {
            get { return WashelfFlag != 0; }
            set {; }
        }
        public int WashelfFlag { get; set; } //入庫済フラグ
        [NotMapped]
        [DisplayName("入庫管理")]
        public bool _WaFlag
        {
            get { return WaFlag != 0; }
            set {; }
        }
        public int WaFlag { get; set; } //入庫管理フラグ
        [DisplayName("非表示理由")]
        public String WaHidden { get; set; }        //非表示理由	
    }

}
