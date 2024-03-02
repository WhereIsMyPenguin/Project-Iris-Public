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
    class T_Order
    {

        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column("OrID",TypeName = "int", Order = 0)]
        [DisplayName("受注ID")]
        public int OrID { get; set; }           //受注ID	

        [Column("SoID", TypeName = "int", Order = 1)]
        [DisplayName("営業所ID")]
        public int SoID { get; set; }           //営業所ID
        
        [Column("EmID", TypeName = "int", Order = 2)]
        [DisplayName("社員ID")]
        public int EmID { get; set; }           //社員ID	
        
        [Column("ClID", TypeName = "int", Order = 3)]
        [DisplayName("顧客ID")]
        public int ClID { get; set; }           //顧客ID

        [Required]
        [MaxLength(50)]
        [Column("ClCharge", TypeName = "nvarchar", Order = 4)]
        [DisplayName("顧客担当者名")]
        public String ClCharge { get; set; }    //顧客担当者名

        [Required]
        [Column("OrDate", TypeName = "DateTime", Order = 5)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [DisplayName("発注年月日")]
        public DateTime OrDate { get; set; }    //受注年月日

        
        public int? OrStateFlag { get; set; }    //受注状態フラグ
        
        [Required]
        public int OrFlag { get; set; } //受注管理フラグ

        [NotMapped]
        [Column("OrFlag", TypeName = "int", Order = 7)]
        [DisplayName("受注管理")]
        public bool _OrFlag
        {
            get
            {
                return OrFlag != 0;
            }
            set
            {
                OrFlag = value ? 1 : 0;
            }
        }


        [Column("OrHidden", TypeName = "nvarchar", Order = 8)]
        [DisplayName("非表示理由")]
        public String OrHidden { get; set; }    //非表示理由
    }
    class T_OrderDsp
    {
        [DisplayName("受注ID")]
        public int OrID { get; set; }
        public int SoID { get; set; }
        [DisplayName("営業所名")]
        public String SoName { get; set; }
        public int EmID {get;set;}
        [DisplayName("社員名")]
        public String EmName { get; set; }
        public int ClID { get; set; }
        [DisplayName("顧客名")]
        public String ClName { get; set; }
        [DisplayName("顧客担当名")]
        public String ClCharge { get; set; }
        [DisplayName("発注年月日")]
        public DateTime OrDate { get; set; }
    }
    class T_OrderDspHidden
    {
        [DisplayName("受注ID")]
        public int OrID { get; set; }
        public int SoID { get; set; }
        [DisplayName("営業所名")]
        public String SoName { get; set; }
        public int EmID { get; set; }
        [DisplayName("社員名")]
        public String EmName { get; set; }
        public int ClID { get; set; }
        [DisplayName("顧客名")]
        public String ClName { get; set; }
        [DisplayName("顧客担当名")]
        public String ClCharge { get; set; }
        [DisplayName("発注年月日")]
        public DateTime OrDate { get; set; }
        public int? OrStateFlag { get; set; }
        [NotMapped]
        [DisplayName("受注状態")]
        public bool _OrStateFlag
        {
            get
            {
                return OrStateFlag != 0;
            }
            set {; }
        }
        public int OrFlag { get; set; }

        [NotMapped]
        [DisplayName("受注管理")]
        public bool _OrFlag
        {
            get
            {
                return OrFlag != 0;
            }
            set
            {
                OrFlag = value ? 1 : 0;
            }
        }
        [DisplayName("非表示理由")]
        public String OrHidden { get; set; }
    }
}
