#pragma checksum "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\School\EQ.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffff7c82a578ad768caf1a98367169220aeb2a51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ayush.Pages.School.Pages_School_EQ), @"mvc.1.0.razor-page", @"/Pages/School/EQ.cshtml")]
namespace ayush.Pages.School
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
#line 1 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\_ViewImports.cshtml"
using ayush;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffff7c82a578ad768caf1a98367169220aeb2a51", @"/Pages/School/EQ.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30a319bf93157485e6034cff29d85f12084656cc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_School_EQ : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Chart.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-app border border-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "EQTable", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\School\EQ.cshtml"
  
    ViewData["Title"] = "EQ";
    Layout = "~/Pages/Shared/_SchoolLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffff7c82a578ad768caf1a98367169220aeb2a514285", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral(@"

<section class=""content-header"">
    <div class=""container-fluid"">
        <div class=""row mb-2"">
            <div class=""col-sm-6"">
                <h5 class=""text-uppercase"">EQ</h5>
            </div>
            <div class=""col-sm-6"">
                <ol class=""breadcrumb float-sm-right"">

                    <li>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffff7c82a578ad768caf1a98367169220aeb2a515727", async() => {
                WriteLiteral("\r\n                            <i class=\"fas fa-database\"></i>Table\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </li>

                </ol>
            </div>
        </div>
    </div>
</section>

<section class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">


            <div class=""col-md-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">My School</h3>
                    </div>

                    <div class=""card-body"">
                        <div class=""row"">
                            <div class=""col-md-6"" style=""min-height:250px;"">
                                <canvas id=""myChart""></canvas>
                            </div>
                            <div class=""col-md-6"">
                                <h5 class=""text-uppercase ml-4"">Implication</h5>
                                <ul>
                                    <li><b>Intrinsic: </b>workshop description will be written here.. only few line of description..</li>
                         ");
            WriteLiteral(@"           <li><b>Extrinsic: </b>workshop description will be written here.. only few line of description..</li>
                                    <li><b>Overall: </b>workshop description will be written here.. only few line of description..</li>
                                </ul>
                            </div>

                        </div>
                    </div>

                </div>

            </div>


            <div class=""col-md-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">My Class</h3>
                    </div>
                    <div class=""row p-3"">
                        <div class=""col-md-4"">
                            <div class=""card"">
                                <div class=""card-header"">
                                    <h3 class=""card-title"">Intrinsic</h3>
                                </div>
                                <div class=""card-body"" style=");
            WriteLiteral(@"""height:300px;"">
                                    <canvas id=""Graph_Intrinsic""></canvas>
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <div class=""card"">
                                <div class=""card-header"">
                                    <h3 class=""card-title"">Extrinsic</h3>
                                </div>
                                <div class=""card-body"" style=""height:300px;"">
                                    <canvas id=""Graph_Extrinsic""></canvas>
                                </div>
                            </div>
                        </div>

                        <div class=""col-md-4"">
                            <div class=""card"">
                                <div class=""card-header"">
                                    <h3 class=""card-title"">Overall</h3>
                                </div>
                   ");
            WriteLiteral(@"             <div class=""card-body"" style=""height:300px;"">
                                    <canvas id=""Graph_Overall""></canvas>
                                </div>
                            </div>
                        </div>





                    </div>

                </div>

            </div>

        </div>

    </div>

</section>


");
            DefineSection("JavaScript", async() => {
                WriteLiteral("\r\n\r\n");
                WriteLiteral(@"   
    <script>
        var graph_six = document.getElementById(""myChart"").getContext(""2d"");

        var graph_six_Data = {
            labels: [


                ""Intrinsic"",
                ""Extrinsic"",
                ""Overall"",
               



            ],
            datasets: [
                {
                    label: ""Result"",
                    data: [5, 3, 7],
                    backgroundColor: [""#947aa3"", ""#88a4c2"", ""#a9bf9b""],
                    hoverBackgroundColor: [""#66A2EB"", ""#66A2EB"", ""#66A2EB""]
                }]
        };

        var graph_three_Chart = new Chart(graph_six, {
            type: 'horizontalBar',
            data: graph_six_Data,
            options: {
                responsive: true,
                maintainAspectRatio: false,
                legend: {
                    display: false
                },
                scales: {

                    xAxes: [{

                        ticks: {
                         ");
                WriteLiteral(@"   min: 0,
                            max: 10,
                            diplay: false
                        },
                        gridLines: {
                            display: false
                        }

                    }],
                    yAxes: [{
                        ticks: {
                            min: 0,
                            max: 10,
                            diplay: false
                        },
                        stacked: true,
                        gridLines: {
                            display: false
                        }
                    }]
                }
            }
        });
    </script>
   
<script>
   

    Chart.pluginService.register({
        afterDraw: function (chart) {
            if (typeof chart.config.options.lineAt != 'undefined') {
                var lineAt = chart.config.options.lineAt;
                var ctxPlugin = chart.chart.ctx;
                var xAxe = chart.scales[chart");
                WriteLiteral(@".config.options.scales.xAxes[0].id];
                var yAxe = chart.scales[chart.config.options.scales.yAxes[0].id];

                // I'm not good at maths
                // So I couldn't find a way to make it work ...
                // ... without having the `min` property set to 0
                if (yAxe.min != 0) return;

                ctxPlugin.setLineDash([5, 10]);

                ctxPlugin.strokeStyle = ""silver"";
                ctxPlugin.beginPath();
                lineAt = (lineAt - yAxe.min) * (100 / yAxe.max);
                lineAt = (100 - lineAt) / 100 * (yAxe.height) + yAxe.top;
                ctxPlugin.moveTo(xAxe.left, lineAt);
                ctxPlugin.lineTo(xAxe.right, lineAt);
                ctxPlugin.stroke();
            }
        }
    });


");
                WriteLiteral(@"    var ctx = document.getElementById(""Graph_Intrinsic"");
    var myChart = new Chart(ctx, {
        type: 'bar',
        data: {
            labels: [""8th"",""9th"",""10th"",""11th"",""12th""],
            datasets: [
                {
                    label: ""Result"",
                    data: [1, 2, 3, 4, 8],
                    backgroundColor: [""#947aa3"", ""#88a4c2"", ""#a9bf9b"", ""#e09fd6"", ""#e65f1c""],
                    hoverBackgroundColor: [""#66A2EB"", ""#66A2EB"", ""#66A2EB"", ""#66A2EB"", ""#66A2EB""]
                }]
        },
        options: {
            responsive: true,
            maintainAspectRatio: false,
            legend: {
                display: false
            },

            lineAt: 8,
            scales: {

                xAxes: [{

                    ticks: {
                        min: 0,
                        max: 10,
                        diplay: false
                    },
                    gridLines: {
                        display: false
    ");
                WriteLiteral(@"                }

                }],
                yAxes: [{
                    ticks: {
                        min: 0,
                        max: 10,
                        diplay: false
                    },
                    stacked: true,
                    gridLines: {
                        display: false
                    }
                }]
            }
        }
    });


");
                WriteLiteral(@"    var ctx2 = document.getElementById(""Graph_Extrinsic"");
    var myChart2 = new Chart(ctx2, {
        type: 'bar',
        data: {
            labels: [""8th"", ""9th"", ""10th"", ""11th"", ""12th""],
            datasets: [
                {
                    label: ""Result"",
                    data: [1, 2, 3, 4, 8],
                    backgroundColor: [""#947aa3"", ""#88a4c2"", ""#a9bf9b"", ""#e09fd6"", ""#e65f1c""],
                    hoverBackgroundColor: [""#66A2EB"", ""#66A2EB"", ""#66A2EB"", ""#66A2EB"", ""#66A2EB""]
                }]
        },
        options: {
            responsive: true,
            maintainAspectRatio: false,
            legend: {
                display: false
            },

            lineAt: 5,
            scales: {

                xAxes: [{

                    ticks: {
                        min: 0,
                        max: 10,
                        diplay: false
                    },
                    gridLines: {
                        display: fals");
                WriteLiteral(@"e
                    }

                }],
                yAxes: [{
                    ticks: {
                        min: 0,
                        max: 10,
                        diplay: false
                    },
                    stacked: true,
                    gridLines: {
                        display: false
                    }
                }]
            }
        }
    });
");
                WriteLiteral(@"    var ctx3 = document.getElementById(""Graph_Overall"");
    var myChart3 = new Chart(ctx3, {
        type: 'bar',
        data: {
            labels: [""8th"", ""9th"", ""10th"", ""11th"", ""12th""],
            datasets: [
                {
                    label: ""Result"",
                    data: [1, 2, 3, 4, 8],
                    backgroundColor: [""#947aa3"", ""#88a4c2"", ""#a9bf9b"", ""#e09fd6"", ""#e65f1c""],
                    hoverBackgroundColor: [""#66A2EB"", ""#66A2EB"", ""#66A2EB"", ""#66A2EB"", ""#66A2EB""]
                }]
        },
        options: {
            responsive: true,
            maintainAspectRatio: false,
            legend: {
                display: false
            },

            lineAt: 6,
            scales: {

                xAxes: [{

                    ticks: {
                        min: 0,
                        max: 10,
                        diplay: false
                    },
                    gridLines: {
                        display: false");
                WriteLiteral(@"
                    }

                }],
                yAxes: [{
                    ticks: {
                        min: 0,
                        max: 10,
                        diplay: false
                    },
                    stacked: true,
                    gridLines: {
                        display: false
                    }
                }]
            }
        }
    });
</script>


   
");
                WriteLiteral("\r\n   \r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ayush.EQmodel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ayush.EQmodel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ayush.EQmodel>)PageContext?.ViewData;
        public ayush.EQmodel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
