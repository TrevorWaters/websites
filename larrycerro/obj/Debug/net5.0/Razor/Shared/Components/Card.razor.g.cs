#pragma checksum "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\larrycerro\Shared\Components\Card.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a535bf69a907cbb1976bac3b42b33e99f0f8a2d"
// <auto-generated/>
#pragma warning disable 1591
namespace larrycerro.Shared.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\larrycerro\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\larrycerro\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\larrycerro\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\larrycerro\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\larrycerro\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\larrycerro\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\larrycerro\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\larrycerro\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\larrycerro\_Imports.razor"
using larrycerro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\larrycerro\_Imports.razor"
using larrycerro.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\larrycerro\_Imports.razor"
using larrycerro.Shared.Components;

#line default
#line hidden
#nullable disable
    public partial class Card : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "class", "p-4" + " md:w-" + (
#nullable restore
#line 1 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\larrycerro\Shared\Components\Card.razor"
                         Width

#line default
#line hidden
#nullable disable
            ) + " grid" + " grid-cols-3" + " shadow-sm" + " hover:shadow-lg" + " group");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 1 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\larrycerro\Shared\Components\Card.razor"
                                                                                           OnClickCallback

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "flex col-span-2");
            __builder.AddMarkupContent(5, @"<div class=""w-12 h-12 inline-flex items-center justify-center rounded-full bg-blue-50 text-indigo-700 mb-4 flex-shrink-0 group-hover:bg-indigo-300""><svg fill=""none"" stroke=""currentColor"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" class=""w-6 h-6"" viewBox=""0 0 24 24""><path d=""M22 12h-4l-3 9L9 3l-3 9H2""></path></svg></div>
      ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "flex-grow pl-2 justify-start justify-self-start");
            __builder.OpenElement(8, "h3");
            __builder.AddAttribute(9, "class", "text-gray-900 text-xl title-font font-medium mb-2");
            __builder.AddContent(10, 
#nullable restore
#line 9 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\larrycerro\Shared\Components\Card.razor"
                                                                       Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "p");
            __builder.AddAttribute(13, "class", "leading-relaxed text-base");
            __builder.AddContent(14, 
#nullable restore
#line 10 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\larrycerro\Shared\Components\Card.razor"
                                              Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "a");
            __builder.AddAttribute(17, "class", "mt-3 text-indigo-900 inline-flex items-center hover:underline hover:scale-105");
            __builder.AddAttribute(18, "href", 
#nullable restore
#line 11 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\larrycerro\Shared\Components\Card.razor"
                                                                                                        Link

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(19, "Learn More\r\n          ");
            __builder.AddMarkupContent(20, @"<svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 24 24"" class=""ml-1 transform inline-block fill-current text-gray-500 w-6 h-6""><path fill-rule=""evenodd"" d=""M15.3 10.3a1 1 0 011.4 1.4l-4 4a1 1 0 01-1.4 0l-4-4a1 1 0 011.4-1.4l3.3 3.29 3.3-3.3z""></path></svg>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.AddMarkupContent(22, @"<div class=""justify-self-end grid-flow-col self-center""><div @click.away=""open = false"" class=""relative"" x-data=""{ open: false }""><button @click=""open = !open"" class=""flex flex-row items-center w-full px-4 py-2 mt-2 text-sm font-semibold text-left bg-transparent rounded-lg dark-mode:bg-transparent dark-mode:focus:text-white dark-mode:hover:text-white dark-mode:focus:bg-gray-600 dark-mode:hover:bg-gray-600 md:w-auto md:inline md:mt-0 md:ml-4 hover:text-gray-900 focus:text-gray-900 hover:bg-gray-200 hover:underline focus:bg-gray-200 focus:outline-none focus:shadow-outline""><span>Dropdown</span>
          <svg fill=""currentColor"" viewBox=""0 0 20 20"" :class=""{'rotate-180': open, 'rotate-0': !open}"" class=""inline w-4 h-4 mt-1 ml-1 transition-transform duration-200 transform md:-mt-1""><path fill-rule=""evenodd"" d=""M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z"" clip-rule=""evenodd""></path></svg></button></div></div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\larrycerro\Shared\Components\Card.razor"
       
  [Parameter]
  public string Icon {get; set;}
    [Parameter]
  public string Title {get; set;}
    [Parameter]
  public string Text {get; set;}
    [Parameter]
  public string Link {get; set;}
  [Parameter]
  public bool? Multiple {get; set;}
  [Parameter]
  public string Width {get; set;}
  [Parameter]
  public EventCallback<MouseEventArgs> OnClickCallback {get; set;}
  [Parameter(CaptureUnmatchedValues = true)]
  public Dictionary<string, object> InputAttributes { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
