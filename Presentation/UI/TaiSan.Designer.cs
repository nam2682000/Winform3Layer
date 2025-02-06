namespace Presentation
{
    partial class TaiSan
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
            this.userName = new System.Windows.Forms.Label();
            this.txtTenTaiSan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKyHieuil = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbChiNhanhQL = new System.Windows.Forms.ComboBox();
            this.numSoNamSD = new System.Windows.Forms.NumericUpDown();
            this.numNamSD = new System.Windows.Forms.NumericUpDown();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.cbTinhTrang = new System.Windows.Forms.ComboBox();
            this.txtViTri = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtChiNhanhTT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtSoMay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHangSX = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.viewTaiSan = new System.Windows.Forms.DataGridView();
            this.cbFillterTinhTrang = new System.Windows.Forms.ComboBox();
            this.cbFillterChiNhanh = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNamSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNamSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTaiSan)).BeginInit();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.userName.Location = new System.Drawing.Point(11, 24);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(79, 17);
            this.userName.TabIndex = 0;
            this.userName.Text = "Tên tài sản";
            // 
            // txtTenTaiSan
            // 
            this.txtTenTaiSan.Location = new System.Drawing.Point(119, 23);
            this.txtTenTaiSan.Name = "txtTenTaiSan";
            this.txtTenTaiSan.Size = new System.Drawing.Size(165, 20);
            this.txtTenTaiSan.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(582, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tài sản";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtKyHieuil
            // 
            this.txtKyHieuil.Location = new System.Drawing.Point(119, 63);
            this.txtKyHieuil.Name = "txtKyHieuil";
            this.txtKyHieuil.Size = new System.Drawing.Size(165, 20);
            this.txtKyHieuil.TabIndex = 4;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.email.Location = new System.Drawing.Point(11, 64);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(51, 17);
            this.email.TabIndex = 3;
            this.email.Text = "Kí hiệu";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAdd.Location = new System.Drawing.Point(15, 461);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 31);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbChiNhanhQL);
            this.panel1.Controls.Add(this.numSoNamSD);
            this.panel1.Controls.Add(this.numNamSD);
            this.panel1.Controls.Add(this.cbTrangThai);
            this.panel1.Controls.Add(this.cbTinhTrang);
            this.panel1.Controls.Add(this.txtViTri);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtChiNhanhTT);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.txtSoMay);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtHangSX);
            this.panel1.Controls.Add(this.lb1);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtKyHieuil);
            this.panel1.Controls.Add(this.txtTenTaiSan);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.userName);
            this.panel1.Location = new System.Drawing.Point(12, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 512);
            this.panel1.TabIndex = 6;
            // 
            // cbChiNhanhQL
            // 
            this.cbChiNhanhQL.FormattingEnabled = true;
            this.cbChiNhanhQL.Location = new System.Drawing.Point(119, 345);
            this.cbChiNhanhQL.Name = "cbChiNhanhQL";
            this.cbChiNhanhQL.Size = new System.Drawing.Size(165, 21);
            this.cbChiNhanhQL.TabIndex = 30;
            // 
            // numSoNamSD
            // 
            this.numSoNamSD.Location = new System.Drawing.Point(119, 227);
            this.numSoNamSD.Name = "numSoNamSD";
            this.numSoNamSD.Size = new System.Drawing.Size(165, 20);
            this.numSoNamSD.TabIndex = 29;
            // 
            // numNamSD
            // 
            this.numNamSD.Location = new System.Drawing.Point(119, 187);
            this.numNamSD.Name = "numNamSD";
            this.numNamSD.Size = new System.Drawing.Size(165, 20);
            this.numNamSD.TabIndex = 28;
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Location = new System.Drawing.Point(119, 304);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(165, 21);
            this.cbTrangThai.TabIndex = 27;
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.FormattingEnabled = true;
            this.cbTinhTrang.Location = new System.Drawing.Point(119, 264);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Size = new System.Drawing.Size(165, 21);
            this.cbTinhTrang.TabIndex = 26;
            // 
            // txtViTri
            // 
            this.txtViTri.Location = new System.Drawing.Point(119, 423);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(165, 20);
            this.txtViTri.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(12, 425);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Vị trí";
            // 
            // txtChiNhanhTT
            // 
            this.txtChiNhanhTT.Location = new System.Drawing.Point(119, 384);
            this.txtChiNhanhTT.Name = "txtChiNhanhTT";
            this.txtChiNhanhTT.Size = new System.Drawing.Size(165, 20);
            this.txtChiNhanhTT.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(12, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Chi Nhánh TT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(12, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Chi Nhánh QL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(12, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Trạng thái";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(12, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tình trạng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(12, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Số năm SD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(12, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Năm SD";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDelete.Location = new System.Drawing.Point(208, 461);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 31);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnUpdate.Location = new System.Drawing.Point(109, 461);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(76, 31);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtSoMay
            // 
            this.txtSoMay.Location = new System.Drawing.Point(119, 105);
            this.txtSoMay.Name = "txtSoMay";
            this.txtSoMay.Size = new System.Drawing.Size(165, 20);
            this.txtSoMay.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(11, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Số máy";
            // 
            // txtHangSX
            // 
            this.txtHangSX.Location = new System.Drawing.Point(119, 146);
            this.txtHangSX.Name = "txtHangSX";
            this.txtHangSX.Size = new System.Drawing.Size(165, 20);
            this.txtHangSX.TabIndex = 7;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb1.Location = new System.Drawing.Point(11, 147);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(64, 17);
            this.lb1.TabIndex = 6;
            this.lb1.Text = "Hãng SX";
            // 
            // viewTaiSan
            // 
            this.viewTaiSan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewTaiSan.Location = new System.Drawing.Point(317, 109);
            this.viewTaiSan.Name = "viewTaiSan";
            this.viewTaiSan.Size = new System.Drawing.Size(835, 512);
            this.viewTaiSan.TabIndex = 8;
            this.viewTaiSan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewTaiSan_CellClick);
            this.viewTaiSan.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.viewTaiSan_RowPostPaint);
            // 
            // cbFillterTinhTrang
            // 
            this.cbFillterTinhTrang.FormattingEnabled = true;
            this.cbFillterTinhTrang.Location = new System.Drawing.Point(769, 82);
            this.cbFillterTinhTrang.Name = "cbFillterTinhTrang";
            this.cbFillterTinhTrang.Size = new System.Drawing.Size(95, 21);
            this.cbFillterTinhTrang.TabIndex = 28;
            // 
            // cbFillterChiNhanh
            // 
            this.cbFillterChiNhanh.FormattingEnabled = true;
            this.cbFillterChiNhanh.Location = new System.Drawing.Point(870, 82);
            this.cbFillterChiNhanh.Name = "cbFillterChiNhanh";
            this.cbFillterChiNhanh.Size = new System.Drawing.Size(95, 21);
            this.cbFillterChiNhanh.TabIndex = 31;
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnFilter.Location = new System.Drawing.Point(976, 76);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(85, 28);
            this.btnFilter.TabIndex = 32;
            this.btnFilter.Text = "Lọc";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBaoCao.Location = new System.Drawing.Point(1067, 76);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(85, 28);
            this.btnBaoCao.TabIndex = 33;
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(766, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 34;
            this.label10.Text = "Trạng thái";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(867, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 17);
            this.label11.TabIndex = 35;
            this.label11.Text = "Chi nhánh QL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 629);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cbFillterChiNhanh);
            this.Controls.Add(this.cbFillterTinhTrang);
            this.Controls.Add(this.viewTaiSan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNamSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNamSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTaiSan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.TextBox txtTenTaiSan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKyHieuil;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtHangSX;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox txtSoMay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView viewTaiSan;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtViTri;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtChiNhanhTT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.ComboBox cbTinhTrang;
        private System.Windows.Forms.ComboBox cbChiNhanhQL;
        private System.Windows.Forms.NumericUpDown numSoNamSD;
        private System.Windows.Forms.NumericUpDown numNamSD;
        private System.Windows.Forms.ComboBox cbFillterTinhTrang;
        private System.Windows.Forms.ComboBox cbFillterChiNhanh;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

