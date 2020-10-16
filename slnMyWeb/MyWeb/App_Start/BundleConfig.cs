using System.Web;
using System.Web.Optimization;

namespace MyWeb
{
    public class BundleConfig
    {
        // 如需統合的詳細資訊，請瀏覽 https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js", 
                        "~/Scripts/jquery.unobtrusive-ajax.js",
                        "~/Scripts/jquery-ui-1.12.1.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用開發版本的 Modernizr 進行開發並學習。然後，當您
            // 準備好可進行生產時，請使用 https://modernizr.com 的建置工具，只挑選您需要的測試。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/Bootstrap4_Dialog/js/bootstrap-dialog.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/Bootstrap4_Dialog/bootstrap-dialog.css",
                      "~/Content/themes/base/jquery-ui.min.css"));

            //KendoUI JS
            bundles.Add(new ScriptBundle("~/bundles/kendoJS").Include(
                     "~/Scripts/js/kendo.all.min.js"));
            //KendoUI CSS
            bundles.Add(new StyleBundle("~/Content/kendoCSS").Include(
                      //"~/Content/styles/kendo.common.min.css",
                      //"~/Content/styles/kendo.default.min.css",
                      "~/Content/styles/kendo.common-material.min.css",
                      "~/Content/styles/kendo.material.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/SharedJS").Include(
               "~/Scripts/Custom/SharedScript.js"));
        }
    }
}
