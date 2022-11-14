
namespace _3.PL.Views
{
    partial class FrmHoaDonChiTiet
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
            this.dgrid_hoaDonCT = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_hoaDonCT)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrid_hoaDonCT
            // 
            this.dgrid_hoaDonCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_hoaDonCT.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgrid_hoaDonCT.Location = new System.Drawing.Point(0, 0);
            this.dgrid_hoaDonCT.Name = "dgrid_hoaDonCT";
            this.dgrid_hoaDonCT.RowTemplate.Height = 25;
            this.dgrid_hoaDonCT.Size = new System.Drawing.Size(1020, 269);
            this.dgrid_hoaDonCT.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 297);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "label1";
            // 
            // FrmHoaDonChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 566);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgrid_hoaDonCT);
            this.Name = "FrmHoaDonChiTiet";
            this.Text = "FrmHoaDonChiTiet";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_hoaDonCT)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrid_hoaDonCT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}