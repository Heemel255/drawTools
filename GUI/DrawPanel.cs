using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawTools.GUI
{
    //this class is where everything is drawn onto
    class DrawPanel : Panel
    {
        public DrawPanel()
        {
            this.BackColor = Color.White;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Cursor = Cursors.Cross;
            this.Location = new Point(170, 60);
            this.Size = new Size(492, 735);
            this.DoubleBuffered = true;
            this.Anchor = AnchorStyles.Top;
        }
    }
}
