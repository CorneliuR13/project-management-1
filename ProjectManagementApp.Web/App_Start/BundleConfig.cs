using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace ProjectManagementApp.Web.App_Start
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/app/css").Include(
                "~/Content/assets/css/app.min.css", new CssRewriteUrlTransform()));
        }
    }
}