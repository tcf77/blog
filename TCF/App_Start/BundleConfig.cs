using System.Web.Optimization;

namespace TCF
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/styles").Include(
                "~/Content/bootstrap.css",
                "~/Content/Styles/site.css"));

            bundles.Add(new StyleBundle("~/admin/styles").Include(
                "~/Content/bootstrap.css",
                "~/Content/Styles/admin.css"));

            bundles.Add(new ScriptBundle("~/admin/scripts")
                .Include("~/scripts/jquery-{version}.js")
                .Include("~/scripts/jquery.validate*")
                .Include("~/scripts/bootstrap.js")
                .Include("~/areas/admin/scripts/forms.js"));

            bundles.Add(new ScriptBundle("~/admin/post/scripts")
                .Include("~/areas/admin/scripts/posteditor.js"));

            bundles.Add(new ScriptBundle("~/scripts")
                .Include("~/scripts/jquery-{version}.js")
                .Include("~/scripts/jquery.timeago.js")
                .Include("~/scripts/jquery.validate*")
                .Include("~/scripts/bootstrap.js")
                .Include("~/scripts/Frontend.js"));
        }
    }
}