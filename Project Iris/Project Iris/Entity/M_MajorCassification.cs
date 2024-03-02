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
    class M_MajorClassification
    {
        [Key]
        public int McID { get; set; }           //大分類ID
        [MaxLength(50)]
        [Required]
        public String McName { get; set; }      //大分類名		
        public int McFlag { get; set; }         //大分類管理フラグ
        public String McHidden { get; set; }	//非表示理由		

    }
    class M_MajorClassificationDsp
    {
        [DisplayName("大分類ID")]
        public int McID { get; set; }
        [DisplayName("大分類名")]
        public String McName { get; set; }
    }
    class M_MajorClassificationHiddenDsp
    {
        [DisplayName("大分類ID")]
        public int McID { get; set; }
        [DisplayName("大分類名")]
        public String McName { get; set; }
        public int McFlag { get; set; }
        public String McHidden { get; set; }
    }
    class M_MajorClassificationCombo
    {
        public String Display { get; set; }
        public String Value { get; set; }
    }
}
