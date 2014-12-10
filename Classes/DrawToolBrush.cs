using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawTools.Classes{
    
    //this class is used to get properties of whats drawn onto the scree    
    class DrawToolBrush{

        //this enum chekcs which brush is selected
        public enum BrushSelected {
            Circle, Rectangle, Text,
        }

        public Rectangle RectBounds { get; set; }
        public Color BrushColor { get; set; }

        public DrawToolBrush(Color c, int x, int y, int width, int height)
        {
            RectBounds = new Rectangle(x, y, width, height);
            BrushColor = c;
        }
    }
}
