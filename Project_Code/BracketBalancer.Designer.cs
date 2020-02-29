namespace Project_Code
{
    partial class BracketBalancer
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
            System.Windows.Forms.Panel panel2;
            Bunifu.Framework.UI.BunifuThinButton2 InpBtn;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BracketBalancer));
            this.TempStk = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FinalShowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.StackePnl = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.inpbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            panel2 = new System.Windows.Forms.Panel();
            InpBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // TempStk
            // 
            this.TempStk.BackColor = System.Drawing.Color.Lavender;
            this.TempStk.Dock = System.Windows.Forms.DockStyle.Top;
            this.TempStk.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.TempStk.Location = new System.Drawing.Point(192, 3);
            this.TempStk.Name = "TempStk";
            this.TempStk.Size = new System.Drawing.Size(177, 578);
            this.TempStk.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.82418F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.17582F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 546F));
            this.tableLayoutPanel1.Controls.Add(panel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.StackePnl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TempStk, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(919, 584);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.PowderBlue;
            panel2.Controls.Add(this.inpbox);
            panel2.Controls.Add(this.bunifuSeparator1);
            panel2.Controls.Add(this.FinalShowPanel);
            panel2.Controls.Add(InpBtn);
            panel2.Controls.Add(this.bunifuImageButton1);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(375, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(541, 578);
            panel2.TabIndex = 3;
            // 
            // FinalShowPanel
            // 
            this.FinalShowPanel.AutoSize = true;
            this.FinalShowPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.FinalShowPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FinalShowPanel.Location = new System.Drawing.Point(0, 0);
            this.FinalShowPanel.Name = "FinalShowPanel";
            this.FinalShowPanel.Size = new System.Drawing.Size(541, 0);
            this.FinalShowPanel.TabIndex = 2;
            // 
            // InpBtn
            // 
            InpBtn.ActiveBorderThickness = 1;
            InpBtn.ActiveCornerRadius = 20;
            InpBtn.ActiveFillColor = System.Drawing.Color.Turquoise;
            InpBtn.ActiveForecolor = System.Drawing.Color.Transparent;
            InpBtn.ActiveLineColor = System.Drawing.Color.Aqua;
            InpBtn.BackColor = System.Drawing.Color.PowderBlue;
            InpBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InpBtn.BackgroundImage")));
            InpBtn.ButtonText = "Input";
            InpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            InpBtn.Font = new System.Drawing.Font("Pasajero", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            InpBtn.ForeColor = System.Drawing.Color.SeaGreen;
            InpBtn.IdleBorderThickness = 1;
            InpBtn.IdleCornerRadius = 20;
            InpBtn.IdleFillColor = System.Drawing.Color.White;
            InpBtn.IdleForecolor = System.Drawing.Color.DeepSkyBlue;
            InpBtn.IdleLineColor = System.Drawing.SystemColors.GrayText;
            InpBtn.Location = new System.Drawing.Point(190, 511);
            InpBtn.Margin = new System.Windows.Forms.Padding(5);
            InpBtn.Name = "InpBtn";
            InpBtn.Size = new System.Drawing.Size(181, 41);
            InpBtn.TabIndex = 1;
            InpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            InpBtn.Click += new System.EventHandler(this.InpBtn_Click);
            // 
            // StackePnl
            // 
            this.StackePnl.BackColor = System.Drawing.SystemColors.ControlDark;
            this.StackePnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.StackePnl.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.StackePnl.Location = new System.Drawing.Point(3, 3);
            this.StackePnl.Name = "StackePnl";
            this.StackePnl.Size = new System.Drawing.Size(183, 578);
            this.StackePnl.TabIndex = 1;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.MediumTurquoise;
            this.bunifuSeparator1.LineThickness = 3;
            this.bunifuSeparator1.Location = new System.Drawing.Point(3, 554);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(534, 20);
            this.bunifuSeparator1.TabIndex = 3;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            this.bunifuSeparator1.Load += new System.EventHandler(this.bunifuSeparator1_Load);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(467, 495);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(74, 54);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 10;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // inpbox
            // 
            this.inpbox.BackColor = System.Drawing.Color.AliceBlue;
            this.inpbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inpbox.Font = new System.Drawing.Font("Pasajero", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inpbox.HintForeColor = System.Drawing.Color.Empty;
            this.inpbox.HintText = "";
            this.inpbox.isPassword = false;
            this.inpbox.LineFocusedColor = System.Drawing.Color.LightSkyBlue;
            this.inpbox.LineIdleColor = System.Drawing.Color.DeepSkyBlue;
            this.inpbox.LineMouseHoverColor = System.Drawing.Color.AliceBlue;
            this.inpbox.LineThickness = 6;
            this.inpbox.Location = new System.Drawing.Point(81, 461);
            this.inpbox.Margin = new System.Windows.Forms.Padding(4);
            this.inpbox.Name = "inpbox";
            this.inpbox.Size = new System.Drawing.Size(379, 41);
            this.inpbox.TabIndex = 0;
            this.inpbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BracketBalancer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 584);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BracketBalancer";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BracketBalancer";
            this.tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel TempStk;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel FinalShowPanel;
        private System.Windows.Forms.FlowLayoutPanel StackePnl;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox inpbox;
    }
}