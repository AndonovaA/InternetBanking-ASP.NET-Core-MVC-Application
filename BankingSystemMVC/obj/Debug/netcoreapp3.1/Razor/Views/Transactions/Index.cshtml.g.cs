#pragma checksum "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Transactions\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eec93167bbc927baf9c4b4962c10829c2101c594"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transactions_Index), @"mvc.1.0.view", @"/Views/Transactions/Index.cshtml")]
namespace AspNetCore
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
#line 1 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\_ViewImports.cshtml"
using BankingSystemMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\_ViewImports.cshtml"
using BankingSystemMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eec93167bbc927baf9c4b4962c10829c2101c594", @"/Views/Transactions/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba8de078b1ed5b7593e4c35c8e9ef031429d241c", @"/Views/_ViewImports.cshtml")]
    public class Views_Transactions_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BankingSystemMVC.Models.Transaction>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Transactions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Transactions\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Content Header (Page header) -->\r\n<section class=\"content-header\">\r\n    <div class=\"container-fluid\">\r\n        <div class=\"row mb-2\">\r\n            <div class=\"col-sm-6\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eec93167bbc927baf9c4b4962c10829c2101c5944704", async() => {
                WriteLiteral("\r\n                <h1>Листа на сите трансакции</h1>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
</section>

<!-- Main content -->
<section class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card"">
                    <div class=""card-header""></div>
                    <div class=""card-body"">
                        <table id=""example1"" class=""table table-bordered table-striped"">
                            <thead>
                                <tr>
                                    <th>
                                        ");
#nullable restore
#line 32 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Transactions\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Account));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 35 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Transactions\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 38 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Transactions\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.TransDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 41 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Transactions\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.TotalBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 44 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Transactions\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 47 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Transactions\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Receiver));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 50 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Transactions\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Employee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th></th>\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
#nullable restore
#line 56 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Transactions\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 60 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Transactions\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Account.AccountNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 63 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Transactions\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 66 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Transactions\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.TransDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 69 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Transactions\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.TotalBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 72 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Transactions\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 75 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Transactions\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Receiver));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 78 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Transactions\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Employee.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eec93167bbc927baf9c4b4962c10829c2101c59413840", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Transactions\Index.cshtml"
                                                                  WriteLiteral(item.Id);

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
            WriteLiteral("<br/>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 84 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Transactions\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                            <tfoot>\r\n                                <tr>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 89 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Transactions\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Account));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 92 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Transactions\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 95 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Transactions\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.TransDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 98 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Transactions\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.TotalBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 101 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Transactions\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 104 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Transactions\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Receiver));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 107 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Transactions\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Employee));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </th>
                                    <th></th>
                                </tr>
                            </tfoot>
                        </table>
                    </div>
                </div>
                <!-- /.card -->
            </div>
        </div>
    </div>

</section>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 123 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Transactions\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral("    <script>\r\n        $(document).ready(function () {\r\n            $(\"#example1\").DataTable({\r\n            \"responsive\": true,\r\n            \"autoWidth\": false,\r\n            });\r\n        });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BankingSystemMVC.Models.Transaction>> Html { get; private set; }
    }
}
#pragma warning restore 1591