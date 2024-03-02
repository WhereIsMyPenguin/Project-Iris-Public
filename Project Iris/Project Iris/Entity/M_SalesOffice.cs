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
    class M_SalesOffice
    {
        [Key]
        [Column("SoID", TypeName = "int", Order = 0)]
        [DisplayName("営業所ID")]
        public int SoID { get; set; }           //営業所ID

        [MaxLength(50)]
        [Required]
        [Column("SoName", TypeName = "nvarchar", Order = 1)]
        [DisplayName("営業所名")]
        public String SoName { get; set; }      //営業所名
                                                
        [MaxLength(50)]
        [Required]
        [Column("SoAddress", TypeName = "nvarchar", Order = 2)]
        [DisplayName("住所")]
        public String SoAddress { get; set; }   //住所 

        [MaxLength(13)]
        [Required]
        [Column("SoPhone", TypeName = "nvarchar", Order = 3)]
        [DisplayName("電話番号")]
        public String SoPhone { get; set; }     //電話番号 

        [MaxLength(7)]
        [Required]
        [Column("SoPostal", TypeName = "nvarchar", Order = 4)]
        [DisplayName("郵便番号")]
        public String SoPostal { get; set; }    //郵便番号	

        [MaxLength(13)]
        [Required]
        [Column("SoFAX", TypeName = "nvarchar", Order = 5)]
        [DisplayName("FAX")]
        public String SoFAX { get; set; }       //FAX		

        [Column("SoFlag", TypeName = "int", Order = 6)]
        [DisplayName("営業所管理")]
        public int SoFlag { get; set; }         //営業所管理フラグ	 
        [Column("SoHidden", TypeName = "nvarchar", Order = 7)]
        [DisplayName("非表示理由")]
        public String SoHidden { get; set; }    //非表示理由		
    }
    class M_SalesOfficeDsp
    {
        [DisplayName("営業所ID")]
        public int SoID { get; set; }
        [DisplayName("営業所名")]
        public String SoName { get; set; }
        [DisplayName("住所")]
        public String SoAddress { get; set; }
        [DisplayName("電話番号")]
        public String SoPhone { get; set; }
        [DisplayName("郵便番号")]
        public String SoPostal { get; set; }
        [DisplayName("FAX")]
        public String SoFAX { get; set; }
    }
    class M_SalesOfficeDspHidden
    {
        [DisplayName("営業所ID")]
        public int SoID { get; set; }
        [DisplayName("営業所名")]
        public String SoName { get; set; }
        [DisplayName("住所")]
        public String SoAddress { get; set; }
        [DisplayName("電話番号")]
        public String SoPhone { get; set; }
        [DisplayName("郵便番号")]
        public String SoPostal { get; set; }
        [DisplayName("FAX")]
        public String SoFAX { get; set; }
        public int SoFlag { get; set; }
        [NotMapped]
        [DisplayName("営業所管理")]
        public bool _SoFlag
        {
            get { return SoFlag != 0; }
            set {; }
        }

        [DisplayName("非表示理由")]
        public String SoHidden { get; set; }	
    }
    class M_SalesOfficeCombo
    {
        public String Display { get; set; }
        public String Value { get; set; }
    }
}
