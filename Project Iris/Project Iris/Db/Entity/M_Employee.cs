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
    class M_Employee
    {
        [Key]
        
        [Column("EmID",TypeName = "int",Order = 0)]
        [DisplayName("社員ID")]
        public int EmID { get; set; }               //社員ID
        
        [Required]
        [Column("EmName",TypeName ="nvarchar",Order = 1)]
        [MaxLength(50)]
        [DisplayName("社員名")]
        public String EmName { get; set; }          //社員名	
                                                    
        [Column("SoID", TypeName = "int", Order = 2)]
        [DisplayName("営業所ID")]
        public int SoID { get; set; }               //営業所ID
                                                    
        [Column("PoID", TypeName = "int", Order = 3)]
        [DisplayName("役職ID")]
        public int PoID { get; set; }               //役職ID

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [Column(Order = 5)]
        [DisplayName("入社年月日")]
        public DateTime EmHiredate { get; set; }    //入社年月日

        [Required]
        [Column("EmPassword", TypeName = "nvarchar", Order = 6)]
        public String EmPassword { get; set; }      //パスワード

        [MaxLength(13)]
        [Required]
        [Column("EmPhone", TypeName = "nvarchar", Order = 7)]
        [DisplayName("電話番号")]
        public String EmPhone { get; set; }         //電話番号
                                                    //	
        //[MaxLength(13)]
        //[Required]
        // public String EmBarcode { get; set; }    //社員バーコード
        //
        [Column("EmFlag", TypeName = "int", Order = 8)]
        [DisplayName("社員管理")]
        public int EmFlag { get; set; }             //社員管理フラグ

        [Column("EmHidden",TypeName = "nvarchar", Order = 9)]
        [DisplayName("非表示理由")]
        public String EmHidden { get; set; }        //非表示理由
    }
    class M_EmployeeDsp
    {
        [DisplayName("社員ID")]
        public int EmID { get; set; }                               //0
        [DisplayName("社員名")]
        public String EmName { get; set; }                    //1
        public int SoID { get; set; }                               //2
        [DisplayName("営業所名")]
        public String SoName { get; set; }                   //3
        public int PoID { get; set; }                              //4
        [DisplayName("役職名")]
        public String PoName { get; set; }                  //5
        [DisplayName("入社年月日")]
        public DateTime EmHireDate { get; set; }     //6
        [DisplayName("電話番号")]
        public String EmPhone { get; set; }               //7
    }
    class M_EmployeeDspHidden
    {
        [DisplayName("社員ID")]               
        public int EmID { get; set; }                           //0
        [DisplayName("社員名")]
        public String EmName { get; set; }                //1
        public int SoID { get; set; }                           //2
        [DisplayName("営業所名")]
        public String SoName { get; set; }                //3
        public int PoID { get; set; }                           //4
        [DisplayName("役職名")]
        public String PoName { get; set; }                //5
        [DisplayName("入社年月日")]
        public DateTime EmHireDate { get; set; }    //6
        [DisplayName("電話番号")]
        public String EmPhone { get; set; }              //7
        public int EmFlag { get; set; }                      //8
        [NotMapped]
        [DisplayName("社員管理")]
        public bool _EmFlag                                     //9
        { get { return EmFlag != 0; } set { EmFlag = value ? 1 : 0; } }
        [DisplayName("非表示理由")]
        public String EmHidden { get; set; }          //10
    }
    class M_EmployeeCombo
    {
        public string Display { get; set; }
        public string Value { get; set; }
    }
}
