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
    class M_Position
    { 

        [Key]
        public int PoID { get; set; }           //役職ID
        [MaxLength(50)]
        [Required]
        public String PoName { get; set; }      //役職名	
        public String Positions { get; set; }	//役職割り当て
        public int PoFlag { get; set; }         //役職管理フラグ
        public String PoHidden { get; set; }    //非表示理由		
 
    }
    class M_PositionDsp
    {
        [DisplayName("役職ID")]
        public int PoID { get; set; }
        [DisplayName("役職名")]
        public String PoName { get; set; }
    }
    class M_PositionCombo
    {
        public String Display { get; set; }
        public String Value { get; set; }
    }
}
