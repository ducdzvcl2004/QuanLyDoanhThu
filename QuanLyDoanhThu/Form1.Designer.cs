namespace QuanLyDoanhThu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            txtSLVe = new TextBox();
            txtTenNuoc = new TextBox();
            txtGiaVe = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            comboBoxCLB = new ComboBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            txtTiemKiem = new TextBox();
            label6 = new Label();
            BtnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(196, 9);
            label1.Name = "label1";
            label1.Size = new Size(262, 38);
            label1.TabIndex = 0;
            label1.Text = "Quản lý doanh thu";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 195);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(506, 355);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtSLVe);
            groupBox1.Controls.Add(txtTenNuoc);
            groupBox1.Controls.Add(txtGiaVe);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBoxCLB);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(588, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(338, 474);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSua.Location = new Point(120, 392);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.Location = new Point(238, 392);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThem.Location = new Point(6, 392);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtSLVe
            // 
            txtSLVe.Location = new Point(120, 289);
            txtSLVe.Name = "txtSLVe";
            txtSLVe.Size = new Size(125, 27);
            txtSLVe.TabIndex = 7;
            txtSLVe.TabStop = false;
            txtSLVe.KeyPress += txtSLVe_KeyPress;
            // 
            // txtTenNuoc
            // 
            txtTenNuoc.Location = new Point(120, 210);
            txtTenNuoc.Name = "txtTenNuoc";
            txtTenNuoc.ReadOnly = true;
            txtTenNuoc.Size = new Size(166, 27);
            txtTenNuoc.TabIndex = 6;
            // 
            // txtGiaVe
            // 
            txtGiaVe.Location = new Point(120, 141);
            txtGiaVe.Name = "txtGiaVe";
            txtGiaVe.ReadOnly = true;
            txtGiaVe.Size = new Size(118, 27);
            txtGiaVe.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(25, 289);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 4;
            label5.Text = "Số lượng vé:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(25, 210);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 3;
            label4.Text = "Tên nước:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(25, 144);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 2;
            label3.Text = "Giá vé:";
            // 
            // comboBoxCLB
            // 
            comboBoxCLB.FormattingEnabled = true;
            comboBoxCLB.Items.AddRange(new object[] { "MU", "BARCA", "MC", "ACMILAN", "INTER MILAN", "REAL" });
            comboBoxCLB.Location = new Point(120, 69);
            comboBoxCLB.Name = "comboBoxCLB";
            comboBoxCLB.Size = new Size(166, 28);
            comboBoxCLB.TabIndex = 1;
            comboBoxCLB.SelectedIndexChanged += comboBoxCLB_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(25, 77);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 0;
            label2.Text = "Tên CLB:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTiemKiem);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(29, 76);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(489, 80);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // txtTiemKiem
            // 
            txtTiemKiem.Location = new Point(147, 36);
            txtTiemKiem.Name = "txtTiemKiem";
            txtTiemKiem.Size = new Size(202, 27);
            txtTiemKiem.TabIndex = 6;
            txtTiemKiem.TextChanged += txtTiemKiem_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 0, 64);
            label6.Location = new Point(52, 36);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 5;
            label6.Text = "Tên CLB:";
            // 
            // BtnThoat
            // 
            BtnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnThoat.Location = new Point(807, 18);
            BtnThoat.Name = "BtnThoat";
            BtnThoat.Size = new Size(94, 29);
            BtnThoat.TabIndex = 12;
            BtnThoat.Text = "Thoát";
            BtnThoat.UseVisualStyleBackColor = true;
            BtnThoat.Click += BtnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 609);
            Controls.Add(BtnThoat);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox comboBoxCLB;
        private Label label2;
        private GroupBox groupBox2;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txtSLVe;
        private TextBox txtTenNuoc;
        private TextBox txtGiaVe;
        private TextBox txtTiemKiem;
        private Button BtnThoat;
    }
}
