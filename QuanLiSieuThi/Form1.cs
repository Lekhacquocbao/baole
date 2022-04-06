using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSieuThi
{
    public partial class Form1 : Form
    {
        private QLSP QLSPInstance = new QLSP();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
            cbboxSort.Items.Add("Masanpham");
            cbboxSort.Items.Add("Tensanpham");
            cbboxSort.Items.Add("Ngaynhap");
            Reload("");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
                {
                    QLSPInstance.DelRow(dr.Cells[1].Value.ToString());
                }
            }
            Reload();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }

        }

        private void btName_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btSort_Click(object sender, EventArgs e)
        {
            List<SP> data = QLSPInstance.Sort(cbboxSort.SelectedItem.ToString());
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("STT",typeof(string)),
                new DataColumn("Mã sản phẩm",typeof(string)),
                new DataColumn("Tên sản phẩm",typeof(string)),
                new DataColumn("Nhà sản xuất",typeof(string)),
                new DataColumn("Ngày nhập",typeof(DateTime)),
                new DataColumn("Tên Mặt hàng",typeof(string)),
                new DataColumn("Tình trạng",typeof(bool)),
            }
            );
            int i = 0;
            foreach (SP s in data)
            {
                i++;
                dt.Rows.Add(i.ToString(), s.Masanpham, s.Tensanpham, s.Nhasanxuat, s.Ngaynhap, s.Tenmathang, s.Tinhtrang);
            }
            dataGridView1.DataSource = dt;
        }
        public void Reload(string name = "")
        {
            List<SP> data;
            if (name == "") data = QLSPInstance.GetAllSP();
            else data = QLSPInstance.GetSPByName(name);
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("STT",typeof(string)),
                new DataColumn("Mã sản phẩm",typeof(string)),
                new DataColumn("Tên sản phẩm",typeof(string)),
                new DataColumn("Nhà sản xuất",typeof(string)),
                new DataColumn("Ngày nhập",typeof(DateTime)),
                new DataColumn("Tên Mặt hàng",typeof(string)),
                new DataColumn("Tình trạng",typeof(bool)),
            });
            int i = 0;
            foreach(SP s in data)
            {
                i++;
                dt.Rows.Add(i.ToString(), s.Masanpham, s.Tensanpham, s.Nhasanxuat, s.Ngaynhap, s.Tenmathang, s.Tinhtrang);
            }
            dataGridView1.DataSource = dt;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            Reload(textSearch.Text);
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Form2 f = new Form2(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                f.d = Reload;
                f.Show();
            }
        }
    }
}
