#pragma checksum "C:\Users\kamin\projekt-zaliczeniowy-marcin-kaminski\workday\Pages\VacationRequest\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9785eea5d2be2917ea3aa5514b57450e28c4aad2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(workday.Pages.VacationRequest.Pages_VacationRequest_Index), @"mvc.1.0.razor-page", @"/Pages/VacationRequest/Index.cshtml")]
namespace workday.Pages.VacationRequest
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
#line 1 "C:\Users\kamin\projekt-zaliczeniowy-marcin-kaminski\workday\Pages\_ViewImports.cshtml"
using workday;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9785eea5d2be2917ea3aa5514b57450e28c4aad2", @"/Pages/VacationRequest/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f18483164eb0e5ba56986de1c8637cd64c0770d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_VacationRequest_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\kamin\projekt-zaliczeniowy-marcin-kaminski\workday\Pages\VacationRequest\Index.cshtml"
  
    ViewData["Title"] = "Wnioski urlopowe";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n\r\n    <h2>Wnioski do zaakceptowania</h2>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 16 "C:\Users\kamin\projekt-zaliczeniowy-marcin-kaminski\workday\Pages\VacationRequest\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.VacationRequest[0].Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 19 "C:\Users\kamin\projekt-zaliczeniowy-marcin-kaminski\workday\Pages\VacationRequest\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.VacationRequest[0].DateOfRequest));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 22 "C:\Users\kamin\projekt-zaliczeniowy-marcin-kaminski\workday\Pages\VacationRequest\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.VacationRequest[0].From));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 25 "C:\Users\kamin\projekt-zaliczeniowy-marcin-kaminski\workday\Pages\VacationRequest\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.VacationRequest[0].To));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n\r\n");
#nullable restore
#line 32 "C:\Users\kamin\projekt-zaliczeniowy-marcin-kaminski\workday\Pages\VacationRequest\Index.cshtml"
             foreach (var item in Model.VacationRequest)
            {
                if (item.status.Equals(false))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 38 "C:\Users\kamin\projekt-zaliczeniowy-marcin-kaminski\workday\Pages\VacationRequest\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 41 "C:\Users\kamin\projekt-zaliczeniowy-marcin-kaminski\workday\Pages\VacationRequest\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DateOfRequest));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 44 "C:\Users\kamin\projekt-zaliczeniowy-marcin-kaminski\workday\Pages\VacationRequest\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.From));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 47 "C:\Users\kamin\projekt-zaliczeniowy-marcin-kaminski\workday\Pages\VacationRequest\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.To));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9785eea5d2be2917ea3aa5514b57450e28c4aad27183", async() => {
                WriteLiteral("Zaakceptuj");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\kamin\projekt-zaliczeniowy-marcin-kaminski\workday\Pages\VacationRequest\Index.cshtml"
                                                   WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 53 "C:\Users\kamin\projekt-zaliczeniowy-marcin-kaminski\workday\Pages\VacationRequest\Index.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    <h2>Stare Wnioski</h2>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 63 "C:\Users\kamin\projekt-zaliczeniowy-marcin-kaminski\workday\Pages\VacationRequest\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.VacationRequest[0].Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 66 "C:\Users\kamin\projekt-zaliczeniowy-marcin-kaminski\workday\Pages\VacationRequest\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.VacationRequest[0].DateOfRequest));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 69 "C:\Users\kamin\projekt-zaliczeniowy-marcin-kaminski\workday\Pages\VacationRequest\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.VacationRequest[0].From));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 72 "C:\Users\kamin\projekt-zaliczeniowy-marcin-kaminski\workday\Pages\VacationRequest\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.VacationRequest[0].To));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n\r\n");
#nullable restore
#line 79 "C:\Users\kamin\projekt-zaliczeniowy-marcin-kaminski\workday\Pages\VacationRequest\Index.cshtml"
             foreach (var item in Model.VacationRequest)
            {
                if (item.status.Equals(true))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 85 "C:\Users\kamin\projekt-zaliczeniowy-marcin-kaminski\workday\Pages\VacationRequest\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 88 "C:\Users\kamin\projekt-zaliczeniowy-marcin-kaminski\workday\Pages\VacationRequest\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DateOfRequest));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 91 "C:\Users\kamin\projekt-zaliczeniowy-marcin-kaminski\workday\Pages\VacationRequest\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.From));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 94 "C:\Users\kamin\projekt-zaliczeniowy-marcin-kaminski\workday\Pages\VacationRequest\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.To));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 97 "C:\Users\kamin\projekt-zaliczeniowy-marcin-kaminski\workday\Pages\VacationRequest\Index.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<workday.Pages_VacationRequest.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<workday.Pages_VacationRequest.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<workday.Pages_VacationRequest.IndexModel>)PageContext?.ViewData;
        public workday.Pages_VacationRequest.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
