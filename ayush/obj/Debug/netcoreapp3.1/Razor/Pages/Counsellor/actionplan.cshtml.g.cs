#pragma checksum "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Counsellor\actionplan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "098a5d1a457282c4fdedc6cfc780ba20406c84ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ayush.Pages.Counsellor.Pages_Counsellor_actionplan), @"mvc.1.0.razor-page", @"/Pages/Counsellor/actionplan.cshtml")]
namespace ayush.Pages.Counsellor
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"098a5d1a457282c4fdedc6cfc780ba20406c84ef", @"/Pages/Counsellor/actionplan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30a319bf93157485e6034cff29d85f12084656cc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Counsellor_actionplan : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("direct-chat-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/user1-128x128.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Message User Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/user3-128x128.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Hp\source\repos\schooldashboard\ayush\Pages\Counsellor\actionplan.cshtml"
  
    ViewData["Title"] = "sessions";
    Layout = "~/Pages/Shared/_CounsellorLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <link href=""http://hayageek.github.io/jQuery-Upload-File/4.0.11/uploadfile.css"" rel=""stylesheet"">
    <script src=""http://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js""></script>
    <script src=""http://hayageek.github.io/jQuery-Upload-File/4.0.11/jquery.uploadfile.min.js""></script>
");
            WriteLiteral(@"

<section class=""content-header"">
    <div class=""container-fluid"">
        <div class=""row mb-2"">
            <div class=""col-sm-6"">
                <h1>Action Plan</h1>
            </div>

        </div>
    </div>
</section>

<section class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">

            <div class=""col-md-9"">
                <div class=""card"">
                    <div class=""card-header p-2"">
                        <ul class=""nav nav-pills"">
                            <li class=""nav-item""><a class=""nav-link active"" href=""#session1"" data-toggle=""tab"">Session 1</a></li>
                            <li class=""nav-item""><a class=""nav-link"" href=""#session2"" data-toggle=""tab"">Session 2</a></li>
                            <li class=""nav-item""><a class=""nav-link"" href=""#session3"" data-toggle=""tab"">Session 3</a></li>
                            <li class=""nav-item""><a class=""nav-link"" href=""#session4"" data-toggle=""tab"">General Activities</a></li>

 ");
            WriteLiteral(@"                       </ul>
                    </div>
                    <div class=""card-body"">
                        <div class=""tab-content"">
                            <div class=""active tab-pane"" id=""session1"">
                                <div class=""callout callout-info"">
                                    <h5>I am a danger callout!</h5>

                                    <p>
                                        There is a problem that we need to fix. A wonderful serenity has taken possession of my entire
                                        soul,
                                        like these sweet mornings of spring which I enjoy with my whole heart.
                                    </p>
                                    <div class=""bg-white"">
                                        <ul class=""mailbox-attachments d-flex align-items-stretch clearfix"">
                                            <li>

                                                <div class");
            WriteLiteral(@"=""mailbox-attachment-info"">
                                                    <a href=""#"" class=""text-decoration-none""><i class=""fas fa-paperclip""></i> Sep2014-report.pdf</a>

                                                </div>
                                            </li>
                                            <li>

                                                <div class=""mailbox-attachment-info"">
                                                    <a href=""#"" class=""text-decoration-none""><i class=""fas fa-paperclip""></i> App Description.docx</a>

                                                </div>
                                            </li>

                                        </ul>
                                    </div>



                                    <div class=""bg-white"">
                                        <p>Response(s) from Student</p>
                                        <ul class=""mailbox-attachments d-flex align-items-stretch clearf");
            WriteLiteral(@"ix"">
                                            <li>

                                                <div class=""mailbox-attachment-info"">
                                                    <a href=""#"" class=""text-decoration-none""><i class=""fas fa-paperclip""></i> response1.pdf</a>

                                                </div>
                                            </li>
                                            <li>

                                                <div class=""mailbox-attachment-info"">
                                                    <a href=""#"" class=""text-decoration-none""><i class=""fas fa-paperclip""></i> response22.docx</a>

                                                </div>
                                            </li>

                                        </ul>
                                    </div>
                                    <a");
            BeginWriteAttribute("href", " href=\"", 4437, "\"", 4444, 0);
            EndWriteAttribute();
            WriteLiteral("><small>Edit</small></a> | <a");
            BeginWriteAttribute("href", " href=\"", 4474, "\"", 4481, 0);
            EndWriteAttribute();
            WriteLiteral(@"><small>Delete</small></a>
                                </div>

                                <div class=""callout callout-info"">
                                    <div class=""form-group"">
                                        <label>Enter Title of Action Plan</label>
                                        <input type=""text"" class=""form-control"" placeholder=""Enter Title of Action Plan"">
                                    </div>

                                    <div class=""form-group"">
                                        <label>Enter Description</label>
                                        <textarea class=""form-control"" rows=""3"" placeholder=""Enter Description...""></textarea>
                                    </div>
                                    <div class=""form-group"">
                                        <div id=""multipleupload"">Upload</div>
                                    </div>

                                    <div class=""row"">
                      ");
            WriteLiteral(@"                  <div class=""col-12"">

                                            <input type=""submit"" value=""Add Action Plan"" class=""btn btn-info"">
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class=""tab-pane"" id=""session2"">
                                <div class=""callout callout-info"">
                                    <h5>I am a danger callout!</h5>

                                    <p>
                                        There is a problem that we need to fix. A wonderful serenity has taken possession of my entire
                                        soul,
                                        like these sweet mornings of spring which I enjoy with my whole heart.
                                    </p>
                                    <div class=""bg-white"">
                                        <ul class=""mailbo");
            WriteLiteral(@"x-attachments d-flex align-items-stretch clearfix"">
                                            <li>

                                                <div class=""mailbox-attachment-info"">
                                                    <a href=""#"" class=""text-decoration-none""><i class=""fas fa-paperclip""></i> Sep2014-report.pdf</a>

                                                </div>
                                            </li>
                                            <li>

                                                <div class=""mailbox-attachment-info"">
                                                    <a href=""#"" class=""text-decoration-none""><i class=""fas fa-paperclip""></i> App Description.docx</a>

                                                </div>
                                            </li>

                                        </ul>
                                    </div>



                                    <div class=""bg-white"">
              ");
            WriteLiteral(@"                          <p>Response(s) from Student</p>
                                        <ul class=""mailbox-attachments d-flex align-items-stretch clearfix"">
                                            <li>

                                                <div class=""mailbox-attachment-info"">
                                                    <a href=""#"" class=""text-decoration-none""><i class=""fas fa-paperclip""></i> response1.pdf</a>

                                                </div>
                                            </li>
                                            <li>

                                                <div class=""mailbox-attachment-info"">
                                                    <a href=""#"" class=""text-decoration-none""><i class=""fas fa-paperclip""></i> response22.docx</a>

                                                </div>
                                            </li>

                                        </ul>
                  ");
            WriteLiteral("                  </div>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 8642, "\"", 8649, 0);
            EndWriteAttribute();
            WriteLiteral("><small>Edit</small></a> | <a");
            BeginWriteAttribute("href", " href=\"", 8679, "\"", 8686, 0);
            EndWriteAttribute();
            WriteLiteral(@"><small>Delete</small></a>
                                </div>

                                <div class=""callout callout-info"">
                                    <div class=""form-group"">
                                        <label>Enter Title of Action Plan</label>
                                        <input type=""text"" class=""form-control"" placeholder=""Enter Title of Action Plan"">
                                    </div>

                                    <div class=""form-group"">
                                        <label>Enter Description</label>
                                        <textarea class=""form-control"" rows=""3"" placeholder=""Enter Description...""></textarea>
                                    </div>
                                    <div class=""form-group"">
                                        <div id=""multipleupload"">Upload</div>
                                    </div>

                                    <div class=""row"">
                      ");
            WriteLiteral(@"                  <div class=""col-12"">

                                            <input type=""submit"" value=""Add Action Plan"" class=""btn btn-info"">
                                        </div>
                                    </div>
                                </div>

                            </div>
                            <div class=""tab-pane"" id=""session3"">

                                <div class=""callout callout-info"">
                                    <h5>I am a danger callout!</h5>

                                    <p>
                                        There is a problem that we need to fix. A wonderful serenity has taken possession of my entire
                                        soul,
                                        like these sweet mornings of spring which I enjoy with my whole heart.
                                    </p>
                                    <div class=""bg-white"">
                                        <ul class=""mail");
            WriteLiteral(@"box-attachments d-flex align-items-stretch clearfix"">
                                            <li>

                                                <div class=""mailbox-attachment-info"">
                                                    <a href=""#"" class=""text-decoration-none""><i class=""fas fa-paperclip""></i> Sep2014-report.pdf</a>

                                                </div>
                                            </li>
                                            <li>

                                                <div class=""mailbox-attachment-info"">
                                                    <a href=""#"" class=""text-decoration-none""><i class=""fas fa-paperclip""></i> App Description.docx</a>

                                                </div>
                                            </li>

                                        </ul>
                                    </div>



                                    <div class=""bg-white"">
            ");
            WriteLiteral(@"                            <p>Response(s) from Student</p>
                                        <ul class=""mailbox-attachments d-flex align-items-stretch clearfix"">
                                            <li>

                                                <div class=""mailbox-attachment-info"">
                                                    <a href=""#"" class=""text-decoration-none""><i class=""fas fa-paperclip""></i> response1.pdf</a>

                                                </div>
                                            </li>
                                            <li>

                                                <div class=""mailbox-attachment-info"">
                                                    <a href=""#"" class=""text-decoration-none""><i class=""fas fa-paperclip""></i> response22.docx</a>

                                                </div>
                                            </li>

                                        </ul>
                ");
            WriteLiteral("                    </div>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 12849, "\"", 12856, 0);
            EndWriteAttribute();
            WriteLiteral("><small>Edit</small></a> | <a");
            BeginWriteAttribute("href", " href=\"", 12886, "\"", 12893, 0);
            EndWriteAttribute();
            WriteLiteral(@"><small>Delete</small></a>
                                </div>

                                <div class=""callout callout-info"">
                                    <div class=""form-group"">
                                        <label>Enter Title of Action Plan</label>
                                        <input type=""text"" class=""form-control"" placeholder=""Enter Title of Action Plan"">
                                    </div>

                                    <div class=""form-group"">
                                        <label>Enter Description</label>
                                        <textarea class=""form-control"" rows=""3"" placeholder=""Enter Description...""></textarea>
                                    </div>
                                    <div class=""form-group"">
                                        <div id=""multipleupload"">Upload</div>
                                    </div>

                                    <div class=""row"">
                      ");
            WriteLiteral(@"                  <div class=""col-12"">

                                            <input type=""submit"" value=""Add Action Plan"" class=""btn btn-info"">
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""tab-pane"" id=""session4"">
                                <div class=""callout callout-info"">
                                    <h5>I am a danger callout!</h5>

                                    <p>
                                        There is a problem that we need to fix. A wonderful serenity has taken possession of my entire
                                        soul,
                                        like these sweet mornings of spring which I enjoy with my whole heart.
                                    </p>
                                    <div class=""bg-white"">
                                        <ul class=""mailbox-");
            WriteLiteral(@"attachments d-flex align-items-stretch clearfix"">
                                            <li>

                                                <div class=""mailbox-attachment-info"">
                                                    <a href=""#"" class=""text-decoration-none""><i class=""fas fa-paperclip""></i> Sep2014-report.pdf</a>

                                                </div>
                                            </li>
                                            <li>

                                                <div class=""mailbox-attachment-info"">
                                                    <a href=""#"" class=""text-decoration-none""><i class=""fas fa-paperclip""></i> App Description.docx</a>

                                                </div>
                                            </li>

                                        </ul>
                                    </div>



                                    <div class=""bg-white"">
                ");
            WriteLiteral(@"                        <p>Response(s) from Student</p>
                                        <ul class=""mailbox-attachments d-flex align-items-stretch clearfix"">
                                            <li>

                                                <div class=""mailbox-attachment-info"">
                                                    <a href=""#"" class=""text-decoration-none""><i class=""fas fa-paperclip""></i> response1.pdf</a>

                                                </div>
                                            </li>
                                            <li>

                                                <div class=""mailbox-attachment-info"">
                                                    <a href=""#"" class=""text-decoration-none""><i class=""fas fa-paperclip""></i> response22.docx</a>

                                                </div>
                                            </li>

                                        </ul>
                    ");
            WriteLiteral("                </div>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 17052, "\"", 17059, 0);
            EndWriteAttribute();
            WriteLiteral("><small>Edit</small></a> | <a");
            BeginWriteAttribute("href", " href=\"", 17089, "\"", 17096, 0);
            EndWriteAttribute();
            WriteLiteral(@"><small>Delete</small></a>
                                </div>

                                <div class=""callout callout-info"">
                                    <div class=""form-group"">
                                        <label>Enter Title of Action Plan</label>
                                        <input type=""text"" class=""form-control"" placeholder=""Enter Title of Action Plan"">
                                    </div>

                                    <div class=""form-group"">
                                        <label>Enter Description</label>
                                        <textarea class=""form-control"" rows=""3"" placeholder=""Enter Description...""></textarea>
                                    </div>
                                    <div class=""form-group"">
                                        <div id=""multipleupload"">Upload</div>
                                    </div>

                                    <div class=""row"">
                      ");
            WriteLiteral(@"                  <div class=""col-12"">

                                            <input type=""submit"" value=""Add Action Plan"" class=""btn btn-info"">
                                        </div>
                                    </div>
                                </div>

                            </div>


                        </div>

                    </div>
                </div>
            </div>
            <div class=""col-md-3"">

                <div class=""card card-prirary cardutline direct-chat direct-chat-primary"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">Direct Chat</h3>


                    </div>

                    <div class=""card-body"">

                        <div class=""direct-chat-messages"">

                            <div class=""direct-chat-msg"">
                                <div class=""direct-chat-infos clearfix"">
                                    <span class=""direct-chat-name float-");
            WriteLiteral("left\">Alexander Pierce</span>\r\n                                    <span class=\"direct-chat-timestamp float-right\">23 Jan 2:00 pm</span>\r\n                                </div>\r\n\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "098a5d1a457282c4fdedc6cfc780ba20406c84ef26844", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                                <div class=""direct-chat-text"">
                                    Is this template really for free? That's unbelievable!
                                </div>

                            </div>

                            <div class=""direct-chat-msg right"">
                                <div class=""direct-chat-infos clearfix"">
                                    <span class=""direct-chat-name float-right"">Sarah Bullock</span>
                                    <span class=""direct-chat-timestamp float-left"">23 Jan 2:05 pm</span>
                                </div>

                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "098a5d1a457282c4fdedc6cfc780ba20406c84ef28709", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                                <div class=""direct-chat-text"">
                                    You better believe it!
                                </div>

                            </div>







                        </div>


                    </div>

                    <div class=""card-footer"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "098a5d1a457282c4fdedc6cfc780ba20406c84ef30265", async() => {
                WriteLiteral(@"
                            <div class=""input-group"">
                                <input type=""text"" name=""message"" placeholder=""Type Message ..."" class=""form-control"">
                                <span class=""input-group-append"">
                                    <button type=""submit"" class=""btn btn-primary"">Send</button>
                                </span>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n</section>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("JavaScript", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $(""#multipleupload"").uploadFile({
                url: ""upload.php"",
                multiple: true,
                dragDrop: true,
                fileName: ""myfile""
            }); 
        });
    </script>

");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ayush.actionplanModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ayush.actionplanModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ayush.actionplanModel>)PageContext?.ViewData;
        public ayush.actionplanModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
