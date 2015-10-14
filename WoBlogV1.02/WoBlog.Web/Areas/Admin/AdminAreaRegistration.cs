using System.Web.Mvc;
using WoBlog.Web.Mvc.Routing;

namespace WoBlog.Web.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapLowerCaseUrlRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new string[] { "WoBlog.Web.Areas.Admin.Controllers", "WoBlog.Web.Areas.Admin.Controllers.Identity" }
            );
        }
    }
}