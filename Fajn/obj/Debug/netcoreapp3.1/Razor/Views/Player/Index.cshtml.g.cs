#pragma checksum "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Player\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4215fd213eaeaf357310dc5c7b2ea48c43a6cf24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Player_Index), @"mvc.1.0.view", @"/Views/Player/Index.cshtml")]
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
#line 1 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\_ViewImports.cshtml"
using Fajn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\_ViewImports.cshtml"
using Fajn.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4215fd213eaeaf357310dc5c7b2ea48c43a6cf24", @"/Views/Player/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c59fdf9666b0294d335209b7c0c41b2370dc4651", @"/Views/_ViewImports.cshtml")]
    public class Views_Player_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Player>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button-color"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Player", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddPlayer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Player\Index.cshtml"
  
    ViewData["Title"] = "Players";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script>\r\n function Remove(obj) {\r\n     \r\n     if(confirm(\"Are you sure you want to delete this player ? Id =\"+obj))\r\n     {\r\n     var data = { };\r\n     data[\"Id\"] = obj;\r\n$.ajax({\r\n    url: \'");
#nullable restore
#line 15 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Player\Index.cshtml"
     Write(Url.Action("Delete", "Player"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
    type: ""POST"",
    dataType: 'TEXT',
    data: data,
    success: function () {
        var b =  document.getElementById(obj);
        b.remove();          
    },
    error: function () {
        alert(""Fail to delete"");
    }
});
     }

}
</script>

<h4> Top Players ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4215fd213eaeaf357310dc5c7b2ea48c43a6cf245951", async() => {
                WriteLiteral("  <i class=\"fas fa-plus-square\"></i> ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" </h4>
    <table class=""table"">
        <thead>
          <tr>
            <th scope=""col"">Id</th>
            <th scope=""col"">First Name</th>
            <th scope=""col"">Last Name </th>
            <th scope=""col"">Title</th>
            <th scope=""col"">Age</th>
            <th scope=""col"">Country</th>
            <th scope=""col"">Elo</th>
            <th scope=""col"">Update</th>
            <th scope=""col"">Delete</th>
          </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 48 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Player\Index.cshtml"
          foreach (Player player in Model)
         {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <tr");
            BeginWriteAttribute("id", " id=", 1271, "", 1285, 1);
#nullable restore
#line 50 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Player\Index.cshtml"
WriteAttributeValue("", 1275, player.Id, 1275, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n           <th scope=\"row\">");
#nullable restore
#line 51 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Player\Index.cshtml"
                      Write(player.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n           <td>");
#nullable restore
#line 52 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Player\Index.cshtml"
          Write(player.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 53 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Player\Index.cshtml"
          Write(player.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 54 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Player\Index.cshtml"
          Write(player.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>    \r\n           <td>");
#nullable restore
#line 55 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Player\Index.cshtml"
          Write(player.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>   \r\n           <td>");
#nullable restore
#line 56 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Player\Index.cshtml"
          Write(player.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>    \r\n           <td>");
#nullable restore
#line 57 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Player\Index.cshtml"
          Write(player.Elo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>   \r\n           <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4215fd213eaeaf357310dc5c7b2ea48c43a6cf2410508", async() => {
                WriteLiteral("Update");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Player\Index.cshtml"
                                                                       WriteLiteral(player.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n           <td>\r\n                <div class=\"form-group\">\r\n                <button type=\"button\" class=\"btn btn-sm btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1800, "\"", 1828, 3);
            WriteAttributeValue("", 1810, "Remove(", 1810, 7, true);
#nullable restore
#line 61 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Player\Index.cshtml"
WriteAttributeValue("", 1817, player.Id, 1817, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1827, ")", 1827, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</button>\r\n                </div>\r\n            </td>\r\n          </tr>\r\n");
#nullable restore
#line 65 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Player\Index.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Player>> Html { get; private set; }
    }
}
#pragma warning restore 1591
