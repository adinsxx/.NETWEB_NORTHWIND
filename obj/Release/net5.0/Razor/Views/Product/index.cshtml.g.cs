#pragma checksum "C:\Users\Connor\Documents\.NET WEB DEVELOPMENT\Northwind\Views\Product\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0078f664b42e7d40aaa1a0d165af9665fd84f5de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_index), @"mvc.1.0.view", @"/Views/Product/index.cshtml")]
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
#line 1 "C:\Users\Connor\Documents\.NET WEB DEVELOPMENT\Northwind\Views\_ViewImports.cshtml"
using Northwind;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Connor\Documents\.NET WEB DEVELOPMENT\Northwind\Views\Product\index.cshtml"
using Northwind.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0078f664b42e7d40aaa1a0d165af9665fd84f5de", @"/Views/Product/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e30e2f765c592252c857de32b0a2b3e088383c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<table class=""table table-hover"">
    <thead>
        <tr>
            <th scope=""col"">Product</th>
            <th scope=""col"" class=""text-right"">Price</th>
            <th scope=""col"" class=""text-right"">Stock</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 13 "C:\Users\Connor\Documents\.NET WEB DEVELOPMENT\Northwind\Views\Product\index.cshtml"
         foreach (Product p in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 16 "C:\Users\Connor\Documents\.NET WEB DEVELOPMENT\Northwind\Views\Product\index.cshtml"
           Write(p.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"text-right\">");
#nullable restore
#line 17 "C:\Users\Connor\Documents\.NET WEB DEVELOPMENT\Northwind\Views\Product\index.cshtml"
                              Write(string.Format("{0:c}", p.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"text-right\">");
#nullable restore
#line 18 "C:\Users\Connor\Documents\.NET WEB DEVELOPMENT\Northwind\Views\Product\index.cshtml"
                              Write(p.UnitsInStock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 20 "C:\Users\Connor\Documents\.NET WEB DEVELOPMENT\Northwind\Views\Product\index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
