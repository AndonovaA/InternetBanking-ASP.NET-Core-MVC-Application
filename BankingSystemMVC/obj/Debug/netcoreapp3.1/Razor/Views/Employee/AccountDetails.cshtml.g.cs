#pragma checksum "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Employee\AccountDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "948ca97e0062ad3d1f6e335275861818bcfb3a64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_AccountDetails), @"mvc.1.0.view", @"/Views/Employee/AccountDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"948ca97e0062ad3d1f6e335275861818bcfb3a64", @"/Views/Employee/AccountDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba8de078b1ed5b7593e4c35c8e9ef031429d241c", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_AccountDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BankingSystemMVC.Models.BankAccount>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EmployeeClients", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AccountReport", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeactivateBankAccount", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark float-right mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Employee\AccountDetails.cshtml"
  
    ViewData["Title"] = "Детали";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Content Header (Page header) -->
<section class=""content-header"">
    <div class=""container-fluid"">
        <div class=""row mb-2"">
            <div class=""col-sm-6"">
                <h1>Детали за сметка</h1>
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
                        <div class=""col-12 col-sm-4"">
                            <div class=""info-box bg-light"">
                                <div class=""info-box-content"">
                                    <span class=""info-box-text text-center text-muted""> ");
#nullable restore
#line 29 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Employee\AccountDetails.cshtml"
                                                                                   Write(Html.DisplayNameFor(model => model.AvailBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n                                    <span class=\"info-box-number text-center text-muted mb-0\"> ");
#nullable restore
#line 30 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Employee\AccountDetails.cshtml"
                                                                                          Write(Html.DisplayFor(model => model.AvailBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </span>
                                </div>
                            </div>
                        </div>
                        <div class=""col-12 col-sm-4"">
                            <div class=""info-box bg-light"">
                                <div class=""info-box-content"">
                                    <span class=""info-box-text text-center text-muted"">");
#nullable restore
#line 37 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Employee\AccountDetails.cshtml"
                                                                                  Write(Html.DisplayNameFor(model => model.PendingBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <span class=\"info-box-number text-center text-muted mb-0\"> ");
#nullable restore
#line 38 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Employee\AccountDetails.cshtml"
                                                                                          Write(Html.DisplayFor(model => model.PendingBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </div>
                            </div>
                        </div>
                        <div class=""col-12 col-sm-4"">
                            <div class=""info-box bg-light"">
                                <div class=""info-box-content"">
                                    <span class=""info-box-text text-center text-muted""> ");
#nullable restore
#line 45 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Employee\AccountDetails.cshtml"
                                                                                   Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <span class=\"info-box-number text-center text-muted mb-0\"> ");
#nullable restore
#line 46 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Employee\AccountDetails.cshtml"
                                                                                          Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </span>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-12"">
                            <div class=""card card-primary"">
                                <div class=""card-header"">
                                    <h3 class=""card-title"">Општи податоци за сметка: <b>");
#nullable restore
#line 55 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Employee\AccountDetails.cshtml"
                                                                                   Write(Html.DisplayFor(model => model.AccountNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b></h3>
                                    <div class=""card-tools"">
                                        <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"" data-toggle=""tooltip"" title=""Collapse"">
                                            <i class=""fas fa-minus""></i>
                                        </button>
                                    </div>
                                </div>
                                <div class=""card-body"">
                                    <dl class=""row"">
                                        <dt class=""col-sm-6"">
                                            ");
#nullable restore
#line 65 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Employee\AccountDetails.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Customer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-6\">\r\n                                            ");
#nullable restore
#line 68 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Employee\AccountDetails.cshtml"
                                       Write(Html.DisplayFor(model => model.Customer.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dd>\r\n                                        <dt class=\"col-sm-6\">\r\n                                            ");
#nullable restore
#line 71 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Employee\AccountDetails.cshtml"
                                       Write(Html.DisplayNameFor(model => model.OpenDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-6\">\r\n                                            ");
#nullable restore
#line 74 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Employee\AccountDetails.cshtml"
                                       Write(Html.DisplayFor(model => model.OpenDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dd>\r\n                                        <dt class=\"col-sm-6\">\r\n                                            ");
#nullable restore
#line 77 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Employee\AccountDetails.cshtml"
                                       Write(Html.DisplayNameFor(model => model.CloseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-6\">\r\n                                            ");
#nullable restore
#line 80 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Employee\AccountDetails.cshtml"
                                       Write(Html.DisplayFor(model => model.CloseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dd>\r\n                                        <dt class=\"col-sm-6\">\r\n                                            ");
#nullable restore
#line 83 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Employee\AccountDetails.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-6\">\r\n                                            ");
#nullable restore
#line 86 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Employee\AccountDetails.cshtml"
                                       Write(Html.DisplayFor(model => model.Product.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dd>\r\n                                        <dt class=\"col-sm-6\">\r\n                                            ");
#nullable restore
#line 89 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Employee\AccountDetails.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Employee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-6\">\r\n                                            ");
#nullable restore
#line 92 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Employee\AccountDetails.cshtml"
                                       Write(Html.DisplayFor(model => model.Employee.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </dd>
                                    </dl>
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
#line 106 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Employee\AccountDetails.cshtml"
                       Write(Html.DisplayNameFor(model => model.Customer.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <b class=\"d-block\"> ");
#nullable restore
#line 107 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Employee\AccountDetails.cshtml"
                                           Write(Html.DisplayFor(model => model.Customer.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b>\r\n                        </p>\r\n                        <p class=\"text-sm\">\r\n                            ");
#nullable restore
#line 110 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Employee\AccountDetails.cshtml"
                       Write(Html.DisplayNameFor(model => model.Customer.BirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <b class=\"d-block\">");
#nullable restore
#line 111 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Employee\AccountDetails.cshtml"
                                          Write(Html.DisplayFor(model => model.Customer.BirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b>\r\n                        </p>\r\n                        <p class=\"text-sm\">\r\n                            ");
#nullable restore
#line 114 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Employee\AccountDetails.cshtml"
                       Write(Html.DisplayNameFor(model => model.Customer.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <b class=\"d-block\">");
#nullable restore
#line 115 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Employee\AccountDetails.cshtml"
                                          Write(Html.DisplayFor(model => model.Customer.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b>\r\n                        </p>\r\n                        <p class=\"text-sm\">\r\n                            ");
#nullable restore
#line 118 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Employee\AccountDetails.cshtml"
                       Write(Html.DisplayNameFor(model => model.Customer.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <b class=\"d-block\">");
#nullable restore
#line 119 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Employee\AccountDetails.cshtml"
                                          Write(Html.DisplayFor(model => model.Customer.City));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b>\r\n                        </p>\r\n                        <p class=\"text-sm\">\r\n                            ");
#nullable restore
#line 122 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Employee\AccountDetails.cshtml"
                       Write(Html.DisplayNameFor(model => model.Customer.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <b class=\"d-block\">");
#nullable restore
#line 123 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Employee\AccountDetails.cshtml"
                                          Write(Html.DisplayFor(model => model.Customer.State));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b>\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-12\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "948ca97e0062ad3d1f6e335275861818bcfb3a6421703", async() => {
                WriteLiteral("Назад кон клиенти");
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
#line 132 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Employee\AccountDetails.cshtml"
                                              WriteLiteral(ViewData["EmployeeId"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 133 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Employee\AccountDetails.cshtml"
              if (Model.Status == "ACTIVE")
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "948ca97e0062ad3d1f6e335275861818bcfb3a6424361", async() => {
                WriteLiteral("Извештај за сметка");
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
#line 135 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Employee\AccountDetails.cshtml"
                                                    WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 135 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Employee\AccountDetails.cshtml"
                                                                               WriteLiteral(ViewData["EmployeeId"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["emId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-emId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["emId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "948ca97e0062ad3d1f6e335275861818bcfb3a6427516", async() => {
                WriteLiteral("\r\n                        Деактивирај сметка\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 136 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Employee\AccountDetails.cshtml"
                                                            WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 136 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Employee\AccountDetails.cshtml"
                                                                                       WriteLiteral(ViewData["EmployeeId"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["emId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-emId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["emId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 139 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Employee\AccountDetails.cshtml"
              }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "948ca97e0062ad3d1f6e335275861818bcfb3a6431048", async() => {
                WriteLiteral("\r\n                        Активирај сметка\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 142 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Employee\AccountDetails.cshtml"
                                                            WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 142 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Employee\AccountDetails.cshtml"
                                                                                       WriteLiteral(ViewData["EmployeeId"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["emId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-emId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["emId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 145 "D:\ФЕИТ\VI семестар\Развој на серверски web апликации\Семинарска-1\BankingSystemMVC\BankingSystemMVC\Views\Employee\AccountDetails.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BankingSystemMVC.Models.BankAccount> Html { get; private set; }
    }
}
#pragma warning restore 1591
