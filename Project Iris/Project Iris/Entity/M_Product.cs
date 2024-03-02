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
    class M_Product
    {
        [Key]
        [Column("PrID",TypeName = "int")]
        [DisplayName("商品ID")]
        public int PrID { get; set; }               //商品ID		
        [Column("MaID", TypeName = "int")]
        [DisplayName("メーカID")]
        public int MaID { get; set; }               //メーカID	
        [MaxLength(50)]
        [Required]
        [Column("PrName", TypeName = "nvarchar")]
        [DisplayName("商品名")]
        public String PrName { get; set; }           //商品名
        [Column("Price", TypeName = "int")]
        [DisplayName("価格")]
        public int Price { get; set; }              //価格	
        [MaxLength(13)]
        [Column("PrJCode", TypeName = "nvarchar")]
        [DisplayName("JANコード")]
        public String PrJCode { get; set; }         //JANコード
        [Column("PrSafetyStock", TypeName = "int")]
        [DisplayName("安全在庫数")]
        public int PrSafetyStock { get; set; }      //安全在庫数	
        [Column("ScID", TypeName = "int")]
        [DisplayName("小分類ID")]
        public int ScID { get; set; }               //小分類ID	                                                
        [MaxLength(20)]
        [Required]
        [Column("PrModelNumber", TypeName = "nvarchar")]
        [DisplayName("型番")]
        public String PrModelNumber { get; set; }      //型番
        [MaxLength(20)]
        [Required]
        [Column("PrColor", TypeName = "nvarchar")]
        [DisplayName("色")]
        public String PrColor { get; set; }         //色	
        [Column("PrReleaseDate")]
        [DisplayName("発売日")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime PrReleaseDate { get; set; } //発売日	
        public int PrFlag { get; set; }             //商品管理フラグ
        [NotMapped]
        [Column("PrFlag", TypeName = "int")]
        [DisplayName("商品管理")]
        public bool _PrFlag
        { get { return PrFlag != 0; } set {; } }
        [Column("PrHidden", TypeName = "nvarchar")]
        [DisplayName("非表示理由")]
        public String PrHidden { get; set; }	    //非表示理由		
    }
    class M_ProductDsp
    {
        [DisplayName("商品ID")]
        public int PrID { get; set; }                                   //0
        public int MaID { get; set; }                                 //1
        [DisplayName("メーカ名")]
        public String MaName { get; set; }                      //2
        [DisplayName("商品名")]
        public String PrName { get; set; }                       //3
        [DisplayName("価格")]                                 
        public int Price { get; set; }                                 //4
        [DisplayName("JANコード")]
        public String PrJCode { get; set; }                      //5
        [DisplayName("安全在庫数")]
        public int PrSafetyStock { get; set; }                  //6
        public int ScID { get; set; }                                  //7
        [DisplayName("小分類名")]
        public String ScName { get; set; }                       //8
        [DisplayName("型番")]
        public String PrModelNumber { get; set; }          //9
        [DisplayName("色")]
        public String PrColor { get; set; }                       //10 
        [DisplayName("発売日")]
        public DateTime PrReleaseDate { get; set; }     //11
    }
    class M_ProductDspHidden
    {
        [DisplayName("商品ID")]
        public int PrID { get; set; }                                   //0
        public int MaID { get; set; }                                 //1
        [DisplayName("メーカ名")]
        public String MaName { get; set; }                      //2
        [DisplayName("商品名")]
        public String PrName { get; set; }                       //3
        [DisplayName("価格")]
        public int Price { get; set; }                                 //4
        [DisplayName("JANコード")]
        public String PrJCode { get; set; }                      //5
        [DisplayName("安全在庫数")]
        public int PrSafetyStock { get; set; }                  //6
        public int ScID { get; set; }                                  //7
        [DisplayName("小分類名")]
        public String ScName { get; set; }                       //8
        [DisplayName("型番")]
        public String PrModelNumber { get; set; }          //9
        [DisplayName("色")]
        public String PrColor { get; set; }                       //10 
        [DisplayName("発売日")]
        public DateTime PrReleaseDate { get; set; }     //11
        public int PrFlag { get; set; }                              //12
        [NotMapped]
        [DisplayName("商品管理")]
        public bool _PrFlag                                              //13
        { get { return PrFlag != 0; } set {; } }
        [DisplayName("非表示理由")]
        public String PrHidden { get; set; }                    //14
    }
    class M_ProductForOrder
    {
        [DisplayName("商品ID")]
        public int PrID { get; set; }
        [DisplayName("メーカ名")]
        public String MaName { get; set; }
        [DisplayName("商品名")]
        public String PrName { get; set; }
        [DisplayName("価格")]
        public int Price { get; set; }
    }
}
