﻿using IkeCode.Web.Core.Mvc;
using System.Web.Optimization;

namespace IkeCode.Clinike.Backend
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            var jsBundles = new ScriptBundle("~/jsBundles/js");
            jsBundles.Orderer = new AsDefinedBundleOrderer();
            //jsBundles.Include("~/Scripts");
            jsBundles.Include("~/Scripts/bootstrap.min.js");
            jsBundles.Include("~/Scripts/moment.min.js");
            jsBundles.Include("~/Scripts/moment-with-locales.min.js");
            
            jsBundles.IncludeDirectory("~/Scripts/plugins", "*.js", false);
            jsBundles.IncludeDirectory("~/Scripts/bootstrap-table.i18n", "*.js");

            jsBundles.Include("~/Scripts/knockout-3.4.0.js");
            jsBundles.Include("~/Scripts/knockout.mapping-latest.js");
            jsBundles.Include("~/Scripts/knockout.reactor.js");
            jsBundles.Include("~/Scripts/knockout.validation.js");
            jsBundles.IncludeDirectory("~/Scripts/knockout.validation.localization", "*.js");
            
            jsBundles.Include("~/Scripts/pixel-admin.js");

            jsBundles.Include("~/Scripts/clinike.prototype.utils.js");
            jsBundles.Include("~/Scripts/ClinikeModels.js");
            jsBundles.Include("~/Scripts/ViewModels/Clinike.Base.js");
            jsBundles.Include("~/Scripts/clinike.js");
            jsBundles.Include("~/Scripts/clinike.log.js");
            jsBundles.Include("~/Scripts/clinike.apiBaseUrls.js");
            jsBundles.Include("~/Scripts/clinike.ajax.js");

            jsBundles.IncludeDirectory("~/Scripts/ViewModels", "*.js", true);
            bundles.Add(jsBundles);

            var styleBundle = new IkeCodeStyleBundle("~/cssBundles/styles");
            styleBundle.Orderer = new AsDefinedBundleOrderer();
            //styleBundle.Include("~/Content/Css", new CssRewriteUrlTransform());
            styleBundle.Include("~/Content/Css/bootstrap.css", new CssRewriteUrlTransform());
            styleBundle.Include("~/Content/Css/pixel-admin.css", new CssRewriteUrlTransform());
            styleBundle.Include("~/Content/Css/widgets.min.css", new CssRewriteUrlTransform());
            styleBundle.Include("~/Content/Css/rtl.css", new CssRewriteUrlTransform());
            styleBundle.Include("~/Content/Css/themes.css", new CssRewriteUrlTransform());
            styleBundle.Include("~/Content/Css/bootstrap-table.css", new CssRewriteUrlTransform());
            styleBundle.Include("~/Content/Css/bootstrap-switch.css", new CssRewriteUrlTransform());
            styleBundle.Include("~/Content/Css/sweetalert.css", new CssRewriteUrlTransform());
            styleBundle.Include("~/Content/Css/clinike.css", new CssRewriteUrlTransform());
            bundles.Add(styleBundle);
        }
    }
}
