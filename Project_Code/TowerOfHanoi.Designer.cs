namespace Project_Code
{
    partial class TowerOfHanoi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TowerOfHanoi));
            this.c = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.a = new System.Windows.Forms.FlowLayoutPanel();
            this._3 = new System.Windows.Forms.Button();
            this._2 = new System.Windows.Forms.Button();
            this._1 = new System.Windows.Forms.Button();
            this.b = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Disk_num = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this._clock = new System.Windows.Forms.Timer(this.components);
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator5 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator6 = new Bunifu.Framework.UI.BunifuSeparator();
            this.flowLayoutPanel1.SuspendLayout();
            this.a.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // c
            // 
            this.c.BackColor = System.Drawing.Color.White;
            this.c.Enabled = false;
            this.c.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.c.Location = new System.Drawing.Point(325, 3);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(139, 391);
            this.c.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Lavender;
            this.flowLayoutPanel1.Controls.Add(this.a);
            this.flowLayoutPanel1.Controls.Add(this.bunifuSeparator3);
            this.flowLayoutPanel1.Controls.Add(this.b);
            this.flowLayoutPanel1.Controls.Add(this.bunifuSeparator2);
            this.flowLayoutPanel1.Controls.Add(this.c);
            this.flowLayoutPanel1.Controls.Add(this.bunifuSeparator4);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.bunifuSeparator5);
            this.flowLayoutPanel1.Controls.Add(this.bunifuSeparator6);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.Disk_num);
            this.flowLayoutPanel1.Controls.Add(this.bunifuFlatButton1);
            this.flowLayoutPanel1.Controls.Add(this.bunifuImageButton1);
            this.flowLayoutPanel1.Controls.Add(this.bunifuSeparator1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(706, 485);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // a
            // 
            this.a.BackColor = System.Drawing.Color.DarkGray;
            this.a.Controls.Add(this._3);
            this.a.Controls.Add(this._2);
            this.a.Controls.Add(this._1);
            this.a.Enabled = false;
            this.a.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.a.Location = new System.Drawing.Point(3, 3);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(139, 391);
            this.a.TabIndex = 0;
            // 
            // _3
            // 
            this._3.BackColor = System.Drawing.Color.Coral;
            this._3.Location = new System.Drawing.Point(3, 349);
            this._3.Name = "_3";
            this._3.Size = new System.Drawing.Size(136, 39);
            this._3.TabIndex = 0;
            this._3.Text = "3";
            this._3.UseVisualStyleBackColor = false;
            this._3.Visible = false;
            // 
            // _2
            // 
            this._2.BackColor = System.Drawing.Color.CornflowerBlue;
            this._2.Location = new System.Drawing.Point(3, 304);
            this._2.Name = "_2";
            this._2.Size = new System.Drawing.Size(136, 39);
            this._2.TabIndex = 1;
            this._2.Text = "2";
            this._2.UseVisualStyleBackColor = false;
            this._2.Visible = false;
            // 
            // _1
            // 
            this._1.BackColor = System.Drawing.Color.Crimson;
            this._1.Location = new System.Drawing.Point(3, 258);
            this._1.Name = "_1";
            this._1.Size = new System.Drawing.Size(136, 40);
            this._1.TabIndex = 2;
            this._1.Text = "1";
            this._1.UseVisualStyleBackColor = false;
            this._1.Visible = false;
            // 
            // b
            // 
            this.b.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.b.Enabled = false;
            this.b.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.b.Location = new System.Drawing.Point(164, 3);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(139, 391);
            this.b.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(486, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 391);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "GO";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Pasajero", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(316, 416);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(138, 50);
            this.bunifuFlatButton1.TabIndex = 1;
            this.bunifuFlatButton1.Text = "GO";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.GhostWhite;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Pasajero", 14.25F, System.Drawing.FontStyle.Bold);
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // Disk_num
            // 
            this.Disk_num.BorderColorFocused = System.Drawing.Color.Blue;
            this.Disk_num.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Disk_num.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.Disk_num.BorderThickness = 3;
            this.Disk_num.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Disk_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Disk_num.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Disk_num.isPassword = false;
            this.Disk_num.Location = new System.Drawing.Point(161, 417);
            this.Disk_num.Margin = new System.Windows.Forms.Padding(4);
            this.Disk_num.Name = "Disk_num";
            this.Disk_num.Size = new System.Drawing.Size(148, 48);
            this.Disk_num.TabIndex = 0;
            this.Disk_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // _clock
            // 
            this._clock.Tick += new System.EventHandler(this._clock_Tick);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuSeparator1.LineThickness = 3;
            this.bunifuSeparator1.Location = new System.Drawing.Point(3, 472);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(699, 10);
            this.bunifuSeparator1.TabIndex = 4;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator2.LineThickness = 3;
            this.bunifuSeparator2.Location = new System.Drawing.Point(309, 3);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(10, 388);
            this.bunifuSeparator2.TabIndex = 5;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = true;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator3.LineThickness = 3;
            this.bunifuSeparator3.Location = new System.Drawing.Point(148, 3);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(10, 388);
            this.bunifuSeparator3.TabIndex = 6;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = true;
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator4.LineThickness = 3;
            this.bunifuSeparator4.Location = new System.Drawing.Point(470, 3);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(10, 388);
            this.bunifuSeparator4.TabIndex = 7;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = true;
            // 
            // bunifuSeparator5
            // 
            this.bunifuSeparator5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator5.LineThickness = 3;
            this.bunifuSeparator5.Location = new System.Drawing.Point(692, 3);
            this.bunifuSeparator5.Name = "bunifuSeparator5";
            this.bunifuSeparator5.Size = new System.Drawing.Size(10, 391);
            this.bunifuSeparator5.TabIndex = 8;
            this.bunifuSeparator5.Transparency = 255;
            this.bunifuSeparator5.Vertical = true;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(460, 421);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(199, 45);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 9;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Pasajero", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(3, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 56);
            this.label1.TabIndex = 10;
            this.label1.Text = "Number of Disks";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuSeparator6
            // 
            this.bunifuSeparator6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator6.LineColor = System.Drawing.Color.PowderBlue;
            this.bunifuSeparator6.LineThickness = 3;
            this.bunifuSeparator6.Location = new System.Drawing.Point(3, 400);
            this.bunifuSeparator6.Name = "bunifuSeparator6";
            this.bunifuSeparator6.Size = new System.Drawing.Size(697, 10);
            this.bunifuSeparator6.TabIndex = 5;
            this.bunifuSeparator6.Transparency = 255;
            this.bunifuSeparator6.Vertical = false;
            // 
            // TowerOfHanoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 485);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TowerOfHanoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TowerOfHanoi";
            this.Load += new System.EventHandler(this.TowerOfHanoi_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.a.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel c;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel a;
        private System.Windows.Forms.Button _3;
        private System.Windows.Forms.Button _2;
        private System.Windows.Forms.Button _1;
        private System.Windows.Forms.FlowLayoutPanel b;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuMetroTextbox Disk_num;
        private System.Windows.Forms.Timer _clock;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator5;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator6;

    }
}