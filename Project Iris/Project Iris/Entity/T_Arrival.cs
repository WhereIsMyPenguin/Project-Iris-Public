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
    class T_Arrival
    {
        [Key]
        public int ArID { get; set; }               //入荷ID	
        public int SoID { get; set; }               //営業所ID	
        public int? EmID { get; set; }               //社員ID	
        public int ClID { get; set; }               //顧客ID	
        public int OrID { get; set; }               //受注ID	
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime? ArDate { get; set; }       //入荷年月日	
        public int? ArStateFlag { get; set; }   //入荷状態フラグ
        public int ArFlag { get; set; }	//入荷管理フラグ
        public String ArHidden { get; set; }	    //非表示理由	

    }
    class T_ArrivalDsp
    {
        [DisplayName("入荷ID")]
        public int ArID { get; set; }
        public int SoID { get; set; }
        [DisplayName("営業所名")]
        public String SoName { get; set; }
        public int EmID { get; set; }
        [DisplayName("社員名")]
        public String EmName { get; set; }
        public int ClID { get; set; }
        [DisplayName("顧客名")]
        public String ClName { get; set; }
        [DisplayName("受注ID")]
        public int OrID { get; set; }
        [DisplayName("入荷年月日")]
        public DateTime? ArDate { get; set; }
     }
    class T_ArrivalDspHidden
    {
        [DisplayName("入荷ID")]
        public int ArID { get; set; }
        public int SoID { get; set; }
        [DisplayName("営業所名")]
        public String SoName { get; set; }
        public int? EmID { get; set; }
        [DisplayName("社員名")]
        public String EmName { get; set; }
        public int ClID { get; set; }
        [DisplayName("顧客名")]
        public String ClName { get; set; }
        [DisplayName("受注ID")]
        public int OrID { get; set; }
        [DisplayName("入荷年月日")]
        public DateTime? ArDate { get; set; }
        public int? ArStateFlag { get; set; }    //入荷状態フラグ
        [NotMapped]
        [DisplayName("入荷状態")]
        public bool _ArStateFlag
        {
            get { return ArStateFlag != 0; }
            set {; }
        }
        public int ArFlag { get; set; } //入荷管理フラグ
        [NotMapped]
        [DisplayName("入荷管理")]
        public bool _ArFlag
        {
            get { return ArFlag != 0; }
            set {; }
        }
        [DisplayName("非表示理由")]
        public String ArHidden { get; set; }        //非表示理由	
    }
}

