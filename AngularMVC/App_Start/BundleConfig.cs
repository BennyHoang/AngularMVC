using System.Web;
using System.Web.Optimization;

namespace AngularMVC
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/AngularApp")
           .IncludeDirectory("~/Scripts/Controllers", "*.js")
           .IncludeDirectory("~/Scripts/Factories", "*.js")
           .Include("~/Scripts/AngularMVCApp.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/site.css"));

            BundleTable.EnableOptimizations = true;
           
        }
    }
}
