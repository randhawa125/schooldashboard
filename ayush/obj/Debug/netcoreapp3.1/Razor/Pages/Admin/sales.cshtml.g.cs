#pragma checksum "D:\freeeeeeeeee\ayush\Pages\Admin\sales.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e07446a5dd1cc5ab7f41ccc197425c8f80d40805"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ayush.Pages.Admin.Pages_Admin_sales), @"mvc.1.0.razor-page", @"/Pages/Admin/sales.cshtml")]
namespace ayush.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\freeeeeeeeee\ayush\Pages\_ViewImports.cshtml"
using ayush;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e07446a5dd1cc5ab7f41ccc197425c8f80d40805", @"/Pages/Admin/sales.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30a319bf93157485e6034cff29d85f12084656cc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_sales : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/ionicons.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Chart.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/demo.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\freeeeeeeeee\ayush\Pages\Admin\sales.cshtml"
  
	Layout = "~/Pages/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e07446a5dd1cc5ab7f41ccc197425c8f80d408054440", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("<section class=\"content-header\">\r\n\t<div class=\"container-fluid\">\r\n\t\t<div class=\"row mb-2\">\r\n");
            WriteLiteral(@"		</div>
	</div><!-- /.container-fluid -->
</section>

<!-- Main content -->
<section class=""content"">
	<div class=""container-fluid"">
		<div class=""card card-success"">
			<div class=""card-header"">
				<h3 class=""card-title"">Sales Chart</h3>

				<div class=""card-tools"">
					<button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"">
						<i class=""fas fa-minus""></i>
					</button>
					<button type=""button"" class=""btn btn-tool"" data-card-widget=""remove""><i class=""fas fa-times""></i></button>
				</div>
			</div>
			<div class=""card-body"">
				<div class=""chart"">
					<canvas id=""barChart"" style=""min-height: 250px; height: 250px; max-height: 250px; max-width: 100%;""></canvas>
				</div>
			</div>
		</div>
		<div class=""row"">
			<div class=""col-md-6"">
				<!-- AREA CHART -->
");
            WriteLiteral("\t\t\t\t<!-- /.card -->\r\n\t\t\t\t<!-- DONUT CHART -->\r\n");
            WriteLiteral("\t\t\t\t<!-- /.card -->\r\n\t\t\t\t<!-- PIE CHART -->\r\n");
            WriteLiteral("\t\t\t\t<!-- /.card -->\r\n\r\n\t\t\t</div>\r\n\t\t\t<!-- /.col (LEFT) -->\r\n\t\t\t<div class=\"col-md-6\">\r\n\t\t\t\t<!-- LINE CHART -->\r\n");
            WriteLiteral("\t\t\t\t<!-- /.card -->\r\n\t\t\t\t<!-- BAR CHART -->\r\n");
            WriteLiteral("\t\t\t\t<!-- /.card -->\r\n\t\t\t\t<!-- STACKED BAR CHART -->\r\n");
            WriteLiteral("\t\t\t\t<!-- /.card -->\r\n\r\n\t\t\t</div>\r\n\t\t\t<!-- /.col (RIGHT) -->\r\n\t\t</div>\r\n\t\t<!-- /.row -->\r\n\t</div><!-- /.container-fluid -->\r\n</section>\r\n\r\n\r\n");
            DefineSection("JavaScript", async() => {
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e07446a5dd1cc5ab7f41ccc197425c8f80d408057430", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t<!-- AdminLTE App -->\r\n\t<!-- AdminLTE for demo purposes -->\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e07446a5dd1cc5ab7f41ccc197425c8f80d408058595", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
	<!-- page script -->
	<script>
		$(function () {
			/* ChartJS
			 * -------
			 * Here we will create a few charts using ChartJS
			 */

			//--------------
			//- AREA CHART -
			//--------------

			// Get context with jQuery - using jQuery's .get() method.
			//var areaChartCanvas = $('#areaChart').get(0).getContext('2d')

			var areaChartData = {
				labels: [");
#nullable restore
#line 190 "D:\freeeeeeeeee\ayush\Pages\Admin\sales.cshtml"
                    Write(Html.Raw("'" + String.Join("','", (Model.PlanOneSales.Select(x => x.Month).ToList())) + "'"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"],
			    //labels: ['January', 'February', 'March', 'April', 'May', 'June', 'July'],
			    datasets: [
			        {
			            label: 'Plan 2',
			            backgroundColor: 'rgba(60,141,188,0.9)',
			            borderColor: 'rgba(60,141,188,0.8)',
			            pointRadius: false,
			            pointColor: '#3b8bba',
			            pointStrokeColor: 'rgba(60,141,188,1)',
			            pointHighlightFill: '#fff',
						pointHighlightStroke: 'rgba(60,141,188,1)',
						data: [");
#nullable restore
#line 202 "D:\freeeeeeeeee\ayush\Pages\Admin\sales.cshtml"
                          Write(Html.Raw("'" + String.Join("','", (Model.PlanTwoSales.Select(x => x.Sale).ToList())) + "'"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"],
			            //data: [28, 48, 40, 19, 86, 27, 90]
			        },
			        {
			            label: 'Plan 1',
			            backgroundColor: 'rgba(210, 123, 123, 1)',
			            borderColor: 'rgba(210, 123, 123, 1)',
			            pointRadius: false,
			            pointColor: 'rgba(210, 123, 123, 1)',
			            pointStrokeColor: '#c1c7d1',
			            pointHighlightFill: '#fff',
						pointHighlightStroke: 'rgba(220,123,123,1)',
						data: [");
#nullable restore
#line 214 "D:\freeeeeeeeee\ayush\Pages\Admin\sales.cshtml"
                          Write(Html.Raw("'" + String.Join("','", (Model.PlanOneSales.Select(x => x.Sale).ToList())) + "'"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"],
			            //data: [65, 59, 80, 81, 56, 55, 40]
			        },
			        {
			            label: 'Plan 3',
			            backgroundColor: 'rgba(210, 214, 222, 1)',
			            borderColor: 'rgba(210, 214, 222, 1)',
			            pointRadius: false,
			            pointColor: 'rgba(210, 214, 222, 1)',
			            pointStrokeColor: '#c1c7d1',
			            pointHighlightFill: '#fff',
			            pointHighlightStroke: 'rgba(220,220,220,1)',
						data: [");
#nullable restore
#line 226 "D:\freeeeeeeeee\ayush\Pages\Admin\sales.cshtml"
                          Write(Html.Raw("'" + String.Join("','", (Model.PlanThreeSales.Select(x => x.Sale).ToList())) + "'"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"],
			            //data: [65, 59, 80, 81, 56, 55, 40]
			        },
			    ]
			}

			//var areaChartData = {
			//	labels: ['Plan Sales'],
			//	datasets: [
			//		{
			//			label: 'Plan 1',
			//			backgroundColor: 'rgba(60,141,188,0.9)',
			//			borderColor: 'rgba(60,141,188,0.8)',
			//			pointRadius: false,
			//			pointColor: '#3b8bba',
			//			pointStrokeColor: 'rgba(60,141,188,1)',
			//			pointHighlightFill: '#fff',
			//			pointHighlightStroke: 'rgba(60,141,188,1)',
			//			data: [40]
			//		},
			//		{
			//			label: 'Plan 2',
			//			backgroundColor: 'rgba(210, 214, 222, 1)',
			//			borderColor: 'rgba(210, 214, 222, 1)',
			//			pointRadius: false,
			//			pointColor: 'rgba(210, 214, 222, 1)',
			//			pointStrokeColor: '#c1c7d1',
			//			pointHighlightFill: '#fff',
			//			pointHighlightStroke: 'rgba(220,220,220,1)',
			//			data: [20]
			//		},					
			//		{
			//			label: 'Plan 3',
			//			backgroundColor: 'rgba(210, 214, 123, 1)',
			//			borderColor: 'rgba(2");
                WriteLiteral(@"10, 214, 123, 1)',
			//			pointRadius: false,
			//			pointColor: 'rgba(210, 214, 123, 1)',
			//			pointStrokeColor: '#c1c7d1',
			//			pointHighlightFill: '#fff',
			//			pointHighlightStroke: 'rgba(220,220,123,1)',
			//			data: [30]
			//		}
			//	]
			//}

			//var areaChartOptions = {
			//    maintainAspectRatio: false,
			//    responsive: true,
			//    legend: {
			//        display: false
			//    },
			//    scales: {
			//        xAxes: [{
			//            gridLines: {
			//                display: false,
			//            }
			//        }],
			//        yAxes: [{
			//            gridLines: {
			//                display: false,
			//            }
			//        }]
			//    }
			//}

			//// This will get the first returned node in the jQuery collection.
			//var areaChart = new Chart(areaChartCanvas, {
			//    type: 'line',
			//    data: areaChartData,
			//    options: areaChartOptions
			//})

			////-------------
			////- LINE CHART -
			////----------");
                WriteLiteral(@"----
			//var lineChartCanvas = $('#lineChart').get(0).getContext('2d')
			//var lineChartOptions = jQuery.extend(true, {}, areaChartOptions)
			//var lineChartData = jQuery.extend(true, {}, areaChartData)
			//lineChartData.datasets[0].fill = false;
			//lineChartData.datasets[1].fill = false;
			//lineChartOptions.datasetFill = false

			//var lineChart = new Chart(lineChartCanvas, {
			//    type: 'line',
			//    data: lineChartData,
			//    options: lineChartOptions
			//})

			////-------------
			////- DONUT CHART -
			////-------------
			//// Get context with jQuery - using jQuery's .get() method.
			//var donutChartCanvas = $('#donutChart').get(0).getContext('2d')
			//var donutData = {
			//    labels: [
			//        'Chrome',
			//        'IE',
			//        'FireFox',
			//        'Safari',
			//        'Opera',
			//        'Navigator',
			//    ],
			//    datasets: [
			//        {
			//            data: [700, 500, 400, 600, 300, 100],
			//            background");
                WriteLiteral(@"Color: ['#f56954', '#00a65a', '#f39c12', '#00c0ef', '#3c8dbc', '#d2d6de'],
			//        }
			//    ]
			//}
			//var donutOptions = {
			//    maintainAspectRatio: false,
			//    responsive: true,
			//}
			////Create pie or douhnut chart
			//// You can switch between pie and douhnut using the method below.
			//var donutChart = new Chart(donutChartCanvas, {
			//    type: 'doughnut',
			//    data: donutData,
			//    options: donutOptions
			//})

			////-------------
			////- PIE CHART -
			////-------------
			//// Get context with jQuery - using jQuery's .get() method.
			//var pieChartCanvas = $('#pieChart').get(0).getContext('2d')
			//var pieData = donutData;
			//var pieOptions = {
			//    maintainAspectRatio: false,
			//    responsive: true,
			//}
			////Create pie or douhnut chart
			//// You can switch between pie and douhnut using the method below.
			//var pieChart = new Chart(pieChartCanvas, {
			//    type: 'pie',
			//    data: pieData,
			//    options: pi");
                WriteLiteral(@"eOptions
			//})

			//-------------
			//- BAR CHART -
			//-------------
			var barChartCanvas = $('#barChart').get(0).getContext('2d')
			var barChartData = jQuery.extend(true, {}, areaChartData)
			var temp0 = areaChartData.datasets[0]
			var temp1 = areaChartData.datasets[1]
			barChartData.datasets[0] = temp1
			barChartData.datasets[1] = temp0

			var barChartOptions = {
				responsive: true,
				maintainAspectRatio: false,
				datasetFill: false
			}

			var barChart = new Chart(barChartCanvas, {
				type: 'bar',
				data: barChartData,
				options: barChartOptions
			})

			////---------------------
			////- STACKED BAR CHART -
			////---------------------
			//var stackedBarChartCanvas = $('#stackedBarChart').get(0).getContext('2d')
			//var stackedBarChartData = jQuery.extend(true, {}, barChartData)

			//var stackedBarChartOptions = {
			//    responsive: true,
			//    maintainAspectRatio: false,
			//    scales: {
			//        xAxes: [{
			//            stacke");
                WriteLiteral(@"d: true,
			//        }],
			//        yAxes: [{
			//            stacked: true
			//        }]
			//    }
			//}

			//var stackedBarChart = new Chart(stackedBarChartCanvas, {
			//    type: 'bar',
			//    data: stackedBarChartData,
			//    options: stackedBarChartOptions
			//})
		})</script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ayush.Pages.Admin.salesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ayush.Pages.Admin.salesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ayush.Pages.Admin.salesModel>)PageContext?.ViewData;
        public ayush.Pages.Admin.salesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
