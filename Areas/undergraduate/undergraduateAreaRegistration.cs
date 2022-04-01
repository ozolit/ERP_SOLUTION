using System.Web.Mvc;

namespace ERP_SOLUTION.Areas.undergraduate
{
    public class undergraduateAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "undergraduate";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "undergraduate_default",
                "undergraduate/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}