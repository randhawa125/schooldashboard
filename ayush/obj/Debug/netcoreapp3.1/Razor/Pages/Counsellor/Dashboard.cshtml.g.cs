#pragma checksum "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Counsellor\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0c7aa3c55311679bd6bbc5cd13e4b99ba8dc3bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ayush.Pages.Counsellor.Pages_Counsellor_Dashboard), @"mvc.1.0.razor-page", @"/Pages/Counsellor/Dashboard.cshtml")]
namespace ayush.Pages.Counsellor
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
#line 1 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\_ViewImports.cshtml"
using ayush;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0c7aa3c55311679bd6bbc5cd13e4b99ba8dc3bd", @"/Pages/Counsellor/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30a319bf93157485e6034cff29d85f12084656cc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Counsellor_Dashboard : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/ionicons.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap-datepicker/bootstrap-datepicker3.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Counsellor\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";
    Layout = "~/Pages/Shared/_CounsellorLayout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a0c7aa3c55311679bd6bbc5cd13e4b99ba8dc3bd4324", async() => {
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a0c7aa3c55311679bd6bbc5cd13e4b99ba8dc3bd5443", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <script src=\"https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.6.4/js/bootstrap-datepicker.js\"></script>\r\n");
            WriteLiteral(@"
<div class=""modal fade"" id=""modal-default"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">

                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""form-group"">
                    <label for=""exampleInputEmail1"">Name</label>
                    <input type=""email"" class=""form-control"" id=""exampleInputEmail1"" readonly>
                </div>
                <div class=""form-group"">
                    <label for=""exampleInputEmail2"">Email</label>
                    <input type=""email"" class=""form-control"" id=""exampleInputEmail2"" readonly>
                </div>
                <div class=""form-group"">
                    <label for=""exampleInputEmail3"">Number of Coupons Required?</label>
                    <input type=""email");
            WriteLiteral(@""" class=""form-control"" id=""exampleInputEmail3"">
                </div>
            </div>
            <div class=""modal-footer justify-content-between"">

                <button type=""button"" class=""btn btn-primary"">Send Request</button>
            </div>
        </div>
        <!-- /.modal-content -->
    </div>
    <!-- /.modal-dialog -->
</div>

<br />
<section class=""content"">
    <div class=""row"">

        <!-- ./col -->
        <div class=""col-md-3"">
            <!-- small box -->
            <div class=""small-box bg-warning"">
                <div class=""inner"">
                    <h3>44</h3>

                    <p>Coupons Used</p>
                </div>
                <div class=""icon"">
                    <i class=""fa fa-gifts""></i>
                </div>
                <a href=""coupons"" class=""small-box-footer"">View History <i class=""fas fa-arrow-circle-right""></i></a>
            </div>
        </div>
        <div class=""col-md-3"">
            <!-- small box -->");
            WriteLiteral(@"
            <div class=""small-box bg-success"">
                <div class=""inner"">
                    <h3>04</h3>

                    <p>Coupons Remaining</p>
                </div>
                <div class=""icon"">
                    <i class=""fa fa-gift""></i>
                </div>
");
            WriteLiteral(@"                <a href=""#"" data-toggle=""modal"" data-target=""#modal-default"" class=""small-box-footer"">Send Buy Request <i class=""fas fa-arrow-circle-right""></i></a>
            </div>
        </div>
        <!-- ./col -->
        <div class=""col-md-3"">
            <!-- small box -->
            <div class=""small-box bg-info"">
                <div class=""inner"">
                    <h3>14</h3>

                    <p>Total Reward Points</p>
                </div>
                <div class=""icon"">
                    <i class=""fa fa-coins""></i>
                </div>
                <a href=""RewardPoints"" class=""small-box-footer"">View All <i class=""fas fa-arrow-circle-right""></i></a>
            </div>
        </div>
        <div class=""col-md-3"">
            <!-- small box -->
            <div class=""small-box bg-danger"">
                <div class=""inner"">
                    <h3>10</h3>

                    <p>Total Referrals</p>
                </div>
                <div class=""i");
            WriteLiteral(@"con"">
                    <i class=""fa fa-user-plus""></i>
                </div>
                <a href=""refer"" class=""small-box-footer"">View All <i class=""fas fa-arrow-circle-right""></i></a>
            </div>
        </div>

    </div>


    <div class=""card22"">
        <div class=""card-body22"">
            <div class=""row"">


                <div class=""col-md-8"">

                    <div class=""row"">

");
#nullable restore
#line 124 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Counsellor\Dashboard.cshtml"
                         foreach (var blog in Model.Blogs)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""col-12 col-sm-6"">

                                <div class=""info-box bg-light"">
                                    <div class=""info-box-content"">
                                        <div class=""post"">
                                            <div class=""user-block"">
                                                <img class=""img-circle img-bordered-sm"" src=""/images/user1-128x128.jpg"" alt=""user image"">
                                                <span class=""username"">
                                                    ");
#nullable restore
#line 134 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Counsellor\Dashboard.cshtml"
                                               Write(blog.SubmittedByUserFullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </span>\r\n                                                <span class=\"description\">");
#nullable restore
#line 136 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Counsellor\Dashboard.cshtml"
                                                                     Write(blog.SubmittedDate.ToString("dddd, dd MMMM yyyy - HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n                                            </div>\r\n\r\n                                            <span class=\"username\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 5502, "\"", 5531, 2);
            WriteAttributeValue("", 5509, "blogdetail?id=", 5509, 14, true);
#nullable restore
#line 141 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Counsellor\Dashboard.cshtml"
WriteAttributeValue("", 5523, blog.Id, 5523, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 141 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Counsellor\Dashboard.cshtml"
                                                                            Write(blog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </span>\r\n");
#nullable restore
#line 143 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Counsellor\Dashboard.cshtml"
                                             if (string.IsNullOrEmpty(blog.FeaturedImagePath) == false)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <img class=\"img-fluid pad mb-3 mt-2\"");
            BeginWriteAttribute("src", " src=\"", 5839, "\"", 5877, 2);
            WriteAttributeValue("", 5845, "/uploads/", 5845, 9, true);
#nullable restore
#line 145 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Counsellor\Dashboard.cshtml"
WriteAttributeValue("", 5854, blog.FeaturedImagePath, 5854, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Photo\">\r\n");
#nullable restore
#line 146 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Counsellor\Dashboard.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div>\r\n");
#nullable restore
#line 148 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Counsellor\Dashboard.cshtml"
                                                   if (blog.Description.Length < 200)
                                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <div style=\"height: 84px; overflow: hidden;\">");
#nullable restore
#line 151 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Counsellor\Dashboard.cshtml"
                                                                                                Write(Html.Raw(blog.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</div>\r\n                                                        <div class=\"text-right\">\r\n                                                            <a");
            BeginWriteAttribute("href", " href=\"", 6418, "\"", 6447, 2);
            WriteAttributeValue("", 6425, "blogdetail?id=", 6425, 14, true);
#nullable restore
#line 153 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Counsellor\Dashboard.cshtml"
WriteAttributeValue("", 6439, blog.Id, 6439, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-book-reader mr-1\"></i> read more</a>\r\n                                                        </div>\r\n");
#nullable restore
#line 155 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Counsellor\Dashboard.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <div>");
#nullable restore
#line 158 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Counsellor\Dashboard.cshtml"
                                                        Write(Html.Raw(blog.Description.Substring(0, 200)));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</div>\r\n");
#nullable restore
#line 159 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Counsellor\Dashboard.cshtml"
                                                    }
                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </div>\r\n\r\n\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 169 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Counsellor\Dashboard.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>

                </div>
                <div class=""col-md-4"">

                    <div class=""info-box bg-light"">

                        <div class=""info-box-content"">

                            <div class=""post"">
                                <div id=""datepicker"" style=""width: 100%""></div>


                            </div>
                        </div>
                    </div>

                    <div class=""info-box bg-light"">

                        <div class=""info-box-content"">

                            <div class=""post"">
                                <h6>Current Challenge</h6>
                                <hr />

                                <p>  Text of the challenge will be written here. You can add few lines here.</p>

                                <hr />



                            </div>
                        </div>
                    </div>





                    <div class=""info-box bg-light"">
");
            WriteLiteral(@"
                        <div class=""info-box-content"">

                            <div class=""post"">
                                <h6>Upcoming Sessions</h6>
                                <hr />

                                <p>  Harpreet Singh - 02-09-2020 (10:00 - 11:00 AM)</p>

                                <hr />



                            </div>
                        </div>
                    </div>


                    <div>

                        <div class=""info-box bg-light"">

                            <div class=""info-box-content"">

                                <div class=""post"">
                                    <h6>Latest Notifications</h6>
                                    <hr />
");
#nullable restore
#line 237 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Counsellor\Dashboard.cshtml"
                                     foreach (var notification in Model.Notifications)
                                    {

                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p>   <a");
            BeginWriteAttribute("href", " href=\"", 9258, "\"", 9303, 2);
            WriteAttributeValue("", 9265, "notificationdetail?id=", 9265, 22, true);
#nullable restore
#line 242 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Counsellor\Dashboard.cshtml"
WriteAttributeValue("", 9287, notification.Id, 9287, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 242 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Counsellor\Dashboard.cshtml"
                                                                                          Write(notification.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n");
            WriteLiteral("                                        <hr />\r\n");
#nullable restore
#line 245 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Counsellor\Dashboard.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                </div>
                            </div>
                        </div>



                    </div>


                </div>
            </div>
        </div>

    </div>


</section>

<script>

    function sendBuyRequest() {
        $(""#buyRequest"").modal(""show"");
    }
</script>
<script>
    $('#datepicker').datepicker({
        startDate: truncateDate(new Date())
    });

    function truncateDate(date) {
        return new Date(date.getFullYear(), date.getMonth(), date.getDate());
    }

 

   
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ayush.Pages.Counsellor.DashboardModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ayush.Pages.Counsellor.DashboardModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ayush.Pages.Counsellor.DashboardModel>)PageContext?.ViewData;
        public ayush.Pages.Counsellor.DashboardModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
