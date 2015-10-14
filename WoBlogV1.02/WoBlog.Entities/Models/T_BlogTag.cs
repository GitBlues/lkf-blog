using System;
using System.Collections.Generic;

namespace WoBlog.Entities.Models
{
    public partial class T_BlogTag
    {
        public int ID { get; set; }
        public string Tag_Name { get; set; }
        public int Tag_ParentID { get; set; }
        public int Tag_State { get; set; }
        public int Tag_SortID { get; set; }
        public int Tag_ArticleCount { get; set; }
        public string G_Note { get; set; }
        public System.DateTime G_InputDate { get; set; }
        public string G_InputPerson { get; set; }
    }
}
