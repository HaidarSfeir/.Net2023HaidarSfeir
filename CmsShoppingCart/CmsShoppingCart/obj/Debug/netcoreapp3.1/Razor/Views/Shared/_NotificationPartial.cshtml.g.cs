#pragma checksum "C:\Users\Msi1\Desktop\Training\CmsShoppingCart\CmsShoppingCart\Views\Shared\_NotificationPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23b5cb44c93e3e429603a0873149abe605cdeca5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__NotificationPartial), @"mvc.1.0.view", @"/Views/Shared/_NotificationPartial.cshtml")]
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
#line 1 "C:\Users\Msi1\Desktop\Training\CmsShoppingCart\CmsShoppingCart\Views\_ViewImports.cshtml"
using CmsShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Msi1\Desktop\Training\CmsShoppingCart\CmsShoppingCart\Views\_ViewImports.cshtml"
using CmsShoppingCart.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23b5cb44c93e3e429603a0873149abe605cdeca5", @"/Views/Shared/_NotificationPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb4be8b7e4a2b608fee496ab08e7ef7d2067a2cf", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__NotificationPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Msi1\Desktop\Training\CmsShoppingCart\CmsShoppingCart\Views\Shared\_NotificationPartial.cshtml"
 if (TempData["Success"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class = \"alert alert-success notification\">\r\n        ");
#nullable restore
#line 4 "C:\Users\Msi1\Desktop\Training\CmsShoppingCart\CmsShoppingCart\Views\Shared\_NotificationPartial.cshtml"
   Write(TempData["Success"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 6 "C:\Users\Msi1\Desktop\Training\CmsShoppingCart\CmsShoppingCart\Views\Shared\_NotificationPartial.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Msi1\Desktop\Training\CmsShoppingCart\CmsShoppingCart\Views\Shared\_NotificationPartial.cshtml"
 if (TempData["Error"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class =\"alert alert-danger notification\">\r\n        ");
#nullable restore
#line 10 "C:\Users\Msi1\Desktop\Training\CmsShoppingCart\CmsShoppingCart\Views\Shared\_NotificationPartial.cshtml"
   Write(TempData["Error"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 12 "C:\Users\Msi1\Desktop\Training\CmsShoppingCart\CmsShoppingCart\Views\Shared\_NotificationPartial.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
