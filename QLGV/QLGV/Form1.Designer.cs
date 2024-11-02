namespace QLGV
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.FlowLayoutPanel();
            this.pnGiaovien = new System.Windows.Forms.Panel();
            this.btnGiaovien = new System.Windows.Forms.Button();
            this.pnChucvu = new System.Windows.Forms.Panel();
            this.btnChucvu = new System.Windows.Forms.Button();
            this.pnLuong = new System.Windows.Forms.Panel();
            this.btnLuong = new System.Windows.Forms.Button();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.menu.SuspendLayout();
            this.pnGiaovien.SuspendLayout();
            this.pnChucvu.SuspendLayout();
            this.pnLuong.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 40);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "MENU";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMenu.Image = global::QLGV.Properties.Resources.menu;
            this.btnMenu.Location = new System.Drawing.Point(6, 5);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(28, 28);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.CadetBlue;
            this.menu.Controls.Add(this.pnGiaovien);
            this.menu.Controls.Add(this.pnChucvu);
            this.menu.Controls.Add(this.pnLuong);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.menu.Location = new System.Drawing.Point(0, 40);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.menu.Size = new System.Drawing.Size(170, 440);
            this.menu.TabIndex = 1;
            // 
            // pnGiaovien
            // 
            this.pnGiaovien.Controls.Add(this.btnGiaovien);
            this.pnGiaovien.Location = new System.Drawing.Point(3, 28);
            this.pnGiaovien.Name = "pnGiaovien";
            this.pnGiaovien.Size = new System.Drawing.Size(167, 52);
            this.pnGiaovien.TabIndex = 2;
            // 
            // btnGiaovien
            // 
            this.btnGiaovien.BackColor = System.Drawing.Color.CadetBlue;
            this.btnGiaovien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaovien.ForeColor = System.Drawing.Color.White;
            this.btnGiaovien.Image = ((System.Drawing.Image)(resources.GetObject("btnGiaovien.Image")));
            this.btnGiaovien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiaovien.Location = new System.Drawing.Point(-10, -8);
            this.btnGiaovien.Name = "btnGiaovien";
            this.btnGiaovien.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnGiaovien.Size = new System.Drawing.Size(184, 70);
            this.btnGiaovien.TabIndex = 0;
            this.btnGiaovien.Text = "           GIÁO VIÊN";
            this.btnGiaovien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiaovien.UseVisualStyleBackColor = false;
            this.btnGiaovien.Click += new System.EventHandler(this.btnGiaovien_Click);
            // 
            // pnChucvu
            // 
            this.pnChucvu.Controls.Add(this.btnChucvu);
            this.pnChucvu.Location = new System.Drawing.Point(3, 86);
            this.pnChucvu.Name = "pnChucvu";
            this.pnChucvu.Size = new System.Drawing.Size(167, 52);
            this.pnChucvu.TabIndex = 4;
            // 
            // btnChucvu
            // 
            this.btnChucvu.BackColor = System.Drawing.Color.CadetBlue;
            this.btnChucvu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChucvu.ForeColor = System.Drawing.Color.White;
            this.btnChucvu.Image = ((System.Drawing.Image)(resources.GetObject("btnChucvu.Image")));
            this.btnChucvu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChucvu.Location = new System.Drawing.Point(-10, -9);
            this.btnChucvu.Name = "btnChucvu";
            this.btnChucvu.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnChucvu.Size = new System.Drawing.Size(184, 76);
            this.btnChucvu.TabIndex = 0;
            this.btnChucvu.Text = "           CHỨC VỤ";
            this.btnChucvu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChucvu.UseVisualStyleBackColor = false;
            this.btnChucvu.Click += new System.EventHandler(this.btnChucvu_Click);
            // 
            // pnLuong
            // 
            this.pnLuong.Controls.Add(this.btnLuong);
            this.pnLuong.Location = new System.Drawing.Point(3, 144);
            this.pnLuong.Name = "pnLuong";
            this.pnLuong.Size = new System.Drawing.Size(167, 52);
            this.pnLuong.TabIndex = 3;
            // 
            // btnLuong
            // 
            this.btnLuong.BackColor = System.Drawing.Color.CadetBlue;
            this.btnLuong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuong.ForeColor = System.Drawing.Color.White;
            this.btnLuong.Image = ((System.Drawing.Image)(resources.GetObject("btnLuong.Image")));
            this.btnLuong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuong.Location = new System.Drawing.Point(-9, -9);
            this.btnLuong.Name = "btnLuong";
            this.btnLuong.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnLuong.Size = new System.Drawing.Size(183, 70);
            this.btnLuong.TabIndex = 0;
            this.btnLuong.Text = "      LƯƠNG GIÁO VIÊN";
            this.btnLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuong.UseVisualStyleBackColor = false;
            this.btnLuong.Click += new System.EventHandler(this.btnLuong_Click);
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(740, 480);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.menu.ResumeLayout(false);
            this.pnGiaovien.ResumeLayout(false);
            this.pnChucvu.ResumeLayout(false);
            this.pnLuong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel menu;
        private System.Windows.Forms.Panel pnGiaovien;
        private System.Windows.Forms.Button btnGiaovien;
        private System.Windows.Forms.Panel pnLuong;
        private System.Windows.Forms.Button btnLuong;
        private System.Windows.Forms.Panel pnChucvu;
        private System.Windows.Forms.Button btnChucvu;
        private System.Windows.Forms.Timer menuTransition;
    }
}

