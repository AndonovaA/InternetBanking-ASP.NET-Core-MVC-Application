#pragma checksum "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Customer\CustomerDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dde4851e576a6b8adf84df906f67f45d1fbe21fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_CustomerDetails), @"mvc.1.0.view", @"/Views/Customer/CustomerDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dde4851e576a6b8adf84df906f67f45d1fbe21fb", @"/Views/Customer/CustomerDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba8de078b1ed5b7593e4c35c8e9ef031429d241c", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_CustomerDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BankingSystemMVC.Models.Customer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CustomerAccount", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Customer\CustomerDetails.cshtml"
  
    ViewData["Title"] = "Мои Податоци";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Content Header (Page header) -->\r\n<section class=\"content-header\">\r\n    <div class=\"container-fluid\">\r\n        <div class=\"row mb-2\">\r\n            <div class=\"col-sm-6\">\r\n                <h1>Клиент: ");
#nullable restore
#line 12 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Customer\CustomerDetails.cshtml"
                       Write(ViewData["CustomerName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h1>
            </div>
        </div>
    </div>
</section>

<section class=""content"">
    <!-- Default box -->
    <div class=""card"">
        <div class=""card-body"">
            <div class=""row"">
                <div class=""col-12 col-md-12 col-lg-8 order-2 order-md-1"">
                    <div class=""row"">
                        <div class=""col-12"">
                            <div class=""card card-primary"">
                                <div class=""card-header"">
                                    <h3 class=""card-title"">Активни сметки </h3>
                                    <div class=""card-tools"">
                                        <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"" data-toggle=""tooltip"" title=""Collapse"">
                                            <i class=""fas fa-minus""></i>
                                        </button>
                                    </div>
                                </div>
                            ");
            WriteLiteral("    <div class=\"card-body\">\r\n                                    <ul>\r\n");
#nullable restore
#line 37 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Customer\CustomerDetails.cshtml"
                                         if (Model.Accounts != null)
                                        {
                                            foreach (var item in Model.Accounts)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li>\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dde4851e576a6b8adf84df906f67f45d1fbe21fb6216", async() => {
                WriteLiteral("\r\n                                                        ");
#nullable restore
#line 43 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Customer\CustomerDetails.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.AccountNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Customer\CustomerDetails.cshtml"
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
            WriteLiteral("\r\n                                                </li>\r\n");
#nullable restore
#line 46 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Customer\CustomerDetails.cshtml"
                                            }
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"col-sm-6\">\r\n                                                Немате активни сметки!\r\n                                            </li>\r\n");
#nullable restore
#line 53 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Customer\CustomerDetails.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-12 col-md-12 col-lg-4 order-1 order-md-2"">
                    <h3 class=""text-primary""><i class=""far fa-user"" aria-hidden=""true""></i> Податоци за клиент </h3>
                    <br>
                    <div class=""text-muted"">
                        <p class=""text-sm"">
                            ");
#nullable restore
#line 65 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Customer\CustomerDetails.cshtml"
                       Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <b class=\"d-block\"> ");
#nullable restore
#line 66 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Customer\CustomerDetails.cshtml"
                                           Write(Html.DisplayFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b>\r\n                        </p>\r\n                        <p class=\"text-sm\">\r\n                            ");
#nullable restore
#line 69 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Customer\CustomerDetails.cshtml"
                       Write(Html.DisplayNameFor(model => model.BirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <b class=\"d-block\">");
#nullable restore
#line 70 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Customer\CustomerDetails.cshtml"
                                          Write(Html.DisplayFor(model => model.BirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b>\r\n                        </p>\r\n                        <p class=\"text-sm\">\r\n                            ");
#nullable restore
#line 73 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Customer\CustomerDetails.cshtml"
                       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <b class=\"d-block\">");
#nullable restore
#line 74 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Customer\CustomerDetails.cshtml"
                                          Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b>\r\n                        </p>\r\n                        <p class=\"text-sm\">\r\n                            ");
#nullable restore
#line 77 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Customer\CustomerDetails.cshtml"
                       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <b class=\"d-block\">");
#nullable restore
#line 78 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Customer\CustomerDetails.cshtml"
                                          Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b>\r\n                        </p>\r\n                        <p class=\"text-sm\">\r\n                            ");
#nullable restore
#line 81 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Customer\CustomerDetails.cshtml"
                       Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <b class=\"d-block\">");
#nullable restore
#line 82 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Customer\CustomerDetails.cshtml"
                                          Write(Html.DisplayFor(model => model.State));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b>\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BankingSystemMVC.Models.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
