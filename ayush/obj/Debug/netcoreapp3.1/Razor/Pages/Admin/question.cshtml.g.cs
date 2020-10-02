#pragma checksum "D:\freeeeeeeeee\ayush\Pages\Admin\question.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acaeb17efc4d84a90436e0f139e59021b31309ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ayush.Pages.Admin.Pages_Admin_question), @"mvc.1.0.razor-page", @"/Pages/Admin/question.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acaeb17efc4d84a90436e0f139e59021b31309ec", @"/Pages/Admin/question.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30a319bf93157485e6034cff29d85f12084656cc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_question : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\freeeeeeeeee\ayush\Pages\Admin\question.cshtml"
  
    ViewData["Title"] = "question";
    Layout = "~/Pages/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            <div class=\"card\">\r\n                <div class=\"card-header\">\r\n                    <h1>Questions</h1>\r\n                    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 381, "\"", 426, 2);
            WriteAttributeValue("", 388, "add_text_question?quizId=", 388, 25, true);
#nullable restore
#line 14 "D:\freeeeeeeeee\ayush\Pages\Admin\question.cshtml"
WriteAttributeValue("", 413, Model.QuizId, 413, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-plus\"></i>&nbsp;Add New Text Question</a>\r\n                    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 534, "\"", 580, 2);
            WriteAttributeValue("", 541, "add_image_question?quizId=", 541, 26, true);
#nullable restore
#line 15 "D:\freeeeeeeeee\ayush\Pages\Admin\question.cshtml"
WriteAttributeValue("", 567, Model.QuizId, 567, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-plus\"></i>&nbsp;Add New Image Question</a>\r\n                    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 689, "\"", 735, 2);
            WriteAttributeValue("", 696, "add_timed_question?quizId=", 696, 26, true);
#nullable restore
#line 16 "D:\freeeeeeeeee\ayush\Pages\Admin\question.cshtml"
WriteAttributeValue("", 722, Model.QuizId, 722, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-plus\"></i>&nbsp;Add New Timed Question</a>\r\n                </div>\r\n                <div class=\"card-body\">\r\n");
#nullable restore
#line 19 "D:\freeeeeeeeee\ayush\Pages\Admin\question.cshtml"
                     if (Model.Questions != null && Model.Questions.Count > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""col-md-12 table-responsive"">
                            <table class=""table table-striped table-bordered m-b-0"">
                                <thead>
                                    <tr>
                                        <th>Question</th>
                                        <th>Type</th>
                                        <th class=""text-center hide-phone"">Options</th>
                                        <th>Actions</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 32 "D:\freeeeeeeeee\ayush\Pages\Admin\question.cshtml"
                                     foreach (var question in Model.Questions)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td class=\"align-middle\">");
#nullable restore
#line 35 "D:\freeeeeeeeee\ayush\Pages\Admin\question.cshtml"
                                                            Write(Html.Raw(question.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"align-middle text-center wrap-td hide-phone\">");
#nullable restore
#line 36 "D:\freeeeeeeeee\ayush\Pages\Admin\question.cshtml"
                                                                                           Write(question.QuestionType.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"align-middle text-center wrap-td hide-phone\">");
#nullable restore
#line 37 "D:\freeeeeeeeee\ayush\Pages\Admin\question.cshtml"
                                                                                           Write(question.Options.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"align-middle wrap-td\">\r\n                                            <div class=\"input-group\">\r\n");
#nullable restore
#line 40 "D:\freeeeeeeeee\ayush\Pages\Admin\question.cshtml"
                                                 if (question.QuestionType == Models.Enums.QuestionType.Image)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <a");
            BeginWriteAttribute("href", " href=\"", 2471, "\"", 2542, 4);
            WriteAttributeValue("", 2478, "edit_image_question?quizId=", 2478, 27, true);
#nullable restore
#line 42 "D:\freeeeeeeeee\ayush\Pages\Admin\question.cshtml"
WriteAttributeValue("", 2505, Model.QuizId, 2505, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2518, "&questionId=", 2518, 12, true);
#nullable restore
#line 42 "D:\freeeeeeeeee\ayush\Pages\Admin\question.cshtml"
WriteAttributeValue("", 2530, question.Id, 2530, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" class=\"btn btn-primary btn-sm\"><i class=\"fas fa-edit mg-r-10\"></i>&nbsp;Modify Question</a>\r\n");
#nullable restore
#line 43 "D:\freeeeeeeeee\ayush\Pages\Admin\question.cshtml"
                                                }
                                                else if (question.QuestionType == Models.Enums.QuestionType.Text)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <a");
            BeginWriteAttribute("href", " href=\"", 2922, "\"", 2992, 4);
            WriteAttributeValue("", 2929, "edit_text_question?quizId=", 2929, 26, true);
#nullable restore
#line 46 "D:\freeeeeeeeee\ayush\Pages\Admin\question.cshtml"
WriteAttributeValue("", 2955, Model.QuizId, 2955, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2968, "&questionId=", 2968, 12, true);
#nullable restore
#line 46 "D:\freeeeeeeeee\ayush\Pages\Admin\question.cshtml"
WriteAttributeValue("", 2980, question.Id, 2980, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" class=\"btn btn-primary btn-sm\"><i class=\"fas fa-edit mg-r-10\"></i>&nbsp;Modify Question</a>\r\n");
#nullable restore
#line 47 "D:\freeeeeeeeee\ayush\Pages\Admin\question.cshtml"
                                                }
                                                else if (question.QuestionType == Models.Enums.QuestionType.Timed)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <a");
            BeginWriteAttribute("href", " href=\"", 3373, "\"", 3444, 4);
            WriteAttributeValue("", 3380, "edit_timed_question?quizId=", 3380, 27, true);
#nullable restore
#line 50 "D:\freeeeeeeeee\ayush\Pages\Admin\question.cshtml"
WriteAttributeValue("", 3407, Model.QuizId, 3407, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3420, "&questionId=", 3420, 12, true);
#nullable restore
#line 50 "D:\freeeeeeeeee\ayush\Pages\Admin\question.cshtml"
WriteAttributeValue("", 3432, question.Id, 3432, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" class=\"btn btn-primary btn-sm\"><i class=\"fas fa-edit mg-r-10\"></i>&nbsp;Modify Question</a>\r\n");
#nullable restore
#line 51 "D:\freeeeeeeeee\ayush\Pages\Admin\question.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </div>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 55 "D:\freeeeeeeeee\ayush\Pages\Admin\question.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n");
#nullable restore
#line 59 "D:\freeeeeeeeee\ayush\Pages\Admin\question.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""col-md-12"">
                            <div class=""row"">
                                <div class=""col-md-12"">
                                    <div class=""m-t-10 alert alert-icon alert-warning"" role=""alert"">
                                        <i class=""mdi mdi-alert""></i>
                                        Sorry. No Questions Found.
                                    </div>
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 72 "D:\freeeeeeeeee\ayush\Pages\Admin\question.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ayush.questionModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ayush.questionModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ayush.questionModel>)PageContext?.ViewData;
        public ayush.questionModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
