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
    class M_Client
    {
        [Key]
        [Column("ClID", TypeName = "int", Order = 0)]
        [DisplayName("顧客ID")]

        public int ClID { get; set; }           //顧客ID
        [Column("SoID", TypeName = "int", Order = 1)]
        [DisplayName("営業所ID")]                                        //		
        public int SoID { get; set; }           //営業所ID
        [MaxLength(50)]
        [Required]

        [Column("ClName", TypeName = "nvarchar", Order = 2)]
        [DisplayName("顧客名")]
        public String ClName { get; set; }      //顧客名
        [MaxLength(50)]
        [Required]

        [Column("ClAddress", TypeName = "nvarchar", Order = 3)]
        [DisplayName("住所")]
        public String ClAddress { get; set; }   //住所	 
        [MaxLength(13)]
        [Required]

        [Column("ClPhone", TypeName = "nvarchar", Order = 4)]
        [DisplayName("電話番号")]
        public String ClPhone { get; set; }     //電話番号	
        [MaxLength(7)]
        [Required]

        [Column("ClPostal", TypeName = "nvarchar", Order = 5)]
        [DisplayName("郵便番号")]
        public String ClPostal { get; set; }       //郵便番号
        [MaxLength(13)]
        [Required]

        [Column("ClFAX", TypeName = "nvarchar", Order = 6)]
        [DisplayName("FAX")]
        public String ClFAX { get; set; }       //FAX
                                                
        [Column("ClFlag", TypeName = "int", Order = 7)]
        [DisplayName("顧客管理フラグ")]
        public int ClFlag { get; set; }         //顧客管理フラグ

        [Column("ClHidden", TypeName = "nvarchar", Order = 8)]
        [DisplayName("非表示理由")]
        public String ClHidden { get; set; }	//非表示理由		

    }
    class M_ClientDsp
    {
        [DisplayName("顧客ID")]
        public int ClID { get; set; }
        public int SoID { get; set; }
        [DisplayName("営業所名")]
        public String SoName { get; set; }
        [DisplayName("顧客名")]
        public String ClName { get; set; }
        [DisplayName("住所")]
        public String ClAddress { get; set; }
        [DisplayName("電話番号")]
        public String ClPhone { get; set; }
        [DisplayName("郵便番号")]
        public String ClPostal { get; set; }
        [DisplayName("FAX")]
        public String ClFAX { get; set; }
    }
    class M_ClientDspHidden
    {
        [DisplayName("顧客ID")]
        public int ClID { get; set; }                   //0
        public int SoID { get; set; }                  //1
        [DisplayName("営業所名")]
        public String SoName { get; set; }       //2
        [DisplayName("顧客名")]
        public String ClName { get; set; }         //3
        [DisplayName("住所")]
        public String ClAddress { get; set; }   //4
        [DisplayName("電話番号")]
        public String ClPhone { get; set; }       //5
        [DisplayName("郵便番号")]
        public String ClPostal { get; set; }       //6
        [DisplayName("FAX")]
        public String ClFAX { get; set; }           //7
        public int ClFlag { get; set; }                 //8
        [NotMapped]
        [DisplayName("顧客管理フラグ")]
        public bool _ClFlag                                 //9
        {
            get { return ClFlag != 0; }
            set {; }
        }

        [DisplayName("非表示理由")]
        public String ClHidden { get; set; }        //10

    }
    class M_ClientCombo
    {
        public String Display { get; set; }
        public String Value { get; set; }
    }
}
