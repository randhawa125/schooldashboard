#pragma checksum "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\edit_text_question.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8249213f3eed6d8b9fa06d5dbcb4f4d120f2433"
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
#line 1 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\_ViewImports.cshtml"
using ayush;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8249213f3eed6d8b9fa06d5dbcb4f4d120f2433", @"/Pages/Admin/edit_text_question.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"780f75cdb21e45cdf2691da819d8b5f5fbb8c766", @"/Pages/_ViewImports.cshtml")]
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
#line 3 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\edit_text_question.cshtml"
  
	ViewData["Title"] = "edit_question";
	Layout = "~/Pages/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"container-fluid\">\n\t<div class=\"row\">\n\t\t<div class=\"col-sm-12\">\n\t\t\t<div class=\"card\">\n\t\t\t\t<div class=\"card-header\">\n\t\t\t\t\t<h1>Edit Question</h1>\n\t\t\t\t</div>\n\t\t\t\t<div class=\"card-body\">\n\n\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8249213f3eed6d8b9fa06d5dbcb4f4d120f24334940", async() => {
                WriteLiteral("\n\t\t\t\t\t\t<input type=\"hidden\" id=\"ID\" name=\"ID\"");
                BeginWriteAttribute("value", " value=\"", 536, "\"", 571, 1);
#nullable restore
#line 19 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\edit_text_question.cshtml"
WriteAttributeValue("", 544, Model.QuestionViewModel.ID, 544, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n\t\t\t\t\t\t<input type=\"hidden\" id=\"QuizID\" name=\"QuizID\"");
                BeginWriteAttribute("value", " value=\"", 628, "\"", 667, 1);
#nullable restore
#line 20 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\edit_text_question.cshtml"
WriteAttributeValue("", 636, Model.QuestionViewModel.QuizID, 636, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n\n\t\t\t\t\t\t<div class=\"form-group\">\n\t\t\t\t\t\t\t<label for=\"Title\">Question Title</label>\n");
                WriteLiteral("\t\t\t\t\t\t\t<textarea class=\"textarea\" placeholder=\"Place some text here\" name=\"Title\" id=\"Title\"\n\t\t\t\t\t\t\t\t\t  style=\"width: 100%; height: 200px; font-size: 14px; line-height: 18px; border: 1px solid #dddddd; padding: 10px;\">\n\t\t\t\t\t\t\t");
#nullable restore
#line 27 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\edit_text_question.cshtml"
                       Write(Model.QuestionViewModel.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\n");
#nullable restore
#line 28 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\edit_text_question.cshtml"
                             if (!ViewData.ModelState.IsValid && ViewData.ModelState["Title"] != null && ViewData.ModelState["Title"].Errors.Count > 0)
							{
								

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\edit_text_question.cshtml"
                           Write(Html.ValidationMessageFor(m => m.QuestionViewModel.Title, ViewData.ModelState["Title"].Errors.FirstOrDefault().ErrorMessage, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\edit_text_question.cshtml"
                                                                                                                                                                                             
							}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t</div>\n\n");
                WriteLiteral("\n");
#nullable restore
#line 56 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\edit_text_question.cshtml"
                         if (!ViewData.ModelState.IsValid && ViewData.ModelState["CorrectOptions"] != null && ViewData.ModelState["CorrectOptions"].Errors.Count > 0)
						{

							

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\edit_text_question.cshtml"
                       Write(Html.ValidationMessageFor(m => m.QuestionViewModel.CorrectOptions, ViewData.ModelState["CorrectOptions"].Errors.FirstOrDefault().ErrorMessage, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\edit_text_question.cshtml"
                                                                                                                                                                                                           
						}

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\t\t\t\t\t\t<div>\n\t\t\t\t\t\t\t<label><span name=\"optionNoText\">Options</span></label>\n\t\t\t\t\t\t</div>\n\n");
#nullable restore
#line 66 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\edit_text_question.cshtml"
                         if (Model.QuestionViewModel.Options != null && Model.QuestionViewModel.Options.Count > 0)
						{
							foreach (var option in Model.QuestionViewModel.Options)
							{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t<div class=\"option form-group row\">\n\t\t\t\t\t\t\t\t\t<input class=\"form-control col-6\" type=\"text\"");
                BeginWriteAttribute("name", " name=\"", 3050, "\"", 3117, 2);
                WriteAttributeValue("", 3057, "option", 3057, 6, true);
#nullable restore
#line 71 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\edit_text_question.cshtml"
WriteAttributeValue("", 3063, Model.QuestionViewModel.Options.IndexOf(option) + 1, 3063, 54, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Enter Other Option\"");
                BeginWriteAttribute("value", " value=\"", 3151, "\"", 3173, 1);
#nullable restore
#line 71 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\edit_text_question.cshtml"
WriteAttributeValue("", 3159, option.Answer, 3159, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t\t\t\t\t\t<label class=\"text-right col-3\">Is Option Correct?</label>\n");
#nullable restore
#line 73 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\edit_text_question.cshtml"
                                     if (option.IsCorrect)
									{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t\t\t<input class=\"form-control col-1\" type=\"checkbox\"");
                BeginWriteAttribute("name", " name=\"", 3346, "\"", 3422, 2);
                WriteAttributeValue("", 3353, "isoptioncorrect", 3353, 15, true);
#nullable restore
#line 75 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\edit_text_question.cshtml"
WriteAttributeValue("", 3368, Model.QuestionViewModel.Options.IndexOf(option) + 1, 3368, 54, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" checked=\"checked\">\n");
#nullable restore
#line 76 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\edit_text_question.cshtml"
									}
									else
									{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t\t\t<input class=\"form-control col-1\" type=\"checkbox\"");
                BeginWriteAttribute("name", " name=\"", 3538, "\"", 3614, 2);
                WriteAttributeValue("", 3545, "isoptioncorrect", 3545, 15, true);
#nullable restore
#line 79 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\edit_text_question.cshtml"
WriteAttributeValue("", 3560, Model.QuestionViewModel.Options.IndexOf(option) + 1, 3560, 54, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n");
#nullable restore
#line 80 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\edit_text_question.cshtml"
									}

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\t\t\t\t\t\t\t\t</div>\n");
#nullable restore
#line 83 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\edit_text_question.cshtml"
							}
						}
						else
						{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t<div class=\"option form-group row\">\n\t\t\t\t\t\t\t\t<input class=\"form-control col-6\" type=\"text\" name=\"option1\" placeholder=\"Enter Other Option\"");
                BeginWriteAttribute("value", " value=\"", 3824, "\"", 3832, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t\t\t\t\t<label class=\"text-right col-3\">Is Option Correct?</label>\n\t\t\t\t\t\t\t\t<input class=\"form-control col-1\" type=\"checkbox\" name=\"isoptioncorrect1\">\n\t\t\t\t\t\t\t</div>\n");
#nullable restore
#line 92 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\edit_text_question.cshtml"
						}

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\t\t\t\t\t\t<span id=\"options\"></span>\n\n");
#nullable restore
#line 96 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\edit_text_question.cshtml"
                         if (!ViewData.ModelState.IsValid && ViewData.ModelState["Options"] != null && ViewData.ModelState["Options"].Errors.Count > 0)
						{

							

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\edit_text_question.cshtml"
                       Write(Html.ValidationMessageFor(m => m.QuestionViewModel.Options, ViewData.ModelState["Options"].Errors.FirstOrDefault().ErrorMessage, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\edit_text_question.cshtml"
                                                                                                                                                                                             
						}

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\t\t\t\t\t\t<div id=\"actionsRow\">\n\t\t\t\t\t\t\t<hr />\n");
                WriteLiteral(@"							<button type=""button"" id=""addOptionButton"" class=""btn btn-info waves-effect waves-light w-md""><i class=""fas fa-plus mg-r-10""></i>&nbsp;Add Option</button>
							<button type=""submit"" id=""updateButton"" class=""btn btn-warning""><i class=""fas fa-save mg-r-10""></i>&nbsp;Update this Question and Go Back</button>
							<button type=""button"" class=""btn btn-danger"" data-toggle=""modal"" data-target=""#deleteModal""><i class=""fas fa-trash-alt mg-r-10""></i>&nbsp;Delete this Question</button>
							<a");
                BeginWriteAttribute("href", " href=\"", 5086, "\"", 5140, 2);
                WriteAttributeValue("", 5093, "question?quizId=", 5093, 16, true);
#nullable restore
#line 108 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\edit_text_question.cshtml"
WriteAttributeValue("", 5109, Model.QuestionViewModel.QuizID, 5109, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" role=\"button\" class=\"btn btn-primary waves-effect waves-light w-md\"><i class=\"fas fa-times mg-r-10\"></i>&nbsp;Cancel and Go Back</a>\n\t\t\t\t\t\t</div>\n\t\t\t\t\t");
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
            AddHtmlAttributeValue("", 390, "~/admin/edit_question?quizId=", 390, 29, true);
#nullable restore
#line 18 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\edit_text_question.cshtml"
AddHtmlAttributeValue("", 419, Model.QuestionViewModel.QuizID, 419, 31, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 450, "&questionId=", 450, 12, true);
#nullable restore
#line 18 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\edit_text_question.cshtml"
AddHtmlAttributeValue("", 462, Model.QuestionViewModel.ID, 462, 27, false);

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
				<h4 class=""tx-warning tx-semibold mg-b-20"">Warning!</h4>
");
            WriteLiteral(@"				<p class=""mg-b-20 mg-x-20"">Are you sure you want to delete this record? This will not be reversible.</p>
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
#line 167 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\edit_text_question.cshtml"
                                                                     Write(Model.QuizId);

#line default
#line hidden
#nullable disable
                WriteLiteral("&questionId=");
#nullable restore
#line 167 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Admin\edit_text_question.cshtml"
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
        var $html = $('.optionRowTemplate').clone();
        $html");
                WriteLiteral(".find(\'[name=optionNo]\')[0].name = \"optionNo\" + len;\n\t\t$html.find(\'[name=isoptioncorrect]\')[0].name = \"isoptioncorrect\" + len;\n        return $html.html();\n    }\n\t</script>\n");
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
