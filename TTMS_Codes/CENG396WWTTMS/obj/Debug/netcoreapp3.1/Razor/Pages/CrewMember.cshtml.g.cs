#pragma checksum "C:\Users\User\source\repos\CENG396WWTTMS\CENG396WWTTMS\Pages\CrewMember.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2033cbd9040b2b2743e964a44e3a7358c4b2e0de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CENG396WWTTMS.Pages.Pages_CrewMember), @"mvc.1.0.razor-page", @"/Pages/CrewMember.cshtml")]
namespace CENG396WWTTMS.Pages
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
#line 1 "C:\Users\User\source\repos\CENG396WWTTMS\CENG396WWTTMS\Pages\_ViewImports.cshtml"
using CENG396WWTTMS;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2033cbd9040b2b2743e964a44e3a7358c4b2e0de", @"/Pages/CrewMember.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0350dd407f85563d994e7d255f94d02e31c77f14", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CrewMember : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #9acbff"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sendButton"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("Message2()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Save", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("Message()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\User\source\repos\CENG396WWTTMS\CENG396WWTTMS\Pages\CrewMember.cshtml"
  
    ViewData["Title"] = "CrewMember";
    Layout = "~/Pages/Shared/_LayoutCrewMember.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2033cbd9040b2b2743e964a44e3a7358c4b2e0de6426", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>WELCOME</title>
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2033cbd9040b2b2743e964a44e3a7358c4b2e0de7979", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 21 "C:\Users\User\source\repos\CENG396WWTTMS\CENG396WWTTMS\Pages\CrewMember.cshtml"
Write(Model.Msg);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <!--<button type=\"submit\" asp-page=\"Index\" asp-page-handler=\"Logout\" style=\"float:right; background-color:lightgrey\" class=\"btn\" value=\"Logout\">Logout</button>-->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2033cbd9040b2b2743e964a44e3a7358c4b2e0de8645", async() => {
                    WriteLiteral(@"
        <style>
            table {
                font-family: arial, sans-serif;
                border-collapse: collapse;
                width: 100%;
                background-color: #8ec8ff;
            }

            td, th {
                border: 1px solid #dddddd;
                text-align: left;
                padding: 8px;
            }

            tr:nth-child(even) {
                background-color: #dddddd;
            }
        </style>

        <h4>Assigned Trouble's Box</h4>

        <table>
            <thead>
                <tr>
                    <th>
                        ");
#nullable restore
#line 49 "C:\Users\User\source\repos\CENG396WWTTMS\CENG396WWTTMS\Pages\CrewMember.cshtml"
                   Write(Html.DisplayNameFor(model => model.Trouble[0].TtNumber));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 52 "C:\Users\User\source\repos\CENG396WWTTMS\CENG396WWTTMS\Pages\CrewMember.cshtml"
                   Write(Html.DisplayNameFor(model => model.Trouble[0].AbonNum));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 55 "C:\Users\User\source\repos\CENG396WWTTMS\CENG396WWTTMS\Pages\CrewMember.cshtml"
                   Write(Html.DisplayNameFor(model => model.Trouble[0].FullName));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 58 "C:\Users\User\source\repos\CENG396WWTTMS\CENG396WWTTMS\Pages\CrewMember.cshtml"
                   Write(Html.DisplayNameFor(model => model.Trouble[0].Email));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 61 "C:\Users\User\source\repos\CENG396WWTTMS\CENG396WWTTMS\Pages\CrewMember.cshtml"
                   Write(Html.DisplayNameFor(model => model.Trouble[0].TroubleDesc));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 64 "C:\Users\User\source\repos\CENG396WWTTMS\CENG396WWTTMS\Pages\CrewMember.cshtml"
                   Write(Html.DisplayNameFor(model => model.Trouble[0].TicketState));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 69 "C:\Users\User\source\repos\CENG396WWTTMS\CENG396WWTTMS\Pages\CrewMember.cshtml"
                 foreach (var item in Model.Trouble)
                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 73 "C:\Users\User\source\repos\CENG396WWTTMS\CENG396WWTTMS\Pages\CrewMember.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TtNumber));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 76 "C:\Users\User\source\repos\CENG396WWTTMS\CENG396WWTTMS\Pages\CrewMember.cshtml"
                       Write(Html.DisplayFor(modelItem => item.AbonNum));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 79 "C:\Users\User\source\repos\CENG396WWTTMS\CENG396WWTTMS\Pages\CrewMember.cshtml"
                       Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 82 "C:\Users\User\source\repos\CENG396WWTTMS\CENG396WWTTMS\Pages\CrewMember.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 85 "C:\Users\User\source\repos\CENG396WWTTMS\CENG396WWTTMS\Pages\CrewMember.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TroubleDesc));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 88 "C:\Users\User\source\repos\CENG396WWTTMS\CENG396WWTTMS\Pages\CrewMember.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TicketState));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 91 "C:\Users\User\source\repos\CENG396WWTTMS\CENG396WWTTMS\Pages\CrewMember.cshtml"
                }

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"            </tbody>
        </table>
        <div>
            <label class=""control-label"">Enter the ticket number of the trouble you want to see the address of it:</label>
            <input class=""control-label "" id=""ttnumber"" name=""ttnumber"" />
            <div class=""form-group"">
                <center>");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2033cbd9040b2b2743e964a44e3a7358c4b2e0de14886", async() => {
                        WriteLiteral("Send the address via E-mail");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"</center>
            </div>
            <label class=""control-label"">Enter the ticket number of the trouble you want to close:</label>
            <input class=""control-label "" id=""tnumber"" name=""tnumber"" />
            <div class=""form-group"">
                <center>");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2033cbd9040b2b2743e964a44e3a7358c4b2e0de16681", async() => {
                        WriteLiteral("Close the ticket");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_5.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("</center>\r\n            </div>\r\n        </div>\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n<script>\r\n    function Message() {\r\n        alert(\"Ticket is closed!\");\r\n    }\r\n    function Message2() {\r\n        alert(\"The address is sent via E-mail!\");\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CENG396WWTTMS.CrewMemberModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CENG396WWTTMS.CrewMemberModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CENG396WWTTMS.CrewMemberModel>)PageContext?.ViewData;
        public CENG396WWTTMS.CrewMemberModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
