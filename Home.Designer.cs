namespace ELO
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.categoryPanel = new System.Windows.Forms.Panel();
            this.categoryLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnKids = new System.Windows.Forms.Button();
            this.btnWomen = new System.Windows.Forms.Button();
            this.btnMen = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.searchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.cartLink = new System.Windows.Forms.LinkLabel();
            this.loginLink = new System.Windows.Forms.LinkLabel();
            this.pbSearchLogo = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.homePanel = new System.Windows.Forms.Panel();
            this.homeFrontPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.categoryPanel.SuspendLayout();
            this.categoryLayout.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.homePanel.SuspendLayout();
            this.homeFrontPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.categoryPanel);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 135);
            this.panel1.TabIndex = 0;
            // 
            // categoryPanel
            // 
            this.categoryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.categoryPanel.Controls.Add(this.categoryLayout);
            this.categoryPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.categoryPanel.Location = new System.Drawing.Point(0, 86);
            this.categoryPanel.Name = "categoryPanel";
            this.categoryPanel.Size = new System.Drawing.Size(1039, 49);
            this.categoryPanel.TabIndex = 4;
            // 
            // categoryLayout
            // 
            this.categoryLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryLayout.ColumnCount = 3;
            this.categoryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.categoryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.categoryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.categoryLayout.Controls.Add(this.btnKids, 2, 0);
            this.categoryLayout.Controls.Add(this.btnWomen, 1, 0);
            this.categoryLayout.Controls.Add(this.btnMen, 0, 0);
            this.categoryLayout.Location = new System.Drawing.Point(335, 3);
            this.categoryLayout.Name = "categoryLayout";
            this.categoryLayout.RowCount = 1;
            this.categoryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.categoryLayout.Size = new System.Drawing.Size(328, 40);
            this.categoryLayout.TabIndex = 1;
            // 
            // btnKids
            // 
            this.btnKids.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKids.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKids.Location = new System.Drawing.Point(221, 3);
            this.btnKids.Name = "btnKids";
            this.btnKids.Size = new System.Drawing.Size(104, 34);
            this.btnKids.TabIndex = 4;
            this.btnKids.Text = "Kids";
            this.btnKids.UseVisualStyleBackColor = true;
            this.btnKids.Click += new System.EventHandler(this.btnKids_Click);
            this.btnKids.MouseLeave += new System.EventHandler(this.btnKids_MouseLeave);
            this.btnKids.MouseHover += new System.EventHandler(this.btnKids_MouseHover);
            // 
            // btnWomen
            // 
            this.btnWomen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWomen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWomen.Location = new System.Drawing.Point(112, 3);
            this.btnWomen.Name = "btnWomen";
            this.btnWomen.Size = new System.Drawing.Size(103, 34);
            this.btnWomen.TabIndex = 3;
            this.btnWomen.Text = "Women";
            this.btnWomen.UseVisualStyleBackColor = true;
            this.btnWomen.Click += new System.EventHandler(this.btnWomen_Click);
            this.btnWomen.MouseLeave += new System.EventHandler(this.btnWomen_MouseLeave);
            this.btnWomen.MouseHover += new System.EventHandler(this.btnWomen_MouseHover);
            // 
            // btnMen
            // 
            this.btnMen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMen.Location = new System.Drawing.Point(3, 3);
            this.btnMen.Name = "btnMen";
            this.btnMen.Size = new System.Drawing.Size(103, 34);
            this.btnMen.TabIndex = 2;
            this.btnMen.Text = "Men";
            this.btnMen.UseVisualStyleBackColor = true;
            this.btnMen.Click += new System.EventHandler(this.btnMen_Click_1);
            this.btnMen.MouseLeave += new System.EventHandler(this.btnMen_MouseLeave);
            this.btnMen.MouseHover += new System.EventHandler(this.btnMen_MouseHover);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.8505F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.149502F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel2.Controls.Add(this.searchBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cartLink, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.loginLink, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.pbSearchLogo, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(201, 37);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(807, 39);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.searchBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.DefaultText = "";
            this.searchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.searchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBox.Location = new System.Drawing.Point(4, 4);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchBox.Name = "searchBox";
            this.searchBox.PasswordChar = '\0';
            this.searchBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.searchBox.PlaceholderText = "What are you looking for..";
            this.searchBox.SelectedText = "";
            this.searchBox.Size = new System.Drawing.Size(563, 31);
            this.searchBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.searchBox.TabIndex = 1;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // cartLink
            // 
            this.cartLink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartLink.AutoSize = true;
            this.cartLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cartLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartLink.LinkColor = System.Drawing.Color.White;
            this.cartLink.Location = new System.Drawing.Point(723, 0);
            this.cartLink.Name = "cartLink";
            this.cartLink.Padding = new System.Windows.Forms.Padding(0, 11, 0, 0);
            this.cartLink.Size = new System.Drawing.Size(81, 39);
            this.cartLink.TabIndex = 3;
            this.cartLink.TabStop = true;
            this.cartLink.Text = "Cart";
            this.cartLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cartLink_LinkClicked);
            // 
            // loginLink
            // 
            this.loginLink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginLink.AutoSize = true;
            this.loginLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLink.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.loginLink.LinkColor = System.Drawing.Color.White;
            this.loginLink.Location = new System.Drawing.Point(657, 0);
            this.loginLink.Name = "loginLink";
            this.loginLink.Padding = new System.Windows.Forms.Padding(0, 11, 0, 0);
            this.loginLink.Size = new System.Drawing.Size(60, 39);
            this.loginLink.TabIndex = 4;
            this.loginLink.TabStop = true;
            this.loginLink.Text = "Login";
            this.loginLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginLink_LinkClicked);
            // 
            // pbSearchLogo
            // 
            this.pbSearchLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbSearchLogo.Image")));
            this.pbSearchLogo.Location = new System.Drawing.Point(571, 0);
            this.pbSearchLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pbSearchLogo.Name = "pbSearchLogo";
            this.pbSearchLogo.Size = new System.Drawing.Size(31, 39);
            this.pbSearchLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearchLogo.TabIndex = 6;
            this.pbSearchLogo.TabStop = false;
            this.pbSearchLogo.Click += new System.EventHandler(this.pbSearchLogo_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(32, 15);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(126, 75);
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            this.pbLogo.Tag = "0";
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.homeFrontPanel);
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePanel.Location = new System.Drawing.Point(0, 135);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(1039, 350);
            this.homePanel.TabIndex = 1;
            // 
            // homeFrontPanel
            // 
            this.homeFrontPanel.AutoSize = true;
            this.homeFrontPanel.Controls.Add(this.tableLayoutPanel1);
            this.homeFrontPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeFrontPanel.Location = new System.Drawing.Point(0, 0);
            this.homeFrontPanel.Name = "homeFrontPanel";
            this.homeFrontPanel.Size = new System.Drawing.Size(1039, 350);
            this.homeFrontPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1039, 350);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1039, 485);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load_1);
            this.panel1.ResumeLayout(false);
            this.categoryPanel.ResumeLayout(false);
            this.categoryLayout.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.homeFrontPanel.ResumeLayout(false);
            this.homeFrontPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.LinkLabel cartLink;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbSearchLogo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2TextBox searchBox;
        public System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Panel homeFrontPanel;
        public System.Windows.Forms.Panel categoryPanel;
        public System.Windows.Forms.TableLayoutPanel categoryLayout;
        private System.Windows.Forms.Button btnKids;
        private System.Windows.Forms.Button btnWomen;
        private System.Windows.Forms.Button btnMen;
        public System.Windows.Forms.LinkLabel loginLink;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

