#pragma checksum "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Counsellor\slots.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d4b0c461dec00bf32eab760e971716f29c92836"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ayush.Pages.Counsellor.Pages_Counsellor_slots), @"mvc.1.0.razor-page", @"/Pages/Counsellor/slots.cshtml")]
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
#line 1 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\_ViewImports.cshtml"
using ayush;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d4b0c461dec00bf32eab760e971716f29c92836", @"/Pages/Counsellor/slots.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"780f75cdb21e45cdf2691da819d8b5f5fbb8c766", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Counsellor_slots : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap-datepicker/bootstrap-datepicker3.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Aakib\OneDrive\Desktop\orginal\schooldashboard-master\schooldashboard-master\schooldashboard-master\ayush\Pages\Counsellor\slots.cshtml"
  
	ViewData["Title"] = "slots";
	Layout = "~/Pages/Shared/_CounsellorLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6d4b0c461dec00bf32eab760e971716f29c928364117", async() => {
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
            WriteLiteral("\n\t<script src=\"https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.6.4/js/bootstrap-datepicker.js\"></script>\n");
            WriteLiteral(@"
<section class=""content-header"">
    <div class=""container-fluid"">
        <div class=""row mb-2"">
            <div class=""col-sm-6"">
                <h5 class=""text-uppercase"">Availability</h5>
            </div>
        </div>
    </div>
</section>
	
<div class=""content"">
    <div class=""row"">
       
        <div class=""col-md-6"">
            <div class=""card"">
                <div class=""card-header border-0"">

                    <h3 class=""card-title"">
                        <i class=""far fa-calendar-alt""></i>
                        Choose Date
                    </h3>

                </div>

                <div class=""card-body pt-0"">


                    <div id=""datepicker"" style=""width: 100%""></div>
                </div>

            </div>
           
        </div>
        <div id=""slotsContainer"" class=""col-md-6"" style=""display: none;"">


            <div class=""card"">
                <div class=""card-header border-0"">

                    <h3 class=""card-title"">
                        <i");
            WriteLiteral(@" class=""far fa-calendar-alt""></i>
                        Choose Time
                    </h3>

                </div>

                <div class=""card-body pt-3"">


                    <div id=""slots"">
                    </div>




                </div>
				</div>




            </div>
            <div class=""col-md-12 text-left mt-3"">
                <button onclick=""saveSlots()"" class=""btn btn-success my-auto"">Save</button>
            </div>
        </div>
</div>


<script>
	$('#datepicker').datepicker({
		startDate: truncateDate(new Date())
	});

	function truncateDate(date) {
		return new Date(date.getFullYear(), date.getMonth(), date.getDate());
	}

	$('#datepicker').on('changeDate', function () {
		$("".wrapper"").block({ message: '' });
		$.ajax({
			type: ""GET"",
			url: ""/api/slot/GetSlot?date="" + $('#datepicker').datepicker('getFormattedDate'),
			contentType: ""application/json; charset=utf-8"",
			dataType: ""json"",
			success: function (response) {
				$(""#slots"").html("""");
				for (var i = 0; i");
            WriteLiteral(@" < 8; i++) {
					var isCheckedString = response[i].isAvailable ? """" : 'checked = ""checked""'
					var element = '<label for=""slot' + i + '"" class=""mr-4"">' + response[i].slotName + '</label>' +
						'<input type=""checkbox"" id=""slot' + i + '"" name=""' + response[i].slotName + '"" ' + isCheckedString + ' />' + ""<br/>"";
					$(""#slots"").append(element);
				}
				$(""#slotsContainer"").show();
				$("".wrapper"").unblock({ message: '' });
			},
			failure: function (response) {
				$("".wrapper"").unblock({ message: '' });
			}
		});
	});

	function saveSlots() {
		$("".wrapper"").block({ message: '' });
		var slots = [];
		$(""#slots input:checked"").each(function () {
			slots.push($(this).attr('name'));
		});
		$.ajax({
			type: ""Post"",
			url: ""/api/slot/SaveSlots?date="" + $('#datepicker').datepicker('getFormattedDate'),
			data: JSON.stringify(slots),
			contentType: ""application/json; charset=utf-8"",
			//dataType: ""json"",
			success: function (response) {
				$("".wrapper"").unblock({ message: '' });
				swal({
					ty");
            WriteLiteral("pe: \'success\',\n\t\t\t\t\ttitle: \'Updated Successfully!\',\n\t\t\t\t});\n\t\t\t},\n\t\t\tfailure: function (response) {\n\t\t\t\t$(\".wrapper\").unblock({ message: \'\' });\n\t\t\t}\n\t\t});\n\t}\n</script>\n<style>\n\t#datepicker .datepicker-inline {\n\t\tmargin: auto\n\t}\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ayush.slotsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ayush.slotsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ayush.slotsModel>)PageContext?.ViewData;
        public ayush.slotsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
