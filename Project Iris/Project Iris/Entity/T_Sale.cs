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
    class T_Sale
    {
        [Key]
        [Column("SaID",TypeName = "int",Order = 0)]
        [DisplayName("売上ID")]
        public int SaID { get; set; }           //売上ID	

        [Column("ClID",TypeName = "int", Order = 1)]
        [DisplayName("顧客ID")]
        public int ClID { get; set; }           //顧客ID	

        [Column("SoID", TypeName = "int", Order = 2)]
        [DisplayName("営業所ID")]
        public int SoID { get; set; }           //営業所ID	

        [Column("EmID",TypeName ="int",Order = 3)]
        [DisplayName("受注社員ID")]
        public int EmID { get; set; }           //受注社員ID	

        [Column("ChID",TypeName = "int", Order = 4)]
        [DisplayName("受注ID")]
        public int OrID { get; set; }           //受注ID


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [Column("SaDate",Order = 5)]
        [DisplayName("売上日時")]
        public DateTime SaDate { get; set; }    //売上日時

        [Column("SaFlag",TypeName = "int", Order = 6)]
        public int SaFlag { get; set; }	        //売上管理フラグ	

        [Column("SaHidden", TypeName = "nvarchar", Order = 7)]
        [DisplayName("非表示理由")]
        public String SaHidden { get; set; }    //非表示理由	
    }
    class T_SaleDsp
    {
        [DisplayName("売上ID")]
        public int SaID { get; set; }
        public int ClID { get; set; }
        [DisplayName("顧客名")]
        public String ClName { get; set; }
        public int SoID { get; set; }
        [DisplayName("営業所名")]
        public String SoName { get; set; }
        public int EmID { get; set; }
        [DisplayName("受注社員名")]
        public String EmName { get; set; }
        [DisplayName("注文ID")]
        public int OrID { get; set; }
        [DisplayName("売上日時")]
        public DateTime SaDate { get; set; }
    }
}
