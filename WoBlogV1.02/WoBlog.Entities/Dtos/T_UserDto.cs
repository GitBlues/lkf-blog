using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoBlog.Entities.Dtos
{
   public class T_UserDto
    {
       
        public int ID { get; set; }
        public string U_UserName { get; set; }
        public string U_PassWord { get; set; }
        public string U_NickName { get; set; }
        public string U_Sex { get; set; }
        public string U_PasswordSalt { get; set; }
        public int? U_Age { get; set; }
        public string G_Note { get; set; }
        public System.DateTime G_InputDate { get; set; }
        public string G_InputPerson { get; set; }
    }
}
