using System.Web.Mvc;

namespace ERP_SOLUTION.Areas.nce
{
    public class nceAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "nce";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "nce_default",
                "nce/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}