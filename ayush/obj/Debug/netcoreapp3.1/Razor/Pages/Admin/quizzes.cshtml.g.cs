#pragma checksum "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\quizzes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "096be7b09dc1248cd45c51c1f140346ae031d645"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ayush.Pages.Admin.Pages_Admin_quizzes), @"mvc.1.0.razor-page", @"/Pages/Admin/quizzes.cshtml")]
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
#line 1 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\_ViewImports.cshtml"
using ayush;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"096be7b09dc1248cd45c51c1f140346ae031d645", @"/Pages/Admin/quizzes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30a319bf93157485e6034cff29d85f12084656cc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_quizzes : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\quizzes.cshtml"
  
	ViewData["Title"] = "quizzes";
	Layout = "~/Pages/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""container"">
	<div class=""row mb-4"">
		<div class=""col-md-12"">
			<div class=""card"">

				<div class=""card-header"">
					<h1>Quizzes</h1>
					<a class=""nav-link"" href=""add_quiz""><i class=""fas fa-plus""></i>&nbsp;Create New Quiz</a>
				</div>
				<div class=""card-body"">
					<div class=""col-md-8"">
");
            WriteLiteral("\t\t\t\t\t</div>\r\n");
#nullable restore
#line 31 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\quizzes.cshtml"
                     if (Model.Quizzes != null && Model.Quizzes.Count > 0)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"						<div class=""col-md-12 table-responsive"">
							<table class=""table table-striped table-bordered m-b-0"">
								<thead>
									<tr>
										<th>Name</th>
										<th class=""hide-phone"">Duration</th>
										<th class=""text-center hide-phone"">Questions</th>
										<th>Actions</th>
									</tr>
								</thead>
								<tbody>
");
#nullable restore
#line 44 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\quizzes.cshtml"
                                     foreach (var quiz in Model.Quizzes)
									{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t\t\t<td class=\"align-middle\">");
#nullable restore
#line 47 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\quizzes.cshtml"
                                                                Write(quiz.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td class=\"align-middle text-center wrap-td hide-phone\">\r\n");
#nullable restore
#line 49 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\quizzes.cshtml"
                                                 if (quiz.EnableQuizTimer)
												{
													if (quiz.TimeDuration.Hours > 0)
													{
														if (quiz.TimeDuration.Hours == 1)
														{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<span>");
#nullable restore
#line 55 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\quizzes.cshtml"
                                                             Write(quiz.TimeDuration.Hours.ToString("00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Hour&nbsp;</span>\r\n");
#nullable restore
#line 56 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\quizzes.cshtml"
														}
														else
														{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<span>");
#nullable restore
#line 59 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\quizzes.cshtml"
                                                             Write(quiz.TimeDuration.Hours.ToString("00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Hours&nbsp;</span>\r\n");
#nullable restore
#line 60 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\quizzes.cshtml"
														}
													}

													if (quiz.TimeDuration.Minutes > 0)
													{
														if (quiz.TimeDuration.Minutes == 1)
														{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<span>");
#nullable restore
#line 67 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\quizzes.cshtml"
                                                             Write(quiz.TimeDuration.Minutes.ToString("00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Minute</span>\r\n");
#nullable restore
#line 68 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\quizzes.cshtml"
														}
														else
														{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<span>");
#nullable restore
#line 71 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\quizzes.cshtml"
                                                             Write(quiz.TimeDuration.Minutes.ToString("00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Minutes</span>\r\n");
#nullable restore
#line 72 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\quizzes.cshtml"
														}
													}
												}
												else
												{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t<span>Disabled</span>\r\n");
#nullable restore
#line 78 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\quizzes.cshtml"
												}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td class=\"align-middle text-center wrap-td hide-phone\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 81 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\quizzes.cshtml"
                                           Write(quiz.Questions.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td class=\"align-middle wrap-td\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"input-group\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 2954, "\"", 2986, 2);
            WriteAttributeValue("", 2961, "edit_quiz?quizid=", 2961, 17, true);
#nullable restore
#line 85 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\quizzes.cshtml"
WriteAttributeValue("", 2978, quiz.Id, 2978, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" class=\"btn btn-primary btn-sm\"><i class=\"fas fa-edit mg-r-10\"></i>&nbsp;Modify Quiz</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 3106, "\"", 3137, 2);
            WriteAttributeValue("", 3113, "question?quizId=", 3113, 16, true);
#nullable restore
#line 86 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\quizzes.cshtml"
WriteAttributeValue("", 3129, quiz.Id, 3129, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" class=\"btn btn-info btn-sm hide-phone\"><i class=\"fas fa-list-ul mg-r-10\"></i>&nbsp;Questions List</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 3271, "\"", 3311, 2);
            WriteAttributeValue("", 3278, "add_text_question?quizId=", 3278, 25, true);
#nullable restore
#line 87 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\quizzes.cshtml"
WriteAttributeValue("", 3303, quiz.Id, 3303, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" class=\"btn btn-success btn-sm hide-phone\"><i class=\"fas fa-plus mg-r-10\"></i>&nbsp;Add Text Questions</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 3449, "\"", 3490, 2);
            WriteAttributeValue("", 3456, "add_image_question?quizId=", 3456, 26, true);
#nullable restore
#line 88 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\quizzes.cshtml"
WriteAttributeValue("", 3482, quiz.Id, 3482, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" class=\"btn btn-success btn-sm hide-phone\"><i class=\"fas fa-plus mg-r-10\"></i>&nbsp;Add Image Questions</a>\r\n");
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 96 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\quizzes.cshtml"
									}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t\t\t</table>\r\n\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 100 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\quizzes.cshtml"
					}
					else
					{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"						<div class=""col-md-12"">
							<div class=""row"">
								<div class=""col-md-12"">
									<div class=""m-t-10 alert alert-icon alert-secondary"" role=""alert"">
										<i class=""mdi mdi-alert""></i>
										Sorry. No Quizzes Found.
									</div>
								</div>
							</div>
						</div>
");
#nullable restore
#line 113 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\quizzes.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ayush.quizzesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ayush.quizzesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ayush.quizzesModel>)PageContext?.ViewData;
        public ayush.quizzesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
