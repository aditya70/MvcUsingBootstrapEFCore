#pragma checksum "D:\aditya\PracticeProjects\MvcUsingBootstrapTemplate\MvcUsingBootstrapTemplate\Views\Customers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fda7bb9de1d42ef50e684b5d2b87d29b3c0c8e71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_Details), @"mvc.1.0.view", @"/Views/Customers/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customers/Details.cshtml", typeof(AspNetCore.Views_Customers_Details))]
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
#line 1 "D:\aditya\PracticeProjects\MvcUsingBootstrapTemplate\MvcUsingBootstrapTemplate\Views\_ViewImports.cshtml"
using MvcUsingBootstrapTemplate;

#line default
#line hidden
#line 2 "D:\aditya\PracticeProjects\MvcUsingBootstrapTemplate\MvcUsingBootstrapTemplate\Views\_ViewImports.cshtml"
using MvcUsingBootstrapTemplate.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fda7bb9de1d42ef50e684b5d2b87d29b3c0c8e71", @"/Views/Customers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a81782c124524ba8a2462f870bc9169e18f282b", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcUsingBootstrapTemplate.Models.Customers>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\aditya\PracticeProjects\MvcUsingBootstrapTemplate\MvcUsingBootstrapTemplate\Views\Customers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(96, 123, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Customers</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(220, 47, false);
#line 14 "D:\aditya\PracticeProjects\MvcUsingBootstrapTemplate\MvcUsingBootstrapTemplate\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(267, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(311, 43, false);
#line 17 "D:\aditya\PracticeProjects\MvcUsingBootstrapTemplate\MvcUsingBootstrapTemplate\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(354, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(398, 47, false);
#line 20 "D:\aditya\PracticeProjects\MvcUsingBootstrapTemplate\MvcUsingBootstrapTemplate\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ContactName));

#line default
#line hidden
            EndContext();
            BeginContext(445, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(489, 43, false);
#line 23 "D:\aditya\PracticeProjects\MvcUsingBootstrapTemplate\MvcUsingBootstrapTemplate\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.ContactName));

#line default
#line hidden
            EndContext();
            BeginContext(532, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(576, 48, false);
#line 26 "D:\aditya\PracticeProjects\MvcUsingBootstrapTemplate\MvcUsingBootstrapTemplate\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ContactTitle));

#line default
#line hidden
            EndContext();
            BeginContext(624, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(668, 44, false);
#line 29 "D:\aditya\PracticeProjects\MvcUsingBootstrapTemplate\MvcUsingBootstrapTemplate\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.ContactTitle));

#line default
#line hidden
            EndContext();
            BeginContext(712, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(756, 43, false);
#line 32 "D:\aditya\PracticeProjects\MvcUsingBootstrapTemplate\MvcUsingBootstrapTemplate\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(799, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(843, 39, false);
#line 35 "D:\aditya\PracticeProjects\MvcUsingBootstrapTemplate\MvcUsingBootstrapTemplate\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(882, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(926, 40, false);
#line 38 "D:\aditya\PracticeProjects\MvcUsingBootstrapTemplate\MvcUsingBootstrapTemplate\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(966, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1010, 36, false);
#line 41 "D:\aditya\PracticeProjects\MvcUsingBootstrapTemplate\MvcUsingBootstrapTemplate\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(1046, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1090, 42, false);
#line 44 "D:\aditya\PracticeProjects\MvcUsingBootstrapTemplate\MvcUsingBootstrapTemplate\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Region));

#line default
#line hidden
            EndContext();
            BeginContext(1132, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1176, 38, false);
#line 47 "D:\aditya\PracticeProjects\MvcUsingBootstrapTemplate\MvcUsingBootstrapTemplate\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Region));

#line default
#line hidden
            EndContext();
            BeginContext(1214, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1258, 46, false);
#line 50 "D:\aditya\PracticeProjects\MvcUsingBootstrapTemplate\MvcUsingBootstrapTemplate\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(1304, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1348, 42, false);
#line 53 "D:\aditya\PracticeProjects\MvcUsingBootstrapTemplate\MvcUsingBootstrapTemplate\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.PostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(1390, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1434, 43, false);
#line 56 "D:\aditya\PracticeProjects\MvcUsingBootstrapTemplate\MvcUsingBootstrapTemplate\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(1477, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1521, 39, false);
#line 59 "D:\aditya\PracticeProjects\MvcUsingBootstrapTemplate\MvcUsingBootstrapTemplate\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(1560, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1604, 41, false);
#line 62 "D:\aditya\PracticeProjects\MvcUsingBootstrapTemplate\MvcUsingBootstrapTemplate\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1645, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1689, 37, false);
#line 65 "D:\aditya\PracticeProjects\MvcUsingBootstrapTemplate\MvcUsingBootstrapTemplate\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1726, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1770, 39, false);
#line 68 "D:\aditya\PracticeProjects\MvcUsingBootstrapTemplate\MvcUsingBootstrapTemplate\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Fax));

#line default
#line hidden
            EndContext();
            BeginContext(1809, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1853, 35, false);
#line 71 "D:\aditya\PracticeProjects\MvcUsingBootstrapTemplate\MvcUsingBootstrapTemplate\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Fax));

#line default
#line hidden
            EndContext();
            BeginContext(1888, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1935, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bae2810181bd4139a560966adb975fc7", async() => {
                BeginContext(1989, 4, true);
                WriteLiteral("Edit");
                EndContext();
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
#line 76 "D:\aditya\PracticeProjects\MvcUsingBootstrapTemplate\MvcUsingBootstrapTemplate\Views\Customers\Details.cshtml"
                           WriteLiteral(Model.CustomerId);

#line default
#line hidden
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
            EndContext();
            BeginContext(1997, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2005, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4931bfcc5544399abdc359da1475fc0", async() => {
                BeginContext(2027, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2043, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MvcUsingBootstrapTemplate.Models.Customers> Html { get; private set; }
    }
}
#pragma warning restore 1591
