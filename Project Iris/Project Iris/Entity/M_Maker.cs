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
    class M_Maker
    {
        [Key]
        [Column("MaID", TypeName = "int", Order = 0)]
        [DisplayName("メーカID")]
        public int MaID { get; set; }

        [MaxLength(50)]
        [Required]
        [Column("MaName", TypeName = "nvarchar", Order = 1)]
        [DisplayName("メーカ名")]
        public String MaName { get; set; }      //メーカ名

        [MaxLength(50)]
        [Required]
        [Column("MaAdress", TypeName = "nvarchar", Order = 2)]
        [DisplayName("住所")]
        public String MaAdress { get; set; }    //住所

        [MaxLength(13)]
        [Required]
        [Column("MaPhone", TypeName = "nvarchar", Order = 3)]
        [DisplayName("電話番号")]
        public String MaPhone { get; set; }     //電話番号

        [MaxLength(7)]
        [Required]
        [Column("MaPostal", TypeName = "nvarchar", Order = 4)]
        [DisplayName("郵便番号")]
        public String MaPostal { get; set; }    //郵便番号

        [MaxLength(13)]
        [Required]
        [Column("MaFAX", TypeName = "nvarchar", Order = 5)]
        [DisplayName("FAX")]
        public String MaFAX { get; set; }       //FAX	
        [Column("MaFlag", TypeName = "int", Order = 6)]
        [DisplayName("メーカ管理")]                                        //	
        public int MaFlag { get; set; }         //メーカ管理フラグ

        [Column("MaHidden", TypeName = "nvarchar", Order = 7)]
        [DisplayName("非表示理由")]
        public String MaHidden { get; set; }	//非表示理由		

    }
    class M_MakerDsp
    {
        [DisplayName("メーカID")]
        public int MaID { get; set; }
        [DisplayName("メーカ名")]
        public String MaName { get; set; }
        [DisplayName("住所")]
        public String MaAdress { get; set; }
        [DisplayName("電話番号")]
        public String MaPhone { get; set; }
        [DisplayName("郵便番号")]
        public String MaPostal { get; set; }
        [DisplayName("FAX")]
        public String MaFAX { get; set; }
    }
    class M_MakerDspHidden
    {
        [DisplayName("メーカID")]
        public int MaID { get; set; }
        [DisplayName("メーカ名")]
        public String MaName { get; set; }
        [DisplayName("住所")]
        public String MaAdress { get; set; }
        [DisplayName("電話番号")]
        public String MaPhone { get; set; }
        [DisplayName("郵便番号")]
        public String MaPostal { get; set; }
        [DisplayName("FAX")]
        public String MaFAX { get; set; }
        public int MaFlag { get; set; }
        [NotMapped]
        [DisplayName("メーカ管理")]
        public bool _MaFlag
        {
            get { return MaFlag != 0; }
            set {; }
        }

        [DisplayName("非表示理由")]
        public String MaHidden { get; set; }

    }
    class M_MakerCombo
    {
        public String Display { get; set; }
        public String Value { get; set; }
    }
}
