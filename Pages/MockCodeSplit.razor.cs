using System;
using Blazor.Diagrams.Core;
using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;

namespace MockUp.Pages
{
    public partial class MockCodeSplit
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
        
        public void Setup()
        {
            var node1 = NewNode(50, 50);
            var node2 = NewNode(300, 300);
            Diagram.Nodes.Add(new [] { node1, node2});
            
            Diagram.Links.Add(new LinkModel(node1.GetPort(PortAlignment.Right), node2.GetPort(PortAlignment.Left)));
        }
        
        public static NodeModel NewNode(double x, double y)
        {
            var node = new NodeModel(new Point(x, y));
            node.AddPort(PortAlignment.Bottom);
            node.AddPort(PortAlignment.Top);
            node.AddPort(PortAlignment.Left);
            node.AddPort(PortAlignment.Right);
            return node;
        }

    }
}