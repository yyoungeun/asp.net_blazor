#pragma checksum "C:\ASP.NET\IdeaAppCore\Pages\Ideas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cec2ced32a5c71eada1d6adf79f7354ce65c52c5"
// <auto-generated/>
#pragma warning disable 1591
namespace IdeaAppCore.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\ASP.NET\IdeaAppCore\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ASP.NET\IdeaAppCore\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\ASP.NET\IdeaAppCore\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ASP.NET\IdeaAppCore\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\ASP.NET\IdeaAppCore\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\ASP.NET\IdeaAppCore\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\ASP.NET\IdeaAppCore\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\ASP.NET\IdeaAppCore\_Imports.razor"
using IdeaAppCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\ASP.NET\IdeaAppCore\_Imports.razor"
using IdeaAppCore.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\ASP.NET\IdeaAppCore\_Imports.razor"
using IdeaAppCore.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Ideas")]
    public partial class Ideas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Ideas</h3>\r\n\r\n");
#nullable restore
#line 6 "C:\ASP.NET\IdeaAppCore\Pages\Ideas.razor"
 if (ideas == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 9 "C:\ASP.NET\IdeaAppCore\Pages\Ideas.razor"
}
else if (ideas.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.AddMarkupContent(4, "<p><em>No Data...</em></p>\r\n");
#nullable restore
#line 13 "C:\ASP.NET\IdeaAppCore\Pages\Ideas.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "table");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.AddMarkupContent(9, "<thead>\r\n            <tr>\r\n                <th>ID</th>\r\n                <th>Note</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(10, "tbody");
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 24 "C:\ASP.NET\IdeaAppCore\Pages\Ideas.razor"
             foreach (var idea in ideas)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "                ");
            __builder.OpenElement(13, "tr");
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 27 "C:\ASP.NET\IdeaAppCore\Pages\Ideas.razor"
                         idea.id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 28 "C:\ASP.NET\IdeaAppCore\Pages\Ideas.razor"
                         idea.Note

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
#nullable restore
#line 30 "C:\ASP.NET\IdeaAppCore\Pages\Ideas.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
#nullable restore
#line 33 "C:\ASP.NET\IdeaAppCore\Pages\Ideas.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(25, "\r\n");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "type", "button");
            __builder.AddAttribute(28, "value", "글쓰기");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\ASP.NET\IdeaAppCore\Pages\Ideas.razor"
                                           btnCreate_Click

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "class", "btn btn-primary");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
#nullable restore
#line 36 "C:\ASP.NET\IdeaAppCore\Pages\Ideas.razor"
 if (isShow)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, "    ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "modal fade show");
            __builder.AddAttribute(35, "tabindex", "-1");
            __builder.AddAttribute(36, "role", "dialog");
            __builder.AddAttribute(37, "style", "display:block;");
            __builder.AddAttribute(38, "id", "myModal");
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "modal-dialog");
            __builder.AddAttribute(42, "role", "document");
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "modal-content");
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "modal-header");
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.AddMarkupContent(50, "<h5 class=\"modal-title\">Modal title</h5>\r\n                    ");
            __builder.OpenElement(51, "button");
            __builder.AddAttribute(52, "type", "button");
            __builder.AddAttribute(53, "class", "close");
            __builder.AddAttribute(54, "data-dismiss", "modal");
            __builder.AddAttribute(55, "aria-label", "Close");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\ASP.NET\IdeaAppCore\Pages\Ideas.razor"
                                                                                                          btnClose_Click

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(57, "\r\n                        ");
            __builder.AddMarkupContent(58, "<span aria-hidden=\"true\">&times;</span>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "modal-body");
            __builder.AddMarkupContent(63, "\r\n\r\n                    ");
            __builder.OpenElement(64, "form");
            __builder.AddMarkupContent(65, "\r\n                        ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "form-group");
            __builder.AddMarkupContent(68, "\r\n                            ");
            __builder.AddMarkupContent(69, "<label for=\"exampleInputEmail1\">아이디어</label>\r\n                            ");
            __builder.OpenElement(70, "input");
            __builder.AddAttribute(71, "type", "text");
            __builder.AddAttribute(72, "class", "form-control");
            __builder.AddAttribute(73, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 52 "C:\ASP.NET\IdeaAppCore\Pages\Ideas.razor"
                                                                            idea.Note

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(74, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => idea.Note = __value, idea.Note));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                        ");
            __builder.OpenElement(77, "button");
            __builder.AddAttribute(78, "type", "button");
            __builder.AddAttribute(79, "class", "btn btn-primary");
            __builder.AddAttribute(80, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\ASP.NET\IdeaAppCore\Pages\Ideas.razor"
                                                                                btnSave_Click

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(81, "Submit");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                        ");
            __builder.OpenElement(83, "button");
            __builder.AddAttribute(84, "type", "button");
            __builder.AddAttribute(85, "class", "btn btn-secondary");
            __builder.AddAttribute(86, "data-dismiss", "modal");
            __builder.AddAttribute(87, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\ASP.NET\IdeaAppCore\Pages\Ideas.razor"
                                                                                                       btnClose_Click

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(88, "Close");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n");
#nullable restore
#line 62 "C:\ASP.NET\IdeaAppCore\Pages\Ideas.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\ASP.NET\IdeaAppCore\Pages\Ideas.razor"
       
    Idea idea = new Idea();

    private bool isShow = false;

    private List<Idea> ideas;

    protected override async Task OnInitializedAsync()
    {
        //await Task.Delay(3000);
        ideas = await repository.GetIdeas();
    }

    private void btnCreate_Click()
    {
        isShow = true;
    }

    private void btnClose_Click()
    {
        isShow = false;
        idea = new Idea();
    }

    private async Task btnSave_Click()
    {
        await repository.AddIdea(idea);
        isShow = false;
        ideas = await repository.GetIdeas();
        idea = new Idea();

        //StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IIdeaRepository repository { get; set; }
    }
}
#pragma warning restore 1591
