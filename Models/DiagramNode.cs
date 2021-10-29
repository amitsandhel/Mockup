using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;

namespace MockUp.Models
{
  public sealed class DiagramNode : NodeModel
  {
    public DiagramNode(string name, string description, Point pos) :
      base(name, pos)
    {
      Name = name;
      description = description;
    }

    public string Name { get; set; }
    public string description {get; set;}
  }
}