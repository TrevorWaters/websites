#pragma checksum "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\fostereddesigns\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0666983866bdfc36ca85e0235a01e9506be2ece5"
// <auto-generated/>
#pragma warning disable 1591
namespace fostereddesigns.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\fostereddesigns\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\fostereddesigns\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\fostereddesigns\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\fostereddesigns\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\fostereddesigns\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\fostereddesigns\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\fostereddesigns\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\fostereddesigns\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\fostereddesigns\_Imports.razor"
using fostereddesigns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\fostereddesigns\_Imports.razor"
using fostereddesigns.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.OpenElement(2, "header");
            __builder.OpenComponent<fostereddesigns.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "main");
            __builder.AddContent(6, 
#nullable restore
#line 9 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\fostereddesigns\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
