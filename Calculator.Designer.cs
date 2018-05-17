namespace ED_Project
{
    partial class Calculator
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.textBoxDecimal = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxOctal = new System.Windows.Forms.TextBox();
            this.textBoxHexadecimal = new System.Windows.Forms.TextBox();
            this.textBoxBinary = new System.Windows.Forms.TextBox();
            this.labelDecimal = new System.Windows.Forms.Label();
            this.labelBinary = new System.Windows.Forms.Label();
            this.labelOctal = new System.Windows.Forms.Label();
            this.labelHexadecimal = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.radioButtonBits8 = new System.Windows.Forms.RadioButton();
            this.radioButtonBits16 = new System.Windows.Forms.RadioButton();
            this.radioButtonBits32 = new System.Windows.Forms.RadioButton();
            this.radioButtonComplement2 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDecimal
            // 
            this.textBoxDecimal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDecimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxDecimal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDecimal.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDecimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textBoxDecimal.Location = new System.Drawing.Point(12, 135);
            this.textBoxDecimal.MaxLength = 2000000000;
            this.textBoxDecimal.Multiline = true;
            this.textBoxDecimal.Name = "textBoxDecimal";
            this.textBoxDecimal.Size = new System.Drawing.Size(267, 36);
            this.textBoxDecimal.TabIndex = 1;
            this.textBoxDecimal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDecimal_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(290, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.helpToolStripMenuItem.Text = "About";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(113, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // textBoxOctal
            // 
            this.textBoxOctal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOctal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxOctal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOctal.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOctal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textBoxOctal.Location = new System.Drawing.Point(11, 278);
            this.textBoxOctal.MaxLength = 2000000000;
            this.textBoxOctal.Multiline = true;
            this.textBoxOctal.Name = "textBoxOctal";
            this.textBoxOctal.Size = new System.Drawing.Size(267, 33);
            this.textBoxOctal.TabIndex = 6;
            this.textBoxOctal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOctal_KeyPress);
            // 
            // textBoxHexadecimal
            // 
            this.textBoxHexadecimal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHexadecimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxHexadecimal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHexadecimal.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHexadecimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textBoxHexadecimal.Location = new System.Drawing.Point(12, 339);
            this.textBoxHexadecimal.MaxLength = 2000000000;
            this.textBoxHexadecimal.Multiline = true;
            this.textBoxHexadecimal.Name = "textBoxHexadecimal";
            this.textBoxHexadecimal.Size = new System.Drawing.Size(267, 35);
            this.textBoxHexadecimal.TabIndex = 8;
            this.textBoxHexadecimal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHexadecimal_KeyPress);
            // 
            // textBoxBinary
            // 
            this.textBoxBinary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBinary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxBinary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBinary.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBinary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textBoxBinary.Location = new System.Drawing.Point(12, 217);
            this.textBoxBinary.MaxLength = 2000000000;
            this.textBoxBinary.Multiline = true;
            this.textBoxBinary.Name = "textBoxBinary";
            this.textBoxBinary.Size = new System.Drawing.Size(267, 33);
            this.textBoxBinary.TabIndex = 4;
            this.textBoxBinary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBinary_KeyPress);
            // 
            // labelDecimal
            // 
            this.labelDecimal.AutoSize = true;
            this.labelDecimal.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDecimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.labelDecimal.Location = new System.Drawing.Point(13, 109);
            this.labelDecimal.Name = "labelDecimal";
            this.labelDecimal.Size = new System.Drawing.Size(80, 22);
            this.labelDecimal.TabIndex = 1;
            this.labelDecimal.Text = "Decimal";
            // 
            // labelBinary
            // 
            this.labelBinary.AutoSize = true;
            this.labelBinary.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBinary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.labelBinary.Location = new System.Drawing.Point(12, 173);
            this.labelBinary.Name = "labelBinary";
            this.labelBinary.Size = new System.Drawing.Size(70, 22);
            this.labelBinary.TabIndex = 0;
            this.labelBinary.Text = "Binary";
            // 
            // labelOctal
            // 
            this.labelOctal.AutoSize = true;
            this.labelOctal.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOctal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.labelOctal.Location = new System.Drawing.Point(12, 254);
            this.labelOctal.Name = "labelOctal";
            this.labelOctal.Size = new System.Drawing.Size(60, 22);
            this.labelOctal.TabIndex = 5;
            this.labelOctal.Text = "Octal";
            // 
            // labelHexadecimal
            // 
            this.labelHexadecimal.AutoSize = true;
            this.labelHexadecimal.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHexadecimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.labelHexadecimal.Location = new System.Drawing.Point(13, 315);
            this.labelHexadecimal.Name = "labelHexadecimal";
            this.labelHexadecimal.Size = new System.Drawing.Size(120, 22);
            this.labelHexadecimal.TabIndex = 7;
            this.labelHexadecimal.Text = "Hexadecimal";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTitle.Enabled = false;
            this.textBoxTitle.Font = new System.Drawing.Font("Consolas", 23F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.textBoxTitle.Location = new System.Drawing.Point(12, 52);
            this.textBoxTitle.Multiline = true;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.ReadOnly = true;
            this.textBoxTitle.Size = new System.Drawing.Size(267, 50);
            this.textBoxTitle.TabIndex = 9;
            this.textBoxTitle.Text = "BASE CONVERTER";
            this.textBoxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonConvert
            // 
            this.buttonConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonConvert.FlatAppearance.BorderSize = 2;
            this.buttonConvert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.buttonConvert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.buttonConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConvert.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConvert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonConvert.Location = new System.Drawing.Point(12, 404);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(106, 37);
            this.buttonConvert.TabIndex = 9;
            this.buttonConvert.Text = "CONVERT";
            this.buttonConvert.UseVisualStyleBackColor = false;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonClear.FlatAppearance.BorderSize = 2;
            this.buttonClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.buttonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonClear.Location = new System.Drawing.Point(173, 404);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(106, 37);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // radioButtonBits8
            // 
            this.radioButtonBits8.AutoSize = true;
            this.radioButtonBits8.Location = new System.Drawing.Point(3, 3);
            this.radioButtonBits8.Name = "radioButtonBits8";
            this.radioButtonBits8.Size = new System.Drawing.Size(50, 17);
            this.radioButtonBits8.TabIndex = 0;
            this.radioButtonBits8.TabStop = true;
            this.radioButtonBits8.Text = "8 bits";
            this.radioButtonBits8.UseVisualStyleBackColor = true;
            this.radioButtonBits8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            // 
            // radioButtonBits16
            // 
            this.radioButtonBits16.AutoSize = true;
            this.radioButtonBits16.Location = new System.Drawing.Point(58, 3);
            this.radioButtonBits16.Name = "radioButtonBits16";
            this.radioButtonBits16.Size = new System.Drawing.Size(56, 17);
            this.radioButtonBits16.TabIndex = 1;
            this.radioButtonBits16.TabStop = true;
            this.radioButtonBits16.Text = "16 bits";
            this.radioButtonBits16.UseVisualStyleBackColor = true;
            this.radioButtonBits16.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            // 
            // radioButtonBits32
            // 
            this.radioButtonBits32.AutoSize = true;
            this.radioButtonBits32.Location = new System.Drawing.Point(120, 4);
            this.radioButtonBits32.Name = "radioButtonBits32";
            this.radioButtonBits32.Size = new System.Drawing.Size(56, 17);
            this.radioButtonBits32.TabIndex = 2;
            this.radioButtonBits32.TabStop = true;
            this.radioButtonBits32.Text = "32 bits";
            this.radioButtonBits32.UseVisualStyleBackColor = true;
            this.radioButtonBits32.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBinary_KeyPress);
            // 
            // radioButtonComplement2
            // 
            this.radioButtonComplement2.AutoSize = true;
            this.radioButtonComplement2.Location = new System.Drawing.Point(88, 194);
            this.radioButtonComplement2.Name = "radioButtonComplement2";
            this.radioButtonComplement2.Size = new System.Drawing.Size(109, 17);
            this.radioButtonComplement2.TabIndex = 3;
            this.radioButtonComplement2.TabStop = true;
            this.radioButtonComplement2.Text = "two\'s complement";
            this.radioButtonComplement2.UseVisualStyleBackColor = true;
            this.radioButtonComplement2.CheckedChanged += new System.EventHandler(this.radioButtonComplement2_CheckedChanged);
            this.radioButtonComplement2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonBits8);
            this.panel1.Controls.Add(this.radioButtonBits16);
            this.panel1.Controls.Add(this.radioButtonBits32);
            this.panel1.Location = new System.Drawing.Point(85, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 23);
            this.panel1.TabIndex = 2;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(290, 475);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButtonComplement2);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelHexadecimal);
            this.Controls.Add(this.labelOctal);
            this.Controls.Add(this.labelBinary);
            this.Controls.Add(this.labelDecimal);
            this.Controls.Add(this.textBoxBinary);
            this.Controls.Add(this.textBoxHexadecimal);
            this.Controls.Add(this.textBoxOctal);
            this.Controls.Add(this.textBoxDecimal);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(306, 550);
            this.MinimumSize = new System.Drawing.Size(306, 466);
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        public System.Windows.Forms.TextBox textBoxOctal;
        public System.Windows.Forms.TextBox textBoxHexadecimal;
        public System.Windows.Forms.TextBox textBoxBinary;
        private System.Windows.Forms.Label labelDecimal;
        private System.Windows.Forms.Label labelBinary;
        private System.Windows.Forms.Label labelOctal;
        private System.Windows.Forms.Label labelHexadecimal;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button buttonClear;
        public System.Windows.Forms.TextBox textBoxDecimal;
        private System.Windows.Forms.RadioButton radioButtonBits8;
        private System.Windows.Forms.RadioButton radioButtonBits16;
        private System.Windows.Forms.RadioButton radioButtonBits32;
        private System.Windows.Forms.RadioButton radioButtonComplement2;
        private System.Windows.Forms.Panel panel1;
    }
}

