#pragma checksum "/home/tee/Documents/websites/kristinsite/Client/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdeca9fcda9345a6281824482b0ab72a5bb46887"
// <auto-generated/>
#pragma warning disable 1591
namespace kristinsite.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/tee/Documents/websites/kristinsite/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/tee/Documents/websites/kristinsite/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/tee/Documents/websites/kristinsite/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/tee/Documents/websites/kristinsite/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/tee/Documents/websites/kristinsite/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/tee/Documents/websites/kristinsite/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/tee/Documents/websites/kristinsite/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/tee/Documents/websites/kristinsite/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/tee/Documents/websites/kristinsite/Client/_Imports.razor"
using kristinsite.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/tee/Documents/websites/kristinsite/Client/_Imports.razor"
using kristinsite.Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<img alt=\"insert video\" src=\"/assets/images/norway.png\">\r\n\r\n<div class=\"bg-black w-full h-25 mt-4 mb-4\"></div>\r\n");
            __builder.OpenElement(1, "section");
            __builder.AddAttribute(2, "class");
            __builder.OpenComponent<kristinsite.Client.Pages.AboutMe>(3);
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591