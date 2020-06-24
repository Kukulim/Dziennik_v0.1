using System.Web;
using System.Web.Optimization;

namespace Dziennik_v0._1
{
    public class BundleConfig
    {
        // Aby uzyskać więcej informacji o grupowaniu, odwiedź stronę https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Użyj wersji deweloperskiej biblioteki Modernizr do nauki i opracowywania rozwiązań. Następnie, kiedy wszystko będzie
            // gotowe do produkcji, użyj narzędzia do kompilowania ze strony https://modernizr.com, aby wybrać wyłącznie potrzebne testy.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap-slate.css",
                      "~/Content/Site.css"));

            bundles.Add(new StyleBundle("~/Content/fullcalendarcss").Include(
                      "~/Content/theames/base/jquery-ui.min.css",
                      "~/Content/fullcalendar.css"));

            bundles.Add(new ScriptBundle("~/bundles/fullcalendarjs").Include(
                      "~/Scripts/jquery-ui-{version}.js",
                      "~/Scripts/moment.min.js",
                      "~/Scripts/fullcalendar.min.js",
                      "~/Scripts/locale/pl.js"));

            bundles.Add(new ScriptBundle("~/bundles/highchartjs").Include(
                        "~/Scripts/highcharts/highcharts.js",
                        "~/Scripts/highcharts/modules/data.js",
                        "~/Scripts/highcharts/modules/series-label.js",
                        "~/Scripts/highcharts/modules/exporting.js",
                        "~/Scripts/highcharts/modules/export-data.js",
                        "~/Scripts/highcharts/modules/accessibility.js",
                        "~/Scripts/highcharts/themes/dark-unica.js"));

            bundles.Add(new ScriptBundle("~/bundles/highchartcss").Include(
                        "~/Scripts/highcharts/themes/dark-unica.js"));
        }
    }
}
