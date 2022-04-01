using System.Web.Mvc;

namespace ERP_SOLUTION.Areas.pgd
{
    public class pgdAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "pgd";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "pgd_default",
                "pgd/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}