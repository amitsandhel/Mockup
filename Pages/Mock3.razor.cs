using System;
using Blazor.Diagrams.Core;
using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;
using Blazor.Diagrams.Core.Models.Base;
using Microsoft.AspNetCore.Components;

using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using MockUp.Models;
using MockUp.Widgets;


//https://github.com/Blazor-Diagrams/Blazor.Diagrams/blob/master/docs/CustomNodesLinks/Pages/Index.razor

namespace MockUp.Pages
{
   
    public partial class Mock3
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
            Diagram.RegisterModelComponent<DiagramNode, DiagramNodeWidget>();
            Diagram.RegisterModelComponent<DiagramLinkLabel, DiagramLinkLabelWidget>();
            Diagram.RegisterModelComponent<AddTwoNumbersNode, AddTwoNumbersComponent>();
            Setup();
        }
        
        public void Setup()
        {
            var node1 = NewNode(50, 50);
            var node2 = NewNode(50, 200);
            var node5 = NewNode(500,500);
            var node3 = new DiagramNode("Node3d esc1", "desc1", new Point(200,200));
            var node4 = new DiagramNode("Node4", "desc1", new Point(300,300));
            var node6 = new AddTwoNumbersNode();

            Diagram.Nodes.Add(new [] { node1, node2, node3, node4, node5, node6});
            //Diagram.Links.Add(new LinkModel(node1.GetPort(PortAlignment.Right), node2.GetPort(PortAlignment.Left)));
            Diagram.Links.Add(new LinkModel(node1.GetPort(PortAlignment.Right), node2.GetPort(PortAlignment.Top)));
            Diagram.Links.Add(new LinkModel(node1.GetPort(PortAlignment.Right), node5.GetPort(PortAlignment.Top)));
            Diagram.Links.Add(new LinkModel(node1.GetPort(PortAlignment.Right), node3.GetPort(PortAlignment.Top)));
            Diagram.Links.Add(new LinkModel(node5.GetPort(PortAlignment.Right), node5.GetPort(PortAlignment.Top)));
            Diagram.Links.Add(new LinkModel(node5.GetPort(PortAlignment.Right), node2.GetPort(PortAlignment.Top)));
            
            //try custom link
            var link = new DiagramLink($"{node3.Name}-->{node4.Name}", node3, node4);
            Diagram.Links.Add(link);
            var link2 = new DiagramLink($"{node3.Name}-->{node4.Name}", node4, node2);
            Diagram.Links.Add(link2);
            
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