using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDoanhThu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Modify modify = new Modify();
        QuanLy Ql;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = modify.Table("Select * from CLB");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi!!!" + ex.Message);
            }
            DeleteTxtBoxes();
        }
        //add vao data sql
        //hien thi len bang 
        //hien gia ve va ten tuoc khi nhap clb


        private void comboBoxCLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCLB.SelectedIndex == 0)
            {
                txtGiaVe.Text = "10";
                txtTenNuoc.Text = "England";
            }
            if (comboBoxCLB.SelectedIndex == 1)
            {
                txtGiaVe.Text = "15";
                txtTenNuoc.Text = "Spain";
            }
            if (comboBoxCLB.SelectedIndex == 2)
            {
                txtGiaVe.Text = "12";
                txtTenNuoc.Text = "England";
            }
            if (comboBoxCLB.SelectedIndex == 3)
            {
                txtGiaVe.Text = "15";
                txtTenNuoc.Text = "Italia";
            }
            if (comboBoxCLB.SelectedIndex == 4)
            {
                txtGiaVe.Text = "11";
                txtTenNuoc.Text = "Italia";
            }
            if (comboBoxCLB.SelectedIndex == 5)
            {
                txtGiaVe.Text = "15";
                txtTenNuoc.Text = "Spain";
            }
        }

        private void txtSLVe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void DeleteTxtBoxes()
        {
            comboBoxCLB.SelectedIndex = -1;
            txtGiaVe.Text = "";
            txtSLVe.Text = "";
            txtTenNuoc.Text = "";
        }

        private bool Checker()
        {
            if (comboBoxCLB.SelectedIndex == -1)
            {
                MessageBox.Show("Moi ban nhap CLB");
                return false;
            }

            if (txtSLVe.Text == "")
            {
                MessageBox.Show("Moi ban nhap so luong ve");
                return false;
            }
            return true;
        }

        private void GetValuetextBox()
        {
            string _tenCLB = comboBoxCLB.Text;
            string _tenNuoc = txtTenNuoc.Text;
            int _SLVe = int.Parse(txtSLVe.Text);
            double _GiaVe = double.Parse(txtGiaVe.Text);
            Ql = new QuanLy(_tenCLB, _tenNuoc, _SLVe, _GiaVe);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (Checker())
            {
                GetValuetextBox();
                string query = "INSERT INTO CLB VALUES ('" + Ql.TenCLB + "', N' " + Ql.TenNuoc + "'," + Ql.SLVe + "," + Ql.GiaVe + "," + Ql.DoanhTHU() + ")";
                try
                {
                    modify.Command(query);
                    MessageBox.Show("Them thanh cong");
                    Form1_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi!!!" + ex.Message);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (Checker())
            {
                GetValuetextBox();
                string query = "UPDATE CLB SET TenNuoc = N'" + Ql.TenNuoc + "',SoLuongVe = " + Ql.SLVe + ",GiaVe = " + Ql.GiaVe + ",TongTien = " + Ql.DoanhTHU() + " ";
                query += " WHERE TenCauLacBo = '" + Ql.TenCLB + "'";
                try
                {
                    modify.Command(query);
                    MessageBox.Show("Sua thanh cong");
                    Form1_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi!!!" + ex.Message);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                comboBoxCLB.SelectedItem = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtGiaVe.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtSLVe.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtTenNuoc.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                string choose = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string query = "DELETE CLB ";
                query += "WHERE TenCauLacBo = '" + choose + "'";
                try
                {
                    modify.Command(query);
                    MessageBox.Show("Xoa thanh cong");
                    Form1_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi!!!" + ex.Message);
                }
            }
        }

        private void txtTiemKiem_TextChanged(object sender, EventArgs e)
        {
            string name = txtTiemKiem.Text.Trim();
            if (txtTiemKiem.Text == "")
            {
                Form1_Load(sender, e);
            }
            else
            {
                string query = "Select * from CLB Where TenCauLacBo like '%" + name + "%'";
                dataGridView1.DataSource = modify.Table(query);
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
