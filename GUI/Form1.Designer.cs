namespace DrawTools.GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonText = new System.Windows.Forms.RadioButton();
            this.radioButtonRectangle = new System.Windows.Forms.RadioButton();
            this.radioButtonCircle = new System.Windows.Forms.RadioButton();
            this.buttonBgColor = new System.Windows.Forms.Button();
            this.buttonBrushColor = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxSize = new System.Windows.Forms.GroupBox();
            this.textBoxSizeHeight = new System.Windows.Forms.TextBox();
            this.textBoxSizeWidth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTextDraw = new System.Windows.Forms.TextBox();
            this.labelTextDraw = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxText = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFontSize = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxSize.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBoxText.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.Controls.Add(this.radioButtonText);
            this.groupBox1.Controls.Add(this.radioButtonRectangle);
            this.groupBox1.Controls.Add(this.radioButtonCircle);
            this.groupBox1.Location = new System.Drawing.Point(19, 119);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(147, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Brush";
            // 
            // radioButtonText
            // 
            this.radioButtonText.AutoSize = true;
            this.radioButtonText.Location = new System.Drawing.Point(8, 128);
            this.radioButtonText.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonText.Name = "radioButtonText";
            this.radioButtonText.Size = new System.Drawing.Size(56, 21);
            this.radioButtonText.TabIndex = 3;
            this.radioButtonText.TabStop = true;
            this.radioButtonText.Text = "Text";
            this.radioButtonText.UseVisualStyleBackColor = true;
            this.radioButtonText.CheckedChanged += new System.EventHandler(this.radioButtonText_CheckedChanged);
            // 
            // radioButtonRectangle
            // 
            this.radioButtonRectangle.AutoSize = true;
            this.radioButtonRectangle.Location = new System.Drawing.Point(8, 78);
            this.radioButtonRectangle.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonRectangle.Name = "radioButtonRectangle";
            this.radioButtonRectangle.Size = new System.Drawing.Size(93, 21);
            this.radioButtonRectangle.TabIndex = 1;
            this.radioButtonRectangle.TabStop = true;
            this.radioButtonRectangle.Text = "Rectangle";
            this.radioButtonRectangle.UseVisualStyleBackColor = true;
            this.radioButtonRectangle.CheckedChanged += new System.EventHandler(this.radioButtonRectangle_CheckedChanged);
            // 
            // radioButtonCircle
            // 
            this.radioButtonCircle.AutoSize = true;
            this.radioButtonCircle.Location = new System.Drawing.Point(8, 30);
            this.radioButtonCircle.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonCircle.Name = "radioButtonCircle";
            this.radioButtonCircle.Size = new System.Drawing.Size(64, 21);
            this.radioButtonCircle.TabIndex = 0;
            this.radioButtonCircle.TabStop = true;
            this.radioButtonCircle.Text = "Circle";
            this.radioButtonCircle.UseVisualStyleBackColor = true;
            this.radioButtonCircle.CheckedChanged += new System.EventHandler(this.radioButtonCircle_CheckedChanged);
            // 
            // buttonBgColor
            // 
            this.buttonBgColor.BackColor = System.Drawing.Color.White;
            this.buttonBgColor.Location = new System.Drawing.Point(8, 44);
            this.buttonBgColor.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBgColor.Name = "buttonBgColor";
            this.buttonBgColor.Size = new System.Drawing.Size(123, 28);
            this.buttonBgColor.TabIndex = 3;
            this.buttonBgColor.UseVisualStyleBackColor = false;
            this.buttonBgColor.Click += new System.EventHandler(this.buttonBgColor_Click);
            // 
            // buttonBrushColor
            // 
            this.buttonBrushColor.BackColor = System.Drawing.Color.Black;
            this.buttonBrushColor.Location = new System.Drawing.Point(8, 108);
            this.buttonBrushColor.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBrushColor.Name = "buttonBrushColor";
            this.buttonBrushColor.Size = new System.Drawing.Size(123, 28);
            this.buttonBrushColor.TabIndex = 4;
            this.buttonBrushColor.UseVisualStyleBackColor = false;
            this.buttonBrushColor.Click += new System.EventHandler(this.buttonBrushColor_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.buttonBgColor);
            this.groupBox2.Controls.Add(this.buttonBrushColor);
            this.groupBox2.Location = new System.Drawing.Point(672, 119);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(147, 167);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Brush";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Background";
            // 
            // groupBoxSize
            // 
            this.groupBoxSize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBoxSize.Controls.Add(this.textBoxSizeHeight);
            this.groupBoxSize.Controls.Add(this.textBoxSizeWidth);
            this.groupBoxSize.Controls.Add(this.label5);
            this.groupBoxSize.Controls.Add(this.label4);
            this.groupBoxSize.Location = new System.Drawing.Point(672, 324);
            this.groupBoxSize.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxSize.Name = "groupBoxSize";
            this.groupBoxSize.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxSize.Size = new System.Drawing.Size(147, 167);
            this.groupBoxSize.TabIndex = 7;
            this.groupBoxSize.TabStop = false;
            this.groupBoxSize.Text = "Size";
            // 
            // textBoxSizeHeight
            // 
            this.textBoxSizeHeight.Location = new System.Drawing.Point(12, 121);
            this.textBoxSizeHeight.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSizeHeight.Name = "textBoxSizeHeight";
            this.textBoxSizeHeight.Size = new System.Drawing.Size(111, 22);
            this.textBoxSizeHeight.TabIndex = 10;
            this.textBoxSizeHeight.Text = "50";
            // 
            // textBoxSizeWidth
            // 
            this.textBoxSizeWidth.Location = new System.Drawing.Point(12, 58);
            this.textBoxSizeWidth.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSizeWidth.Name = "textBoxSizeWidth";
            this.textBoxSizeWidth.Size = new System.Drawing.Size(111, 22);
            this.textBoxSizeWidth.TabIndex = 8;
            this.textBoxSizeWidth.Text = "50";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Width:";
            // 
            // textBoxTextDraw
            // 
            this.textBoxTextDraw.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxTextDraw.Location = new System.Drawing.Point(8, 66);
            this.textBoxTextDraw.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTextDraw.Name = "textBoxTextDraw";
            this.textBoxTextDraw.Size = new System.Drawing.Size(132, 22);
            this.textBoxTextDraw.TabIndex = 0;
            // 
            // labelTextDraw
            // 
            this.labelTextDraw.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTextDraw.AutoSize = true;
            this.labelTextDraw.Location = new System.Drawing.Point(8, 34);
            this.labelTextDraw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTextDraw.Name = "labelTextDraw";
            this.labelTextDraw.Size = new System.Drawing.Size(122, 17);
            this.labelTextDraw.TabIndex = 7;
            this.labelTextDraw.Text = "Enter text to draw:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(832, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveDBToolStripMenuItem,
            this.loadDBToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveDBToolStripMenuItem
            // 
            this.saveDBToolStripMenuItem.Name = "saveDBToolStripMenuItem";
            this.saveDBToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.saveDBToolStripMenuItem.Text = "Save: DB";
            this.saveDBToolStripMenuItem.Click += new System.EventHandler(this.saveDBToolStripMenuItem_Click);
            // 
            // loadDBToolStripMenuItem
            // 
            this.loadDBToolStripMenuItem.Name = "loadDBToolStripMenuItem";
            this.loadDBToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.loadDBToolStripMenuItem.Text = "Load: DB";
            this.loadDBToolStripMenuItem.Click += new System.EventHandler(this.loadDBToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBoxText
            // 
            this.groupBoxText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBoxText.Controls.Add(this.label3);
            this.groupBoxText.Controls.Add(this.textBoxFontSize);
            this.groupBoxText.Controls.Add(this.labelTextDraw);
            this.groupBoxText.Controls.Add(this.textBoxTextDraw);
            this.groupBoxText.Enabled = false;
            this.groupBoxText.Location = new System.Drawing.Point(672, 533);
            this.groupBoxText.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxText.Name = "groupBoxText";
            this.groupBoxText.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxText.Size = new System.Drawing.Size(147, 167);
            this.groupBoxText.TabIndex = 11;
            this.groupBoxText.TabStop = false;
            this.groupBoxText.Text = "Text";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Font size:";
            // 
            // textBoxFontSize
            // 
            this.textBoxFontSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxFontSize.Location = new System.Drawing.Point(8, 133);
            this.textBoxFontSize.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFontSize.Name = "textBoxFontSize";
            this.textBoxFontSize.Size = new System.Drawing.Size(132, 22);
            this.textBoxFontSize.TabIndex = 8;
            this.textBoxFontSize.Text = "25";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 839);
            this.Controls.Add(this.groupBoxText);
            this.Controls.Add(this.groupBoxSize);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Draw Tool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxSize.ResumeLayout(false);
            this.groupBoxSize.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxText.ResumeLayout(false);
            this.groupBoxText.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonText;
        private System.Windows.Forms.RadioButton radioButtonRectangle;
        private System.Windows.Forms.RadioButton radioButtonCircle;
        private System.Windows.Forms.Button buttonBgColor;
        private System.Windows.Forms.Button buttonBrushColor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxSize;
        private System.Windows.Forms.TextBox textBoxTextDraw;
        private System.Windows.Forms.Label labelTextDraw;
        private System.Windows.Forms.TextBox textBoxSizeHeight;
        private System.Windows.Forms.TextBox textBoxSizeWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFontSize;
    }
}

