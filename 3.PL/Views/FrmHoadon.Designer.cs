﻿namespace _3.PL.Views
{
    partial class FrmHoadon
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
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.dgrid_view = new System.Windows.Forms.DataGridView();
            this.cbx_khachhang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_sanpham = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_nhanvien = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_sdt = new System.Windows.Forms.TextBox();
            this.tbx_diachi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_tennguoinhan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_tensanpham = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbx_ma = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_giamgia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbx_trangthai = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.date_ngaytao = new System.Windows.Forms.DateTimePicker();
            this.date_ngaythanhtoan = new System.Windows.Forms.DateTimePicker();
            this.date_ngaygiao = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_them
            // 
            this.btn_them.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_them.Location = new System.Drawing.Point(1074, 332);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(155, 64);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            this.btn_sua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sua.Location = new System.Drawing.Point(1074, 409);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(155, 64);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_xoa.Location = new System.Drawing.Point(1074, 486);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(155, 64);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_lammoi.Location = new System.Drawing.Point(1074, 563);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(155, 64);
            this.btn_lammoi.TabIndex = 3;
            this.btn_lammoi.Text = "Làm Mới";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            // 
            // dgrid_view
            // 
            this.dgrid_view.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrid_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_view.Location = new System.Drawing.Point(1, 1);
            this.dgrid_view.Name = "dgrid_view";
            this.dgrid_view.RowTemplate.Height = 25;
            this.dgrid_view.Size = new System.Drawing.Size(1240, 325);
            this.dgrid_view.TabIndex = 4;
            // 
            // cbx_khachhang
            // 
            this.cbx_khachhang.FormattingEnabled = true;
            this.cbx_khachhang.Location = new System.Drawing.Point(88, 346);
            this.cbx_khachhang.Name = "cbx_khachhang";
            this.cbx_khachhang.Size = new System.Drawing.Size(166, 23);
            this.cbx_khachhang.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Khách Hàng:";
            // 
            // cbx_sanpham
            // 
            this.cbx_sanpham.FormattingEnabled = true;
            this.cbx_sanpham.Location = new System.Drawing.Point(88, 389);
            this.cbx_sanpham.Name = "cbx_sanpham";
            this.cbx_sanpham.Size = new System.Drawing.Size(166, 23);
            this.cbx_sanpham.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sản Phẩm:";
            // 
            // cbx_nhanvien
            // 
            this.cbx_nhanvien.FormattingEnabled = true;
            this.cbx_nhanvien.Location = new System.Drawing.Point(88, 432);
            this.cbx_nhanvien.Name = "cbx_nhanvien";
            this.cbx_nhanvien.Size = new System.Drawing.Size(166, 23);
            this.cbx_nhanvien.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nhân Viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 561);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "SDT:";
         
            // 
            // tbx_sdt
            // 
            this.tbx_sdt.Location = new System.Drawing.Point(417, 561);
            this.tbx_sdt.Name = "tbx_sdt";
            this.tbx_sdt.Size = new System.Drawing.Size(178, 23);
            this.tbx_sdt.TabIndex = 14;
            // 
            // tbx_diachi
            // 
            this.tbx_diachi.Location = new System.Drawing.Point(417, 506);
            this.tbx_diachi.Name = "tbx_diachi";
            this.tbx_diachi.Size = new System.Drawing.Size(178, 23);
            this.tbx_diachi.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 506);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Địa Chỉ:";
          
            // 
            // tbx_tennguoinhan
            // 
            this.tbx_tennguoinhan.Location = new System.Drawing.Point(417, 451);
            this.tbx_tennguoinhan.Name = "tbx_tennguoinhan";
            this.tbx_tennguoinhan.Size = new System.Drawing.Size(178, 23);
            this.tbx_tennguoinhan.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 451);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tên Người Nhận:";
            // 
            // tbx_tensanpham
            // 
            this.tbx_tensanpham.Location = new System.Drawing.Point(417, 396);
            this.tbx_tensanpham.Name = "tbx_tensanpham";
            this.tbx_tensanpham.Size = new System.Drawing.Size(178, 23);
            this.tbx_tensanpham.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tên Sản Phẩm:";
            // 
            // tbx_ma
            // 
            this.tbx_ma.Location = new System.Drawing.Point(417, 341);
            this.tbx_ma.Name = "tbx_ma";
            this.tbx_ma.Size = new System.Drawing.Size(178, 23);
            this.tbx_ma.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(303, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Mã:";
            // 
            // tbx_giamgia
            // 
            this.tbx_giamgia.Location = new System.Drawing.Point(743, 338);
            this.tbx_giamgia.Name = "tbx_giamgia";
            this.tbx_giamgia.Size = new System.Drawing.Size(278, 23);
            this.tbx_giamgia.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(632, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Giảm Giá:";
            // 
            // tbx_trangthai
            // 
            this.tbx_trangthai.Location = new System.Drawing.Point(743, 393);
            this.tbx_trangthai.Name = "tbx_trangthai";
            this.tbx_trangthai.Size = new System.Drawing.Size(278, 23);
            this.tbx_trangthai.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(632, 397);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "Trạng Thái:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(632, 456);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 15);
            this.label11.TabIndex = 27;
            this.label11.Text = "Ngày Tạo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(632, 503);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 15);
            this.label12.TabIndex = 29;
            this.label12.Text = "Ngày Thanh Toán:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(632, 561);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 15);
            this.label13.TabIndex = 31;
            this.label13.Text = "Ngày Giao:";
            // 
            // date_ngaytao
            // 
            this.date_ngaytao.Location = new System.Drawing.Point(743, 456);
            this.date_ngaytao.Name = "date_ngaytao";
            this.date_ngaytao.Size = new System.Drawing.Size(278, 23);
            this.date_ngaytao.TabIndex = 32;
            // 
            // date_ngaythanhtoan
            // 
            this.date_ngaythanhtoan.Location = new System.Drawing.Point(743, 505);
            this.date_ngaythanhtoan.Name = "date_ngaythanhtoan";
            this.date_ngaythanhtoan.Size = new System.Drawing.Size(278, 23);
            this.date_ngaythanhtoan.TabIndex = 33;
            // 
            // date_ngaygiao
            // 
            this.date_ngaygiao.Location = new System.Drawing.Point(743, 558);
            this.date_ngaygiao.Name = "date_ngaygiao";
            this.date_ngaygiao.Size = new System.Drawing.Size(278, 23);
            this.date_ngaygiao.TabIndex = 34;
            // 
            // FrmHoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 635);
            this.Controls.Add(this.date_ngaygiao);
            this.Controls.Add(this.date_ngaythanhtoan);
            this.Controls.Add(this.date_ngaytao);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbx_trangthai);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbx_giamgia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbx_ma);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbx_tensanpham);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbx_tennguoinhan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbx_diachi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbx_sdt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbx_nhanvien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbx_sanpham);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_khachhang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgrid_view);
            this.Controls.Add(this.btn_lammoi);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Name = "FrmHoadon";
            this.Text = "FrmHoadon";
            
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.DataGridView dgrid_view;
        private System.Windows.Forms.ComboBox cbx_khachhang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_sanpham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_nhanvien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_sdt;
        private System.Windows.Forms.TextBox tbx_diachi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_tennguoinhan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_tensanpham;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbx_ma;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbx_giamgia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbx_trangthai;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker date_ngaytao;
        private System.Windows.Forms.DateTimePicker date_ngaythanhtoan;
        private System.Windows.Forms.DateTimePicker date_ngaygiao;
    }
}