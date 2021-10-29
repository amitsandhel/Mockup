using System;
using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;
using System.Collections.Generic;
using System.Linq;

using XTMF2;
using XTMF2.RuntimeModules;

namespace MockUp.Models
{
    public class ok 
    {
        public void StartTest1()
        {
            StartModule x = new StartModule();
            Console.WriteLine("ans: ", x);
        }
    }
    public class AddTwoNumbersNode : NodeModel
    {
        public AddTwoNumbersNode(Point position = null) : base(position) { }

        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }

        // Here, you can put whatever you want, such as a method that does the addition
    }

    public class XTMF2Node : NodeModel
    {
        private Node _node;

        public XTMF2Node(Node node) : base(node.Name, new Point(node.Location.X, node.Location.Y) )
        {
            Name = node.Name;
            _node = node;
        }
 
        public XTMF2Node(string name, Point position = null) : base(name, position) 
        { 
            Name = name;
            _node = null;
        }
        public string Name {get; set;}
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        public string FileSelected {get; set; }

        // Here, you can put whatever you want, such as a method that does the addition
    }
}