#pragma checksum "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\question.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45fbebe145d121b6740d9a9275ef7d1624338138"
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
#line 1 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\_ViewImports.cshtml"
using ayush;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45fbebe145d121b6740d9a9275ef7d1624338138", @"/Pages/Admin/question.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"780f75cdb21e45cdf2691da819d8b5f5fbb8c766", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_question : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\question.cshtml"
  
    ViewData["Title"] = "question";
    Layout = "~/Pages/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container-fluid\">\n    <div class=\"row\">\n        <div class=\"col-md-12\">\n            <div class=\"card\">\n                <div class=\"card-header\">\n                    <h1>Questions</h1>\n                    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 368, "\"", 413, 2);
            WriteAttributeValue("", 375, "add_text_question?quizId=", 375, 25, true);
#nullable restore
#line 14 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\question.cshtml"
WriteAttributeValue("", 400, Model.QuizId, 400, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-plus\"></i>&nbsp;Add New Text Question</a>\n                    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 520, "\"", 566, 2);
            WriteAttributeValue("", 527, "add_image_question?quizId=", 527, 26, true);
#nullable restore
#line 15 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\question.cshtml"
WriteAttributeValue("", 553, Model.QuizId, 553, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-plus\"></i>&nbsp;Add New Image Question</a>\n                    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 674, "\"", 720, 2);
            WriteAttributeValue("", 681, "add_timed_question?quizId=", 681, 26, true);
#nullable restore
#line 16 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\question.cshtml"
WriteAttributeValue("", 707, Model.QuizId, 707, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-plus\"></i>&nbsp;Add New Timed Question</a>\n                </div>\n                <div class=\"card-body\">\n");
#nullable restore
#line 19 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\question.cshtml"
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
#line 32 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\question.cshtml"
                                     foreach (var question in Model.Questions)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\n                                        <td class=\"align-middle\">");
#nullable restore
#line 35 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\question.cshtml"
                                                            Write(Html.Raw(question.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td class=\"align-middle text-center wrap-td hide-phone\">");
#nullable restore
#line 36 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\question.cshtml"
                                                                                           Write(question.QuestionType.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td class=\"align-middle text-center wrap-td hide-phone\">");
#nullable restore
#line 37 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\question.cshtml"
                                                                                           Write(question.Options.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td class=\"align-middle wrap-td\">\n                                            <div class=\"input-group\">\n");
#nullable restore
#line 40 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\question.cshtml"
                                                 if (question.QuestionType == Models.Enums.QuestionType.Image)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <a");
            BeginWriteAttribute("href", " href=\"", 2430, "\"", 2501, 4);
            WriteAttributeValue("", 2437, "edit_image_question?quizId=", 2437, 27, true);
#nullable restore
#line 42 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\question.cshtml"
WriteAttributeValue("", 2464, Model.QuizId, 2464, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2477, "&questionId=", 2477, 12, true);
#nullable restore
#line 42 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\question.cshtml"
WriteAttributeValue("", 2489, question.Id, 2489, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" class=\"btn btn-primary btn-sm\"><i class=\"fas fa-edit mg-r-10\"></i>&nbsp;Modify Question</a>\n");
#nullable restore
#line 43 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\question.cshtml"
                                                }
                                                else if (question.QuestionType == Models.Enums.QuestionType.Text)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <a");
            BeginWriteAttribute("href", " href=\"", 2877, "\"", 2947, 4);
            WriteAttributeValue("", 2884, "edit_text_question?quizId=", 2884, 26, true);
#nullable restore
#line 46 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\question.cshtml"
WriteAttributeValue("", 2910, Model.QuizId, 2910, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2923, "&questionId=", 2923, 12, true);
#nullable restore
#line 46 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\question.cshtml"
WriteAttributeValue("", 2935, question.Id, 2935, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" class=\"btn btn-primary btn-sm\"><i class=\"fas fa-edit mg-r-10\"></i>&nbsp;Modify Question</a>\n");
#nullable restore
#line 47 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\question.cshtml"
                                                }
                                                else if (question.QuestionType == Models.Enums.QuestionType.Timed)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <a");
            BeginWriteAttribute("href", " href=\"", 3324, "\"", 3395, 4);
            WriteAttributeValue("", 3331, "edit_timed_question?quizId=", 3331, 27, true);
#nullable restore
#line 50 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\question.cshtml"
WriteAttributeValue("", 3358, Model.QuizId, 3358, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3371, "&questionId=", 3371, 12, true);
#nullable restore
#line 50 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\question.cshtml"
WriteAttributeValue("", 3383, question.Id, 3383, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" class=\"btn btn-primary btn-sm\"><i class=\"fas fa-edit mg-r-10\"></i>&nbsp;Modify Question</a>\n");
#nullable restore
#line 51 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\question.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </div>\n                                        </td>\n                                    </tr>\n");
#nullable restore
#line 55 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\question.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\n                            </table>\n                        </div>\n");
#nullable restore
#line 59 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\question.cshtml"
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
#line 72 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\question.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n            </div>\n        </div>\n    </div>\n</div>");
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
