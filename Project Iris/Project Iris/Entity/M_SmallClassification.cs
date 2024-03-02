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
    class M_SmallClassification
    {
        [Key]
        public int ScID { get; set; }           //小分類ID		
        public int McID { get; set; }           //大分類ID
        [MaxLength(50)]
        [Required]
        public String ScName { get; set; }      //小分類名		
        public int ScFlag { get; set; }         //小分類管理フラグ
        public String ScHidden { get; set; }	//非表示理由		

    }
    class M_SmallClassificationDsp
    {
        [DisplayName("小分類ID")]
        public int ScID { get; set; }
        [DisplayName("小分類名")]
        public String ScName { get; set; }
    }
    class M_SmallClassificationDspHidden
    {
        [DisplayName("小分類ID")]
        public int ScID { get; set; }
        [DisplayName("小分類名")]
        public String ScName { get; set; }
        public int ScFlag { get; set; }
        public String ScHidden { get; set; }
    }
    class M_SmallClassificationCombo
    {
        public String Display { get; set; }
        public String Value { get; set; }
    }
}
