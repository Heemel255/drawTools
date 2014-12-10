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
using DrawTools.Classes;
using DrawTools.GUI;
using System.Data.OleDb;
using DrawTools.Data;

namespace DrawTools.GUI
{
    public partial class Form1 : Form {
        
        DrawPanel drawpanel;
        DrawToolBrush currentBrush;
        BitmapGraphics graphicsBuffer;
        AccessDB accessDB;
        
        int brushType = -1;
        bool isDrawing = false;
        bool allowPaint = false;

        public Form1()
        {
            InitializeComponent();
            
            drawpanel = new DrawPanel();
            graphicsBuffer = new BitmapGraphics(drawpanel.Width, drawpanel.Height);
            accessDB = new AccessDB();

            drawpanel.Paint += new PaintEventHandler(panelDraw_Paint);
            drawpanel.MouseDown += new MouseEventHandler(panelDraw_MouseDown);
            drawpanel.MouseUp += new MouseEventHandler(panelDraw_MouseUp);
            drawpanel.MouseMove += new MouseEventHandler(panelDraw_MouseMove);

            this.Controls.Add(drawpanel);
        }

        //this method draws the buffer onto the panel
        private void panelDraw_Paint(object sender, PaintEventArgs e)
        {
            //after the graphics buffer has all the graphics that are drawn on it, paint the whole buffer to the panel

            //dont execute if a brush is not created or there was no recent image loading
            if (currentBrush != null || allowPaint)
                e.Graphics.DrawImage(graphicsBuffer.Buffer, new Rectangle(0, 0, drawpanel.Width, drawpanel.Height));

            allowPaint = false;
        }

        //panel mouse events

        private void panelDraw_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                
                isDrawing = true;

                if (brushType == (int)DrawToolBrush.BrushSelected.Text) {

                    isDrawing = false;

                    currentBrush = new DrawToolBrush(buttonBrushColor.BackColor,
                        e.X, e.Y, 0, 0);

                    this.DrawText();
                }
                else {

                    this.DrawNonText(e);
                }
            }
        }
        
        private void panelDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing) {
                DrawNonText(e);
                drawpanel.Refresh();
            }
        }

        private void panelDraw_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
            drawpanel.Refresh();
        }

        //brush option radio buttons

        private void radioButtonCircle_CheckedChanged(object sender, EventArgs e)
        {
            brushType = (int)DrawToolBrush.BrushSelected.Circle;
            groupBoxText.Enabled = false;
            groupBoxSize.Enabled = true;
        }

        private void radioButtonRectangle_CheckedChanged(object sender, EventArgs e)
        {
            brushType = (int)DrawToolBrush.BrushSelected.Rectangle;
            groupBoxText.Enabled = false;
            groupBoxSize.Enabled = true;
        }

        private void radioButtonText_CheckedChanged(object sender, EventArgs e)
        {
            brushType = (int)DrawToolBrush.BrushSelected.Text;
            groupBoxText.Enabled = true;
            groupBoxSize.Enabled = false;
        }

        //color chooser buttons

        private void buttonBgColor_Click(object sender, EventArgs e)
        {
            ColorDialog bgColor = new ColorDialog();
            bgColor.ShowDialog();

            buttonBgColor.BackColor = bgColor.Color;
            drawpanel.BackColor = bgColor.Color;
        }

        private void buttonBrushColor_Click(object sender, EventArgs e)
        {
            ColorDialog brushColor = new ColorDialog();
            brushColor.ShowDialog();

            buttonBrushColor.BackColor = brushColor.Color;
        }

        //tool strip menu events
        
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Draw Tools 1.0");
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graphicsBuffer.ClearAll(drawpanel.Width, drawpanel.Height);
            drawpanel.Refresh();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDialogForm sdf = new SaveDialogForm();
            sdf.ShowDialog();

            //if they clicked the ok button then execute
            if (sdf.ButtonOkClicked) {

                Bitmap bmp = new Bitmap(drawpanel.Width, drawpanel.Height);
                drawpanel.DrawToBitmap(bmp, new Rectangle(0, 0, drawpanel.Width, drawpanel.Height));

                ImageConverter converter = new ImageConverter();
                byte[] blob = (byte[])converter.ConvertTo(bmp, typeof(byte[]));

                string result = sdf.TextBoxResult.Text;

                try {

                    accessDB.Save(result, blob);
                }
                catch {
                    MessageBox.Show("Problem with database occured");
                }
            }
        }
        private void loadDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> listAllNames = null;
            List<byte[]> listAllBlobs = null;

            try {

                listAllNames = accessDB.LoadNames();
                listAllBlobs = accessDB.LoadBlobs();
            }
            catch {
                MessageBox.Show("Problem with database occured");
            }

            LoadDialogForm ldf = new LoadDialogForm();
            ldf.ListBoxAllImages.DataSource = listAllNames;
            
            ldf.ShowDialog();

            if (ldf.ButtonOkClicked && listAllNames.Count > 0) {

                int index = ldf.ListBoxAllImages.SelectedIndex;
                Bitmap bmp;

                using (MemoryStream ms = new MemoryStream(listAllBlobs[index])) {
                    bmp = new Bitmap(ms);
                }

                this.LoadFromDB(bmp);
            }
        }

        //program logic functions

        private void LoadFromDB(Bitmap bmp)
        {
            graphicsBuffer.Fill(bmp);
            allowPaint = true;
            drawpanel.Refresh();
        }

        private int GetSize(string type)
        {
            int width = 0;
            int height = 0;

            if (groupBoxSize.Visible) {
                width = int.Parse(textBoxSizeWidth.Text);
                height = int.Parse(textBoxSizeHeight.Text);
            }

            if (width <= 0 || height <= 0)
                throw new Exception();

            if (type.Equals("width"))
                return width;
            else if (type.Equals("height"))
                return height;

            return -1;
        }

        private void DrawNonText(MouseEventArgs e)
        {
            int width = 0;
            int height = 0;

            try {

                width = GetSize("width");
                height = GetSize("height");
            }
            catch {

                MessageBox.Show("Invalid size");
                isDrawing = false;
                return;
            }
            
            currentBrush = new DrawToolBrush(buttonBrushColor.BackColor,
                e.X - (width / 2), e.Y - (height / 2), width, height);

            if (brushType == (int)DrawToolBrush.BrushSelected.Circle)
                graphicsBuffer.DrawGraphicsCircle(currentBrush.BrushColor, currentBrush.RectBounds);
            else if (brushType == (int)DrawToolBrush.BrushSelected.Rectangle)
                graphicsBuffer.DrawGraphicsRect(currentBrush.BrushColor, currentBrush.RectBounds);
        }
       
        private void DrawText()
        {
            try {

                int fontSize = int.Parse(textBoxFontSize.Text);

                if (textBoxTextDraw.Text == "")
                    MessageBox.Show("No text entered");

                if (fontSize < 0)
                    throw new Exception();

                graphicsBuffer.DrawGraphicsText(textBoxTextDraw.Text, fontSize, currentBrush.BrushColor, currentBrush.RectBounds.Location);
            }
            catch {
                MessageBox.Show("Invalid font size");
            }
        }
    }
}
