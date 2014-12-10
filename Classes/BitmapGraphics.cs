using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DrawTools.Classes {
    
    //this class handles the buffer image and the graphics that will be drawn onto it
    class BitmapGraphics {

        //this is the buffer, when instanced it will created a black image for grpahics to be drawn on
        private Bitmap buffer;
        public Bitmap Buffer { get { return this.buffer; } }
        //this is the object used to draw graphics to the buffer
        Graphics draw;

        public BitmapGraphics(int panelWidth,int panelHeight)
        {
            buffer = new Bitmap(panelWidth, panelHeight);
        }

        //called when the graphics need to be cleared
        public void ClearAll(int panelWidth, int panelHeight)
        {
            buffer = new Bitmap(panelWidth, panelHeight);
        }

        //called when image is loaded from db
        public void Fill(Bitmap filler)
        {
            draw = Graphics.FromImage(buffer);

            draw.DrawImage(filler, 0, 0);

            draw.Dispose();
        }

        //the following methods draw shapes and text onto the buffer

        public void DrawGraphicsRect(Color c, Rectangle r)
        {
            draw = Graphics.FromImage(buffer);

            draw.FillRectangle(new SolidBrush(c), r);

            draw.Dispose();
        }

        public void DrawGraphicsCircle(Color c, Rectangle r)
        {
            draw = Graphics.FromImage(buffer);

            draw.FillEllipse(new SolidBrush(c), r);

            draw.Dispose();
        }

        public void DrawGraphicsText(String textWrite, int fontSize, Color c, Point loc)
        {
            draw = Graphics.FromImage(buffer);

            draw.DrawString(textWrite, new Font(FontFamily.GenericSansSerif, fontSize),
                new SolidBrush(c), loc);

            draw.Dispose();
        }
    }
}
