#pragma checksum "C:\Users\emin.aliyev\Desktop\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2de315b577590ff2b20a55aeed17994f9057f91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_RoleEdit), @"mvc.1.0.view", @"/Views/Admin/RoleEdit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2de315b577590ff2b20a55aeed17994f9057f91", @"/Views/Admin/RoleEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14a9d00117966263fa28653a8b7eea5c60b7f5b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_RoleEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RoleEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1 class=\"h3\">Edit Role</h1>\n<hr>\n\n\n<div class=\"row\">\n    <div class=\"col-md-12\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2de315b577590ff2b20a55aeed17994f9057f915631", async() => {
                WriteLiteral("\n            <input type=\"hidden\" name=\"RoleId\"");
                BeginWriteAttribute("value", " value=\"", 208, "\"", 230, 1);
#nullable restore
#line 9 "C:\Users\emin.aliyev\Desktop\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
WriteAttributeValue("", 216, Model.Role.Id, 216, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n            <input type=\"hidden\" name=\"RoleName\"");
                BeginWriteAttribute("value", " value=\"", 281, "\"", 305, 1);
#nullable restore
#line 10 "C:\Users\emin.aliyev\Desktop\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
WriteAttributeValue("", 289, Model.Role.Name, 289, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n\n            <h6 class=\"bg-info text-white p-1\">Add to ");
#nullable restore
#line 12 "C:\Users\emin.aliyev\Desktop\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
                                                 Write(Model.Role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n            <table class=\"table table-bordered table-sm\">\n");
#nullable restore
#line 14 "C:\Users\emin.aliyev\Desktop\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
                 if(Model.NonMembers.Count()==0)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\n                        <td colspan=\"2\">butun kullanicilar role ait</td>\n                    </tr>\n");
#nullable restore
#line 19 "C:\Users\emin.aliyev\Desktop\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
                }else{
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\emin.aliyev\Desktop\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
                     foreach (var user in Model.NonMembers)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                      <tr>\n                          <td>");
#nullable restore
#line 23 "C:\Users\emin.aliyev\Desktop\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
                         Write(user.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                          <td style=\"width: 150px;\">\n                              <input type=\"checkbox\" name=\"IdsToAdd\"");
                BeginWriteAttribute("value", " value=\"", 937, "\"", 953, 1);
#nullable restore
#line 25 "C:\Users\emin.aliyev\Desktop\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
WriteAttributeValue("", 945, user.Id, 945, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                          </td>\n                      </tr>  \n");
#nullable restore
#line 28 "C:\Users\emin.aliyev\Desktop\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\emin.aliyev\Desktop\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </table>\n\n            <hr>\n\n            <h6 class=\"bg-info text-white p-1\">Remove from ");
#nullable restore
#line 34 "C:\Users\emin.aliyev\Desktop\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
                                                      Write(Model.Role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n            <table class=\"table table-bordered table-sm\">\n");
#nullable restore
#line 36 "C:\Users\emin.aliyev\Desktop\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
                 if(Model.Members.Count()==0)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\n                        <td colspan=\"2\">Role ait kullanici yok</td>\n                    </tr>\n");
#nullable restore
#line 41 "C:\Users\emin.aliyev\Desktop\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
                }else{
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\emin.aliyev\Desktop\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
                     foreach (var user in Model.Members)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                      <tr>\n                          <td>");
#nullable restore
#line 45 "C:\Users\emin.aliyev\Desktop\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
                         Write(user.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                          <td style=\"width: 150px;\">\n                              <input type=\"checkbox\" name=\"IdsToDelete\"");
                BeginWriteAttribute("value", " value=\"", 1723, "\"", 1739, 1);
#nullable restore
#line 47 "C:\Users\emin.aliyev\Desktop\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
WriteAttributeValue("", 1731, user.Id, 1731, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                          </td>\n                      </tr>  \n");
#nullable restore
#line 50 "C:\Users\emin.aliyev\Desktop\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\emin.aliyev\Desktop\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\Shopapp-Asp.Net-Core-3.1--524fdf1cfd53810326a5ec8f8b135356d884ac3c\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </table>\n\n            <button type=\"submit\" class=\"btn btn-primary\">Save Changes</button>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591