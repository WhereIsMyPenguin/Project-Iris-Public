﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Project_Iris
{
    class T_Syukko
    {
        [Key]
        public int SyID { get; set; }               //出庫ID	
        public int EmID { get; set; }               //社員ID	
        public int ClID { get; set; }               //顧客ID	
        public int SoID { get; set; }               //営業所ID	
        public int OrID { get; set; }               //受注ID
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime? SyDate { get; set; }       //出庫年月日	
        public int? SyStateFlag { get; set; }    //出庫状態フラグ
        public int SyFlag { get; set; }	//出庫管理フラグ
        public String SyHidden { get; set; }	    //非表示理由	

    }
    class T_SyukkoDsp
    {
        [DisplayName("出庫ID")]
    　　public int SyID { get; set; }
        [DisplayName("社員名")]
        public String EmName { get; set; }
        [DisplayName("顧客名")]
        public String ClName { get; set; }
        [DisplayName("営業所名")]
        public String SoName { get; set; }
        [DisplayName("受注ID")]
        public int OrID { get; set; }
        [DisplayName("出庫年月日")]
        public DateTime? SyDate { get; set; }
    }
    class T_SyukkoDspHidden
    {
        [DisplayName("出庫ID")]
        public int SyID { get; set; }
        [DisplayName("社員名")]
        public String EmName { get; set; }
        [DisplayName("顧客名")]
        public String ClName { get; set; }
        [DisplayName("営業所名")]
        public String SoName { get; set; }
        [DisplayName("受注ID")]
        public int OrID { get; set; }
        [DisplayName("出庫年月日")]
        public DateTime? SyDate { get; set; }
        [DisplayName("出庫状態フラグ")]
        public int? SyStateFlag { get; set; }
        [DisplayName("出庫管理フラグ")]
        public int SyFlag { get; set; }
        [DisplayName("非表示化理由")]
        public string SyHidden { get; set; }
    }
}
