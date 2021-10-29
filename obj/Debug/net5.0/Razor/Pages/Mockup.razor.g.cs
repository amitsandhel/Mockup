#pragma checksum "C:\Users\sandhela\source\repos\Mockup\Pages\Mockup.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ef2b61b1697a5cabafa7397d1e64d786a4ed7d6"
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
#line 3 "C:\Users\sandhela\source\repos\Mockup\Pages\Mockup.razor"
using Blazor.Diagrams.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sandhela\source\repos\Mockup\Pages\Mockup.razor"
using Blazor.Diagrams.Core.Geometry;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sandhela\source\repos\Mockup\Pages\Mockup.razor"
using Blazor.Diagrams.Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sandhela\source\repos\Mockup\Pages\Mockup.razor"
using Blazor.Diagrams.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/mockup")]
    public partial class Mockup : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Z Blazor Diagrams</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates a diagram.</p>\r\n\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "style", "width:100vw; height: 100vh");
            __Blazor.MockUp.Pages.Mockup.TypeInference.CreateCascadingValue_0(__builder, 4, 5, 
#nullable restore
#line 21 "C:\Users\sandhela\source\repos\Mockup\Pages\Mockup.razor"
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
#nullable restore
#line 26 "C:\Users\sandhela\source\repos\Mockup\Pages\Mockup.razor"
       
  private Diagram Diagram { get; set; }

  protected override void OnInitialized()
  {
    base.OnInitialized();

    var options = new DiagramOptions
    {
      DeleteKey = "Delete", // What key deletes the selected nodes/links
      DefaultNodeComponent = null, // Default component for nodes
      AllowMultiSelection = true, // Whether to allow multi selection using CTRL
      Links = new DiagramLinkOptions
      {
      },
      Zoom = new DiagramZoomOptions
      {
        Minimum = 0.5, // Minimum zoom value
        Inverse = false, // Whether to inverse the direction of the zoom when using the wheel
      }
    };
    Diagram = new Diagram(options);
    
    Setup();
  }
  
  private void Setup()
  {
    var node1 = NewNode(50, 50);
    var node2 = NewNode(300, 300);
    var node3 = NewNode(300, 50);
    var node4 = NewNode(400, 100);
    Diagram.Nodes.Add(new [] { node1, node2, node3, node4 });
    
    Diagram.Links.Add(new LinkModel(node1.GetPort(PortAlignment.Right), node2.GetPort(PortAlignment.Left)));
  }
  
  private static NodeModel NewNode(double x, double y)
  {
    var node = new NodeModel(new Point(x, y));
    node.AddPort(PortAlignment.Bottom);
    node.AddPort(PortAlignment.Top);
    node.AddPort(PortAlignment.Left);
    node.AddPort(PortAlignment.Right);
    return node;
  }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.MockUp.Pages.Mockup
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
