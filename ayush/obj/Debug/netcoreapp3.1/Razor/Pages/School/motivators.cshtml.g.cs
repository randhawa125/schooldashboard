#pragma checksum "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\School\motivators.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1aaddcf132d3e550fbedf3e1d4eb4e89353194f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ayush.Pages.School.Pages_School_motivators), @"mvc.1.0.razor-page", @"/Pages/School/motivators.cshtml")]
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
#line 1 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\_ViewImports.cshtml"
using ayush;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1aaddcf132d3e550fbedf3e1d4eb4e89353194f1", @"/Pages/School/motivators.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30a319bf93157485e6034cff29d85f12084656cc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_School_motivators : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Chart.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-app border border-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "MotivatorTable", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\School\motivators.cshtml"
  
    ViewData["Title"] = "Motivator";
    Layout = "~/Pages/Shared/_SchoolLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1aaddcf132d3e550fbedf3e1d4eb4e89353194f14359", async() => {
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
                <h5 class=""text-uppercase"">Motivator</h5>
            </div>
            <div class=""col-sm-6"">
                <ol class=""breadcrumb float-sm-right"">

                    <li>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1aaddcf132d3e550fbedf3e1d4eb4e89353194f15808", async() => {
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
                           
                            <div class=""col-md-6"">
                                <canvas id=""myschool""></canvas>
                            </div>


                            <div class=""col-md-6"">
                                <h5 class=""text-uppercase ml-4"">Implication</h5>
                                <ul>
                                    <li><b>Money And Profits: </b>workshop description will be written here.. only few line of description..</li>
         ");
            WriteLiteral(@"                           <li><b>Security: </b>workshop description will be written here.. only few line of description..</li>
                                    <li><b>Networking: </b>workshop description will be written here.. only few line of description..</li>
                                    <li><b>Fun Loving: </b>workshop description will be written here.. only few line of description..</li>
                                    <li><b>Social Service: </b>workshop description will be written here.. only few line of description..</li>
                                    <li><b>Recognition: </b>workshop description will be written here.. only few line of description..</li>

                                    <li><b>Power: </b>workshop description will be written here.. only few line of description..</li>
                                    <li><b>Respect: </b>workshop description will be written here.. only few line of description..</li>
                                    <li><b>Knowledge See");
            WriteLiteral(@"king: </b>workshop description will be written here.. only few line of description..</li>
                                    <li><b>Creativity and Innovation: </b>workshop description will be written here.. only few line of description..</li>
                                    <li><b>Goal Setting: </b>workshop description will be written here.. only few line of description..</li>
                                </ul>

                            </div>


                        </div>
                        </div>

                    </div>

            </div>

          

            <div class=""col-md-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">My Classes</h3>
                    </div>
                    <div class=""row p-3"">
                        <div class=""col-md-4"">
                            <div class=""card"">
                                <div class=""card-header"">
             ");
            WriteLiteral(@"                       <h3 class=""card-title"">8th</h3>
                                </div>
                                <div class=""card-body"" style=""height:300px;"">
                                    <canvas id=""Graph_8th""></canvas>
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <div class=""card"">
                                <div class=""card-header"">
                                    <h3 class=""card-title"">9th</h3>
                                </div>
                                <div class=""card-body"" style=""height:300px;"">
                                    <canvas id=""Graph_9th""></canvas>
                                </div>
                            </div>
                        </div>

                        <div class=""col-md-4"">
                            <div class=""card"">
                                <div class=""card-hea");
            WriteLiteral(@"der"">
                                    <h3 class=""card-title"">10th</h3>
                                </div>
                                <div class=""card-body"" style=""height:300px;"">
                                    <canvas id=""Graph_10th""></canvas>
                                </div>
                            </div>
                        </div>

                        <div class=""col-md-4"">
                            <div class=""card"">
                                <div class=""card-header"">
                                    <h3 class=""card-title"">11th</h3>
                                </div>
                                <div class=""card-body"" style=""height:300px;"">
                                    <canvas id=""Graph_11th""></canvas>
                                </div>
                            </div>
                        </div>

                        <div class=""col-md-4"">
                            <div class=""card"">
                          ");
            WriteLiteral(@"      <div class=""card-header"">
                                    <h3 class=""card-title"">12th</h3>
                                </div>
                                <div class=""card-body"" style=""height:300px;"">
                                    <canvas id=""Graph_12th""></canvas>
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
                WriteLiteral(@"    <script>
        var ctx = document.getElementById(""myschool"").getContext('2d');
        var myChart = new Chart(ctx, {
            type: 'pie',
            data: {
                labels: [""Money And Profits"", ""Security"", ""Networking"", ""Fun Loving"", ""Social Service"", ""Recognition"", ""Power"", ""Respect"", ""Knowledge Seeking"", ""Creativity and Innovation"", ""Goal Setting""],
                datasets: [{
                    backgroundColor: [
                        ""#2ecc71"",
                        ""#3498db"",
                        ""#95a5a6"",
                        ""#9b59b6"",
                        ""#f1c40f"",
                        ""#e74c3c"",
                        ""#2ecc71"",
                        ""#3498db"",
                        ""#95a5a6"",
                        ""#9b59b6"",
                        ""#f1c40f""
                    ],
                    data: [8, 7, 3, 5, 9, 10, 8, 7, 3, 5, 9]
                }]
            },
            options: {
                responsive: true");
                WriteLiteral(",\r\n                maintainAspectRatio: false,\r\n                legend: {\r\n                    display: true\r\n                }\r\n            }\r\n\r\n\r\n        });\r\n    </script>\r\n\r\n\r\n");
                WriteLiteral(@"    <script>
        var Eight = document.getElementById(""Graph_8th"").getContext('2d');
        var Graph_8th = new Chart(Eight, {
            type: 'pie',
            data: {
                labels: [""Money And Profits"", ""Security"", ""Networking"", ""Fun Loving"", ""Social Service"", ""Recognition"", ""Power"", ""Respect"", ""Knowledge Seeking"", ""Creativity and Innovation"", ""Goal Setting""],
                datasets: [{
                    backgroundColor: [
                        ""#2ecc71"",
                        ""#3498db"",
                        ""#95a5a6"",
                        ""#9b59b6"",
                        ""#f1c40f"",
                        ""#e74c3c"",
                        ""#2ecc71"",
                        ""#3498db"",
                        ""#95a5a6"",
                        ""#9b59b6"",
                        ""#f1c40f""
                    ],
                    data: [3, 3, 1, 7, 9, 7, 2, 2, 1, 1, 9]
                }]
            },
            options: {
                responsive");
                WriteLiteral(": true,\r\n                maintainAspectRatio: false,\r\n                legend: {\r\n                    display: false\r\n                }\r\n            }\r\n        });\r\n    </script>\r\n\r\n\r\n\r\n");
                WriteLiteral(@"    <script>
        var nine = document.getElementById(""Graph_9th"").getContext('2d');
        var Graph_9th = new Chart(nine, {
            type: 'pie',
            data: {
                labels: [""Money And Profits"", ""Security"", ""Networking"", ""Fun Loving"", ""Social Service"", ""Recognition"", ""Power"", ""Respect"", ""Knowledge Seeking"", ""Creativity and Innovation"", ""Goal Setting""],
                datasets: [{
                    backgroundColor: [
                        ""#2ecc71"",
                        ""#3498db"",
                        ""#95a5a6"",
                        ""#9b59b6"",
                        ""#f1c40f"",
                        ""#e74c3c"",
                        ""#2ecc71"",
                        ""#3498db"",
                        ""#95a5a6"",
                        ""#9b59b6"",
                        ""#f1c40f""
                    ],
                    data: [3, 3, 1, 1, 10, 0, 8, 7, 1, 5, 9]
                }]
            },
            options: {
                responsive:");
                WriteLiteral(" true,\r\n                maintainAspectRatio: false,\r\n                legend: {\r\n                    display: false\r\n                }\r\n            }\r\n        });\r\n    </script>\r\n\r\n\r\n");
                WriteLiteral(@"    <script>
        var ten = document.getElementById(""Graph_10th"").getContext('2d');
        var Graph_10th = new Chart(ten, {
            type: 'pie',
            data: {
                labels: [""Money And Profits"", ""Security"", ""Networking"", ""Fun Loving"", ""Social Service"", ""Recognition"", ""Power"", ""Respect"", ""Knowledge Seeking"", ""Creativity and Innovation"", ""Goal Setting""],
                datasets: [{
                    backgroundColor: [
                        ""#2ecc71"",
                        ""#3498db"",
                        ""#95a5a6"",
                        ""#9b59b6"",
                        ""#f1c40f"",
                        ""#e74c3c"",
                        ""#2ecc71"",
                        ""#3498db"",
                        ""#95a5a6"",
                        ""#9b59b6"",
                        ""#f1c40f""
                    ],
                    data: [8, 7, 4, 1, 1, 10, 2, 7, 3, 5, 9]
                }]
            },
            options: {
                responsive:");
                WriteLiteral(" true,\r\n                maintainAspectRatio: false,\r\n                legend: {\r\n                    display: false\r\n                }\r\n            }\r\n        });\r\n    </script>\r\n\r\n");
                WriteLiteral(@"    <script>
        var eleven = document.getElementById(""Graph_11th"").getContext('2d');
        var Graph_11th = new Chart(eleven, {
            type: 'pie',
            data: {
                labels: [""Money And Profits"", ""Security"", ""Networking"", ""Fun Loving"", ""Social Service"", ""Recognition"", ""Power"", ""Respect"", ""Knowledge Seeking"", ""Creativity and Innovation"", ""Goal Setting""],
                datasets: [{
                    backgroundColor: [
                        ""#2ecc71"",
                        ""#3498db"",
                        ""#95a5a6"",
                        ""#9b59b6"",
                        ""#f1c40f"",
                        ""#e74c3c"",
                        ""#2ecc71"",
                        ""#3498db"",
                        ""#95a5a6"",
                        ""#9b59b6"",
                        ""#f1c40f""
                    ],
                    data: [8, 7, 3, 5, 1, 1, 8, 7, 3, 5, 1]
                }]
            },
            options: {
                respon");
                WriteLiteral("sive: true,\r\n                maintainAspectRatio: false,\r\n                legend: {\r\n                    display: false\r\n                }\r\n            }\r\n        });\r\n    </script>\r\n\r\n");
                WriteLiteral(@"    <script>
        var twelve = document.getElementById(""Graph_12th"").getContext('2d');
        var Graph_12th = new Chart(twelve, {
            type: 'pie',
            data: {
                labels: [""Money And Profits"", ""Security"", ""Networking"", ""Fun Loving"", ""Social Service"", ""Recognition"", ""Power"", ""Respect"", ""Knowledge Seeking"", ""Creativity and Innovation"", ""Goal Setting""],
                datasets: [{
                    backgroundColor: [
                        ""#2ecc71"",
                        ""#3498db"",
                        ""#95a5a6"",
                        ""#9b59b6"",
                        ""#f1c40f"",
                        ""#e74c3c"",
                        ""#2ecc71"",
                        ""#3498db"",
                        ""#95a5a6"",
                        ""#9b59b6"",
                        ""#f1c40f""
                    ],
                    data: [1, 7, 3, 1, 9, 13, 8, 7, 3, 5, 1]
                }]
            },
            options: {
                respo");
                WriteLiteral("nsive: true,\r\n                maintainAspectRatio: false,\r\n                legend: {\r\n                    display: false\r\n                }\r\n            }\r\n        });\r\n    </script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ayush.motivatorsmodel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ayush.motivatorsmodel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ayush.motivatorsmodel>)PageContext?.ViewData;
        public ayush.motivatorsmodel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
