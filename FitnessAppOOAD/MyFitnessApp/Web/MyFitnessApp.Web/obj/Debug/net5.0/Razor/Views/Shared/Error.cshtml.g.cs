#pragma checksum "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Views\Shared\Error.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "fc239a2b6327c97f8b6ad494b9354c3ce0bc14ec5bdf007d017d16beb044fca0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line (3,2)-(4,1) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Views\_ViewImports.cshtml"
using MyFitnessApp.Web

#nullable disable
    ;
#nullable restore
#line (4,2)-(5,1) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Views\_ViewImports.cshtml"
using MyFitnessApp.Web.ViewModels

#nullable disable
    ;
#nullable restore
#line (5,2)-(6,1) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Views\_ViewImports.cshtml"
using MyFitnessApp.Web.ViewModels.Exercises

#nullable disable
    ;
#nullable restore
#line (6,2)-(7,1) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Views\_ViewImports.cshtml"
using MyFitnessApp.Web.ViewModels.Articles

#nullable disable
    ;
#nullable restore
#line (7,2)-(8,1) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Views\_ViewImports.cshtml"
using MyFitnessApp.Web.ViewModels.Forum

#nullable disable
    ;
#nullable restore
#line (8,2)-(9,1) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Views\_ViewImports.cshtml"
using MyFitnessApp.Web.ViewModels.Posts

#nullable disable
    ;
#nullable restore
#line (9,2)-(10,1) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Views\_ViewImports.cshtml"
using MyFitnessApp.Web.ViewModels.Foods

#nullable disable
    ;
#nullable restore
#line (10,2)-(11,1) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Views\_ViewImports.cshtml"
using MyFitnessApp.Web.ViewModels.Users

#nullable disable
    ;
#nullable restore
#line (11,2)-(12,1) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Views\_ViewImports.cshtml"
using MyFitnessApp.Web.ViewModels.Profiles

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"fc239a2b6327c97f8b6ad494b9354c3ce0bc14ec5bdf007d017d16beb044fca0", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"5c22b595ed9b06fc9c72bac8df881d52992275f1fbfb41ae41a60a22a3e9b438", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line (2,3)-(4,1) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Views\Shared\Error.cshtml"

    this.ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<h1 class=\"text-danger\">Error.</h1>\r\n<h2 class=\"text-danger\">An error occurred while processing your request.</h2>\r\n\r\n");
#nullable restore
#line (9,2)-(11,1) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Views\Shared\Error.cshtml"
if (this.Model.ShowRequestId)
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <p>\r\n        <strong>Request ID:</strong> <code>");
            Write(
#nullable restore
#line (12,45)-(12,65) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Views\Shared\Error.cshtml"
this.Model.RequestId

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</code>\r\n    </p>\r\n");
#nullable restore
#line (14,1)-(15,1) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Views\Shared\Error.cshtml"
}

#line default
#line hidden
#nullable disable

            WriteLiteral(@"
<h3>Development Mode</h3>
<p>
    Swapping to <strong>Development</strong> environment will display more detailed information about the error that occurred.
</p>
<p>
    <strong>The Development environment shouldn't be enabled for deployed applications.</strong>
    It can result in displaying sensitive information from exceptions to end users.
    For local debugging, enable the <strong>Development</strong> environment by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>
    and restarting the app.
</p>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
