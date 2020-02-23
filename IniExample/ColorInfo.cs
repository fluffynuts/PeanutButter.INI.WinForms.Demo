using System.Drawing;

namespace IniExample
{
    public class ColorInfo
    {
        public string Name { get; set; }
        public Color Color { get; set; }

        public ColorInfo(string name, Color color)
        {
            Name = name;
            Color = color;
        }
    }
}