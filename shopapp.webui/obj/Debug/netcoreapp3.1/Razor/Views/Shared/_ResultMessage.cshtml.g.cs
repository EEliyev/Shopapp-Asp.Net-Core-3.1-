#pragma checksum "C:\Users\emin.aliyev\Desktop\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\shopapp\shopapp.webui\Views\Shared\_ResultMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57cf3bbef5d6435784073e623f7e028fed070857"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ResultMessage), @"mvc.1.0.view", @"/Views/Shared/_ResultMessage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57cf3bbef5d6435784073e623f7e028fed070857", @"/Views/Shared/_ResultMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14a9d00117966263fa28653a8b7eea5c60b7f5b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ResultMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AlertMessage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-md-12\">\n        <div");
            BeginWriteAttribute("class", " class=\"", 79, "\"", 115, 3);
            WriteAttributeValue("", 87, "alert", 87, 5, true);
            WriteAttributeValue(" ", 92, "alert-", 93, 7, true);
#nullable restore
#line 5 "C:\Users\emin.aliyev\Desktop\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\shopapp\shopapp.webui\Views\Shared\_ResultMessage.cshtml"
WriteAttributeValue("", 99, Model.AlertType, 99, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n            <h4 class=\"alert-title\">");
#nullable restore
#line 6 "C:\Users\emin.aliyev\Desktop\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\shopapp\shopapp.webui\Views\Shared\_ResultMessage.cshtml"
                               Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n            <p>");
#nullable restore
#line 7 "C:\Users\emin.aliyev\Desktop\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\shopapp\shopapp.webui\Views\Shared\_ResultMessage.cshtml"
          Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AlertMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591
