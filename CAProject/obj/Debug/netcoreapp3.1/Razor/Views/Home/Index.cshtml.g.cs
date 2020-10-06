#pragma checksum "C:\Users\SakuraDemon\Desktop\CAProject\CAProject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bff19a5951861d6a8fbcf7ad9220157393a96af2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\SakuraDemon\Desktop\CAProject\CAProject\Views\_ViewImports.cshtml"
using CAProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SakuraDemon\Desktop\CAProject\CAProject\Views\_ViewImports.cshtml"
using CAProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bff19a5951861d6a8fbcf7ad9220157393a96af2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45a5e57a77a3e05fffddf6820fac83f035f5d91d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaginatedList<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\SakuraDemon\Desktop\CAProject\CAProject\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    var prevDisabled = !Model.HasPreviousPage ? "disabled" : "";
    var nextDisabled = !Model.HasNextPage ? "disabled" : "";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .product-container {
        display: flex;
        flex-direction: row;
        flex-wrap: wrap;
        justify-content: center;
    }

    .product-item {
        display: grid;
        grid-template-areas: ""image"" ""name"" ""description"" ""add-to-cart"";
        grid-template-columns: 1fr;
        grid-template-rows: 3fr 0.5fr 3fr 1fr;
        align-content: center;
        justify-content: center;
        border: 0.1rem solid black;
        height: 25rem;
        width: 15rem;
        margin: 0.5rem;
        padding-top: 0.5rem;
    }

    .product-item li {
        list-style-type: none;
    }

    .product-item a {
        text-decoration: none;
    }

    .product-item a:hover {
        color: orange;
    }

    .product-item img {
        grid-area: image;
        width: 10rem;
        height: 10rem;
        padding: 0.2rem;
    }

    .product-item h4 {
        grid-area: name;
        display: block;
        text-align: center;
        width: 10");
            WriteLiteral(@"rem;
        max-height: 3rem;
        overflow: hidden;
        white-space: nowrap;
        text-overflow: ellipsis;
    }

    .product-item p {
        grid-area: description;
        display: block;
        width: 10rem;
        max-height: 8rem;
        overflow: hidden;
        text-overflow: ellipsis;
    }

    .product-item button {
        grid-area: add-to-cart;
        width: 10rem;
    }

    .product-item button:hover {
        background-color: orange;
        color: black;
    }
</style>

<div class=""product-container"">
");
#nullable restore
#line 82 "C:\Users\SakuraDemon\Desktop\CAProject\CAProject\Views\Home\Index.cshtml"
     foreach (Product product in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <ul class=\"product-item\">\r\n            <li>\r\n                <a href=\"#\">\r\n                    <img");
            BeginWriteAttribute("src", " src=", 1956, "", 1975, 1);
#nullable restore
#line 87 "C:\Users\SakuraDemon\Desktop\CAProject\CAProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 1961, product.Image, 1961, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=", 1975, "", 1993, 1);
#nullable restore
#line 87 "C:\Users\SakuraDemon\Desktop\CAProject\CAProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 1980, product.Name, 1980, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </a>\r\n            </li>\r\n            <li>\r\n                <a href=\"#\">\r\n                    <h4>");
#nullable restore
#line 92 "C:\Users\SakuraDemon\Desktop\CAProject\CAProject\Views\Home\Index.cshtml"
                   Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                </a>\r\n            </li>\r\n            <li>\r\n                <p>");
#nullable restore
#line 96 "C:\Users\SakuraDemon\Desktop\CAProject\CAProject\Views\Home\Index.cshtml"
              Write(product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </li>\r\n            <li>\r\n                <button class=\"btn btn-primary\"><span class=\"mr-1\">$");
#nullable restore
#line 99 "C:\Users\SakuraDemon\Desktop\CAProject\CAProject\Views\Home\Index.cshtml"
                                                               Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>Add To Cart</button>\r\n            </li>\r\n        </ul>\r\n");
#nullable restore
#line 102 "C:\Users\SakuraDemon\Desktop\CAProject\CAProject\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bff19a5951861d6a8fbcf7ad9220157393a96af27718", async() => {
                WriteLiteral("\r\n    Previous\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 106 "C:\Users\SakuraDemon\Desktop\CAProject\CAProject\Views\Home\Index.cshtml"
              WriteLiteral(Model.PageIndex - 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2517, "btn", 2517, 3, true);
            AddHtmlAttributeValue(" ", 2520, "btn-default", 2521, 12, true);
#nullable restore
#line 107 "C:\Users\SakuraDemon\Desktop\CAProject\CAProject\Views\Home\Index.cshtml"
AddHtmlAttributeValue(" ", 2532, prevDisabled, 2533, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bff19a5951861d6a8fbcf7ad9220157393a96af210501", async() => {
                WriteLiteral("\r\n    Next\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 112 "C:\Users\SakuraDemon\Desktop\CAProject\CAProject\Views\Home\Index.cshtml"
              WriteLiteral(Model.PageIndex + 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2655, "btn", 2655, 3, true);
            AddHtmlAttributeValue(" ", 2658, "btn-default", 2659, 12, true);
#nullable restore
#line 113 "C:\Users\SakuraDemon\Desktop\CAProject\CAProject\Views\Home\Index.cshtml"
AddHtmlAttributeValue(" ", 2670, nextDisabled, 2671, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaginatedList<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
