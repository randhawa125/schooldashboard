#pragma checksum "D:\FreelancerProject\ayush\Pages\Admin\Sessions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e15a79c7fc4355fc8c9ea80faf3ef730042921fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ayush.Pages.Admin.Pages_Admin_Sessions), @"mvc.1.0.razor-page", @"/Pages/Admin/Sessions.cshtml")]
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
#line 1 "D:\FreelancerProject\ayush\Pages\_ViewImports.cshtml"
using ayush;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e15a79c7fc4355fc8c9ea80faf3ef730042921fb", @"/Pages/Admin/Sessions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30a319bf93157485e6034cff29d85f12084656cc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Sessions : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/summernote-bs4.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/summernote-bs4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\FreelancerProject\ayush\Pages\Admin\Sessions.cshtml"
  
    ViewData["Title"] = "sessions";
    Layout = "~/Pages/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e15a79c7fc4355fc8c9ea80faf3ef730042921fb4801", async() => {
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
            WriteLiteral(@"
    <link href=""http://hayageek.github.io/jQuery-Upload-File/4.0.11/uploadfile.css"" rel=""stylesheet"">
    <script src=""http://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js""></script>
    <script src=""http://hayageek.github.io/jQuery-Upload-File/4.0.11/jquery.uploadfile.min.js""></script>
");
            WriteLiteral(@"

<br />

<section class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">

            <div class=""col-md-12"">
                <div class=""card"">
                    <div class=""card-header p-2"">
                        <ul class=""nav nav-pills"">
                            <li class=""nav-item""><a class=""nav-link active"" href=""#view"" data-toggle=""tab"">View</a></li>

                            <li class=""nav-item""><a class=""nav-link"" href=""#add"" data-toggle=""tab"">Add</a></li>

                        </ul>
                    </div>
                    <div class=""card-body"">
                        <div class=""tab-content"">
                            <div class=""active tab-pane"" id=""view"">
                                <div class=""row"">
                                    <div class=""row"">


                                        <div class=""col-md-4"">
                                            <div class=""card"">
                                          ");
            WriteLiteral(@"      <div class=""card-header"">
                                                    <h3 class=""card-title"">Session Title</h3>
                                                </div>

                                                <div class=""card-body"">
                                                    <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
                                                        <ol class=""carousel-indicators"">
                                                            <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
                                                            <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
                                                            <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
                                                        </ol>
                                                        <div class=""carou");
            WriteLiteral(@"sel-inner"">
                                                            <div class=""carousel-item active"">
                                                                <img class=""d-block w-100"" src=""https://placehold.it/900x500/39CCCC/ffffff&text=I+Love+Bootstrap"" alt=""First slide"">
                                                            </div>
                                                            <div class=""carousel-item"">
                                                                <img class=""d-block w-100"" src=""https://placehold.it/900x500/3c8dbc/ffffff&text=I+Love+Bootstrap"" alt=""Second slide"">
                                                            </div>
                                                            <div class=""carousel-item"">
                                                                <img class=""d-block w-100"" src=""https://placehold.it/900x500/f39c12/ffffff&text=I+Love+Bootstrap"" alt=""Third slide"">
                                                      ");
            WriteLiteral(@"      </div>
                                                        </div>
                                                        <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                                                            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                                                            <span class=""sr-only"">Previous</span>
                                                        </a>
                                                        <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                                                            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                                                            <span class=""sr-only"">Next</span>
                                                        </a>
                                                    </di");
            WriteLiteral(@"v>
                                                    <p class=""mt-2"">Session description will be written here.. only few line of description...</p>
                                                    <div class=""row pr-2"">
                                                      
                                                        <a href=""SkillCenterDetail"" class=""btn btn-primary d-block ml-auto float-right"">Delete</a>
                                                    </div>

                                                </div>

                                            </div>

                                        </div>

                                        <div class=""col-md-4"">
                                            <div class=""card"">
                                                <div class=""card-header"">
                                                    <h3 class=""card-title"">Session Title</h3>
                                                </div>

            ");
            WriteLiteral(@"                                    <div class=""card-body"">
                                                    <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
                                                        <ol class=""carousel-indicators"">
                                                            <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
                                                            <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
                                                            <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
                                                        </ol>
                                                        <div class=""carousel-inner"">
                                                            <div class=""carousel-item active"">
                                                                <img class=""d-block w-100");
            WriteLiteral(@""" src=""https://placehold.it/900x500/39CCCC/ffffff&text=I+Love+Bootstrap"" alt=""First slide"">
                                                            </div>
                                                            <div class=""carousel-item"">
                                                                <img class=""d-block w-100"" src=""https://placehold.it/900x500/3c8dbc/ffffff&text=I+Love+Bootstrap"" alt=""Second slide"">
                                                            </div>
                                                            <div class=""carousel-item"">
                                                                <img class=""d-block w-100"" src=""https://placehold.it/900x500/f39c12/ffffff&text=I+Love+Bootstrap"" alt=""Third slide"">
                                                            </div>
                                                        </div>
                                                        <a class=""carousel-control-prev"" href=""#carouselExampleIndicator");
            WriteLiteral(@"s"" role=""button"" data-slide=""prev"">
                                                            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                                                            <span class=""sr-only"">Previous</span>
                                                        </a>
                                                        <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                                                            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                                                            <span class=""sr-only"">Next</span>
                                                        </a>
                                                    </div>
                                                    <p class=""mt-2"">Session description will be written here.. only few line of description...</p>
                                              ");
            WriteLiteral(@"      <div class=""row pr-2"">
                                                       
                                                        <a href=""SkillCenterDetail"" class=""btn btn-primary d-block ml-auto float-right"">Delete</a>
                                                    </div>
                                                </div>

                                            </div>

                                        </div>

                                        <div class=""col-md-4"">
                                            <div class=""card"">
                                                <div class=""card-header"">
                                                    <h3 class=""card-title"">Session Title</h3>
                                                </div>

                                                <div class=""card-body"">
                                                    <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
    ");
            WriteLiteral(@"                                                    <ol class=""carousel-indicators"">
                                                            <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
                                                            <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
                                                            <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
                                                        </ol>
                                                        <div class=""carousel-inner"">
                                                            <div class=""carousel-item active"">
                                                                <img class=""d-block w-100"" src=""https://placehold.it/900x500/39CCCC/ffffff&text=I+Love+Bootstrap"" alt=""First slide"">
                                                            </div>
                                      ");
            WriteLiteral(@"                      <div class=""carousel-item"">
                                                                <img class=""d-block w-100"" src=""https://placehold.it/900x500/3c8dbc/ffffff&text=I+Love+Bootstrap"" alt=""Second slide"">
                                                            </div>
                                                            <div class=""carousel-item"">
                                                                <img class=""d-block w-100"" src=""https://placehold.it/900x500/f39c12/ffffff&text=I+Love+Bootstrap"" alt=""Third slide"">
                                                            </div>
                                                        </div>
                                                        <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                                                            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                                 ");
            WriteLiteral(@"                           <span class=""sr-only"">Previous</span>
                                                        </a>
                                                        <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                                                            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                                                            <span class=""sr-only"">Next</span>
                                                        </a>
                                                    </div>
                                                    <p class=""mt-2"">Session description will be written here.. only few line of description...</p>
                                                    <div class=""row pr-2"">
                                                      
                                                        <a href=""SkillCenterDetail"" class=""btn btn-primary d-bloc");
            WriteLiteral(@"k ml-auto float-right"">Delete</a>
                                                    </div>
                                                </div>

                                            </div>

                                        </div>



                                    </div>
                                </div>



                            </div>


                            <div class=""tab-pane"" id=""add"">


                                <div class=""col-md-12"">
                                    <div class=""card card-primary"">


                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e15a79c7fc4355fc8c9ea80faf3ef730042921fb19887", async() => {
                WriteLiteral(@"
                                            <div class=""card-body"">
                                                <div class=""form-group"">
                                                    <label for=""exampleInputEmail1"">Title</label>
                                                    <input type=""text"" class=""form-control"" id=""exampleInputEmail1"" placeholder=""Enter Title"">
                                                </div>
                                               
                                                <div class=""form-group"">
                                                    <label for=""exampleInputPassword1"">Description</label>
                                                    <textarea class=""textarea"" placeholder=""Place some text here""
                                                              style=""width: 100%; height: 400px; font-size: 14px; line-height: 18px; border: 1px solid #dddddd; padding: 10px;"">
                                Description</textarea>
");
                WriteLiteral(@"                                                </div>
                                                <div class=""form-group"">
                                                    <label for=""exampleInputFile"">Images</label>
                                                    <div class=""form-group"">
                                                        <div id=""multipleupload"">Upload multiple image files</div>
                                                    </div>
                                                </div>

                                            </div>


                                            <div class=""card-footer"">
                                                <button type=""submit"" class=""btn btn-primary"">Submit</button>
                                            </div>
                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e15a79c7fc4355fc8c9ea80faf3ef730042921fb23561", async() => {
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
                WriteLiteral("\r\n    <script>\r\n        $(function () {\r\n\r\n            $(\'.textarea\').summernote({\r\n                height: 300\r\n            });\r\n\r\n        })\r\n    </script>\r\n\r\n");
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ayush.Pages.Admin.SessionsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ayush.Pages.Admin.SessionsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ayush.Pages.Admin.SessionsModel>)PageContext?.ViewData;
        public ayush.Pages.Admin.SessionsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
