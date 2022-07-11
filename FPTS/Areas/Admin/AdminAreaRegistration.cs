using System.Web.Mvc;

namespace FPTS.Areas.Admin
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
            context.MapRoute(
                "Admin",
                "{controller}/{action}/{id}",
                new {action = "Index", controller = "Admin", id = UrlParameter.Optional }
            );
        }
    }
}