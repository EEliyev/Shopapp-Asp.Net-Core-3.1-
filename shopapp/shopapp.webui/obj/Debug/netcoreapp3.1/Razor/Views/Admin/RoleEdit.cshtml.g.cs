#pragma checksum "C:\Users\Emin\Desktop\Google\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca5af94f18451673a844764ab9af7d58f80494c7"
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
#line 2 "C:\Users\Emin\Desktop\Google\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Emin\Desktop\Google\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Emin\Desktop\Google\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Emin\Desktop\Google\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Emin\Desktop\Google\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Emin\Desktop\Google\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca5af94f18451673a844764ab9af7d58f80494c7", @"/Views/Admin/RoleEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f21d0c39f46d4300cef65d90e653df71cbd94b0", @"/Views/_ViewImports.cshtml")]
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
            WriteLiteral("<h1 class=\"h3\">Edit Role</h1>\r\n<hr>\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca5af94f18451673a844764ab9af7d58f80494c74705", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"RoleId\"");
                BeginWriteAttribute("value", " value=\"", 216, "\"", 238, 1);
#nullable restore
#line 9 "C:\Users\Emin\Desktop\Google\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
WriteAttributeValue("", 224, Model.Role.Id, 224, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <input type=\"hidden\" name=\"RoleName\"");
                BeginWriteAttribute("value", " value=\"", 290, "\"", 314, 1);
#nullable restore
#line 10 "C:\Users\Emin\Desktop\Google\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
WriteAttributeValue("", 298, Model.Role.Name, 298, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n            <h6 class=\"bg-info text-white p-1\">Add to ");
#nullable restore
#line 12 "C:\Users\Emin\Desktop\Google\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
                                                 Write(Model.Role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n            <table class=\"table table-bordered table-sm\">\r\n");
#nullable restore
#line 14 "C:\Users\Emin\Desktop\Google\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
                 if(Model.NonMembers.Count()==0)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td colspan=\"2\">butun kullanicilar role ait</td>\r\n                    </tr>\r\n");
#nullable restore
#line 19 "C:\Users\Emin\Desktop\Google\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
                }else{
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Emin\Desktop\Google\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
                     foreach (var user in Model.NonMembers)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                      <tr>\r\n                          <td>");
#nullable restore
#line 23 "C:\Users\Emin\Desktop\Google\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
                         Write(user.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                          <td style=\"width: 150px;\">\r\n                              <input type=\"checkbox\" name=\"IdsToAdd\"");
                BeginWriteAttribute("value", " value=\"", 961, "\"", 977, 1);
#nullable restore
#line 25 "C:\Users\Emin\Desktop\Google\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
WriteAttributeValue("", 969, user.Id, 969, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                          </td>\r\n                      </tr>  \r\n");
#nullable restore
#line 28 "C:\Users\Emin\Desktop\Google\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Emin\Desktop\Google\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </table>\r\n\r\n            <hr>\r\n\r\n            <h6 class=\"bg-info text-white p-1\">Remove from ");
#nullable restore
#line 34 "C:\Users\Emin\Desktop\Google\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
                                                      Write(Model.Role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n            <table class=\"table table-bordered table-sm\">\r\n");
#nullable restore
#line 36 "C:\Users\Emin\Desktop\Google\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
                 if(Model.Members.Count()==0)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td colspan=\"2\">Role ait kullanici yok</td>\r\n                    </tr>\r\n");
#nullable restore
#line 41 "C:\Users\Emin\Desktop\Google\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
                }else{
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\Emin\Desktop\Google\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
                     foreach (var user in Model.Members)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                      <tr>\r\n                          <td>");
#nullable restore
#line 45 "C:\Users\Emin\Desktop\Google\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
                         Write(user.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                          <td style=\"width: 150px;\">\r\n                              <input type=\"checkbox\" name=\"IdsToDelete\"");
                BeginWriteAttribute("value", " value=\"", 1769, "\"", 1785, 1);
#nullable restore
#line 47 "C:\Users\Emin\Desktop\Google\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
WriteAttributeValue("", 1777, user.Id, 1777, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                          </td>\r\n                      </tr>  \r\n");
#nullable restore
#line 50 "C:\Users\Emin\Desktop\Google\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\Emin\Desktop\Google\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </table>\r\n\r\n            <button type=\"submit\" class=\"btn btn-primary\">Save Changes</button>\r\n        ");
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
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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