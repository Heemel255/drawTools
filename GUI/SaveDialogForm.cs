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
    
    //this class is created when the save event happens
    //a window pops up with a textbox, the info in the textbox will be the saved image name
    class SaveDialogForm : Form{

        private Label label1;
        private TextBox textBoxResult;
        private Button buttonOk;
        private Button buttonCancel;

        public bool ButtonOkClicked { get; set; }
        public TextBox TextBoxResult { get { return textBoxResult; } }

        public SaveDialogForm()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
             
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            
            this.textBoxResult.Location = new System.Drawing.Point(26, 50);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(302, 22);
            this.textBoxResult.TabIndex = 1;
             
            this.buttonOk.Location = new System.Drawing.Point(26, 87);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);

            this.buttonCancel.Location = new System.Drawing.Point(119, 87);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 122);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.label1);
            this.Name = "SaveDialog";
            this.Text = "SaveDialog";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (this.textBoxResult.Text != "") {
                ButtonOkClicked = true;
                this.Close();
            }
            else
                MessageBox.Show("Nothing entered");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ButtonOkClicked = false;
            this.Close();
        }
    }
}
