using System;
using System.Collections.Generic;

namespace WoBlog.Entities.Models
{
    public partial class T_BlogCategory
    {
        public int ID { get; set; }
        public string Categoty_Name { get; set; }
        public int Categoty_ParentID { get; set; }
        public int Categoty_State { get; set; }
        public int Categoty_SortID { get; set; }
        public int Categoty_ArticleCount { get; set; }
        public System.DateTime Categoty_CreateTime { get; set; }
        public string G_Note { get; set; }
        public System.DateTime G_InputDate { get; set; }
        public string G_InputPerson { get; set; }
    }
}
