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
    public partial class Form2 : Form
    {
        private QLSP QLSPInstance = new QLSP();
        string Masanpham;
        public delegate void MyDel(string Name);
        public MyDel d;
        public void FillNhasanxuat(string Tenmathang)
        {
            cbboxNhasanxuat.Items.Clear();
            foreach (string s in QLSPInstance.GetNhasanxuat(Tenmathang))
            {
                cbboxNhasanxuat.Items.Add(s);
            }
        }
        public Form2(string a = "")
        {
            InitializeComponent();
            QLSP QLSPInstance = new QLSP();
            foreach (string Tenmathang in QLSPInstance.Getmathang())
            {
                cbboxMathang.Items.Add(Tenmathang);
            }
            Masanpham = a;
            if (Masanpham != "")
            {
                textMasanpham.Enabled = false;
                SP s = QLSPInstance.GetSanpham(Masanpham);
                textMasanpham.Text = s.Masanpham;
                textTensanpham.Text = s.Tensanpham;
                dateTimePicker2.Value = s.Ngaynhap;
                cbboxMathang.SelectedItem = s.Tenmathang;
                FillNhasanxuat(s.Tensanpham);
                cbboxNhasanxuat.SelectedItem = s.Nhasanxuat;
                bool Tinhtrang = s.Tinhtrang;
                if (Tinhtrang) radioButton1.Checked = true;
                else radioButton2.Checked = false;
            }
        }
        private void OKButton_Click(object sender, EventArgs e)
        {
            bool Tinhtrang;
            if (radioButton1.Checked) Tinhtrang = true;
            else Tinhtrang = false;
            SP s = new SP(textMasanpham.Text, textTensanpham.Text,dateTimePicker2.Value.ToString(), cbbNhasanxuat.SelectedItem.ToString(), Tinhtrang.ToString(), cbbMathang.SelectedItem.ToString());
            if (Masanpham == "") QLSPInstance.AddRow(s);
            else QLSPInstance.UpdateRow(s);
            d("");
            this.Close();
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void cbboxMathang_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillNhasanxuat(cbboxMathang.SelectedItem.ToString());
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
    }
}