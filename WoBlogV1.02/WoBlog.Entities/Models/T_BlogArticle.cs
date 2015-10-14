using System;

namespace WoBlog.Entities.Models
{
    public partial class T_BlogArticle
    {
        public int ID { get; set; }
        public string Article_Title { get; set; }
        public string Article_Content { get; set; }
        public string Article_Description { get; set; }
        public string Article_ImageUrl { get; set; }
        public string Article_Tag { get; set; }
        public int Article_Hits { get; set; }
        public bool Article_IsTop { get; set; }
        public int Article_State { get; set; }
        public Nullable<int> Article_UserID { get; set; }
        public string Article_UserName { get; set; }
        public string Article_UserIP { get; set; }
        public System.DateTime Article_PublishTime { get; set; }
        public System.DateTime Article_UpdateTime { get; set; }
        public int Article_Category_ID { get; set; }
        public string G_Note { get; set; }
        public System.DateTime G_InputDate { get; set; }
    }
}
