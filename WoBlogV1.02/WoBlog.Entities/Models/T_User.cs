using System;
using System.Collections.Generic;

namespace WoBlog.Entities.Models
{
    public partial class T_User
    {
        public int ID { get; set; }
        public string U_UserName { get; set; }
        public string U_PassWord { get; set; }
        public string U_NickName { get; set; }
        public string U_Sex { get; set; }
        public string U_PasswordSalt { get; set; }
        public Nullable<int> U_Age { get; set; }
        public string G_Note { get; set; }
        public System.DateTime G_InputDate { get; set; }
        public string G_InputPerson { get; set; }
    }
}
