using System.Web;
using System.Web.Optimization;

namespace ERP_SOLUTION
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.js"));
            bundles.Add(new ScriptBundle("~/bundles/CommonFile").Include("~/Scripts/CommonFile.js"));
            bundles.Add(new ScriptBundle("~/bundles/_AdminLayout").Include("~/Areas/Admin/Script/_AdminLayout.js"));
            bundles.Add(new ScriptBundle("~/bundles/PersonType").Include("~/Areas/Common/Script/PersonType.js"));
            bundles.Add(new ScriptBundle("~/bundles/SchoolType").Include("~/Areas/Common/Script/SchoolType.js"));


            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/bootstrap.css", "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Content/_AdminLayout").Include("~/Areas/Admin/Content/_AdminLayout.css"));
            bundles.Add(new StyleBundle("~/Content/PersonType").Include("~/Areas/Common/Content/personType.css"));
        }
    }
}
