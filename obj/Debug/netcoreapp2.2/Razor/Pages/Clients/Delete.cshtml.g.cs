#pragma checksum "C:\Users\joaov\OneDrive\Área de Trabalho\Trabalho Fatec\Social_fit\Pages\Clients\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "449f4e7fea6aa2445502c065e4082376193a70a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SocialFit.Pages.Clients.Pages_Clients_Delete), @"mvc.1.0.razor-page", @"/Pages/Clients/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Clients/Delete.cshtml", typeof(SocialFit.Pages.Clients.Pages_Clients_Delete), null)]
namespace SocialFit.Pages.Clients
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\joaov\OneDrive\Área de Trabalho\Trabalho Fatec\Social_fit\Pages\_ViewImports.cshtml"
using SocialFit;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"449f4e7fea6aa2445502c065e4082376193a70a3", @"/Pages/Clients/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93e6bc11a7129a1e02cc50afe2cca2d989d570e5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Clients_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\joaov\OneDrive\Área de Trabalho\Trabalho Fatec\Social_fit\Pages\Clients\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(95, 174, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Client</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(270, 48, false);
#line 16 "C:\Users\joaov\OneDrive\Área de Trabalho\Trabalho Fatec\Social_fit\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Client.Login));

#line default
#line hidden
            EndContext();
            BeginContext(318, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(380, 44, false);
#line 19 "C:\Users\joaov\OneDrive\Área de Trabalho\Trabalho Fatec\Social_fit\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Client.Login));

#line default
#line hidden
            EndContext();
            BeginContext(424, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(485, 51, false);
#line 22 "C:\Users\joaov\OneDrive\Área de Trabalho\Trabalho Fatec\Social_fit\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Client.Password));

#line default
#line hidden
            EndContext();
            BeginContext(536, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(598, 47, false);
#line 25 "C:\Users\joaov\OneDrive\Área de Trabalho\Trabalho Fatec\Social_fit\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Client.Password));

#line default
#line hidden
            EndContext();
            BeginContext(645, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(706, 47, false);
#line 28 "C:\Users\joaov\OneDrive\Área de Trabalho\Trabalho Fatec\Social_fit\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Client.Name));

#line default
#line hidden
            EndContext();
            BeginContext(753, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(815, 43, false);
#line 31 "C:\Users\joaov\OneDrive\Área de Trabalho\Trabalho Fatec\Social_fit\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Client.Name));

#line default
#line hidden
            EndContext();
            BeginContext(858, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(919, 48, false);
#line 34 "C:\Users\joaov\OneDrive\Área de Trabalho\Trabalho Fatec\Social_fit\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Client.genre));

#line default
#line hidden
            EndContext();
            BeginContext(967, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1029, 44, false);
#line 37 "C:\Users\joaov\OneDrive\Área de Trabalho\Trabalho Fatec\Social_fit\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Client.genre));

#line default
#line hidden
            EndContext();
            BeginContext(1073, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1134, 51, false);
#line 40 "C:\Users\joaov\OneDrive\Área de Trabalho\Trabalho Fatec\Social_fit\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Client.isActive));

#line default
#line hidden
            EndContext();
            BeginContext(1185, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1247, 47, false);
#line 43 "C:\Users\joaov\OneDrive\Área de Trabalho\Trabalho Fatec\Social_fit\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Client.isActive));

#line default
#line hidden
            EndContext();
            BeginContext(1294, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1355, 51, false);
#line 46 "C:\Users\joaov\OneDrive\Área de Trabalho\Trabalho Fatec\Social_fit\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Client.DateBorn));

#line default
#line hidden
            EndContext();
            BeginContext(1406, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1468, 47, false);
#line 49 "C:\Users\joaov\OneDrive\Área de Trabalho\Trabalho Fatec\Social_fit\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Client.DateBorn));

#line default
#line hidden
            EndContext();
            BeginContext(1515, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1576, 52, false);
#line 52 "C:\Users\joaov\OneDrive\Área de Trabalho\Trabalho Fatec\Social_fit\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Client.CreatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(1628, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1690, 48, false);
#line 55 "C:\Users\joaov\OneDrive\Área de Trabalho\Trabalho Fatec\Social_fit\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Client.CreatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(1738, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1799, 52, false);
#line 58 "C:\Users\joaov\OneDrive\Área de Trabalho\Trabalho Fatec\Social_fit\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Client.UpdatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(1851, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1913, 48, false);
#line 61 "C:\Users\joaov\OneDrive\Área de Trabalho\Trabalho Fatec\Social_fit\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Client.UpdatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(1961, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1999, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "449f4e7fea6aa2445502c065e4082376193a70a311958", async() => {
                BeginContext(2019, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2029, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "449f4e7fea6aa2445502c065e4082376193a70a312351", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 66 "C:\Users\joaov\OneDrive\Área de Trabalho\Trabalho Fatec\Social_fit\Pages\Clients\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Client.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2072, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(2155, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "449f4e7fea6aa2445502c065e4082376193a70a314279", async() => {
                    BeginContext(2177, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2193, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2206, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SocialFit.Pages.Clients.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SocialFit.Pages.Clients.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SocialFit.Pages.Clients.DeleteModel>)PageContext?.ViewData;
        public SocialFit.Pages.Clients.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
