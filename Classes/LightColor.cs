using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLight.Classes
{
    public class LightColor
    {
        public LightColorEnum Color { get; set; }
        public Bitmap Image { get; set; }
        public int DisplayTime { get; set; }

        public LightColor Next;

        public LightColor(LightColorEnum Color, Bitmap Image)
        {
            this.Color = Color;
            this.Image = Image;
            this.DisplayTime = 15;
        }

        public LightColor()
        {
        }
    }
}
