#pragma checksum "D:\freeeeeeeeee\ayush\Pages\School\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47487cc64dda8e5c5408628d59966626eb731350"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ayush.Pages.School.Pages_School_Dashboard), @"mvc.1.0.razor-page", @"/Pages/School/Dashboard.cshtml")]
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
#line 1 "D:\freeeeeeeeee\ayush\Pages\_ViewImports.cshtml"
using ayush;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47487cc64dda8e5c5408628d59966626eb731350", @"/Pages/School/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30a319bf93157485e6034cff29d85f12084656cc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_School_Dashboard : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/ionicons.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\freeeeeeeeee\ayush\Pages\School\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";
    Layout = "~/Pages/Shared/_SchoolLayout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "47487cc64dda8e5c5408628d59966626eb7313503813", async() => {
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
            WriteLiteral(@"<br />

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
                    <input typ");
            WriteLiteral(@"e=""email"" class=""form-control"" id=""exampleInputEmail3"">
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

<section class=""content"">


    <div class=""card22"">
        <div class=""card-body22"">
            <div class=""row"">


                <div class=""col-md-8"">
                    <div class=""row"">

                        <!-- ./col -->
                        <div class=""col-md-6"">
                            <!-- small box -->
                            <div class=""small-box bg-info"">
                                <div class=""inner"">
                                    <h3>04</h3>

                                    <p>Coupons Remaining</p>
                                </div>
                                <div cla");
            WriteLiteral(@"ss=""icon"">
                                    <i class=""fa fa-gift""></i>
                                </div>
                                <a href=""coupons"" class=""small-box-footer"">View History <i class=""fas fa-arrow-circle-right""></i></a>
                            </div>
                        </div>
                        <!-- ./col -->
                        <div class=""col-md-6"">
                            <!-- small box -->
                            <div class=""small-box bg-warning"">
                                <div class=""inner"">
                                    <h3>44</h3>

                                    <p>Coupons Used</p>
                                </div>
                                <div class=""icon"">
                                    <i class=""fa fa-gifts""></i>
                                </div>
                                <a href=""#"" data-toggle=""modal"" data-target=""#modal-default"" class=""small-box-footer"">Send Buy Request <i class=""fa");
            WriteLiteral("s fa-arrow-circle-right\"></i></a>\r\n                            </div>\r\n                        </div>\r\n\r\n                    </div>\r\n\r\n                    <div class=\"row\">\r\n\r\n");
#nullable restore
#line 90 "D:\freeeeeeeeee\ayush\Pages\School\Dashboard.cshtml"
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
#line 100 "D:\freeeeeeeeee\ayush\Pages\School\Dashboard.cshtml"
                                               Write(blog.SubmittedByUserFullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </span>\r\n                                                <span class=\"description\">");
#nullable restore
#line 102 "D:\freeeeeeeeee\ayush\Pages\School\Dashboard.cshtml"
                                                                     Write(blog.SubmittedDate.ToString("dddd, dd MMMM yyyy - HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n                                            </div>\r\n\r\n                                            <span class=\"username\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 4535, "\"", 4564, 2);
            WriteAttributeValue("", 4542, "blogdetail?id=", 4542, 14, true);
#nullable restore
#line 107 "D:\freeeeeeeeee\ayush\Pages\School\Dashboard.cshtml"
WriteAttributeValue("", 4556, blog.Id, 4556, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 107 "D:\freeeeeeeeee\ayush\Pages\School\Dashboard.cshtml"
                                                                            Write(blog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </span>\r\n");
#nullable restore
#line 109 "D:\freeeeeeeeee\ayush\Pages\School\Dashboard.cshtml"
                                             if (string.IsNullOrEmpty(blog.FeaturedImagePath) == false)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <img class=\"img-fluid pad mb-3 mt-2\"");
            BeginWriteAttribute("src", " src=\"", 4872, "\"", 4910, 2);
            WriteAttributeValue("", 4878, "/uploads/", 4878, 9, true);
#nullable restore
#line 111 "D:\freeeeeeeeee\ayush\Pages\School\Dashboard.cshtml"
WriteAttributeValue("", 4887, blog.FeaturedImagePath, 4887, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Photo\">\r\n");
#nullable restore
#line 112 "D:\freeeeeeeeee\ayush\Pages\School\Dashboard.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div>\r\n");
#nullable restore
#line 114 "D:\freeeeeeeeee\ayush\Pages\School\Dashboard.cshtml"
                                                   if (blog.Description.Length < 200)
                                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <div style=\"height: 84px; overflow: hidden;\">");
#nullable restore
#line 117 "D:\freeeeeeeeee\ayush\Pages\School\Dashboard.cshtml"
                                                                                                Write(Html.Raw(blog.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</div>\r\n                                                        <div class=\"text-right\">\r\n                                                            <a");
            BeginWriteAttribute("href", " href=\"", 5451, "\"", 5480, 2);
            WriteAttributeValue("", 5458, "blogdetail?id=", 5458, 14, true);
#nullable restore
#line 119 "D:\freeeeeeeeee\ayush\Pages\School\Dashboard.cshtml"
WriteAttributeValue("", 5472, blog.Id, 5472, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-book-reader mr-1\"></i> read more</a>\r\n                                                        </div>\r\n");
#nullable restore
#line 121 "D:\freeeeeeeeee\ayush\Pages\School\Dashboard.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <div>");
#nullable restore
#line 124 "D:\freeeeeeeeee\ayush\Pages\School\Dashboard.cshtml"
                                                        Write(Html.Raw(blog.Description.Substring(0, 200)));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</div>\r\n");
#nullable restore
#line 125 "D:\freeeeeeeeee\ayush\Pages\School\Dashboard.cshtml"
                                                    }
                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </div>\r\n\r\n\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 135 "D:\freeeeeeeeee\ayush\Pages\School\Dashboard.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>

                </div>
                <div class=""col-md-4"">
                    


                    




                    <div>

                        <div class=""info-box bg-light"">

                            <div class=""info-box-content"">

                                <div class=""post"">
                                    <h6>Latest Notifications</h6>
                                    <hr />
");
#nullable restore
#line 157 "D:\freeeeeeeeee\ayush\Pages\School\Dashboard.cshtml"
                                     foreach (var notification in Model.Notifications)
                                    {

                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p>   <a");
            BeginWriteAttribute("href", " href=\"", 6970, "\"", 7015, 2);
            WriteAttributeValue("", 6977, "notificationdetail?id=", 6977, 22, true);
#nullable restore
#line 162 "D:\freeeeeeeeee\ayush\Pages\School\Dashboard.cshtml"
WriteAttributeValue("", 6999, notification.Id, 6999, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 162 "D:\freeeeeeeeee\ayush\Pages\School\Dashboard.cshtml"
                                                                                          Write(notification.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n");
            WriteLiteral("                                        <hr />\r\n");
#nullable restore
#line 165 "D:\freeeeeeeeee\ayush\Pages\School\Dashboard.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ayush.Pages.School.DashboardModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ayush.Pages.School.DashboardModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ayush.Pages.School.DashboardModel>)PageContext?.ViewData;
        public ayush.Pages.School.DashboardModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
