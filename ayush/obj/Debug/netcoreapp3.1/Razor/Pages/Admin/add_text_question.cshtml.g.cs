#pragma checksum "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_text_question.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9755fe8f495668d2ea2eead9610999b6c52cceaa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ayush.Pages.Admin.Pages_Admin_add_text_question), @"mvc.1.0.razor-page", @"/Pages/Admin/add_text_question.cshtml")]
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
#line 1 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\_ViewImports.cshtml"
using ayush;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9755fe8f495668d2ea2eead9610999b6c52cceaa", @"/Pages/Admin/add_text_question.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30a319bf93157485e6034cff29d85f12084656cc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_add_text_question : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 3 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_text_question.cshtml"
  
	ViewData["Title"] = "add_question";
	Layout = "~/Pages/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n\t<div class=\"row\">\r\n\t\t<div class=\"col-sm-12\">\r\n\t\t\t<div class=\"card\">\r\n\t\t\t\t<div class=\"card-header\">\r\n\t\t\t\t\t<h1>Add New Text Question</h1>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9755fe8f495668d2ea2eead9610999b6c52cceaa4608", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t<input type=\"hidden\" id=\"QuizID\" name=\"QuizID\"");
                BeginWriteAttribute("value", " value=\"", 455, "\"", 494, 1);
#nullable restore
#line 17 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_text_question.cshtml"
WriteAttributeValue("", 463, Model.QuestionViewModel.QuizId, 463, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t<label for=\"Title\">Question Title</label>\r\n");
                WriteLiteral("\t\t\t\t\t\t\t<textarea class=\"textarea\" placeholder=\"Place some text here\" name=\"Title\" id=\"Title\"\r\n\t\t\t\t\t\t\t\t\t  style=\"width: 100%; height: 200px; font-size: 14px; line-height: 18px; border: 1px solid #dddddd; padding: 10px;\">\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 24 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_text_question.cshtml"
                       Write(Model.QuestionViewModel.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\r\n\r\n");
#nullable restore
#line 26 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_text_question.cshtml"
                             if (!ViewData.ModelState.IsValid && ViewData.ModelState["Title"] != null && ViewData.ModelState["Title"].Errors.Count > 0)
							{

								

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_text_question.cshtml"
                           Write(Html.ValidationMessageFor(m => m.QuestionViewModel.Title, ViewData.ModelState["Title"].Errors.FirstOrDefault().ErrorMessage, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_text_question.cshtml"
                                                                                                                                                                                             
							}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t</div>\r\n\r\n");
                WriteLiteral("\r\n");
#nullable restore
#line 55 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_text_question.cshtml"
                             if (!ViewData.ModelState.IsValid && ViewData.ModelState["CorrectOptions"] != null && ViewData.ModelState["CorrectOptions"].Errors.Count > 0)
							{
								

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_text_question.cshtml"
                           Write(Html.ValidationMessageFor(m => m.QuestionViewModel.CorrectOptions, ViewData.ModelState["CorrectOptions"].Errors.FirstOrDefault().ErrorMessage, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_text_question.cshtml"
                                                                                                                                                                                                               
							}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t<label><span name=\"optionNoText\">Options</span></label>\r\n\t\t\t\t\t\t</div>\r\n\r\n");
#nullable restore
#line 64 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_text_question.cshtml"
                         if (Model.QuestionViewModel.Options != null && Model.QuestionViewModel.Options.Count > 0)
						{
							foreach (var option in Model.QuestionViewModel.Options)
							{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t<div class=\"option form-group row\">\r\n\t\t\t\t\t\t\t\t\t<input class=\"form-control col-6\" type=\"text\"");
                BeginWriteAttribute("name", " name=\"", 2934, "\"", 3001, 2);
                WriteAttributeValue("", 2941, "option", 2941, 6, true);
#nullable restore
#line 69 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_text_question.cshtml"
WriteAttributeValue("", 2947, Model.QuestionViewModel.Options.IndexOf(option) + 2, 2947, 54, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Enter Other Option\"");
                BeginWriteAttribute("value", " value=\"", 3035, "\"", 3057, 1);
#nullable restore
#line 69 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_text_question.cshtml"
WriteAttributeValue("", 3043, option.Answer, 3043, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t<label class=\"text-right col-3\">Is Option Correct?</label>\r\n\t\t\t\t\t\t\t\t\t<input class=\"form-control col-1\" type=\"checkbox\"");
                BeginWriteAttribute("name", " name=\"", 3188, "\"", 3264, 2);
                WriteAttributeValue("", 3195, "isoptioncorrect", 3195, 15, true);
#nullable restore
#line 71 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_text_question.cshtml"
WriteAttributeValue("", 3210, Model.QuestionViewModel.Options.IndexOf(option) + 2, 3210, 54, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3265, "\"", 3290, 1);
#nullable restore
#line 71 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_text_question.cshtml"
WriteAttributeValue("", 3273, option.IsCorrect, 3273, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 73 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_text_question.cshtml"
							}
						}
						else
						{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t<div class=\"option form-group row\">\r\n\t\t\t\t\t\t\t\t<input class=\"form-control col-6\" type=\"text\" name=\"option1\" placeholder=\"Enter Other Option\"");
                BeginWriteAttribute("value", " value=\"", 3495, "\"", 3503, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t\t\t<label class=\"text-right col-3\">Is Option Correct?</label>\r\n\t\t\t\t\t\t\t\t<input class=\"form-control col-1\" type=\"checkbox\" name=\"isoptioncorrect1\">\r\n\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 82 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_text_question.cshtml"
						}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t<span id=\"options\"></span>\r\n\r\n");
#nullable restore
#line 86 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_text_question.cshtml"
                         if (!ViewData.ModelState.IsValid && ViewData.ModelState["Options"] != null && ViewData.ModelState["Options"].Errors.Count > 0)
						{

							

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_text_question.cshtml"
                       Write(Html.ValidationMessageFor(m => m.QuestionViewModel.Options, ViewData.ModelState["Options"].Errors.FirstOrDefault().ErrorMessage, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_text_question.cshtml"
                                                                                                                                                                                             
						}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t<div id=\"actionsRow\">\r\n\t\t\t\t\t\t\t<hr />\r\n");
                WriteLiteral(@"							<button type=""button"" id=""addOptionButton"" class=""btn btn-info waves-effect waves-light w-md""><i class=""fas fa-plus mg-r-10""></i>&nbsp;Add Option</button>
							<button type=""submit"" id=""addButton"" class=""btn btn-success waves-effect waves-light w-md""><i class=""fas fa-save mg-r-10""></i>&nbsp;Save this Question and Add Another</button>
							<a");
                BeginWriteAttribute("href", " href=\"", 4630, "\"", 4666, 2);
                WriteAttributeValue("", 4637, "question?quizId=", 4637, 16, true);
#nullable restore
#line 97 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_text_question.cshtml"
WriteAttributeValue("", 4653, Model.QuizId, 4653, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" role=\"button\" class=\"btn btn-primary waves-effect waves-light w-md\"><i class=\"fas fa-times mg-r-10\"></i>&nbsp;Cancel and Go Back</a>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t");
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
            WriteLiteral(@"


					<div class=""correctOptionRowTemplate"" style=""display:none"">
						<input class=""form-control"" type=""text"" name=""correctOptionNo"" placeholder=""Enter Correct Option"">
					</div>

					<div class=""optionRowTemplate"" style=""display:none"">
						<input class=""form-control col-6"" type=""text"" name=""optionNo"" placeholder=""Enter Option"">
						<label class=""text-right col-3"">Is Option Correct?</label>
						<input class=""form-control col-1"" type=""checkbox"" name=""isoptioncorrect"">
					</div>


				</div>
			</div>
		</div>
	</div>
</div>

");
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
		});

		//function AddCorrectOption() {
		//	$('<div/>', {
		//		'class': 'option form-group', html: GetCorrectOptionHtml()
		//	}).hide().insertBefore('#correctOptions').slideDown('slow');
		//}

		function AddOption() {
			$('<div/>', {
				'class': 'option form-group row', html: GetOptionHtml()
			}).hide().insertBefore('#options').slideDown('slow');
		}

		//function GetCorrectOptionHtml() {
		//	var len = $('.option').length + 1;
		//	var $html = $('.correctOptionRowTemplate').clone();
		//	$html.find('[name=correctOptionNo]')[0].name = ""correctOptionNo"" + len;
		//	return $html.html();
		//}

		function GetOptionHtml() {
			var len = $('.option').length + 1;
			var $html = $('.optionRowTempla");
                WriteLiteral("te\').clone();\r\n\t\t\t$html.find(\'[name=optionNo]\')[0].name = \"optionNo\" + len;\r\n\t\t\t$html.find(\'[name=isoptioncorrect]\')[0].name = \"isoptioncorrect\" + len;\r\n\t\t\treturn $html.html();\r\n\t\t}\r\n\t</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ayush.add_questionModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ayush.add_questionModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ayush.add_questionModel>)PageContext?.ViewData;
        public ayush.add_questionModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
