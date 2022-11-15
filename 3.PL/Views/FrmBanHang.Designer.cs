namespace _3.PL.Views
{
    partial class FrmBanHang
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
            this.groupBox_dsSp = new System.Windows.Forms.GroupBox();
            this.dgrid_DsSanPham = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgrid_dsHoaDon = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_tenKhachHang = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_diaChi = new System.Windows.Forms.TextBox();
            this.txt_tongTien = new System.Windows.Forms.TextBox();
            this.txt_tienKhachTra = new System.Windows.Forms.TextBox();
            this.txt_tienThua = new System.Windows.Forms.TextBox();
            this.cb_daThanhToan = new System.Windows.Forms.CheckBox();
            this.cb_chuaThanhToan = new System.Windows.Forms.CheckBox();
            this.groupBox_dsSp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_DsSanPham)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_dsHoaDon)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_dsSp
            // 
            this.groupBox_dsSp.Controls.Add(this.dgrid_DsSanPham);
            this.groupBox_dsSp.Controls.Add(this.groupBox2);
            this.groupBox_dsSp.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox_dsSp.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox_dsSp.Location = new System.Drawing.Point(0, 0);
            this.groupBox_dsSp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_dsSp.Name = "groupBox_dsSp";
            this.groupBox_dsSp.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_dsSp.Size = new System.Drawing.Size(717, 475);
            this.groupBox_dsSp.TabIndex = 8;
            this.groupBox_dsSp.TabStop = false;
            this.groupBox_dsSp.Text = "Danh sách sản phẩm";
            // 
            // dgrid_DsSanPham
            // 
            this.dgrid_DsSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_DsSanPham.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgrid_DsSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_DsSanPham.Location = new System.Drawing.Point(5, 20);
            this.dgrid_DsSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgrid_DsSanPham.Name = "dgrid_DsSanPham";
            this.dgrid_DsSanPham.RowHeadersWidth = 51;
            this.dgrid_DsSanPham.RowTemplate.Height = 29;
            this.dgrid_DsSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_DsSanPham.Size = new System.Drawing.Size(682, 130);
            this.dgrid_DsSanPham.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgrid_dsHoaDon);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(6, 154);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(712, 306);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hóa đơn";
            // 
            // dgrid_dsHoaDon
            // 
            this.dgrid_dsHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_dsHoaDon.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgrid_dsHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_dsHoaDon.Location = new System.Drawing.Point(0, 20);
            this.dgrid_dsHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgrid_dsHoaDon.Name = "dgrid_dsHoaDon";
            this.dgrid_dsHoaDon.RowHeadersWidth = 51;
            this.dgrid_dsHoaDon.RowTemplate.Height = 29;
            this.dgrid_dsHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.dgrid_dsHoaDon.Size = new System.Drawing.Size(681, 188);
            this.dgrid_dsHoaDon.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_chuaThanhToan);
            this.groupBox3.Controls.Add(this.cb_daThanhToan);
            this.groupBox3.Controls.Add(this.txt_tienThua);
            this.groupBox3.Controls.Add(this.txt_tienKhachTra);
            this.groupBox3.Controls.Add(this.txt_tongTien);
            this.groupBox3.Controls.Add(this.txt_diaChi);
            this.groupBox3.Controls.Add(this.txt_sdt);
            this.groupBox3.Controls.Add(this.txt_tenKhachHang);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(724, 13);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(405, 451);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thanh toán";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Image = global::_3.PL.Properties.Resources.icons8_shopping_cart_321;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(79, 401);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thanh toán";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Trạng thái";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tiền khách hàng trả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số điện thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khách hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tiền thừa";
            // 
            // txt_tenKhachHang
            // 
            this.txt_tenKhachHang.Location = new System.Drawing.Point(147, 52);
            this.txt_tenKhachHang.Name = "txt_tenKhachHang";
            this.txt_tenKhachHang.Size = new System.Drawing.Size(252, 23);
            this.txt_tenKhachHang.TabIndex = 2;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(147, 78);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(252, 23);
            this.txt_sdt.TabIndex = 2;
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.Location = new System.Drawing.Point(147, 104);
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Size = new System.Drawing.Size(252, 23);
            this.txt_diaChi.TabIndex = 2;
            // 
            // txt_tongTien
            // 
            this.txt_tongTien.Location = new System.Drawing.Point(147, 158);
            this.txt_tongTien.Name = "txt_tongTien";
            this.txt_tongTien.Size = new System.Drawing.Size(252, 23);
            this.txt_tongTien.TabIndex = 2;
            // 
            // txt_tienKhachTra
            // 
            this.txt_tienKhachTra.Location = new System.Drawing.Point(147, 187);
            this.txt_tienKhachTra.Name = "txt_tienKhachTra";
            this.txt_tienKhachTra.Size = new System.Drawing.Size(252, 23);
            this.txt_tienKhachTra.TabIndex = 2;
            // 
            // txt_tienThua
            // 
            this.txt_tienThua.Location = new System.Drawing.Point(147, 214);
            this.txt_tienThua.Name = "txt_tienThua";
            this.txt_tienThua.Size = new System.Drawing.Size(252, 23);
            this.txt_tienThua.TabIndex = 2;
            // 
            // cb_daThanhToan
            // 
            this.cb_daThanhToan.AutoSize = true;
            this.cb_daThanhToan.Location = new System.Drawing.Point(147, 134);
            this.cb_daThanhToan.Name = "cb_daThanhToan";
            this.cb_daThanhToan.Size = new System.Drawing.Size(102, 19);
            this.cb_daThanhToan.TabIndex = 3;
            this.cb_daThanhToan.Text = "Đã thanh toán";
            this.cb_daThanhToan.UseVisualStyleBackColor = true;
            // 
            // cb_chuaThanhToan
            // 
            this.cb_chuaThanhToan.AutoSize = true;
            this.cb_chuaThanhToan.Location = new System.Drawing.Point(253, 134);
            this.cb_chuaThanhToan.Name = "cb_chuaThanhToan";
            this.cb_chuaThanhToan.Size = new System.Drawing.Size(114, 19);
            this.cb_chuaThanhToan.TabIndex = 3;
            this.cb_chuaThanhToan.Text = "Chưa thanh toán";
            this.cb_chuaThanhToan.UseVisualStyleBackColor = true;
            // 
            // FrmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 475);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox_dsSp);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmBanHang";
            this.Text = "FrmBanHang";
            this.groupBox_dsSp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_DsSanPham)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_dsHoaDon)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_dsSp;
        private System.Windows.Forms.DataGridView dgrid_DsSanPham;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgrid_dsHoaDon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cb_chuaThanhToan;
        private System.Windows.Forms.CheckBox cb_daThanhToan;
        private System.Windows.Forms.TextBox txt_tienThua;
        private System.Windows.Forms.TextBox txt_tienKhachTra;
        private System.Windows.Forms.TextBox txt_tongTien;
        private System.Windows.Forms.TextBox txt_diaChi;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_tenKhachHang;
        private System.Windows.Forms.Label label7;
    }
}