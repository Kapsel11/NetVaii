#pragma checksum "C:\Users\thedj\Source\Repos\Kapsel11\NetVaii\Fajn\Views\AllGames\Find.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb64d5dbac851e83e9b2eb1577114caad83982e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AllGames_Find), @"mvc.1.0.view", @"/Views/AllGames/Find.cshtml")]
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
#line 1 "C:\Users\thedj\Source\Repos\Kapsel11\NetVaii\Fajn\Views\_ViewImports.cshtml"
using Fajn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\thedj\Source\Repos\Kapsel11\NetVaii\Fajn\Views\_ViewImports.cshtml"
using Fajn.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb64d5dbac851e83e9b2eb1577114caad83982e5", @"/Views/AllGames/Find.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c59fdf9666b0294d335209b7c0c41b2370dc4651", @"/Views/_ViewImports.cshtml")]
    public class Views_AllGames_Find : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AllGames>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb64d5dbac851e83e9b2eb1577114caad83982e54170", async() => {
                WriteLiteral(@"
    <h4>All Games</h4>
    <table class=""table"">
        <thead>
          <tr>
            <th scope=""col"">GameID</th>
            <th scope=""col"">White</th>
            <th scope=""col"">Black</th>
            <th scope=""col"">Result</th>
            <th scope=""col"">Date</th>
            <th scope=""col"">Event</th>
            <th scope=""col"">PGN</th>
            <th scope=""col"">Update</th>
            <th scope=""col"">Delete</th>
          </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 20 "C:\Users\thedj\Source\Repos\Kapsel11\NetVaii\Fajn\Views\AllGames\Find.cshtml"
          foreach (AllGames game in Model)
         {

#line default
#line hidden
#nullable disable
                WriteLiteral("          <tr>\r\n           <th scope=\"row\">");
#nullable restore
#line 23 "C:\Users\thedj\Source\Repos\Kapsel11\NetVaii\Fajn\Views\AllGames\Find.cshtml"
                      Write(game.GameId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n           <td>");
#nullable restore
#line 24 "C:\Users\thedj\Source\Repos\Kapsel11\NetVaii\Fajn\Views\AllGames\Find.cshtml"
          Write(game.White);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 25 "C:\Users\thedj\Source\Repos\Kapsel11\NetVaii\Fajn\Views\AllGames\Find.cshtml"
          Write(game.Black);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 26 "C:\Users\thedj\Source\Repos\Kapsel11\NetVaii\Fajn\Views\AllGames\Find.cshtml"
          Write(game.Result);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 27 "C:\Users\thedj\Source\Repos\Kapsel11\NetVaii\Fajn\Views\AllGames\Find.cshtml"
          Write(game.Event);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 28 "C:\Users\thedj\Source\Repos\Kapsel11\NetVaii\Fajn\Views\AllGames\Find.cshtml"
          Write(game.Date);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>           \r\n           <td><a");
                BeginWriteAttribute("href", " href=\"", 848, "\"", 864, 1);
#nullable restore
#line 29 "C:\Users\thedj\Source\Repos\Kapsel11\NetVaii\Fajn\Views\AllGames\Find.cshtml"
WriteAttributeValue("", 855, game.Pgn, 855, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" target=\"_blank\">Download</a></td>\r\n           <td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb64d5dbac851e83e9b2eb1577114caad83982e57167", async() => {
                    WriteLiteral("Update");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\thedj\Source\Repos\Kapsel11\NetVaii\Fajn\Views\AllGames\Find.cshtml"
                                                                       WriteLiteral(game.GameId);

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
                WriteLiteral("</td>\r\n           <td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb64d5dbac851e83e9b2eb1577114caad83982e59552", async() => {
                    WriteLiteral("Delete");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "C:\Users\thedj\Source\Repos\Kapsel11\NetVaii\Fajn\Views\AllGames\Find.cshtml"
                                                                       WriteLiteral(game.GameId);

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
                WriteLiteral("</td>\r\n          </tr>\r\n");
#nullable restore
#line 33 "C:\Users\thedj\Source\Repos\Kapsel11\NetVaii\Fajn\Views\AllGames\Find.cshtml"
         }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n       \r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AllGames>> Html { get; private set; }
    }
}
#pragma warning restore 1591