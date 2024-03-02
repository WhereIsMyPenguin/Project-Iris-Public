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
    class T_Chumon
    {
        [Key]
        public int ChID { get; set; }               //注文ID	
        public int SoID { get; set; }               //営業所ID	
        public int EmID { get; set; }               //社員ID	
        public int ClID { get; set; }               //顧客ID	
        public int OrID { get; set; }               //受注ID
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime? ChDate { get; set; }       //注文年月日
        public int? ChStateFlag { get; set; }    //注文状態フラグ
        public int ChFlag { get; set; }	//注文管理フラグ
        public String ChHidden { get; set; }        //非表示理由	


    }
    class T_ChumonDsp
    {
        [DisplayName("注文ID")]
        public int ChID { get; set; }               //注文ID
        public int SoID { get; set; }
        [DisplayName("営業所名")]           
        public String SoName { get; set; }               //営業所ID
        public int EmID { get; set; }
        [DisplayName("社員名")]
        public String EmName { get; set; }               //社員ID
        public int ClID { get; set; }
        [DisplayName("顧客名")]
        public String ClName { get; set; }               //顧客ID
        [DisplayName("受注ID")]
        public int OrID { get; set; }               //受注ID
        [DisplayName("注文年月日")]
        public DateTime? ChDate { get; set; }       //注文年月日
    }    
    class T_ChumonDspHidden
    {
        [DisplayName("注文ID")]
        public int ChID { get; set; }               //注文ID
        public int SoID { get; set; }
        [DisplayName("営業所名")]
        public String SoName { get; set; }               //営業所ID
        public int EmID { get; set; }
        [DisplayName("社員名")]
        public String EmName { get; set; }               //社員ID
        public int ClID { get; set; }
        [DisplayName("顧客名")]
        public String ClName { get; set; }               //顧客ID
        [DisplayName("受注ID")]
        public int OrID { get; set; }               //受注ID
        [DisplayName("注文年月日")]
        public DateTime? ChDate { get; set; }       //注文年月日
        public int? ChStateFlag { get; set; }    //注文状態フラグ
        [NotMapped]
        [DisplayName("出庫状態")]
        public bool _ChStateFlag
        {
            get { return ChStateFlag != 0; }
            set {; }
        }
        public int ChFlag { get; set; } //注文管理フラグ
        [NotMapped]
        [DisplayName("注文管理")]
        public bool _ChFlag
        {
            get { return ChFlag != 0; }
            set {; }
        }
        [DisplayName("非表示理由")]
        public String ChHidden { get; set; }        //非表示理由	
    }
    
}
