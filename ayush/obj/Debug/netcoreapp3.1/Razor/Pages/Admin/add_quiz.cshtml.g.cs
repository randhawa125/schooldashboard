#pragma checksum "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\add_quiz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98ab59ba216193787dce76219521c777d9347b97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ayush.Pages.Admin.Pages_Admin_add_quiz), @"mvc.1.0.razor-page", @"/Pages/Admin/add_quiz.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98ab59ba216193787dce76219521c777d9347b97", @"/Pages/Admin/add_quiz.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"780f75cdb21e45cdf2691da819d8b5f5fbb8c766", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_add_quiz : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("operationForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\add_quiz.cshtml"
  
    ViewData["Title"] = "add_quiz";
    Layout = "~/Pages/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row mb-4"">
        <div class=""col-md-12"">
            <div class=""card"">
                <div class=""card-header"">
                    <h1>Add New Quiz</h1>
                </div>
                <div class=""card-body"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98ab59ba216193787dce76219521c777d9347b975294", async() => {
                WriteLiteral("\n                        <div class=\"form-group\">\n                            <label for=\"Title\">Quiz Name</label>\n                            <input class=\"form-control\" type=\"text\" id=\"Name\" name=\"Name\"");
                BeginWriteAttribute("value", " value=\"", 668, "\"", 701, 1);
#nullable restore
#line 19 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\add_quiz.cshtml"
WriteAttributeValue("", 676, Model.QuizViewModel.Name, 676, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Enter quiz name\">\n\t\t\t\t\t\t\t\n");
#nullable restore
#line 21 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\add_quiz.cshtml"
                             if (!ViewData.ModelState.IsValid && ViewData.ModelState["Name"] != null && ViewData.ModelState["Name"].Errors.Count > 0)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\add_quiz.cshtml"
                           Write(Html.ValidationMessageFor(m => m.QuizViewModel.Name, ViewData.ModelState["Name"].Errors.FirstOrDefault().ErrorMessage, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\add_quiz.cshtml"
                                                                                                                                                                                       
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </div>
                        <div class=""form-group"">
                            <label for=""Description"">Description</label>
                            <textarea class=""form-control"" name=""Description"" placeholder=""Enter some Description about this quiz"" rows=""4"">");
#nullable restore
#line 28 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\add_quiz.cshtml"
                                                                                                                                       Write(Model.QuizViewModel.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\n");
#nullable restore
#line 29 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\add_quiz.cshtml"
                             if (!ViewData.ModelState.IsValid && ViewData.ModelState["Description"] != null && ViewData.ModelState["Description"].Errors.Count > 0)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\add_quiz.cshtml"
                           Write(Html.ValidationMessageFor(m => m.QuizViewModel.Description, ViewData.ModelState["Description"].Errors.FirstOrDefault().ErrorMessage, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\add_quiz.cshtml"
                                                                                                                                                                                                     
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
#line 37 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\add_quiz.cshtml"
                                  
                                    var quizTimerChecked = Model.QuizViewModel.EnableQuizTimer ? "checked" : string.Empty;
                                

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <input type=\"checkbox\" class=\"mx-2\" id=\"QuizTimerCheckbox\" ");
#nullable restore
#line 40 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\add_quiz.cshtml"
                                                                                      Write(quizTimerChecked);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"> Yes, Enable Quiz Timer
                                <input type=""hidden"" name=""EnableQuizTimer"" id=""EnableQuizTimer"" />
                            </div>
                        </div>
                        <div id=""timerSection"">
                            <div class=""form-group"">
                                <label for=""Hours"">Hours</label>
                                <input class=""form-control"" type=""text"" id=""Hours"" name=""Hours""");
                BeginWriteAttribute("value", " value=\"", 2916, "\"", 2950, 1);
#nullable restore
#line 47 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\add_quiz.cshtml"
WriteAttributeValue("", 2924, Model.QuizViewModel.Hours, 2924, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Enter Hours Duration\">\n");
#nullable restore
#line 48 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\add_quiz.cshtml"
                                 if (!ViewData.ModelState.IsValid && ViewData.ModelState["Hours"] != null && ViewData.ModelState["Hours"].Errors.Count > 0)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\add_quiz.cshtml"
                               Write(Html.ValidationMessageFor(m => m.QuizViewModel.Hours, ViewData.ModelState["Hours"].Errors.FirstOrDefault().ErrorMessage, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\add_quiz.cshtml"
                                                                                                                                                                                             
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </div>
                            <div class=""form-group"">
                                <label for=""Minutes"">Minutes</label>
                                <input class=""form-control"" type=""text"" id=""Minutes"" name=""Minutes""");
                BeginWriteAttribute("value", " value=\"", 3658, "\"", 3694, 1);
#nullable restore
#line 55 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\add_quiz.cshtml"
WriteAttributeValue("", 3666, Model.QuizViewModel.Minutes, 3666, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Enter Minutes Duration\">\n");
#nullable restore
#line 56 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\add_quiz.cshtml"
                                 if (!ViewData.ModelState.IsValid && ViewData.ModelState["Minutes"] != null && ViewData.ModelState["Minutes"].Errors.Count > 0)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\add_quiz.cshtml"
                               Write(Html.ValidationMessageFor(m => m.QuizViewModel.Minutes, ViewData.ModelState["Minutes"].Errors.FirstOrDefault().ErrorMessage, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\add_quiz.cshtml"
                                                                                                                                                                                                 
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </div>\n                            <div class=\"form-group\">\n");
#nullable restore
#line 62 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\add_quiz.cshtml"
                                 if (!ViewData.ModelState.IsValid && ViewData.ModelState["TimeDuration"] != null && ViewData.ModelState["TimeDuration"].Errors.Count > 0)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\add_quiz.cshtml"
                               Write(Html.ValidationMessageFor(m => m.QuizViewModel.TimeDuration, ViewData.ModelState["TimeDuration"].Errors.FirstOrDefault().ErrorMessage, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\add_quiz.cshtml"
                                                                                                                                                                                                           
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
#line 70 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\add_quiz.cshtml"
                                      
                                        var questionTimerChecked = Model.QuizViewModel.EnableQuestionTimer ? "checked" : string.Empty;
                                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <input type=\"checkbox\" class=\"mx-2\" id=\"EnableQuestionTimer\" name=\"EnableQuestionTimer\" value=\"true\" ");
#nullable restore
#line 73 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\add_quiz.cshtml"
                                                                                                                                    Write(questionTimerChecked);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"> Yes, Enable Question Timer
                                </div>
                            </div>
                        </div>
                        <hr />
                        <button type=""submit"" id=""addButton"" class=""btn btn-success waves-effect waves-light w-md""><i class=""fas fa-save mg-r-10""></i>&nbsp;Save Quiz and Start Adding Questions</button>
                        <a href=""quizzes"" role=""button"" class=""btn btn-primary waves-effect waves-light w-md""><i class=""fas fa-times mg-r-10""></i>&nbsp;Cancel and Go Back</a>
                    ");
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
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98ab59ba216193787dce76219521c777d9347b9720164", async() => {
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
            WriteLiteral(@"
<script>
	$(document).ready(function () {
		CheckForTimerSection();

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ayush.add_quizModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ayush.add_quizModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ayush.add_quizModel>)PageContext?.ViewData;
        public ayush.add_quizModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
