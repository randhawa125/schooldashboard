#pragma checksum "D:\UpdateFreelance\ayush\Pages\Admin\edit_text_question.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27ea17b4fda198f8612199fdb9604f6d5c647faf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ayush.Pages.Admin.Pages_Admin_edit_text_question), @"mvc.1.0.razor-page", @"/Pages/Admin/edit_text_question.cshtml")]
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
#line 1 "D:\UpdateFreelance\ayush\Pages\_ViewImports.cshtml"
using ayush;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27ea17b4fda198f8612199fdb9604f6d5c647faf", @"/Pages/Admin/edit_text_question.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30a319bf93157485e6034cff29d85f12084656cc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_edit_text_question : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\UpdateFreelance\ayush\Pages\Admin\edit_text_question.cshtml"
  
	ViewData["Title"] = "edit_question";
	Layout = "~/Pages/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container-fluid\">\r\n\t<div class=\"row\">\r\n\t\t<div class=\"col-sm-12\">\r\n\t\t\t<div class=\"card\">\r\n\t\t\t\t<div class=\"card-header\">\r\n\t\t\t\t\t<h1>Edit Question</h1>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"card-body\">\r\n\r\n\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27ea17b4fda198f8612199fdb9604f6d5c647faf4695", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t<input type=\"hidden\" id=\"ID\" name=\"ID\"");
                BeginWriteAttribute("value", " value=\"", 554, "\"", 589, 1);
#nullable restore
#line 19 "D:\UpdateFreelance\ayush\Pages\Admin\edit_text_question.cshtml"
WriteAttributeValue("", 562, Model.QuestionViewModel.ID, 562, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\t\t\t\t\t\t<input type=\"hidden\" id=\"QuizID\" name=\"QuizID\"");
                BeginWriteAttribute("value", " value=\"", 647, "\"", 686, 1);
#nullable restore
#line 20 "D:\UpdateFreelance\ayush\Pages\Admin\edit_text_question.cshtml"
WriteAttributeValue("", 655, Model.QuestionViewModel.QuizID, 655, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t<label for=\"Title\">Question Title</label>\r\n");
                WriteLiteral("\t\t\t\t\t\t\t<textarea class=\"textarea\" placeholder=\"Place some text here\" name=\"Title\" id=\"Title\"\r\n\t\t\t\t\t\t\t\t\t  style=\"width: 100%; height: 200px; font-size: 14px; line-height: 18px; border: 1px solid #dddddd; padding: 10px;\">\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 27 "D:\UpdateFreelance\ayush\Pages\Admin\edit_text_question.cshtml"
                       Write(Model.QuestionViewModel.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\r\n");
#nullable restore
#line 28 "D:\UpdateFreelance\ayush\Pages\Admin\edit_text_question.cshtml"
                             if (!ViewData.ModelState.IsValid && ViewData.ModelState["Title"] != null && ViewData.ModelState["Title"].Errors.Count > 0)
							{
								

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\UpdateFreelance\ayush\Pages\Admin\edit_text_question.cshtml"
                           Write(Html.ValidationMessageFor(m => m.QuestionViewModel.Title, ViewData.ModelState["Title"].Errors.FirstOrDefault().ErrorMessage, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\UpdateFreelance\ayush\Pages\Admin\edit_text_question.cshtml"
                                                                                                                                                                                             
							}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t</div>\r\n\r\n");
                WriteLiteral("\r\n");
#nullable restore
#line 56 "D:\UpdateFreelance\ayush\Pages\Admin\edit_text_question.cshtml"
                         if (!ViewData.ModelState.IsValid && ViewData.ModelState["CorrectOptions"] != null && ViewData.ModelState["CorrectOptions"].Errors.Count > 0)
						{

							

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "D:\UpdateFreelance\ayush\Pages\Admin\edit_text_question.cshtml"
                       Write(Html.ValidationMessageFor(m => m.QuestionViewModel.CorrectOptions, ViewData.ModelState["CorrectOptions"].Errors.FirstOrDefault().ErrorMessage, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "D:\UpdateFreelance\ayush\Pages\Admin\edit_text_question.cshtml"
                                                                                                                                                                                                           
						}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t<label><span name=\"optionNoText\">Options</span></label>\r\n\t\t\t\t\t\t</div>\r\n\r\n");
#nullable restore
#line 66 "D:\UpdateFreelance\ayush\Pages\Admin\edit_text_question.cshtml"
                         if (Model.QuestionViewModel.Options != null && Model.QuestionViewModel.Options.Count > 0)
						{
							foreach (var option in Model.QuestionViewModel.Options)
							{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t<div class=\"option form-group row\">\r\n\t\t\t\t\t\t\t\t\t<input class=\"form-control col-6\" type=\"text\"");
                BeginWriteAttribute("name", " name=\"", 3120, "\"", 3187, 2);
                WriteAttributeValue("", 3127, "option", 3127, 6, true);
#nullable restore
#line 71 "D:\UpdateFreelance\ayush\Pages\Admin\edit_text_question.cshtml"
WriteAttributeValue("", 3133, Model.QuestionViewModel.Options.IndexOf(option) + 1, 3133, 54, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Enter Other Option\"");
                BeginWriteAttribute("value", " value=\"", 3221, "\"", 3243, 1);
#nullable restore
#line 71 "D:\UpdateFreelance\ayush\Pages\Admin\edit_text_question.cshtml"
WriteAttributeValue("", 3229, option.Answer, 3229, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t<label class=\"text-right col-3\">Is Option Correct?</label>\r\n");
#nullable restore
#line 73 "D:\UpdateFreelance\ayush\Pages\Admin\edit_text_question.cshtml"
                                     if (option.IsCorrect)
									{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t\t\t<input class=\"form-control col-1\" type=\"checkbox\"");
                BeginWriteAttribute("name", " name=\"", 3420, "\"", 3496, 2);
                WriteAttributeValue("", 3427, "isoptioncorrect", 3427, 15, true);
#nullable restore
#line 75 "D:\UpdateFreelance\ayush\Pages\Admin\edit_text_question.cshtml"
WriteAttributeValue("", 3442, Model.QuestionViewModel.Options.IndexOf(option) + 1, 3442, 54, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" checked=\"checked\">\r\n");
#nullable restore
#line 76 "D:\UpdateFreelance\ayush\Pages\Admin\edit_text_question.cshtml"
									}
									else
									{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t\t\t<input class=\"form-control col-1\" type=\"checkbox\"");
                BeginWriteAttribute("name", " name=\"", 3616, "\"", 3692, 2);
                WriteAttributeValue("", 3623, "isoptioncorrect", 3623, 15, true);
#nullable restore
#line 79 "D:\UpdateFreelance\ayush\Pages\Admin\edit_text_question.cshtml"
WriteAttributeValue("", 3638, Model.QuestionViewModel.Options.IndexOf(option) + 1, 3638, 54, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 80 "D:\UpdateFreelance\ayush\Pages\Admin\edit_text_question.cshtml"
									}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 83 "D:\UpdateFreelance\ayush\Pages\Admin\edit_text_question.cshtml"
							}
						}
						else
						{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t<div class=\"option form-group row\">\r\n\t\t\t\t\t\t\t\t<input class=\"form-control col-6\" type=\"text\" name=\"option1\" placeholder=\"Enter Other Option\"");
                BeginWriteAttribute("value", " value=\"", 3911, "\"", 3919, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t\t\t<label class=\"text-right col-3\">Is Option Correct?</label>\r\n\t\t\t\t\t\t\t\t<input class=\"form-control col-1\" type=\"checkbox\" name=\"isoptioncorrect1\">\r\n\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 92 "D:\UpdateFreelance\ayush\Pages\Admin\edit_text_question.cshtml"
						}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t<span id=\"options\"></span>\r\n\r\n");
#nullable restore
#line 96 "D:\UpdateFreelance\ayush\Pages\Admin\edit_text_question.cshtml"
                         if (!ViewData.ModelState.IsValid && ViewData.ModelState["Options"] != null && ViewData.ModelState["Options"].Errors.Count > 0)
						{

							

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "D:\UpdateFreelance\ayush\Pages\Admin\edit_text_question.cshtml"
                       Write(Html.ValidationMessageFor(m => m.QuestionViewModel.Options, ViewData.ModelState["Options"].Errors.FirstOrDefault().ErrorMessage, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "D:\UpdateFreelance\ayush\Pages\Admin\edit_text_question.cshtml"
                                                                                                                                                                                             
						}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t<div id=\"actionsRow\">\r\n\t\t\t\t\t\t\t<hr />\r\n");
                WriteLiteral(@"							<button type=""button"" id=""addOptionButton"" class=""btn btn-info waves-effect waves-light w-md""><i class=""fas fa-plus mg-r-10""></i>&nbsp;Add Option</button>
							<button type=""submit"" id=""updateButton"" class=""btn btn-warning""><i class=""fas fa-save mg-r-10""></i>&nbsp;Update this Question and Go Back</button>
							<button type=""button"" class=""btn btn-danger"" data-toggle=""modal"" data-target=""#deleteModal""><i class=""fas fa-trash-alt mg-r-10""></i>&nbsp;Delete this Question</button>
							<a");
                BeginWriteAttribute("href", " href=\"", 5193, "\"", 5247, 2);
                WriteAttributeValue("", 5200, "question?quizId=", 5200, 16, true);
#nullable restore
#line 108 "D:\UpdateFreelance\ayush\Pages\Admin\edit_text_question.cshtml"
WriteAttributeValue("", 5216, Model.QuestionViewModel.QuizID, 5216, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" role=\"button\" class=\"btn btn-primary waves-effect waves-light w-md\"><i class=\"fas fa-times mg-r-10\"></i>&nbsp;Cancel and Go Back</a>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 407, "~/admin/edit_question?quizId=", 407, 29, true);
#nullable restore
#line 18 "D:\UpdateFreelance\ayush\Pages\Admin\edit_text_question.cshtml"
AddHtmlAttributeValue("", 436, Model.QuestionViewModel.QuizID, 436, 31, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 467, "&questionId=", 467, 12, true);
#nullable restore
#line 18 "D:\UpdateFreelance\ayush\Pages\Admin\edit_text_question.cshtml"
AddHtmlAttributeValue("", 479, Model.QuestionViewModel.ID, 479, 27, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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

<div id=""deleteModal"" class=""modal fade"">
	<div class=""modal-dialog"" role=""document"">
		<div class=""modal-content tx-size-sm"">
			<div class=""modal-body tx-center pd-y-20 pd-x-20"">
				<button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
					<span aria-hidden=""true"">&times;</span>
				</button>
				<i class=""icon icon ion-android-warning tx-100 tx-warning lh-1 mg-t-20 d-inline-block""></i>
				<h4 class=""tx-warning tx-sem");
            WriteLiteral(@"ibold mg-b-20"">Warning!</h4>
				<p class=""mg-b-20 mg-x-20"">Are you sure you want to delete this record? This will not be reversible.</p>
				<button type=""button"" id=""deleteButton"" class=""btn btn-danger mg-b-20"" data-toggle=""modal"" data-dismiss=""modal""><i class=""fas fa-trash-alt mg-r-10""></i>&nbsp;Delete</button>
				<button type=""button"" class=""btn btn-primary mg-b-20"" data-toggle=""modal"" data-dismiss=""modal""><i class=""fas fa-times mg-r-10""></i>&nbsp;Cancel</button>
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
        //    AddCorrectOption();
        //});

        $(""#addOptionButton"").click(function () {
            AddOption();
        });

		$(""#updateButton"").click(function () {
			$(""#operationForm"").attr(""action"", ""edit_text_question?quizId=");
#nullable restore
#line 167 "D:\UpdateFreelance\ayush\Pages\Admin\edit_text_question.cshtml"
                                                                     Write(Model.QuizId);

#line default
#line hidden
#nullable disable
                WriteLiteral("&questionId=");
#nullable restore
#line 167 "D:\UpdateFreelance\ayush\Pages\Admin\edit_text_question.cshtml"
                                                                                              Write(Model.QuestionId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""");
			$(""#operationForm"").submit();
		});
		$(""#deleteButton"").click(function () {
			$(""#operationForm"").attr(""action"", ""edit_text_question?handler=DeleteQuestion"");
			$(""#operationForm"").submit();
		});
    });

    //function AddCorrectOption() {
    //    $('<div/>', {
    //        'class': 'option form-group', html: GetCorrectOptionHtml()
    //    }).hide().insertBefore('#correctOptions').slideDown('slow');
    //}

    function AddOption() {
        $('<div/>', {
            'class': 'option form-group row', html: GetOptionHtml()
        }).hide().insertBefore('#options').slideDown('slow');
    }

    //function GetCorrectOptionHtml() {
    //    var len = $('.option').length + 1;
    //    var $html = $('.correctOptionRowTemplate').clone();
    //    $html.find('[name=correctOptionNo]')[0].name = ""correctOptionNo"" + len;
    //    return $html.html();
    //}

    function GetOptionHtml() {
        var len = $('.option').length + 1;
        var $html = $('.optionRowTem");
                WriteLiteral("plate\').clone();\r\n        $html.find(\'[name=optionNo]\')[0].name = \"optionNo\" + len;\r\n\t\t$html.find(\'[name=isoptioncorrect]\')[0].name = \"isoptioncorrect\" + len;\r\n        return $html.html();\r\n    }\r\n\t</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ayush.edit_questionModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ayush.edit_questionModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ayush.edit_questionModel>)PageContext?.ViewData;
        public ayush.edit_questionModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
