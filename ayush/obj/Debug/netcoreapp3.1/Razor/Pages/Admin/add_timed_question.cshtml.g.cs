#pragma checksum "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f6da5c388620b8e6180bdb7f16399d4fa168e6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ayush.Pages.Admin.Pages_Admin_add_timed_question), @"mvc.1.0.razor-page", @"/Pages/Admin/add_timed_question.cshtml")]
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
#line 1 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\_ViewImports.cshtml"
using ayush;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f6da5c388620b8e6180bdb7f16399d4fa168e6c", @"/Pages/Admin/add_timed_question.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30a319bf93157485e6034cff29d85f12084656cc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_add_timed_question : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("operationForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
  
	ViewData["Title"] = "add_timed_question";
	Layout = "~/Pages/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n\t<div class=\"row\">\r\n\t\t<div class=\"col-sm-12\">\r\n\t\t\t<div class=\"card\">\r\n\t\t\t\t<div class=\"card-header\">\r\n\t\t\t\t\t<h1>Add New Timed Question</h1>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t<div>\r\n\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f6da5c388620b8e6180bdb7f16399d4fa168e6c4639", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t<input type=\"hidden\" id=\"QuizID\" name=\"QuizID\"");
                BeginWriteAttribute("value", " value=\"", 494, "\"", 533, 1);
#nullable restore
#line 18 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
WriteAttributeValue("", 502, Model.QuestionViewModel.QuizId, 502, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t<label for=\"Title\">Question Title</label>\r\n");
                WriteLiteral("\t\t\t\t\t\t\t\t<textarea class=\"textarea\" placeholder=\"Place some text here\" name=\"Title\" id=\"Title\"\r\n\t\t\t\t\t\t\t\t\t\t  style=\"width: 100%; height: 200px; font-size: 14px; line-height: 18px; border: 1px solid #dddddd; padding: 10px;\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 25 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
                           Write(Model.QuestionViewModel.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\r\n");
#nullable restore
#line 26 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
                                 if (!ViewData.ModelState.IsValid && ViewData.ModelState["Title"] != null && ViewData.ModelState["Title"].Errors.Count > 0)
								{
									

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
                               Write(Html.ValidationMessageFor(m => m.QuestionViewModel.Title, ViewData.ModelState["Title"].Errors.FirstOrDefault().ErrorMessage, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
                                                                                                                                                                                                 
								}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t<div class=\"image-holder pull-left\">\r\n\t\t\t\t\t\t\t\t\t<input class=\"txtfield form-control\" type=\"hidden\" name=\"questionfile\"");
                BeginWriteAttribute("value", " value=\"", 1501, "\"", 1509, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t<img");
                BeginWriteAttribute("src", " src=\"", 1526, "\"", 1532, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""img-thumbnail"" style=""height: 300px; display:none"">
								</div>
								<span class=""error-holder""></span>
								<input class=""image-uploader form-control"" type=""file"" accept="".png,.jpg,.jpeg,.gif,.tif"" />
								<div class=""clearfix""></div>
							</div>

							<div>
								<label for=""Title"">Question Time</label>
								<div class=""form-group"">
									<label for=""Hours"">Hours</label>
									<input class=""form-control"" type=""text"" id=""Hours"" name=""Hours""");
                BeginWriteAttribute("value", " value=\"", 2024, "\"", 2062, 1);
#nullable restore
#line 44 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
WriteAttributeValue("", 2032, Model.QuestionViewModel.Hours, 2032, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Enter Hours Duration\">\r\n");
#nullable restore
#line 45 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
                                     if (!ViewData.ModelState.IsValid && ViewData.ModelState["Hours"] != null && ViewData.ModelState["Hours"].Errors.Count > 0)
									{
										

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
                                   Write(Html.ValidationMessageFor(m => m.QuestionViewModel.Hours, ViewData.ModelState["Hours"].Errors.FirstOrDefault().ErrorMessage, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
                                                                                                                                                                                                     
									}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t<label for=\"Minutes\">Minutes</label>\r\n\t\t\t\t\t\t\t\t\t<input class=\"form-control\" type=\"text\" id=\"Minutes\" name=\"Minutes\"");
                BeginWriteAttribute("value", " value=\"", 2601, "\"", 2641, 1);
#nullable restore
#line 52 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
WriteAttributeValue("", 2609, Model.QuestionViewModel.Minutes, 2609, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Enter Minutes Duration\">\r\n");
#nullable restore
#line 53 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
                                     if (!ViewData.ModelState.IsValid && ViewData.ModelState["Minutes"] != null && ViewData.ModelState["Minutes"].Errors.Count > 0)
									{
										

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
                                   Write(Html.ValidationMessageFor(m => m.QuestionViewModel.Minutes, ViewData.ModelState["Minutes"].Errors.FirstOrDefault().ErrorMessage, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
                                                                                                                                                                                                         
									}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t<label for=\"Seconds\">Seconds</label>\r\n\t\t\t\t\t\t\t\t\t<input class=\"form-control\" type=\"text\" id=\"Seconds\" name=\"Seconds\"");
                BeginWriteAttribute("value", " value=\"", 3190, "\"", 3230, 1);
#nullable restore
#line 60 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
WriteAttributeValue("", 3198, Model.QuestionViewModel.Seconds, 3198, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Enter Seconds Duration\">\r\n");
#nullable restore
#line 61 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
                                     if (!ViewData.ModelState.IsValid && ViewData.ModelState["Seconds"] != null && ViewData.ModelState["Seconds"].Errors.Count > 0)
									{
										

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
                                   Write(Html.ValidationMessageFor(m => m.QuestionViewModel.Minutes, ViewData.ModelState["Seconds"].Errors.FirstOrDefault().ErrorMessage, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
                                                                                                                                                                                                         
									}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n");
#nullable restore
#line 67 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
                                     if (!ViewData.ModelState.IsValid && ViewData.ModelState["TimeDuration"] != null && ViewData.ModelState["TimeDuration"].Errors.Count > 0)
									{
										

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
                                   Write(Html.ValidationMessageFor(m => m.QuestionViewModel.TimeDuration, ViewData.ModelState["TimeDuration"].Errors.FirstOrDefault().ErrorMessage, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
                                                                                                                                                                                                                   
									}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t<label for=\"Description\">Should this Question have differnt time duration for options?</label>\r\n\t\t\t\t\t\t\t\t<div class=\"form-control checkbox form-check-inline\">\r\n");
#nullable restore
#line 77 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
                                      
										var OptionTimerChecked = Model.QuestionViewModel.HasOptionsTime ? "checked" : string.Empty;
									

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t\t<input type=\"checkbox\" class=\"mx-2\" id=\"OptionTimerCheckbox\" ");
#nullable restore
#line 80 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
                                                                                            Write(OptionTimerChecked);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"> Yes, Enable Options Timer
									<input type=""hidden"" name=""EnableOptionTimer"" id=""EnableOptionTimer"" />
								</div>
							</div>

							<div id=""timerSection"">
								<label for=""Title"">Options Time</label>
								<div class=""form-group"">
									<label for=""Hours"">Hours</label>
									<input class=""form-control"" type=""text"" id=""OptionHours"" name=""OptionHours""");
                BeginWriteAttribute("value", " value=\"", 4847, "\"", 4891, 1);
#nullable restore
#line 89 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
WriteAttributeValue("", 4855, Model.QuestionViewModel.OptionHours, 4855, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Enter Hours Duration\">\r\n");
#nullable restore
#line 90 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
                                     if (!ViewData.ModelState.IsValid && ViewData.ModelState["OptionHours"] != null && ViewData.ModelState["OptionHours"].Errors.Count > 0)
									{
										

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
                                   Write(Html.ValidationMessageFor(m => m.QuestionViewModel.Hours, ViewData.ModelState["OptionHours"].Errors.FirstOrDefault().ErrorMessage, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
                                                                                                                                                                                                           
									}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t<label for=\"Minutes\">Minutes</label>\r\n\t\t\t\t\t\t\t\t\t<input class=\"form-control\" type=\"text\" id=\"OptionMinutes\" name=\"OptionMinutes\"");
                BeginWriteAttribute("value", " value=\"", 5460, "\"", 5506, 1);
#nullable restore
#line 97 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
WriteAttributeValue("", 5468, Model.QuestionViewModel.OptionMinutes, 5468, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Enter Minutes Duration\">\r\n");
#nullable restore
#line 98 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
                                     if (!ViewData.ModelState.IsValid && ViewData.ModelState["OptionMinutes"] != null && ViewData.ModelState["OptionMinutes"].Errors.Count > 0)
									{
										

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
                                   Write(Html.ValidationMessageFor(m => m.QuestionViewModel.Minutes, ViewData.ModelState["OptionMinutes"].Errors.FirstOrDefault().ErrorMessage, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
                                                                                                                                                                                                               
									}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t<label for=\"OptionSeconds\">Seconds</label>\r\n\t\t\t\t\t\t\t\t\t<input class=\"form-control\" type=\"text\" id=\"OptionSeconds\" name=\"OptionSeconds\"");
                BeginWriteAttribute("value", " value=\"", 6091, "\"", 6137, 1);
#nullable restore
#line 105 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
WriteAttributeValue("", 6099, Model.QuestionViewModel.OptionSeconds, 6099, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Enter Seconds Duration\">\r\n");
#nullable restore
#line 106 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
                                     if (!ViewData.ModelState.IsValid && ViewData.ModelState["OptionSeconds"] != null && ViewData.ModelState["OptionSeconds"].Errors.Count > 0)
									{
										

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
                                   Write(Html.ValidationMessageFor(m => m.QuestionViewModel.Minutes, ViewData.ModelState["OptionSeconds"].Errors.FirstOrDefault().ErrorMessage, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
                                                                                                                                                                                                               
									}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n");
#nullable restore
#line 112 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
                                     if (!ViewData.ModelState.IsValid && ViewData.ModelState["OptionTimeDuration"] != null && ViewData.ModelState["OptionTimeDuration"].Errors.Count > 0)
									{
										

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
                                   Write(Html.ValidationMessageFor(m => m.QuestionViewModel.TimeDuration, ViewData.ModelState["OptionTimeDuration"].Errors.FirstOrDefault().ErrorMessage, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
                                                                                                                                                                                                                         
									}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\r\n");
                WriteLiteral("\r\n");
#nullable restore
#line 177 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
                             if (!ViewData.ModelState.IsValid && ViewData.ModelState["CorrectOptions"] != null && ViewData.ModelState["CorrectOptions"].Errors.Count > 0)
							{
								

#line default
#line hidden
#nullable disable
#nullable restore
#line 179 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
                           Write(Html.ValidationMessageFor(m => m.QuestionViewModel.CorrectOptions, ViewData.ModelState["CorrectOptions"].Errors.FirstOrDefault().ErrorMessage, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 179 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
                                                                                                                                                                                                               
							}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t\t<label><span name=\"optionNoText\">Options</span></label>\r\n\t\t\t\t\t\t\t</div>\r\n\r\n");
#nullable restore
#line 186 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
                             if (Model.QuestionViewModel.Options != null && Model.QuestionViewModel.Options.Count > 0)
							{
								foreach (var option in Model.QuestionViewModel.Options)
								{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t\t<div class=\"option form-group row\">\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"col-6\">\r\n\t\t\t\t\t\t\t\t\t\t\t<div class=\"image-holder pull-left\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<input class=\"txtfield\" type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 10762, "\"", 10829, 2);
                WriteAttributeValue("", 10769, "option", 10769, 6, true);
#nullable restore
#line 193 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
WriteAttributeValue("", 10775, Model.QuestionViewModel.Options.IndexOf(option) + 1, 10775, 54, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 10830, "\"", 10854, 1);
#nullable restore
#line 193 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
WriteAttributeValue("", 10838, option.Image.Id, 10838, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<img");
                BeginWriteAttribute("src", " src=\"", 10874, "\"", 10907, 2);
                WriteAttributeValue("", 10880, "/uploads/", 10880, 9, true);
#nullable restore
#line 194 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
WriteAttributeValue("", 10889, option.Image.Name, 10889, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""img-thumbnail"" style=""height: 300px;"">
											</div>
											<div class=""delete-holder pull-left p-20"">
												<button type=""button"" class=""delete-image btn btn-danger waves-effect waves-light w-md""><i class=""fas fa-trash-alt mg-r-10""></i>&nbsp;Delete</button>
											</div>
											<span class=""error-holder""></span>
											<input class=""image-uploader form-control"" type=""file"" accept="".png,.jpg,.jpeg,.gif,.tif"" />
											<div class=""clearfix""></div>
										</div><label class=""text-right col-3"">Is Option Correct?</label>
										<input class=""form-control col-1"" type=""checkbox""");
                BeginWriteAttribute("name", " name=\"", 11540, "\"", 11616, 2);
                WriteAttributeValue("", 11547, "isoptioncorrect", 11547, 15, true);
#nullable restore
#line 203 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
WriteAttributeValue("", 11562, Model.QuestionViewModel.Options.IndexOf(option) + 1, 11562, 54, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 11617, "\"", 11642, 1);
#nullable restore
#line 203 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
WriteAttributeValue("", 11625, option.IsCorrect, 11625, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 205 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
								}
							}
							else
							{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t<div class=\"option form-group row\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"col-6\">\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"image-holder pull-left\">\r\n\t\t\t\t\t\t\t\t\t\t\t<img");
                BeginWriteAttribute("src", " src=\"", 11845, "\"", 11851, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"txtfield img-thumbnail\" style=\"height: 300px; display:none\">\r\n\t\t\t\t\t\t\t\t\t\t\t<input class=\"txtfield form-control\" type=\"hidden\" name=\"option1\"");
                BeginWriteAttribute("value", " value=\"", 11998, "\"", 12006, 0);
                EndWriteAttribute();
                WriteLiteral(@">
										</div>
										<div class=""delete-holder pull-left p-20"" style=""display: none;"">
											<button type=""button"" class=""delete-image btn btn-danger waves-effect waves-light w-md""><i class=""fas fa-trash-alt mg-r-10""></i>&nbsp;Delete</button>
										</div>
										<span class=""error-holder""></span>
										<input class=""image-uploader form-control"" type=""file"" accept="".png,.jpg,.jpeg,.gif,.tif"" />
										<div class=""clearfix""></div>
									</div>
									<label class=""text-right col-3"">Is Option Correct?</label>
									<input class=""form-control col-1"" type=""checkbox"" name=""isoptioncorrect1"">
								</div>
");
#nullable restore
#line 225 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
							}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t<span id=\"options\"></span>\r\n\r\n");
#nullable restore
#line 229 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
                             if (!ViewData.ModelState.IsValid && ViewData.ModelState["Options"] != null && ViewData.ModelState["Options"].Errors.Count > 0)
							{
								

#line default
#line hidden
#nullable disable
#nullable restore
#line 231 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
                           Write(Html.ValidationMessageFor(m => m.QuestionViewModel.Options, ViewData.ModelState["Options"].Errors.FirstOrDefault().ErrorMessage, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 231 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
                                                                                                                                                                                                 
							}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t<div id=\"actionsRow\">\r\n\t\t\t\t\t\t\t\t<hr />\r\n");
                WriteLiteral(@"								<button type=""button"" id=""addOptionButton"" class=""btn btn-info waves-effect waves-light w-md""><i class=""fas fa-plus mg-r-10""></i>&nbsp;Add Option</button>
								<button type=""submit"" id=""addButton"" class=""btn btn-success waves-effect waves-light w-md""><i class=""fas fa-save mg-r-10""></i>&nbsp;Save this Question and Add Another</button>
								<a");
                BeginWriteAttribute("href", " href=\"", 13628, "\"", 13682, 2);
                WriteAttributeValue("", 13635, "question?quizid=", 13635, 16, true);
#nullable restore
#line 239 "C:\Users\Aakib\OneDrive\Desktop\chch\jsjsjs\ayush\Pages\Admin\add_timed_question.cshtml"
WriteAttributeValue("", 13651, Model.QuestionViewModel.QuizId, 13651, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" role=\"button\" class=\"btn btn-primary waves-effect waves-light w-md\"><i class=\"fas fa-times mg-r-10\"></i>&nbsp;Cancel and Go Back</a>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\t\t\t\t\t\t<div class=\"optionRowTemplateImage\" style=\"display:none\">\r\n\t\t\t\t\t\t\t<div class=\"col-6\">\r\n\t\t\t\t\t\t\t\t<div class=\"image-holder pull-left\">\r\n\t\t\t\t\t\t\t\t\t<input class=\"txtfield form-control\" type=\"hidden\" name=\"optionNo\">\r\n\t\t\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 14838, "\"", 14844, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-thumbnail"" style=""height: 300px; display: none;"">
								</div>
								<div class=""delete-holder pull-left p-20"" style=""display: none;"">
									<button type=""button"" class=""delete-image btn btn-danger waves-effect waves-light w-md""><i class=""fas fa-trash-alt mg-r-10""></i>&nbsp;Delete</button>
								</div>
								<span class=""error-holder""></span>
								<input class=""image-uploader form-control"" type=""file"" accept="".png,.jpg,.jpeg,.gif,.tif"" />
								<div class=""clearfix""></div>
							</div>
							<label class=""text-right col-3"">Is Option Correct?</label>
							<input class=""form-control col-1"" type=""checkbox"" name=""isoptioncorrect"">
						</div>

						<div id=""errorDiv"" style=""display:none"">
							<div class=""m-t-10 alert alert-icon alert-danger alert-dismissible"" role=""alert"">
								<button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
									<span aria-hidden=""true"">×</span>
								</button>
								<i class=""mdi mdi-alert""></i>
				");
            WriteLiteral("\t\t\t\t<span class=\"error-message\">\r\n\t\t\t\t\t\t\t\t</span>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\r\n\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n\r\n");
            DefineSection("JavaScript", async() => {
                WriteLiteral(@"
	<script>
		$(document).ready(function () {

			// Summernote
			$('.textarea').summernote({
				height: 300
			});

			//$(""#addCorrectOptionButton"").click(function () {
			//	AddCorrectOption();
			//});

			$(""#addOptionButton"").click(function () {
				AddOption();
			});

			$(""#OptionTimerCheckbox"").change(function () {
				CheckForTimerSection();
			});

			ImageUploadsListen();
			ImageDeleterListen();

			CheckForTimerSection();
		});

		function CheckForTimerSection() {
			if ($('#OptionTimerCheckbox').is("":checked"")) {
				$('#EnableOptionTimer').val(""true"");
				$(""#timerSection"").show();
			}
			else {
				$('#EnableOptionTimer').val(""false"");
				$(""#timerSection"").hide();
			}
		}

		function ImageUploadsListen() {
			$("".image-uploader"").off('change', ImageUploader).on('change', ImageUploader);
		}

		function ImageDeleterListen() {
			$("".delete-image"").off('click', ImageDeleter).on('click', ImageDeleter);
		}

		function ImageDeleter() {
			$(th");
                WriteLiteral(@"is).parents('.option').remove();
		}

		function ImageUploader() {

			var element = this;

			$(element).prevAll('.image-holder').first().children('.txtfield').val("""");
			$(element).prevAll('.image-holder').first().children('.img-thumbnail').hide();
			$(element).prevAll('.image-holder').first().children('.img-thumbnail').attr('src', '');
			$(element).prevAll('.error-holder').first().html("""");
			$(element).prevAll('.delete-holder').first().hide();

			var formData = new FormData();
			var totalFiles = element.files.length;
			for (var i = 0; i < totalFiles; i++) {
				var file = element.files[i];
				formData.append(""Photo"", file);
			}

			$.ajax({
				type: ""POST"",
				url: '/api/home/uploadimage',
				data: formData,
				dataType: 'json',
				contentType: false,
				processData: false
			}).done(function (data) {
				if (data.success) {
					$(element).prevAll('.image-holder').first().children('.txtfield').val(data.file);
					$(element).prevAll('.image-holder').first().ch");
                WriteLiteral(@"ildren('.img-thumbnail').attr('src', data.imageURL);
					$(element).prevAll('.image-holder').first().children('.img-thumbnail').show();

					$(element).prevAll('.delete-holder').first().show();
				}
				else {
					console.log(data.Message);

					var $error = $('#errorDiv').clone();
					$error.find('.error-message').html(data.Message);
					$error.removeAttr(""id"");
					$(element).prevAll('.error-holder').first().append($error);
					$error.slideDown();
				}
			}).fail(function (xhr, status, errorThrown) {
				console.log(errorThrown);

				var $error = $('#errorDiv').clone();
				$error.find('.error-message').html(errorThrown);
				$error.removeAttr(""id"");
				$(element).prevAll('.error-holder').first().append($error);
				$error.slideDown();
			});
		}

		//function AddCorrectOption() {
		//	$('<div/>', {
		//		'class': 'option form-group', html: GetImageCorrectOptionHtml()
		//	}).hide().insertBefore('#correctOptions').slideDown('slow');

		//	ImageUploadsListen();
		//");
                WriteLiteral(@"	ImageDeleterListen();
		//}

		function AddOption() {
			$('<div/>', {
				'class': 'option form-group row', html: GetImageOptionHtml()
			}).hide().insertBefore('#options').slideDown('slow');

			ImageUploadsListen();
			ImageDeleterListen();
		}

		//function GetImageCorrectOptionHtml() {
		//	var len = $('.option').length + 1;
		//	var $html = $('.correctOptionRowTemplateImage').clone();
		//	$html.find('[name=correctOptionNo]')[0].name = ""correctOptionNo"" + len;
		//	return $html.html();
		//}

		function GetImageOptionHtml() {
			var len = $('.option').length + 1;
			var $html = $('.optionRowTemplateImage').clone();
			$html.find('[name=optionNo]')[0].name = ""optionNo"" + len;
			$html.find('[name=isoptioncorrect]')[0].name = ""isoptioncorrect"" + len;
			return $html.html();
		}

	</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ayush.Pages.Admin.add_timed_questionModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ayush.Pages.Admin.add_timed_questionModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ayush.Pages.Admin.add_timed_questionModel>)PageContext?.ViewData;
        public ayush.Pages.Admin.add_timed_questionModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
