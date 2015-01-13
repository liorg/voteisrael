using BundleTransformer.Core.Bundles;
using BundleTransformer.Core.Orderers;
using BundleTransformer.Core.Transformers;
using System.Web.Optimization;

namespace ASP.NET_MVC5_Bootstrap3_3_1_LESS
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;
            var cssTransformer = new StyleTransformer();
            var jsTransformer = new ScriptTransformer();
            var nullOrderer = new NullOrderer();

            var cssBundle = new StyleBundle("~/bundles/css");
            cssBundle.Include("~/Content/Site.less", "~/Content/bootstrap/bootstrap.less");
            cssBundle.Transforms.Add(cssTransformer);
            cssBundle.Orderer = nullOrderer;
            bundles.Add(cssBundle);

            var cssRtlBundle = new StyleBundle("~/bundles/css-rtl");
            cssRtlBundle.Include("~/Content/Site.less", "~/Content/RTL-Bootstrap-Less/bootstrap.less");
           // cssRtlBundle.Include("~/Content/SiteBase.css","~/Content/css/bootstrap-rtl.css");
            cssRtlBundle.Transforms.Add(cssTransformer);
            cssRtlBundle.Orderer = nullOrderer;
            bundles.Add(cssRtlBundle);
           
            var jqueryBundle = new ScriptBundle("~/bundles/jquery");
          jqueryBundle.Include("~/Scripts/jquery-{version}.js");
          jqueryBundle.Transforms.Add(jsTransformer);
          jqueryBundle.Orderer = nullOrderer;
          bundles.Add(jqueryBundle);

          var jqueryvalBundle = new ScriptBundle("~/bundles/jqueryval");
          jqueryvalBundle.Include("~/Scripts/jquery.validate*");
          jqueryvalBundle.Transforms.Add(jsTransformer);
          jqueryvalBundle.Orderer = nullOrderer;
          bundles.Add(jqueryvalBundle);


          // Use the development version of Modernizr to develop with and learn from. Then, when you're
          // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.

          var modernizrBundle = new ScriptBundle("~/bundles/modernizr");
          modernizrBundle.Include("~/Scripts/modernizr-*");
          modernizrBundle.Transforms.Add(jsTransformer);
          modernizrBundle.Orderer = nullOrderer;
          bundles.Add(modernizrBundle);

          var bootstrapBundle = new ScriptBundle("~/bundles/bootstrap");
          bootstrapBundle.Include("~/Scripts/bootstrap.js", "~/Scripts/respond.js");
          bootstrapBundle.Transforms.Add(jsTransformer);
          bootstrapBundle.Orderer = nullOrderer;
          bundles.Add(bootstrapBundle);
         
          var bootstrapRtlBundle = new ScriptBundle("~/bundles/bootstrap-rtl");
          bootstrapRtlBundle.Include("~/Scripts/bootstrap-rtl.js", "~/Scripts/respond.js");
          bootstrapRtlBundle.Transforms.Add(jsTransformer);
          bootstrapRtlBundle.Orderer = nullOrderer;
          bundles.Add(bootstrapRtlBundle);
          
            var angularBundle = new ScriptBundle("~/bundles/angular");
            angularBundle.Include("~/Scripts/angular.min.js", "~/Scripts/Graph/ng-google-chart.js", "~/Scripts/angular-ui/ui-bootstrap.min.js", "~/Scripts/angular-ui/ui-bootstrap-tpls.min.js");
            angularBundle.Transforms.Add(jsTransformer);
            angularBundle.Orderer = nullOrderer;
            bundles.Add(angularBundle);


            var myBundle = new ScriptBundle("~/bundles/my");
            myBundle.Include("~/Scripts/my/GraphLoad.js");
            myBundle.Transforms.Add(jsTransformer);
            myBundle.Orderer = nullOrderer;
            bundles.Add(myBundle);

            var cssMyBundle = new StyleBundle("~/bundles/mycss");
            cssMyBundle.Include("~/Content/countdown/countdown.css", "~/Content/sharing/Sharing.css");
            cssMyBundle.Transforms.Add(cssTransformer);
            cssMyBundle.Orderer = nullOrderer;
            bundles.Add(cssMyBundle);
        }
    }
}