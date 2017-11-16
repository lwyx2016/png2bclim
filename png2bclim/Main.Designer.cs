namespace png2bclim
{
    partial class Main
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
            this.B_Open = new System.Windows.Forms.Button();
            this.TB_Path = new System.Windows.Forms.TextBox();
            this.PB_BCLIM = new System.Windows.Forms.PictureBox();
            this.GB_BCLIMOptions = new System.Windows.Forms.GroupBox();
            this.CHK_AutoSaveBCLIM = new System.Windows.Forms.CheckBox();
            this.L_SQREC = new System.Windows.Forms.Label();
            this.CB_Shape = new System.Windows.Forms.ComboBox();
            this.CB_OutFormat = new System.Windows.Forms.ComboBox();
            this.GB_PNGOptions = new System.Windows.Forms.GroupBox();
            this.CHK_NoCrop = new System.Windows.Forms.CheckBox();
            this.CHK_AutoSavePNG = new System.Windows.Forms.CheckBox();
            this.PaletteBox = new System.Windows.Forms.PictureBox();
            this.GB_Details = new System.Windows.Forms.GroupBox();
            this.L_Meta = new System.Windows.Forms.Label();
            this.L_Details = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_BCLIM)).BeginInit();
            this.GB_BCLIMOptions.SuspendLayout();
            this.GB_PNGOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaletteBox)).BeginInit();
            this.GB_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_Open
            // 
            this.B_Open.Location = new System.Drawing.Point(2, 50);
            this.B_Open.Name = "B_Open";
            this.B_Open.Size = new System.Drawing.Size(62, 21);
            this.B_Open.TabIndex = 2;
            this.B_Open.Text = "Open";
            this.B_Open.UseVisualStyleBackColor = true;
            this.B_Open.Click += new System.EventHandler(this.B_Open_Click);
            // 
            // TB_Path
            // 
            this.TB_Path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Path.Location = new System.Drawing.Point(83, 7);
            this.TB_Path.Name = "TB_Path";
            this.TB_Path.ReadOnly = true;
            this.TB_Path.Size = new System.Drawing.Size(675, 21);
            this.TB_Path.TabIndex = 5;
            // 
            // PB_BCLIM
            // 
            this.PB_BCLIM.BackgroundImage = global::png2bclim.Properties.Resources.BackgroundImage;
            this.PB_BCLIM.ErrorImage = null;
            this.PB_BCLIM.InitialImage = null;
            this.PB_BCLIM.Location = new System.Drawing.Point(167, 50);
            this.PB_BCLIM.Name = "PB_BCLIM";
            this.PB_BCLIM.Size = new System.Drawing.Size(580, 465);
            this.PB_BCLIM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PB_BCLIM.TabIndex = 6;
            this.PB_BCLIM.TabStop = false;
            // 
            // GB_BCLIMOptions
            // 
            this.GB_BCLIMOptions.Controls.Add(this.CHK_AutoSaveBCLIM);
            this.GB_BCLIMOptions.Controls.Add(this.L_SQREC);
            this.GB_BCLIMOptions.Controls.Add(this.CB_Shape);
            this.GB_BCLIMOptions.Controls.Add(this.CB_OutFormat);
            this.GB_BCLIMOptions.Location = new System.Drawing.Point(12, 93);
            this.GB_BCLIMOptions.Name = "GB_BCLIMOptions";
            this.GB_BCLIMOptions.Size = new System.Drawing.Size(149, 105);
            this.GB_BCLIMOptions.TabIndex = 10;
            this.GB_BCLIMOptions.TabStop = false;
            this.GB_BCLIMOptions.Text = "BCLIM Output Format";
            // 
            // CHK_AutoSaveBCLIM
            // 
            this.CHK_AutoSaveBCLIM.AutoSize = true;
            this.CHK_AutoSaveBCLIM.Location = new System.Drawing.Point(13, 84);
            this.CHK_AutoSaveBCLIM.Name = "CHK_AutoSaveBCLIM";
            this.CHK_AutoSaveBCLIM.Size = new System.Drawing.Size(108, 16);
            this.CHK_AutoSaveBCLIM.TabIndex = 3;
            this.CHK_AutoSaveBCLIM.Text = "Autosave BCLIM";
            this.CHK_AutoSaveBCLIM.UseVisualStyleBackColor = true;
            // 
            // L_SQREC
            // 
            this.L_SQREC.AutoSize = true;
            this.L_SQREC.Location = new System.Drawing.Point(9, 42);
            this.L_SQREC.Name = "L_SQREC";
            this.L_SQREC.Size = new System.Drawing.Size(113, 12);
            this.L_SQREC.TabIndex = 2;
            this.L_SQREC.Text = "Square / Rectangle";
            // 
            // CB_Shape
            // 
            this.CB_Shape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Shape.FormattingEnabled = true;
            this.CB_Shape.Items.AddRange(new object[] {
            "0 - Rectangle (>64)",
            "1 - Square (Override)"});
            this.CB_Shape.Location = new System.Drawing.Point(7, 57);
            this.CB_Shape.Name = "CB_Shape";
            this.CB_Shape.Size = new System.Drawing.Size(132, 20);
            this.CB_Shape.TabIndex = 1;
            // 
            // CB_OutFormat
            // 
            this.CB_OutFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_OutFormat.FormattingEnabled = true;
            this.CB_OutFormat.Items.AddRange(new object[] {
            "0 - L8",
            "1 - A8",
            "2 - LA4",
            "3 - LA8",
            "4 - HILO8",
            "5 - RGB565",
            "6 - RGB8 (24bit)",
            "7 - RGBA5551",
            "X - ColorPalette",
            "8 - RGBA4444",
            "9 - RGBA8888",
            "A - ETC1",
            "B - ETC1A4",
            "C - L4",
            "D - A4"});
            this.CB_OutFormat.Location = new System.Drawing.Point(7, 18);
            this.CB_OutFormat.Name = "CB_OutFormat";
            this.CB_OutFormat.Size = new System.Drawing.Size(132, 20);
            this.CB_OutFormat.TabIndex = 0;
            // 
            // GB_PNGOptions
            // 
            this.GB_PNGOptions.Controls.Add(this.CHK_NoCrop);
            this.GB_PNGOptions.Controls.Add(this.CHK_AutoSavePNG);
            this.GB_PNGOptions.Location = new System.Drawing.Point(12, 213);
            this.GB_PNGOptions.Name = "GB_PNGOptions";
            this.GB_PNGOptions.Size = new System.Drawing.Size(149, 60);
            this.GB_PNGOptions.TabIndex = 11;
            this.GB_PNGOptions.TabStop = false;
            this.GB_PNGOptions.Text = "PNG Output Options";
            // 
            // CHK_NoCrop
            // 
            this.CHK_NoCrop.AutoSize = true;
            this.CHK_NoCrop.Location = new System.Drawing.Point(13, 39);
            this.CHK_NoCrop.Name = "CHK_NoCrop";
            this.CHK_NoCrop.Size = new System.Drawing.Size(126, 16);
            this.CHK_NoCrop.TabIndex = 1;
            this.CHK_NoCrop.Text = "Don\'t Crop Result";
            this.CHK_NoCrop.UseVisualStyleBackColor = true;
            // 
            // CHK_AutoSavePNG
            // 
            this.CHK_AutoSavePNG.AutoSize = true;
            this.CHK_AutoSavePNG.Location = new System.Drawing.Point(13, 18);
            this.CHK_AutoSavePNG.Name = "CHK_AutoSavePNG";
            this.CHK_AutoSavePNG.Size = new System.Drawing.Size(96, 16);
            this.CHK_AutoSavePNG.TabIndex = 0;
            this.CHK_AutoSavePNG.Text = "Autosave PNG";
            this.CHK_AutoSavePNG.UseVisualStyleBackColor = true;
            // 
            // PaletteBox
            // 
            this.PaletteBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PaletteBox.Location = new System.Drawing.Point(167, 34);
            this.PaletteBox.Name = "PaletteBox";
            this.PaletteBox.Size = new System.Drawing.Size(80, 10);
            this.PaletteBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PaletteBox.TabIndex = 28;
            this.PaletteBox.TabStop = false;
            this.PaletteBox.Visible = false;
            // 
            // GB_Details
            // 
            this.GB_Details.Controls.Add(this.L_Meta);
            this.GB_Details.Controls.Add(this.L_Details);
            this.GB_Details.Location = new System.Drawing.Point(12, 289);
            this.GB_Details.Name = "GB_Details";
            this.GB_Details.Size = new System.Drawing.Size(149, 79);
            this.GB_Details.TabIndex = 29;
            this.GB_Details.TabStop = false;
            this.GB_Details.Text = "Details:";
            this.GB_Details.Visible = false;
            // 
            // L_Meta
            // 
            this.L_Meta.AutoSize = true;
            this.L_Meta.Location = new System.Drawing.Point(6, 16);
            this.L_Meta.Name = "L_Meta";
            this.L_Meta.Size = new System.Drawing.Size(83, 60);
            this.L_Meta.TabIndex = 26;
            this.L_Meta.Text = "FileFormat:\r\nImage Width:\r\nImage Height:\r\nTile Width:\r\nTile Height:";
            this.L_Meta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_Details
            // 
            this.L_Details.AutoSize = true;
            this.L_Details.Location = new System.Drawing.Point(98, 16);
            this.L_Details.Name = "L_Details";
            this.L_Details.Size = new System.Drawing.Size(11, 60);
            this.L_Details.TabIndex = 25;
            this.L_Details.Text = "0\r\n0\r\n0\r\n0\r\n0";
            this.L_Details.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Rota to the image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(76, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 21);
            this.button2.TabIndex = 31;
            this.button2.Text = "Save PNG";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 32;
            this.label1.Text = "File path:";
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 527);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GB_Details);
            this.Controls.Add(this.PaletteBox);
            this.Controls.Add(this.GB_PNGOptions);
            this.Controls.Add(this.GB_BCLIMOptions);
            this.Controls.Add(this.PB_BCLIM);
            this.Controls.Add(this.TB_Path);
            this.Controls.Add(this.B_Open);
            this.MinimumSize = new System.Drawing.Size(385, 340);
            this.Name = "Main";
            this.Text = "png2bclim";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.tabMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.tabMain_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.PB_BCLIM)).EndInit();
            this.GB_BCLIMOptions.ResumeLayout(false);
            this.GB_BCLIMOptions.PerformLayout();
            this.GB_PNGOptions.ResumeLayout(false);
            this.GB_PNGOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaletteBox)).EndInit();
            this.GB_Details.ResumeLayout(false);
            this.GB_Details.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Open;
        private System.Windows.Forms.TextBox TB_Path;
        private System.Windows.Forms.PictureBox PB_BCLIM;
        private System.Windows.Forms.GroupBox GB_BCLIMOptions;
        private System.Windows.Forms.ComboBox CB_OutFormat;
        private System.Windows.Forms.GroupBox GB_PNGOptions;
        private System.Windows.Forms.CheckBox CHK_NoCrop;
        private System.Windows.Forms.CheckBox CHK_AutoSavePNG;
        private System.Windows.Forms.PictureBox PaletteBox;
        private System.Windows.Forms.GroupBox GB_Details;
        private System.Windows.Forms.Label L_SQREC;
        private System.Windows.Forms.ComboBox CB_Shape;
        private System.Windows.Forms.Label L_Details;
        private System.Windows.Forms.CheckBox CHK_AutoSaveBCLIM;
        private System.Windows.Forms.Label L_Meta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}

