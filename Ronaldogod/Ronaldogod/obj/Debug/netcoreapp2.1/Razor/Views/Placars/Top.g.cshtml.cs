#pragma checksum "C:\Users\ronal\source\repos\Ronaldogod\Ronaldogod\Views\Placars\Top.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa0ba278a8b5733e47cd505e3dc9b5d4fbc5810a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Placars_Top), @"mvc.1.0.view", @"/Views/Placars/Top.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Placars/Top.cshtml", typeof(AspNetCore.Views_Placars_Top))]
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
#line 1 "C:\Users\ronal\source\repos\Ronaldogod\Ronaldogod\Views\_ViewImports.cshtml"
using Ronaldogod;

#line default
#line hidden
#line 2 "C:\Users\ronal\source\repos\Ronaldogod\Ronaldogod\Views\_ViewImports.cshtml"
using Ronaldogod.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa0ba278a8b5733e47cd505e3dc9b5d4fbc5810a", @"/Views/Placars/Top.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"942be75556a2fb1601683962ba0d9501a9666dff", @"/Views/_ViewImports.cshtml")]
    public class Views_Placars_Top : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ronaldogod.Models.Placar>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ronal\source\repos\Ronaldogod\Ronaldogod\Views\Placars\Top.cshtml"
  
    ViewData["Title"] = "Top";

#line default
#line hidden
#line 6 "C:\Users\ronal\source\repos\Ronaldogod\Ronaldogod\Views\Placars\Top.cshtml"
  int i = 0; 

#line default
#line hidden
            BeginContext(103, 154, true);
            WriteLiteral("\r\n<h2>Top 10 das Melhores Pontuação</h2>\r\n\r\n<div style=\"display: inline; float: left;\" class=\"form-group text-right\">\r\n    <button class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 257, "\"", 304, 3);
            WriteAttributeValue("", 267, "location.href=\'", 267, 15, true);
#line 11 "C:\Users\ronal\source\repos\Ronaldogod\Ronaldogod\Views\Placars\Top.cshtml"
WriteAttributeValue("", 282, Url.Action("Index"), 282, 20, false);

#line default
#line hidden
            WriteAttributeValue("", 302, "\';", 302, 2, true);
            EndWriteAttribute();
            BeginContext(305, 174, true);
            WriteLiteral(">Voltar</button>\r\n</div>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Lugares\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(480, 43, false);
#line 21 "C:\Users\ronal\source\repos\Ronaldogod\Ronaldogod\Views\Placars\Top.cshtml"
           Write(Html.DisplayNameFor(model => model.Jogador));

#line default
#line hidden
            EndContext();
            BeginContext(523, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(579, 47, false);
#line 24 "C:\Users\ronal\source\repos\Ronaldogod\Ronaldogod\Views\Placars\Top.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalPontos));

#line default
#line hidden
            EndContext();
            BeginContext(626, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(682, 39, false);
#line 27 "C:\Users\ronal\source\repos\Ronaldogod\Ronaldogod\Views\Placars\Top.cshtml"
           Write(Html.DisplayNameFor(model => model.Dia));

#line default
#line hidden
            EndContext();
            BeginContext(721, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 33 "C:\Users\ronal\source\repos\Ronaldogod\Ronaldogod\Views\Placars\Top.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(856, 32, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n");
            EndContext();
#line 37 "C:\Users\ronal\source\repos\Ronaldogod\Ronaldogod\Views\Placars\Top.cshtml"
                  i++;

#line default
#line hidden
            BeginContext(913, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(930, 1, false);
#line 38 "C:\Users\ronal\source\repos\Ronaldogod\Ronaldogod\Views\Placars\Top.cshtml"
           Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(931, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(987, 44, false);
#line 41 "C:\Users\ronal\source\repos\Ronaldogod\Ronaldogod\Views\Placars\Top.cshtml"
           Write(Html.DisplayFor(modelItem => item.JogadorId));

#line default
#line hidden
            EndContext();
            BeginContext(1031, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1087, 46, false);
#line 44 "C:\Users\ronal\source\repos\Ronaldogod\Ronaldogod\Views\Placars\Top.cshtml"
           Write(Html.DisplayFor(modelItem => item.TotalPontos));

#line default
#line hidden
            EndContext();
            BeginContext(1133, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1189, 38, false);
#line 47 "C:\Users\ronal\source\repos\Ronaldogod\Ronaldogod\Views\Placars\Top.cshtml"
           Write(Html.DisplayFor(modelItem => item.Dia));

#line default
#line hidden
            EndContext();
            BeginContext(1227, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1282, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c93f10554cbf408aa6d7cebe1451f0dc", async() => {
                BeginContext(1327, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 50 "C:\Users\ronal\source\repos\Ronaldogod\Ronaldogod\Views\Placars\Top.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1335, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1355, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8064db655de49de8fee0958aa38ef37", async() => {
                BeginContext(1403, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 51 "C:\Users\ronal\source\repos\Ronaldogod\Ronaldogod\Views\Placars\Top.cshtml"
                                          WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1414, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1434, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5faa09cbb5b646439c1f695131ff84ce", async() => {
                BeginContext(1481, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\ronal\source\repos\Ronaldogod\Ronaldogod\Views\Placars\Top.cshtml"
                                         WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1491, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 55 "C:\Users\ronal\source\repos\Ronaldogod\Ronaldogod\Views\Placars\Top.cshtml"
        }

#line default
#line hidden
            BeginContext(1538, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Ronaldogod.Models.Placar>> Html { get; private set; }
    }
}
#pragma warning restore 1591
