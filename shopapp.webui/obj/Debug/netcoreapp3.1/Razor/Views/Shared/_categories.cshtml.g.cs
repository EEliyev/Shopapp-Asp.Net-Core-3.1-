#pragma checksum "C:\Users\emin.aliyev\Desktop\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\shopapp\shopapp.webui\Views\Shared\_categories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfcb9235e8e39bc94cc0bee27ea5affd774c30a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__categories), @"mvc.1.0.view", @"/Views/Shared/_categories.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfcb9235e8e39bc94cc0bee27ea5affd774c30a5", @"/Views/Shared/_categories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14a9d00117966263fa28653a8b7eea5c60b7f5b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__categories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"list-group\">\n");
#nullable restore
#line 3 "C:\Users\emin.aliyev\Desktop\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\shopapp\shopapp.webui\Views\Shared\_categories.cshtml"
     foreach (var category in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a href=\"#\" class=\"list-group-item list-group-item-action\">");
#nullable restore
#line 5 "C:\Users\emin.aliyev\Desktop\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\shopapp\shopapp.webui\Views\Shared\_categories.cshtml"
                                                              Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n");
#nullable restore
#line 6 "C:\Users\emin.aliyev\Desktop\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\shopapp\shopapp.webui\Views\Shared\_categories.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
