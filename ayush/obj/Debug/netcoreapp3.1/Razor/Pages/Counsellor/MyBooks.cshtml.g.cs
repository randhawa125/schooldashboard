#pragma checksum "D:\UpdateFreelance\ayush\Pages\Counsellor\MyBooks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "382f89a2289a411e243a46dee35e7490c21f7164"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ayush.Pages.Counsellor.Pages_Counsellor_MyBooks), @"mvc.1.0.razor-page", @"/Pages/Counsellor/MyBooks.cshtml")]
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
#line 1 "D:\UpdateFreelance\ayush\Pages\_ViewImports.cshtml"
using ayush;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"382f89a2289a411e243a46dee35e7490c21f7164", @"/Pages/Counsellor/MyBooks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30a319bf93157485e6034cff29d85f12084656cc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Counsellor_MyBooks : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\UpdateFreelance\ayush\Pages\Counsellor\MyBooks.cshtml"
  
    ViewData["Title"] = "My Books";
    Layout = "~/Pages/Shared/_CounsellorLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card"">
                <div class=""card-header"">
                   <h3>My Books</h3>
                </div>
                <!-- /.card-header -->
                <div class=""card-body"">
                    <table class=""table table-bordered"">
                        <thead>
                            <tr>
                                <th style=""width: 10px"">#</th>
                                <th>Title</th>
                               
                                <th style=""width: 40px"">Download</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>1.</td>
                                <td>
                                    Update software<br />
                                    <small>
                                        description will be written here...
       ");
            WriteLiteral(@"                             </small>
                                </td>

                                <td><span class=""badge bg-primary"">Download</span></td>
                            </tr>
                            <tr>
                                <td>2.</td>
                                <td>
                                    Clean database<br />
                                    <small>
                                        description will be written here...
                                    </small>
                                </td>

                                <td><span class=""badge bg-primary"">Download</span></td>
                            </tr>
                            <tr>
                                <td>3.</td>
                                <td>
                                    Cron job running<br />
                                    <small>
                                        description will be written here...
             ");
            WriteLiteral(@"                       </small>
                                </td>
                               
                                <td><span class=""badge bg-primary"">Download</span></td>
                            </tr>
                            <tr>
                                <td>4.</td>
                                <td>
                                    Fix and squish bugs<br />
                                    <small>
                                        description will be written here...
                                    </small>
                                </td>

                                <td><span class=""badge bg-primary"">Download</span></td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <!-- /.card-body -->
                <div class=""card-footer clearfix"">
                    <ul class=""pagination pagination-sm m-0 float-right"">
                        <li c");
            WriteLiteral(@"lass=""page-item""><a class=""page-link"" href=""#"">«</a></li>
                        <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
                        <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
                        <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                        <li class=""page-item""><a class=""page-link"" href=""#"">»</a></li>
                    </ul>
                </div>
            </div>
            <!-- /.card -->

         
        </div>
    </div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ayush.Pages.Counsellor.MyBooksModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ayush.Pages.Counsellor.MyBooksModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ayush.Pages.Counsellor.MyBooksModel>)PageContext?.ViewData;
        public ayush.Pages.Counsellor.MyBooksModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
