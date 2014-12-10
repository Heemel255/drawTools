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

namespace DrawTools.GUI {
    
    //this class is created when load event is created
    //a new window will popup with a listbox to return the selected index
    class LoadDialogForm : Form{

        private Label label1;
        private Button buttonOk;
        private Button buttonCancel;
        private ListBox listBoxAllImages;

        public bool ButtonOkClicked { get; set; }
        public ListBox ListBoxAllImages { get { return listBoxAllImages; } }

        public LoadDialogForm()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.listBoxAllImages = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Open:";
             
            this.buttonOk.Location = new System.Drawing.Point(26, 226);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            
            this.buttonCancel.Location = new System.Drawing.Point(249, 226);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
             
            this.listBoxAllImages.FormattingEnabled = true;
            this.listBoxAllImages.ItemHeight = 16;
            this.listBoxAllImages.Location = new System.Drawing.Point(26, 60);
            this.listBoxAllImages.Name = "listBoxAllImages";
            this.listBoxAllImages.Size = new System.Drawing.Size(298, 148);
            this.listBoxAllImages.TabIndex = 4;
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 266);
            this.Controls.Add(this.listBoxAllImages);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label1);
            this.Name = "SaveDialog";
            this.Text = "LoadDialog";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            ButtonOkClicked = true;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ButtonOkClicked = false;
            this.Close();
        }
    }
}
