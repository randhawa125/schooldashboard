#pragma checksum "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_image_question.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b36e45107907b4067e9e947647c7dd1536beea1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ayush.Pages.Admin.Pages_Admin_add_image_question), @"mvc.1.0.razor-page", @"/Pages/Admin/add_image_question.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b36e45107907b4067e9e947647c7dd1536beea1", @"/Pages/Admin/add_image_question.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30a319bf93157485e6034cff29d85f12084656cc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_add_image_question : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("operationForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_image_question.cshtml"
  
	ViewData["Title"] = "add_image_question";
	Layout = "~/Pages/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container-fluid\">\r\n\t<div class=\"row\">\r\n\t\t<div class=\"col-sm-12\">\r\n\t\t\t<div class=\"card\">\r\n\t\t\t\t<div class=\"card-header\">\r\n\t\t\t\t\t<h1>Add New Image Question</h1>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t<div>\r\n\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b36e45107907b4067e9e947647c7dd1536beea15173", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t<input type=\"hidden\" id=\"QuizID\" name=\"QuizID\"");
                BeginWriteAttribute("value", " value=\"", 484, "\"", 523, 1);
#nullable restore
#line 19 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_image_question.cshtml"
WriteAttributeValue("", 492, Model.QuestionViewModel.QuizId, 492, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t<label for=\"Title\">Question Title</label>\r\n");
                WriteLiteral("\t\t\t\t\t\t\t\t<textarea class=\"textarea\" placeholder=\"Place some text here\" name=\"Title\" id=\"Title\"\r\n\t\t\t\t\t\t\t\t\t\t  style=\"width: 100%; height: 200px; font-size: 14px; line-height: 18px; border: 1px solid #dddddd; padding: 10px;\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 26 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_image_question.cshtml"
                           Write(Model.QuestionViewModel.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\r\n");
#nullable restore
#line 27 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_image_question.cshtml"
                                 if (!ViewData.ModelState.IsValid && ViewData.ModelState["Title"] != null && ViewData.ModelState["Title"].Errors.Count > 0)
								{
									

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_image_question.cshtml"
                               Write(Html.ValidationMessageFor(m => m.QuestionViewModel.Title, ViewData.ModelState["Title"].Errors.FirstOrDefault().ErrorMessage, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_image_question.cshtml"
                                                                                                                                                                                                 
								}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t<div class=\"image-holder pull-left\">\r\n\t\t\t\t\t\t\t\t\t<input class=\"txtfield form-control\" type=\"hidden\" name=\"questionfile\"");
                BeginWriteAttribute("value", " value=\"", 1491, "\"", 1499, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t<img");
                BeginWriteAttribute("src", " src=\"", 1516, "\"", 1522, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""img-thumbnail"" style=""height: 300px; display:none"">
								</div>
								<span class=""error-holder""></span>
								<input class=""image-uploader form-control"" type=""file"" accept="".png,.jpg,.jpeg,.gif,.tif"" />
								<div class=""clearfix""></div>
							</div>

");
                WriteLiteral("\r\n");
#nullable restore
#line 99 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_image_question.cshtml"
                             if (!ViewData.ModelState.IsValid && ViewData.ModelState["CorrectOptions"] != null && ViewData.ModelState["CorrectOptions"].Errors.Count > 0)
							{
								

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_image_question.cshtml"
                           Write(Html.ValidationMessageFor(m => m.QuestionViewModel.CorrectOptions, ViewData.ModelState["CorrectOptions"].Errors.FirstOrDefault().ErrorMessage, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_image_question.cshtml"
                                                                                                                                                                                                               
							}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t\t<label><span name=\"optionNoText\">Options</span></label>\r\n\t\t\t\t\t\t\t</div>\r\n\r\n");
#nullable restore
#line 108 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_image_question.cshtml"
                             if (Model.QuestionViewModel.Options != null && Model.QuestionViewModel.Options.Count > 0)
							{
								foreach (var option in Model.QuestionViewModel.Options)
								{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t\t<div class=\"option form-group row\">\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"col-6\">\r\n\t\t\t\t\t\t\t\t\t\t\t<div class=\"image-holder pull-left\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<input class=\"txtfield\" type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 5584, "\"", 5651, 2);
                WriteAttributeValue("", 5591, "option", 5591, 6, true);
#nullable restore
#line 115 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_image_question.cshtml"
WriteAttributeValue("", 5597, Model.QuestionViewModel.Options.IndexOf(option) + 1, 5597, 54, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 5652, "\"", 5676, 1);
#nullable restore
#line 115 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_image_question.cshtml"
WriteAttributeValue("", 5660, option.Image.Id, 5660, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<img");
                BeginWriteAttribute("src", " src=\"", 5696, "\"", 5729, 2);
                WriteAttributeValue("", 5702, "/uploads/", 5702, 9, true);
#nullable restore
#line 116 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_image_question.cshtml"
WriteAttributeValue("", 5711, option.Image.Name, 5711, 18, false);

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
										</div>
										<label class=""text-right col-3"">Is Option Correct?</label>
										<input class=""form-control col-1"" type=""checkbox""");
                BeginWriteAttribute("name", " name=\"", 6374, "\"", 6450, 2);
                WriteAttributeValue("", 6381, "isoptioncorrect", 6381, 15, true);
#nullable restore
#line 126 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_image_question.cshtml"
WriteAttributeValue("", 6396, Model.QuestionViewModel.Options.IndexOf(option) + 1, 6396, 54, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 6451, "\"", 6476, 1);
#nullable restore
#line 126 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_image_question.cshtml"
WriteAttributeValue("", 6459, option.IsCorrect, 6459, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 128 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_image_question.cshtml"
								}
							}
							else
							{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t<div class=\"option form-group row\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"col-6\">\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"image-holder pull-left\">\r\n\t\t\t\t\t\t\t\t\t\t\t<img");
                BeginWriteAttribute("src", " src=\"", 6679, "\"", 6685, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"txtfield img-thumbnail\" style=\"height: 300px; display:none\">\r\n\t\t\t\t\t\t\t\t\t\t\t<input class=\"txtfield form-control\" type=\"hidden\" name=\"option1\"");
                BeginWriteAttribute("value", " value=\"", 6832, "\"", 6840, 0);
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
#line 148 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_image_question.cshtml"
							}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t<span id=\"options\"></span>\r\n\r\n");
#nullable restore
#line 152 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_image_question.cshtml"
                             if (!ViewData.ModelState.IsValid && ViewData.ModelState["Options"] != null && ViewData.ModelState["Options"].Errors.Count > 0)
							{
								

#line default
#line hidden
#nullable disable
#nullable restore
#line 154 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_image_question.cshtml"
                           Write(Html.ValidationMessageFor(m => m.QuestionViewModel.Options, ViewData.ModelState["Options"].Errors.FirstOrDefault().ErrorMessage, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 154 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_image_question.cshtml"
                                                                                                                                                                                                 
							}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t<div id=\"actionsRow\">\r\n\t\t\t\t\t\t\t\t<hr />\r\n");
                WriteLiteral(@"								<button type=""button"" id=""addOptionButton"" class=""btn btn-info waves-effect waves-light w-md""><i class=""fas fa-plus mg-r-10""></i>&nbsp;Add Option</button>
								<button type=""submit"" id=""addButton"" class=""btn btn-success waves-effect waves-light w-md""><i class=""fas fa-save mg-r-10""></i>&nbsp;Save this Question and Add Another</button>
								<a");
                BeginWriteAttribute("href", " href=\"", 8462, "\"", 8498, 2);
                WriteAttributeValue("", 8469, "question?quizid=", 8469, 16, true);
#nullable restore
#line 162 "C:\Users\Aakib\source\repos\schooldashboard4\ayush\Pages\Admin\add_image_question.cshtml"
WriteAttributeValue("", 8485, Model.QuizId, 8485, 13, false);

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
            BeginWriteAttribute("src", " src=\"", 9654, "\"", 9660, 0);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b36e45107907b4067e9e947647c7dd1536beea120677", async() => {
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
            WriteLiteral("\r\n");
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

			ImageUploadsListen();
			ImageDeleterListen();
		});

		function ImageUploadsListen() {
			$("".image-uploader"").off('change', ImageUploader).on('change', ImageUploader);
		}

		function ImageDeleterListen() {
			$("".delete-image"").off('click', ImageDeleter).on('click', ImageDeleter);
		}

		function ImageDeleter() {
			$(this).parents('.option').remove();
		}

		function ImageUploader() {

			var element = this;

			$(element).prevAll('.image-holder').first().children('.txtfield').val("""");
			$(element).prevAll('.image-holder').first().children('.img-thumbnail').hide();
			$(element).prevAll('.image-holder').first().children('.img-thumbnail').attr('src', '');
			$(element).prevAll('.error-holde");
                WriteLiteral(@"r').first().html("""");
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
					$(element).prevAll('.image-holder').first().children('.img-thumbnail').attr('src', data.imageURL);
					$(element).prevAll('.image-holder').first().children('.img-thumbnail').show();

					$(element).prevAll('.delete-holder').first().show();
				}
				else {
					console.log(data.Message);

					var $error = $('#errorDiv').clone();
					$error.find('.error-message').html(data.Message);
					$error.removeAttr(""id"");
				");
                WriteLiteral(@"	$(element).prevAll('.error-holder').first().append($error);
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
		//	ImageDeleterListen();
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
		//	var $html = $('.correctOptionRowTemp");
                WriteLiteral(@"lateImage').clone();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ayush.add_image_questionModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ayush.add_image_questionModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ayush.add_image_questionModel>)PageContext?.ViewData;
        public ayush.add_image_questionModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
