using System.Web.Mvc;

namespace ERP_SOLUTION.Areas.ict
{
    public class ictAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "ict";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "ict_default",
                "ict/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}