﻿namespace _3.PL.Views
{
    partial class Frm_MauSac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MauSac));
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dgrd_mausac = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtn_kohd = new System.Windows.Forms.RadioButton();
            this.rbtn_hd = new System.Windows.Forms.RadioButton();
            this.tbx_ten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_ma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tk_timkiem = new System.Windows.Forms.TextBox();
            this.btn_seachbyma = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrd_mausac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_seachbyma)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.Location = new System.Drawing.Point(209, 269);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(132, 61);
            this.btn_clear.TabIndex = 41;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click_1);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_xoa.Location = new System.Drawing.Point(58, 268);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(132, 61);
            this.btn_xoa.TabIndex = 40;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click_1);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sua.Location = new System.Drawing.Point(209, 182);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(132, 61);
            this.btn_sua.TabIndex = 39;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click_1);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_them.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_them.Location = new System.Drawing.Point(58, 183);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(132, 61);
            this.btn_them.TabIndex = 38;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click_1);
            // 
            // dgrd_mausac
            // 
            this.dgrd_mausac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrd_mausac.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgrd_mausac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrd_mausac.Location = new System.Drawing.Point(23, 60);
            this.dgrd_mausac.Name = "dgrd_mausac";
            this.dgrd_mausac.RowHeadersWidth = 51;
            this.dgrd_mausac.RowTemplate.Height = 25;
            this.dgrd_mausac.Size = new System.Drawing.Size(620, 260);
            this.dgrd_mausac.TabIndex = 37;
            this.dgrd_mausac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrd_mausac_CellClick_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(60, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Trạng thái";
            // 
            // rbtn_kohd
            // 
            this.rbtn_kohd.AutoSize = true;
            this.rbtn_kohd.Location = new System.Drawing.Point(223, 160);
            this.rbtn_kohd.Name = "rbtn_kohd";
            this.rbtn_kohd.Size = new System.Drawing.Size(118, 19);
            this.rbtn_kohd.TabIndex = 35;
            this.rbtn_kohd.TabStop = true;
            this.rbtn_kohd.Text = "Không hoạt động";
            this.rbtn_kohd.UseVisualStyleBackColor = true;
            // 
            // rbtn_hd
            // 
            this.rbtn_hd.AutoSize = true;
            this.rbtn_hd.Location = new System.Drawing.Point(135, 160);
            this.rbtn_hd.Name = "rbtn_hd";
            this.rbtn_hd.Size = new System.Drawing.Size(82, 19);
            this.rbtn_hd.TabIndex = 34;
            this.rbtn_hd.TabStop = true;
            this.rbtn_hd.Text = "Hoạt động";
            this.rbtn_hd.UseVisualStyleBackColor = true;
            this.rbtn_hd.CheckedChanged += new System.EventHandler(this.rbtn_hd_CheckedChanged);
            // 
            // tbx_ten
            // 
            this.tbx_ten.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbx_ten.Location = new System.Drawing.Point(125, 106);
            this.tbx_ten.Name = "tbx_ten";
            this.tbx_ten.Size = new System.Drawing.Size(216, 25);
            this.tbx_ten.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(58, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tên";
            // 
            // tbx_ma
            // 
            this.tbx_ma.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbx_ma.Location = new System.Drawing.Point(125, 51);
            this.tbx_ma.Name = "tbx_ma";
            this.tbx_ma.Size = new System.Drawing.Size(216, 25);
            this.tbx_ma.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(60, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Mã";
            // 
            // tk_timkiem
            // 
            this.tk_timkiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tk_timkiem.Location = new System.Drawing.Point(23, 25);
            this.tk_timkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tk_timkiem.Multiline = true;
            this.tk_timkiem.Name = "tk_timkiem";
            this.tk_timkiem.PlaceholderText = "   Nhập dữ liệu cần tìm";
            this.tk_timkiem.Size = new System.Drawing.Size(239, 23);
            this.tk_timkiem.TabIndex = 54;
            this.tk_timkiem.TextChanged += new System.EventHandler(this.tk_timkiem_TextChanged);
            // 
            // btn_seachbyma
            // 
            this.btn_seachbyma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_seachbyma.Image = ((System.Drawing.Image)(resources.GetObject("btn_seachbyma.Image")));
            this.btn_seachbyma.Location = new System.Drawing.Point(268, 22);
            this.btn_seachbyma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_seachbyma.Name = "btn_seachbyma";
            this.btn_seachbyma.Size = new System.Drawing.Size(31, 28);
            this.btn_seachbyma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_seachbyma.TabIndex = 55;
            this.btn_seachbyma.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_ma);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbx_ten);
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.rbtn_hd);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.rbtn_kohd);
            this.groupBox1.Location = new System.Drawing.Point(684, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(381, 334);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgrd_mausac);
            this.groupBox2.Controls.Add(this.tk_timkiem);
            this.groupBox2.Controls.Add(this.btn_seachbyma);
            this.groupBox2.Location = new System.Drawing.Point(10, 25);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(668, 334);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // Frm_MauSac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 387);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_MauSac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_MauSac";
            this.Load += new System.EventHandler(this.Frm_MauSac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrd_mausac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_seachbyma)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dgrd_mausac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtn_kohd;
        private System.Windows.Forms.RadioButton rbtn_hd;
        private System.Windows.Forms.TextBox tbx_ten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_ma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tk_timkiem;
        private System.Windows.Forms.PictureBox btn_seachbyma;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}