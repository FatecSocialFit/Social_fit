<<<<<<< HEAD
#pragma checksum "D:\FATEC\LabEngenhariaSofware\SocialFit\SocialFit\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4876b3fcc0e611853b9cf7342230aba8c278c55e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SocialFit.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(SocialFit.Pages.Pages_Index), null)]
namespace SocialFit.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\FATEC\LabEngenhariaSofware\SocialFit\SocialFit\Pages\_ViewImports.cshtml"
using SocialFit;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4876b3fcc0e611853b9cf7342230aba8c278c55e", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93e6bc11a7129a1e02cc50afe2cca2d989d570e5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Clients/Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\FATEC\LabEngenhariaSofware\SocialFit\SocialFit\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 152, true);
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\" banner col\">\r\n            <h5>Venha fazer parte da sociedade fitness que mais cresce no país!</h5>\r\n            ");
            EndContext();
            BeginContext(223, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4876b3fcc0e611853b9cf7342230aba8c278c55e3626", async() => {
                BeginContext(253, 63, true);
                WriteLiteral("<button type=\"button\" class=\"btn-baner\">Junte-se a nós</button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(320, 2598, true);
            WriteLiteral(@"
    </div>
</div>


<section class=""anuncios"">
    <h5>Aqui você encontrará</h5>
    <div class=""cards-img"">
        <div class=""card container-card"">
            <img class=""card-img-top"" src=""./Assets/saude-image.jpeg"" alt=""saude e lazer"">
            <div class=""card-body"">
                <h5 class=""card-title"">Saúde e bem estar</h5>
            </div>
        </div>

        <div class=""card container-card"">
            <img class=""card-img-top"" src=""./Assets/treino.jpg"" alt=""treino"">
            <div class=""card-body"">
                <h5 class=""card-title"">Treino de qualidade</h5>
            </div>
        </div>

        <div class=""card container-card"">
            <img class=""card-img-top"" src=""./Assets/alimentação.jpg"" alt=""alimentação"">
            <div class=""card-body"">
                <h5 class=""card-title"">Alimentação saudavél</h5>
            </div>
        </div>

        <div class=""card container-card"">
            <img class=""card-img-top"" src=""./Assets/aca");
            WriteLiteral(@"demia.jpg"" alt=""academia"">
            <div class=""card-body"">
                <h5 class=""card-title"">Parceiros em todo país</h5>
            </div>
        </div>
    </div>

</section>

<section class=""vantagens"">
    <h5 style=""text-align: center"">Tornar-se um parceiro, você poderá :</h5>

    <div class=""lista-vantagens"">
        <ul>
            <li>
                Ser um proficional ou trainner <a href=""#"">(saiba mais cliecando aqui) </a>
            </li>

            <li>
                Encontrar amigos através do portal
            </li>

            <li>
                Ver o seu progresso através da time-line
            </li>

            <li>
                Encontrar pessoas motivadoras
            </li>

            <li>
                Ter sua conta vinculada com a sua academia em qualquer lugar do país <a href=""#"">(saiba como)</a>
            </li>

        </ul>
    </div>
    <button type=""button"" class=""btn-baner"">Junte-se a nós</button>
</section>
");
            WriteLiteral(@"
<section class=""container-aplicativos"">
    <h5> Baixe nosso aplicativo através da loja do seu aparelho que está disponível nas plataformas:</h5>
    <div class=""loja-aplicativos"">
        <ul>
            <li>
                <i class='fas fa-apple-alt' style='font-size:4.5rem'></i>
                <p>IOS</p>
               
            </li>

            <li>
                <i class='fab fa-android' style='font-size:4.5rem'></i>
                <p>ANDROID</p>

            </li>
        </ul>
    </div>

</section>
   

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
=======
#pragma checksum "D:\FATEC\LabEngenhariaSofware\SocialFit\SocialFit\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a883127c83908e092b676d6f66744dce8fbb2266"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SocialFit.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(SocialFit.Pages.Pages_Index), null)]
namespace SocialFit.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\FATEC\LabEngenhariaSofware\SocialFit\SocialFit\Pages\_ViewImports.cshtml"
using SocialFit;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a883127c83908e092b676d6f66744dce8fbb2266", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93e6bc11a7129a1e02cc50afe2cca2d989d570e5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Clients/Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\FATEC\LabEngenhariaSofware\SocialFit\SocialFit\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 152, true);
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\" banner col\">\r\n            <h5>Venha fazer parte da sociedade fitness que mais cresce no país!</h5>\r\n            ");
            EndContext();
            BeginContext(223, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a883127c83908e092b676d6f66744dce8fbb22663626", async() => {
                BeginContext(253, 63, true);
                WriteLiteral("<button type=\"button\" class=\"btn-baner\">Junte-se a nós</button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(320, 2671, true);
            WriteLiteral(@"
    </div>
</div>


<section class=""anuncios"">
    <h5>Aqui você encontrará</h5>
    <div class=""cards-img"">
        <div class=""card container-card"">
            <img class=""card-img-top"" src=""./Assets/saude-image.jpeg"" alt=""saude e lazer"">
            <div class=""card-body"">
                <h5 class=""card-title"">Saúde e bem estar</h5>
            </div>
        </div>

        <div class=""card container-card"">
            <img class=""card-img-top"" src=""./Assets/treino.jpg"" alt=""treino"">
            <div class=""card-body"">
                <h5 class=""card-title"">Treino de qualidade</h5>
            </div>
        </div>

        <div class=""card container-card"">
            <img class=""card-img-top"" src=""./Assets/alimentação.jpg"" alt=""alimentação"">
            <div class=""card-body"">
                <h5 class=""card-title"">Alimentação saudavél</h5>
            </div>
        </div>

        <div class=""card container-card"">
            <img class=""card-img-top"" src=""./Assets/aca");
            WriteLiteral(@"demia.jpg"" alt=""academia"">
            <div class=""card-body"">
                <h5 class=""card-title"">Parceiros em todo país</h5>
            </div>
        </div>
    </div>

</section>

<section class=""vantagens"">
    <h5 style=""text-align: center"">Tornar-se um parceiro, você poderá :</h5>

    <div class=""lista-vantagens"">
        <ul>
            <li>
                Ser um proficional ou trainner <a href=""#"" class=""text-decoration-none text-white""><b>(saiba mais cliecando aqui)</b> </a>
            </li>

            <li>
                Encontrar amigos através do portal
            </li>

            <li>
                Ver o seu progresso através da time-line
            </li>

            <li>
                Encontrar pessoas motivadoras
            </li>

            <li>
                Ter sua conta vinculada com a sua academia em qualquer lugar do país <a href=""#"" class=""text-white""><b>(saiba como)</b></a>
            </li>

        </ul>
    </div>
    <butt");
            WriteLiteral(@"on type=""button"" class=""btn-baner"">Junte-se a nós</button>
</section>

<section class=""container-aplicativos"">
    <h5> Baixe nosso aplicativo através da loja do seu aparelho que está disponível nas plataformas:</h5>
    <div class=""loja-aplicativos"">
        <ul>
            <li>
                <i class='fas fa-apple-alt' style='font-size:4.5rem'></i>
                <p>IOS</p>
               
            </li>

            <li>
                <i class='fab fa-android' style='font-size:4.5rem'></i>
                <p>ANDROID</p>

            </li>
        </ul>
    </div>

</section>
   

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
>>>>>>> 97abeff861750ea6d9da11b11eaa77d7c0c1c6d1
