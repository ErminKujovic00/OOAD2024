#pragma checksum "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Areas\Administration\Views\Exercises\Delete.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b5c5f68a2d3ea3c358a48142f51e0e478cdfa8f5c98602aaf143c1757dc42460"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administration_Views_Exercises_Delete), @"mvc.1.0.view", @"/Areas/Administration/Views/Exercises/Delete.cshtml")]
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
#line (1,2)-(2,1) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Areas\Administration\Views\_ViewImports.cshtml"
using MyFitnessApp.Web

#nullable disable
    ;
#nullable restore
#line (2,2)-(3,1) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Areas\Administration\Views\_ViewImports.cshtml"
using MyFitnessApp.Web.ViewModels

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"b5c5f68a2d3ea3c358a48142f51e0e478cdfa8f5c98602aaf143c1757dc42460", @"/Areas/Administration/Views/Exercises/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"c320d7c797be209ce04bf087cca216ddb7b2d3315a03965f12ecf5377df8c96e", @"/Areas/Administration/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Administration_Views_Exercises_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyFitnessApp.Data.Models.Exercise>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line (3,3)-(5,1) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Areas\Administration\Views\Exercises\Delete.cshtml"

    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Exercise</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line (15,14)-(15,54) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Areas\Administration\Views\Exercises\Delete.cshtml"
Html.DisplayNameFor(model => model.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line (18,14)-(18,50) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Areas\Administration\Views\Exercises\Delete.cshtml"
Html.DisplayFor(model => model.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line (21,14)-(21,61) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Areas\Administration\Views\Exercises\Delete.cshtml"
Html.DisplayNameFor(model => model.Description)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line (24,14)-(24,57) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Areas\Administration\Views\Exercises\Delete.cshtml"
Html.DisplayFor(model => model.Description)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line (27,14)-(27,60) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Areas\Administration\Views\Exercises\Delete.cshtml"
Html.DisplayNameFor(model => model.Difficulty)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line (30,14)-(30,56) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Areas\Administration\Views\Exercises\Delete.cshtml"
Html.DisplayFor(model => model.Difficulty)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line (33,14)-(33,58) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Areas\Administration\Views\Exercises\Delete.cshtml"
Html.DisplayNameFor(model => model.Category)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line (36,14)-(36,59) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Areas\Administration\Views\Exercises\Delete.cshtml"
Html.DisplayFor(model => model.Category.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line (39,14)-(39,59) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Areas\Administration\Views\Exercises\Delete.cshtml"
Html.DisplayNameFor(model => model.Equipment)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line (42,14)-(42,60) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Areas\Administration\Views\Exercises\Delete.cshtml"
Html.DisplayFor(model => model.Equipment.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line (45,14)-(45,58) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Areas\Administration\Views\Exercises\Delete.cshtml"
Html.DisplayNameFor(model => model.ImageUrl)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line (48,14)-(48,54) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Areas\Administration\Views\Exercises\Delete.cshtml"
Html.DisplayFor(model => model.ImageUrl)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line (51,14)-(51,58) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Areas\Administration\Views\Exercises\Delete.cshtml"
Html.DisplayNameFor(model => model.VideoUrl)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line (54,14)-(54,54) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Areas\Administration\Views\Exercises\Delete.cshtml"
Html.DisplayFor(model => model.VideoUrl)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line (57,14)-(57,61) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Areas\Administration\Views\Exercises\Delete.cshtml"
Html.DisplayNameFor(model => model.AddedByUser)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line (60,14)-(60,60) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Areas\Administration\Views\Exercises\Delete.cshtml"
Html.DisplayFor(model => model.AddedByUser.Id)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line (63,14)-(63,59) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Areas\Administration\Views\Exercises\Delete.cshtml"
Html.DisplayNameFor(model => model.IsDeleted)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line (66,14)-(66,55) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Areas\Administration\Views\Exercises\Delete.cshtml"
Html.DisplayFor(model => model.IsDeleted)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line (69,14)-(69,59) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Areas\Administration\Views\Exercises\Delete.cshtml"
Html.DisplayNameFor(model => model.DeletedOn)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line (72,14)-(72,55) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Areas\Administration\Views\Exercises\Delete.cshtml"
Html.DisplayFor(model => model.DeletedOn)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line (75,14)-(75,59) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Areas\Administration\Views\Exercises\Delete.cshtml"
Html.DisplayNameFor(model => model.CreatedOn)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line (78,14)-(78,55) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Areas\Administration\Views\Exercises\Delete.cshtml"
Html.DisplayFor(model => model.CreatedOn)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line (81,14)-(81,60) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Areas\Administration\Views\Exercises\Delete.cshtml"
Html.DisplayNameFor(model => model.ModifiedOn)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line (84,14)-(84,56) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Areas\Administration\Views\Exercises\Delete.cshtml"
Html.DisplayFor(model => model.ModifiedOn)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5c5f68a2d3ea3c358a48142f51e0e478cdfa8f5c98602aaf143c1757dc4246016627", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b5c5f68a2d3ea3c358a48142f51e0e478cdfa8f5c98602aaf143c1757dc4246016918", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.
#nullable restore
#line (89,39)-(89,41) "C:\Users\ermin\Desktop\Faks\Semestar_6\Objektno orijentisana analiza i dizajn\Fitness\MyFitnessApp\MyFitnessApp\Web\MyFitnessApp.Web\Areas\Administration\Views\Exercises\Delete.cshtml"
Id

#line default
#line hidden
#nullable disable
                );
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5c5f68a2d3ea3c358a48142f51e0e478cdfa8f5c98602aaf143c1757dc4246018882", async() => {
                    WriteLiteral("Back to List");
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
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyFitnessApp.Data.Models.Exercise> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
