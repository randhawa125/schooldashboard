#pragma checksum "D:\mmmmm\ayush\Pages\School\WorkshopDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2b7a7dc14f74454c0f28400b026e874ca1b462a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ayush.Pages.School.Pages_School_WorkshopDetail), @"mvc.1.0.razor-page", @"/Pages/School/WorkshopDetail.cshtml")]
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
#line 1 "D:\mmmmm\ayush\Pages\_ViewImports.cshtml"
using ayush;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2b7a7dc14f74454c0f28400b026e874ca1b462a", @"/Pages/School/WorkshopDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30a319bf93157485e6034cff29d85f12084656cc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_School_WorkshopDetail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\mmmmm\ayush\Pages\School\WorkshopDetail.cshtml"
  
    ViewData["Title"] = "Workshop Detail";
    Layout = "~/Pages/Shared/_SchoolLayout.cshtml";
   

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""modal fade"" id=""modal-default"">
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
                    <label for=""exampleInputEmail3"">Contact Number</label>
                    <input type=""email"" class=""form-c");
            WriteLiteral(@"ontrol"" id=""exampleInputEmail3"" readonly>
                </div>
                <div class=""form-group"">
                    <label for=""exampleInputEmail3"">Workshop Title</label>
                    <input type=""email"" class=""form-control"" id=""exampleInputEmail4"" readonly>
                </div>
                <div class=""form-group"">
                    <label for=""exampleInputEmail3"">Workshop Start Date</label>
                    <input type=""email"" class=""form-control"" id=""exampleInputEmail5"" readonly>
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

<section class=""content-header"">
    <div class=""container-fluid"">
        <div class=""row mb-2"">
            <div class=""col-sm-6"">
                <h5 class=""text-uppercase"">Work");
            WriteLiteral(@"shop Title</h5>
            </div>
        </div>
    </div>
</section>

<section class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-12"">
                <p>Complete Description about the workshop will be written here... Complete Description about the workshop will be written here... Complete Description about the workshop will be written here... Complete Description about the workshop will be written here... Complete Description about the workshop will be written here... Complete Description about the workshop will be written here... Complete Description about the workshop will be written here... Complete Description about the workshop will be written here... Complete Description about the workshop will be written here... Complete Description about the workshop will be written here... Complete Description about the workshop will be written here... Complete Description about the workshop will be written here... Complete Description about the work");
            WriteLiteral(@"shop will be written here... Complete Description about the workshop will be written here... </p>
                <div class=""row text-right pr-2"">
                   
                    <a href=""#"" data-toggle=""modal"" data-target=""#modal-default"" class=""btn btn-primary d-block ml-auto"">Book Now</a>
                </div>
            </div>
            <!-- /.col -->
        </div>
        <!-- /.row -->
    </div>
    <!-- /.container-fluid -->
</section>


");
            DefineSection("JavaScript", async() => {
                WriteLiteral("\r\n   \r\n    <script>\r\n\r\n        function sendBuyRequest() {\r\n            $(\"#buyRequest\").modal(\"show\");\r\n        }\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ayush.WorkshopDetailmodel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ayush.WorkshopDetailmodel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ayush.WorkshopDetailmodel>)PageContext?.ViewData;
        public ayush.WorkshopDetailmodel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
