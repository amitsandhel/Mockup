#pragma checksum "C:\Users\sandhela\source\repos\Mockup\Pages\MockCodeSplit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "691708087c639c12c4eec9f085b29a8c0b0d4cf2"
// <auto-generated/>
#pragma warning disable 1591
namespace MockUp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sandhela\source\repos\Mockup\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sandhela\source\repos\Mockup\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sandhela\source\repos\Mockup\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sandhela\source\repos\Mockup\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sandhela\source\repos\Mockup\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sandhela\source\repos\Mockup\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sandhela\source\repos\Mockup\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sandhela\source\repos\Mockup\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sandhela\source\repos\Mockup\_Imports.razor"
using MockUp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\sandhela\source\repos\Mockup\_Imports.razor"
using MockUp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sandhela\source\repos\Mockup\Pages\MockCodeSplit.razor"
using Blazor.Diagrams.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sandhela\source\repos\Mockup\Pages\MockCodeSplit.razor"
using Blazor.Diagrams.Core.Geometry;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sandhela\source\repos\Mockup\Pages\MockCodeSplit.razor"
using Blazor.Diagrams.Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sandhela\source\repos\Mockup\Pages\MockCodeSplit.razor"
using Blazor.Diagrams.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/m2")]
    public partial class MockCodeSplit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>MOckup split blazor</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>I split the code into a cs file for robustness.</p>\r\n\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "style", "width:100vw; height: 100vh");
            __Blazor.MockUp.Pages.MockCodeSplit.TypeInference.CreateCascadingValue_0(__builder, 4, 5, 
#nullable restore
#line 21 "C:\Users\sandhela\source\repos\Mockup\Pages\MockCodeSplit.razor"
                         Diagram

#line default
#line hidden
#nullable disable
            , 6, (__builder2) => {
                __builder2.OpenComponent<Blazor.Diagrams.Components.DiagramCanvas>(7);
                __builder2.CloseComponent();
            }
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.MockUp.Pages.MockCodeSplit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
