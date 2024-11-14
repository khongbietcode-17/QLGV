namespace QLGV.Views
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.FlowLayoutPanel();
            this.giaovien = new System.Windows.Forms.Button();
            this.chucvu = new System.Windows.Forms.Button();
            this.luong = new System.Windows.Forms.Button();
            this.bomon = new System.Windows.Forms.Button();
            this.chunhiem = new System.Windows.Forms.Button();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.menu.SuspendLayout();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 62);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "MENU";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMenu.Image = global::QLGV.Properties.Resources.menu;
<<<<<<< Updated upstream
            this.btnMenu.Location = new System.Drawing.Point(9, 8);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(42, 43);
=======
            this.btnMenu.Location = new System.Drawing.Point(6, 5);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(28, 28);
>>>>>>> Stashed changes
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.menu.Controls.Add(this.giaovien);
            this.menu.Controls.Add(this.chucvu);
            this.menu.Controls.Add(this.luong);
            this.menu.Controls.Add(this.bomon);
            this.menu.Controls.Add(this.chunhiem);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.menu.Location = new System.Drawing.Point(0, 62);
            this.menu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(255, 676);
            this.menu.TabIndex = 1;
            // 
            // giaovien
            // 
            this.giaovien.BackColor = System.Drawing.Color.Transparent;
            this.giaovien.FlatAppearance.BorderSize = 0;
            this.giaovien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(140)))), ((int)(((byte)(247)))));
            this.giaovien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.giaovien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giaovien.ForeColor = System.Drawing.Color.White;
            this.giaovien.Image = ((System.Drawing.Image)(resources.GetObject("giaovien.Image")));
            this.giaovien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.giaovien.Location = new System.Drawing.Point(4, 5);
            this.giaovien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.giaovien.Name = "giaovien";
            this.giaovien.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.giaovien.Size = new System.Drawing.Size(250, 57);
            this.giaovien.TabIndex = 0;
            this.giaovien.Text = "  GIÁO VIÊN";
            this.giaovien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.giaovien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.giaovien.UseVisualStyleBackColor = false;
          
            // 
            // chucvu
            // 
            this.chucvu.BackColor = System.Drawing.Color.Transparent;
            this.chucvu.FlatAppearance.BorderSize = 0;
            this.chucvu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chucvu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chucvu.ForeColor = System.Drawing.Color.White;
            this.chucvu.Image = ((System.Drawing.Image)(resources.GetObject("chucvu.Image")));
            this.chucvu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chucvu.Location = new System.Drawing.Point(4, 72);
            this.chucvu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chucvu.Name = "chucvu";
            this.chucvu.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.chucvu.Size = new System.Drawing.Size(250, 57);
            this.chucvu.TabIndex = 0;
            this.chucvu.Text = "  CHỨC VỤ";
            this.chucvu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chucvu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chucvu.UseVisualStyleBackColor = false;
            // 
            // luong
            // 
            this.luong.BackColor = System.Drawing.Color.Transparent;
            this.luong.FlatAppearance.BorderSize = 0;
            this.luong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.luong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luong.ForeColor = System.Drawing.Color.White;
            this.luong.Image = global::QLGV.Properties.Resources.money;
            this.luong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.luong.Location = new System.Drawing.Point(4, 139);
            this.luong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.luong.Name = "luong";
            this.luong.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.luong.Size = new System.Drawing.Size(250, 57);
            this.luong.TabIndex = 1;
            this.luong.Text = "  LƯƠNG";
            this.luong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.luong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.luong.UseVisualStyleBackColor = false;
            // 
<<<<<<< Updated upstream
            // bomon
            // 
            this.bomon.BackColor = System.Drawing.Color.CadetBlue;
            this.bomon.FlatAppearance.BorderSize = 0;
            this.bomon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bomon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bomon.ForeColor = System.Drawing.Color.White;
            this.bomon.Image = ((System.Drawing.Image)(resources.GetObject("bomon.Image")));
            this.bomon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bomon.Location = new System.Drawing.Point(4, 206);
            this.bomon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bomon.Name = "bomon";
            this.bomon.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.bomon.Size = new System.Drawing.Size(250, 57);
            this.bomon.TabIndex = 2;
            this.bomon.Text = "  BỘ MÔN";
            this.bomon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bomon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bomon.UseVisualStyleBackColor = false;
            this.bomon.Click += new System.EventHandler(this.bomon_Click);
            // 
            // chunhiem
            // 
            this.chunhiem.BackColor = System.Drawing.Color.CadetBlue;
            this.chunhiem.FlatAppearance.BorderSize = 0;
            this.chunhiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chunhiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chunhiem.ForeColor = System.Drawing.Color.White;
            this.chunhiem.Image = ((System.Drawing.Image)(resources.GetObject("chunhiem.Image")));
            this.chunhiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chunhiem.Location = new System.Drawing.Point(4, 273);
            this.chunhiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chunhiem.Name = "chunhiem";
            this.chunhiem.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.chunhiem.Size = new System.Drawing.Size(250, 57);
            this.chunhiem.TabIndex = 3;
            this.chunhiem.Text = "  CHỦ NHIỆM";
            this.chunhiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chunhiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chunhiem.UseVisualStyleBackColor = false;
            // 
            // menuTransition
            // 
=======
            // menuTransition
            // 
>>>>>>> Stashed changes
            this.menuTransition.Interval = 10;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
<<<<<<< Updated upstream
            this.mainPanel.Location = new System.Drawing.Point(255, 62);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(855, 676);
=======
            this.mainPanel.Location = new System.Drawing.Point(170, 40);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(570, 440);
>>>>>>> Stashed changes
            this.mainPanel.TabIndex = 3;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1110, 738);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel menu;
        private System.Windows.Forms.Button giaovien;
        private System.Windows.Forms.Button chucvu;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button luong;
        private System.Windows.Forms.Button bomon;
        private System.Windows.Forms.Button chunhiem;
    }
}

