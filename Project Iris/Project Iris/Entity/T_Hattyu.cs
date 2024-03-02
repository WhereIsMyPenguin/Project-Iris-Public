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
    class T_Hattyu
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column("HaID", TypeName = "int", Order  = 0)]
        [DisplayName("発注ID")]
        public int HaID { get; set; }           //発注ID	

        [Column("MaID", TypeName = "int", Order  = 1)]
        [DisplayName("メーカID")]
        public int MaID { get; set; }           //メーカID

        [Column("EmID", TypeName = "int", Order = 2)]
        [DisplayName("社員ID")]
        public int EmID { get; set; }           //社員ID	

        [Required]
        [Column("HaDate", TypeName = "DateTime", Order = 5)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [DisplayName("発注年月日")]
        public DateTime HaDate { get; set; }    //発注年月日


        public int? WaWarehouseFlag { get; set; }    //発注状態フラグ

        [Required]
        public int HaFlag { get; set; } //発注管理フラグ

        [NotMapped]
        [Column("HaFlag", TypeName = "int", Order = 7)]
        [DisplayName("発注管理")]
        public bool _HaFlag
        {
            get
            {
                return HaFlag != 0;
            }
            set
            {
                HaFlag = value ? 1 : 0;
            }
        }


        [Column("HaHidden", TypeName = "nvarchar", Order = 8)]
        [DisplayName("非表示理由")]
        public String HaHidden { get; set; }    //非表示理由
    }
    class T_HattyuDsp
    {
        [DisplayName("発注ID")]
        public int HaID { get; set; }
        public int MaID {get; set; }
        [DisplayName("メーカ名")]
        public String MaName { get; set; }
        public int EmID { get; set; }
        [DisplayName("発注社員名")]
        public String EmName { get; set; }
        [DisplayName("発注年月日")]
        public DateTime HaDate { get; set; }
    }
    class T_HattyuDspHidden
    {
        [DisplayName("発注ID")]
        public int HaID { get; set; }
        public int MaID { get; set; }
        [DisplayName("メーカ名")]
        public String MaName { get; set; }
        public int EmID { get; set; }
        [DisplayName("発注社員名")]
        public String EmName { get; set; }
        [DisplayName("発注年月日")]
        public DateTime HaDate { get; set; }
        public int? WaWarehouseFlag { get; set; }
        [NotMapped]
        [DisplayName("発注状態")]
        public bool _WaWarehouseFlag
        {
            get
            {
                return WaWarehouseFlag != 0;
            }
            set {; }
        }
        public int HaFlag { get; set; }

        [NotMapped]
        [DisplayName("発注管理")]
        public bool _HaFlag
        {
            get
            {
                return HaFlag != 0;
            }
            set
            {
                HaFlag = value ? 1 : 0;
            }
        }
        [DisplayName("非表示理由")]
        public String HaHidden { get; set; }
    }
}
