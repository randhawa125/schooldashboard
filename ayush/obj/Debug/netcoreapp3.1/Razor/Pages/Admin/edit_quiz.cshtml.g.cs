#pragma checksum "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\edit_quiz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82fd6af2a7481368961fc2059e605334c883250e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ayush.Pages.Admin.Pages_Admin_edit_quiz), @"mvc.1.0.razor-page", @"/Pages/Admin/edit_quiz.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82fd6af2a7481368961fc2059e605334c883250e", @"/Pages/Admin/edit_quiz.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30a319bf93157485e6034cff29d85f12084656cc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_edit_quiz : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/summernote-bs4.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("operationForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/summernote-bs4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\edit_quiz.cshtml"
  
    ViewData["Title"] = "edit_quiz";
    Layout = "~/Pages/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "82fd6af2a7481368961fc2059e605334c883250e5882", async() => {
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
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row mb-4"">
        <div class=""col-md-12"">
            <div class=""card"">
                <div class=""card-header"">
                    <h1>Edit Quiz</h1>
                </div>
                <div class=""card-body"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82fd6af2a7481368961fc2059e605334c883250e7335", async() => {
                WriteLiteral("\r\n                        <input type=\"hidden\" id=\"ID\" name=\"ID\"");
                BeginWriteAttribute("value", " value=\"", 603, "\"", 624, 1);
#nullable restore
#line 18 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\edit_quiz.cshtml"
WriteAttributeValue("", 611, Model.QuizId, 611, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <div class=\"form-group\">\r\n                            <label for=\"Title\">Quiz Name</label>\r\n                            <input class=\"form-control\" type=\"text\" id=\"Name\" name=\"Name\"");
                BeginWriteAttribute("value", " value=\"", 835, "\"", 868, 1);
#nullable restore
#line 21 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\edit_quiz.cshtml"
WriteAttributeValue("", 843, Model.QuizViewModel.Name, 843, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Enter quiz name\">\r\n");
#nullable restore
#line 22 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\edit_quiz.cshtml"
                             if (!ViewData.ModelState.IsValid && ViewData.ModelState["Name"] != null && ViewData.ModelState["Name"].Errors.Count > 0)
                            {

                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\edit_quiz.cshtml"
                           Write(Html.ValidationMessageFor(m => m.QuizViewModel.Name, ViewData.ModelState["Name"].Errors.FirstOrDefault().ErrorMessage, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\edit_quiz.cshtml"
                                                                                                                                                                                       
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </div>
                        <div class=""form-group"">
                            <label for=""Description"">Description</label>
                            <textarea class=""form-control textarea"" name=""Description"" placeholder=""Enter some Description about this quiz"" rows=""4"">");
#nullable restore
#line 30 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\edit_quiz.cshtml"
                                                                                                                                                Write(Model.QuizViewModel.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\r\n");
#nullable restore
#line 31 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\edit_quiz.cshtml"
                             if (!ViewData.ModelState.IsValid && ViewData.ModelState["Description"] != null && ViewData.ModelState["Description"].Errors.Count > 0)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\edit_quiz.cshtml"
                           Write(Html.ValidationMessageFor(m => m.QuizViewModel.Description, ViewData.ModelState["Description"].Errors.FirstOrDefault().ErrorMessage, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\edit_quiz.cshtml"
                                                                                                                                                                                                     
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </div>
                        <div class=""form-group"">
                            <label for=""Description"">Should this Quiz be taken in a timely manner?</label>
                            <div class=""form-control checkbox form-check-inline"">
");
#nullable restore
#line 39 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\edit_quiz.cshtml"
                                  
                                    var quizTimerChecked = Model.QuizViewModel.EnableQuizTimer ? "checked" : string.Empty;
                                

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <input type=\"checkbox\" class=\"mx-2\" id=\"QuizTimerCheckbox\" ");
#nullable restore
#line 42 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\edit_quiz.cshtml"
                                                                                      Write(quizTimerChecked);

#line default
#line hidden
#nullable disable
                WriteLiteral("> Yes, Enable Quiz Timer\r\n                                <input type=\"hidden\" name=\"EnableQuizTimer\" id=\"EnableQuizTimer\" />\r\n                            </div>\r\n");
#nullable restore
#line 45 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\edit_quiz.cshtml"
                             if (!ViewData.ModelState.IsValid && ViewData.ModelState["EnableQuizTimer"] != null && ViewData.ModelState["EnableQuizTimer"].Errors.Count > 0)
                            {

                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\edit_quiz.cshtml"
                           Write(Html.ValidationMessageFor(m => m.QuizViewModel.EnableQuizTimer, ViewData.ModelState["EnableQuizTimer"].Errors.FirstOrDefault().ErrorMessage, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\edit_quiz.cshtml"
                                                                                                                                                                                                             
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </div>
                        <div id=""timerSection"">
                            <div class=""form-group"">
                                <label for=""Hours"">Hours</label>
                                <input class=""form-control"" type=""text"" id=""Hours"" name=""Hours""");
                BeginWriteAttribute("value", " value=\"", 3557, "\"", 3591, 1);
#nullable restore
#line 54 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\edit_quiz.cshtml"
WriteAttributeValue("", 3565, Model.QuizViewModel.Hours, 3565, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Enter Hours Duration\">\r\n");
#nullable restore
#line 55 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\edit_quiz.cshtml"
                                 if (!ViewData.ModelState.IsValid && ViewData.ModelState["Hours"] != null && ViewData.ModelState["Hours"].Errors.Count > 0)
                                {

                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\edit_quiz.cshtml"
                               Write(Html.ValidationMessageFor(m => m.QuizViewModel.Hours, ViewData.ModelState["Hours"].Errors.FirstOrDefault().ErrorMessage, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\edit_quiz.cshtml"
                                                                                                                                                                                             
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </div>
                            <div class=""form-group"">
                                <label for=""Minutes"">Minutes</label>
                                <input class=""form-control"" type=""text"" id=""Minutes"" name=""Minutes""");
                BeginWriteAttribute("value", " value=\"", 4309, "\"", 4345, 1);
#nullable restore
#line 63 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\edit_quiz.cshtml"
WriteAttributeValue("", 4317, Model.QuizViewModel.Minutes, 4317, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Enter Minutes Duration\">\r\n");
#nullable restore
#line 64 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\edit_quiz.cshtml"
                                 if (!ViewData.ModelState.IsValid && ViewData.ModelState["Minutes"] != null && ViewData.ModelState["Minutes"].Errors.Count > 0)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\edit_quiz.cshtml"
                               Write(Html.ValidationMessageFor(m => m.QuizViewModel.Minutes, ViewData.ModelState["Minutes"].Errors.FirstOrDefault().ErrorMessage, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\edit_quiz.cshtml"
                                                                                                                                                                                                 
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </div>\r\n                            <div class=\"form-group\">\r\n");
#nullable restore
#line 70 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\edit_quiz.cshtml"
                                 if (!ViewData.ModelState.IsValid && ViewData.ModelState["TimeDuration"] != null && ViewData.ModelState["TimeDuration"].Errors.Count > 0)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\edit_quiz.cshtml"
                               Write(Html.ValidationMessageFor(m => m.QuizViewModel.TimeDuration, ViewData.ModelState["TimeDuration"].Errors.FirstOrDefault().ErrorMessage, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\edit_quiz.cshtml"
                                                                                                                                                                                                           
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </div>
                            <div class=""form-group"">
                                <label for=""Description"">Do you want to enable each Question Timer?</label>
                                <div class=""form-control checkbox form-check-inline"">
");
#nullable restore
#line 78 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\edit_quiz.cshtml"
                                      
                                        var questionTimerChecked = Model.QuizViewModel.EnableQuestionTimer ? "checked" : string.Empty;
                                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <input type=\"checkbox\" class=\"mx-2\" id=\"EnableQuestionTimer\" name=\"EnableQuestionTimer\" value=\"true\" ");
#nullable restore
#line 81 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\edit_quiz.cshtml"
                                                                                                                                    Write(questionTimerChecked);

#line default
#line hidden
#nullable disable
                WriteLiteral("> Yes, Enable Question Timer\r\n                                </div>\r\n");
#nullable restore
#line 83 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\edit_quiz.cshtml"
                                 if (!ViewData.ModelState.IsValid && ViewData.ModelState["EnableQuestionTimer"] != null && ViewData.ModelState["EnableQuestionTimer"].Errors.Count > 0)
                                {

                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\edit_quiz.cshtml"
                               Write(Html.ValidationMessageFor(m => m.QuizViewModel.EnableQuestionTimer, ViewData.ModelState["EnableQuestionTimer"].Errors.FirstOrDefault().ErrorMessage, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\edit_quiz.cshtml"
                                                                                                                                                                                                                         
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </div>
                        </div>
                        <hr />
                        <button type=""submit"" id=""updateButton"" class=""btn btn-warning waves-effect waves-light w-md""><i class=""fas fa-save mg-r-10""></i>&nbsp;Update this Quiz</button>
                        <button type=""button"" class=""btn btn-danger"" data-toggle=""modal"" data-target=""#deleteModal""><i class=""fas fa-trash-alt mg-r-10""></i>&nbsp;Delete this Quiz</button>
                        <a");
                BeginWriteAttribute("href", " href=\"", 7054, "\"", 7090, 2);
                WriteAttributeValue("", 7061, "question?quizid=", 7061, 16, true);
#nullable restore
#line 93 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\edit_quiz.cshtml"
WriteAttributeValue("", 7077, Model.QuizId, 7077, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" role=\"button\" class=\"btn btn-info waves-effect waves-light w-md\"><i class=\"fas fa-list-ul mg-r-10\"></i>&nbsp;Questions from this Quiz</a>\r\n\r\n");
#nullable restore
#line 95 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\edit_quiz.cshtml"
                         if (Model.QuizViewModel.NoOfQuestions > 0)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <a href=\"#\" role=\"button\" class=\"btn btn-primary waves-effect waves-light w-md\"><i class=\"fas fa-certificate mg-r-10\"></i>&nbsp;Attempt this Quiz</a>\r\n");
#nullable restore
#line 98 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\edit_quiz.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a href=\"quizzes\" role=\"button\" class=\"btn btn-primary waves-effect waves-light w-md\"><i class=\"fas fa-times mg-r-10\"></i>&nbsp;Cancel and Go Back</a>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
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

<div id=""deleteModal"" class=""modal fade"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content tx-size-sm"">
            <div class=""modal-body tx-center pd-y-20 pd-x-20"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
                <i class=""icon icon ion-android-warning tx-100 tx-warning lh-1 mg-t-20 d-inline-block""></i>
                <h4 class=""tx-warning tx-semibold mg-b-20"">Warning!</h4>
                <p class=""mg-b-20 mg-x-20"">Are you sure you want to delete this record? This will not be reversible.</p>
                <button type=""button"" id=""deleteButton"" class=""btn btn-danger mg-b-20"" data-toggle=""modal"" data-dismiss=""modal""><i class=""fas fa-trash-alt mg-r-10""></i>&nbsp;Delete</button>
                <button type=""button"" class=""btn btn-primar");
            WriteLiteral("y mg-b-20\" data-toggle=\"modal\" data-dismiss=\"modal\"><i class=\"fas fa-times mg-r-10\"></i>&nbsp;Cancel</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82fd6af2a7481368961fc2059e605334c883250e26346", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82fd6af2a7481368961fc2059e605334c883250e27386", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    $(function () {
        // Summernote
        $('.textarea').summernote({
            height: 300
        });

    })
</script>
<script>
	$(document).ready(function () {
		CheckForTimerSection();

		$(""#updateButton"").click(function () {
			$(""#operationForm"").attr(""action"", ""edit_quiz?quizid=");
#nullable restore
#line 140 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\edit_quiz.cshtml"
                                                            Write(Model.QuizId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n\t\t\t$(\"#operationForm\").submit();\r\n\t\t});\r\n\t\t$(\"#deleteButton\").click(function () {\r\n\t\t\t$(\"#operationForm\").attr(\"action\", \"edit_quiz?handler=DeleteQuiz&quizId=");
#nullable restore
#line 144 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Admin\edit_quiz.cshtml"
                                                                               Write(Model.QuizId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""");
			$(""#operationForm"").submit();
		});

		$(""#QuizTimerCheckbox"").change(function () {
			CheckForTimerSection();
		});
	});

	function CheckForTimerSection() {
		if ($('#QuizTimerCheckbox').is("":checked"")) {
			$('#EnableQuizTimer').val(""true"");
			$(""#timerSection"").show();
		}
		else {
			$('#EnableQuizTimer').val(""false"");
			$(""#timerSection"").hide();
		}
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ayush.edit_quizModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ayush.edit_quizModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ayush.edit_quizModel>)PageContext?.ViewData;
        public ayush.edit_quizModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
