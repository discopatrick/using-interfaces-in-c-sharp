using System.Drawing;

namespace UsingInterfacesInCSharp
{
    public interface IDrawable
    {
        int Width { get; set; }
        int Height { get; set; }
        Rectangle Bounds { get; }
        bool IsHighlighted { set; }
    }
}
