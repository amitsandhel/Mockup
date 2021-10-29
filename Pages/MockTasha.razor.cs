using System;
using Blazor.Diagrams.Core;
using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;
using Blazor.Diagrams.Core.Models.Base;
using Microsoft.AspNetCore.Components;

using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

//get the model and widgets here
using MockUp.Models;
using MockUp.Widgets;

using XTMF2;

//https://github.com/Blazor-Diagrams/Blazor.Diagrams/blob/master/docs/CustomNodesLinks/Pages/Index.razor

namespace MockUp.Pages
{
   
    public partial class MockTasha
    {
        public Diagram Diagram { get; set; }
        protected override void OnInitialized()
        {
            base.OnInitialized();

            var options = new DiagramOptions
            {
                DeleteKey = "Delete", // What key deletes the selected nodes/links
                DefaultNodeComponent = null, // Default component for nodes
                AllowMultiSelection = true, // Whether to allow multi selection using CTRL
                AllowPanning = false,

                Links = new DiagramLinkOptions
                {
                    DefaultLinkComponent = null,
                    DefaultColor = "red",
                    DefaultSelectedColor = "magenta"
                },
                Zoom = new DiagramZoomOptions
                {
                    Minimum = 0.5, // Minimum zoom value
                    Inverse = false, // Whether to inverse the direction of the zoom when using the wheel
                }
            };

            Diagram = new Diagram(options);
            Diagram.RegisterModelComponent<AddTwoNumbersNode, AddTwoNumbersComponent>();
            Diagram.RegisterModelComponent<XTMF2Node, XTMF2NodeComponents>();
            //add in the diagram link custom widget
            Diagram.RegisterModelComponent<DiagramLinkLabel, DiagramLinkLabelWidget>();
            Setup();
        }
        
        public void Setup()
        {
            var node1 = new XTMF2Node("Load Los Data", new Point(100,100));
            var node2 = new XTMF2Node("Load Household", new Point(200,200));
            var node3 = new XTMF2Node("assign zones", new Point(300,300));
            var node4 = new XTMF2Node("assign driver licenses", new Point(400,400));
            var node5 = new XTMF2Node("carteso houses", new Point(500,500));
            var node6 = new XTMF2Node("model choice", new Point(600,600));
            var node7 = new XTMF2Node("network assignment", new Point(700,700)); 

            Diagram.Nodes.Add(new [] { node1, node2, node3, node4, node5, node6, node7});
            
            //try custom link
            Diagram.Links.Add(new DiagramLink($"TEST", node1, node2) );
            Diagram.Links.Add(new DiagramLink($"TEST", node1, node2) );
            Diagram.Links.Add(new DiagramLink($"TEST", node3, node4) );
            Diagram.Links.Add(new DiagramLink($"TEST", node5, node1) );
            Diagram.Links.Add(new DiagramLink($"TEST", node4, node2) );
            Diagram.Links.Add(new DiagramLink($"TEST", node7, node1) );
            
            
        }
        
        public static NodeModel NewNode(double x, double y)
        {
            var node = new NodeModel(new Point(x, y));
            //node.AddPort(PortAlignment.Bottom);
            node.AddPort(PortAlignment.Top);
            //node.AddPort(PortAlignment.Left);
            node.AddPort(PortAlignment.Right);
            return node;
        }
    }
}

//https://medium.com/@tonerdo/referencing-a-net-dll-directly-using-the-net-core-toolchain-16f0af46a4dc