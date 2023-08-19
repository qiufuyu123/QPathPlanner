using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace QPathPlanner
{
  class CodeConfig
  {
    public string fwd { get; set; }
    public string turn { get; set; }
  }
  class PathConfig
  { 
    public CodeConfig abs { get; set; }
    public CodeConfig delta { get; set; }
  }
  class PathNode
  {
    [JsonPropertyName("heading")]
    public int Heading { get; set; }
    [JsonPropertyName("posx")]
    public int PosX { get; set; }
    [JsonPropertyName("posy")]
    public int PosY { get; set; }
    [JsonPropertyName("comments")]
    public string Comments { get; set; } = "";
    [JsonPropertyName("color")]
    public int[] color { get; set; } = new int[3];
    [JsonPropertyName("start")]
    public bool StartPoint { get; set; }
    [JsonPropertyName("next")]

    public int NextNode { get; set; } = -1;
    public PathNode()
    {

    }
    public PathNode(int posX, int posY,int[] c, int heading = -1, bool startPoint = false)
    {
      Heading = heading;
      PosX = posX;
      PosY = posY;
      color = c;
      StartPoint = startPoint;
    }
  }

}
