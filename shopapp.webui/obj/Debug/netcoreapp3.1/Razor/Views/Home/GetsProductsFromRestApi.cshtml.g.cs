#pragma checksum "C:\Users\emin.aliyev\Desktop\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\shopapp\shopapp.webui\Views\Home\GetsProductsFromRestApi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2921dee082dbd6e5b6165248b4fec8e1b951e5a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetsProductsFromRestApi), @"mvc.1.0.view", @"/Views/Home/GetsProductsFromRestApi.cshtml")]
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
#line 2 "C:\Users\emin.aliyev\Desktop\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\emin.aliyev\Desktop\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\emin.aliyev\Desktop\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\emin.aliyev\Desktop\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\emin.aliyev\Desktop\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\emin.aliyev\Desktop\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2921dee082dbd6e5b6165248b4fec8e1b951e5a3", @"/Views/Home/GetsProductsFromRestApi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14a9d00117966263fa28653a8b7eea5c60b7f5b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetsProductsFromRestApi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\emin.aliyev\Desktop\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\shopapp\shopapp.webui\Views\Home\GetsProductsFromRestApi.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\n    <p>");
#nullable restore
#line 6 "C:\Users\emin.aliyev\Desktop\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\shopapp\shopapp.webui\Views\Home\GetsProductsFromRestApi.cshtml"
  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p>");
#nullable restore
#line 7 "C:\Users\emin.aliyev\Desktop\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\shopapp\shopapp.webui\Views\Home\GetsProductsFromRestApi.cshtml"
  Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    </div>\n");
#nullable restore
#line 9 "C:\Users\emin.aliyev\Desktop\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\shopapp\shopapp.webui\Views\Home\GetsProductsFromRestApi.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591