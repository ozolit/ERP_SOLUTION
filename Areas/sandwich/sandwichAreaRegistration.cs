using System.Web.Mvc;

namespace ERP_SOLUTION.Areas.sandwich
{
    public class sandwichAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "sandwich";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "sandwich_default",
                "sandwich/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}