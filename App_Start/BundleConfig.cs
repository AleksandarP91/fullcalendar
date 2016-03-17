using System.Web;
using System.Web.Optimization;

namespace fullcalendar
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/schedulercss").Include(
                    //"~/Content/themes/jquery.ui.all.css",
                    "~/Content/fullcalendar.css",
                    "~/Content/scheduler.css"));
                    //"~/Content/events.json",
                    //"~/Content/resources.json"
                    

            bundles.Add(new ScriptBundle("~/bundles/schedulerjs").Include(
                    "~/Scripts/Moment.js",
                "~/Scripts/jquery.js",
                    "~/Scripts/fullcalendar.js",
                    "~/Scripts/scheduler.js"));
                        


             

          
        }
    }
}
