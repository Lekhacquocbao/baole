using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiSieuThi
{
    public class DBSP
    {
        private static DBSP _Instance;
        public static DBSP Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DBSP();
                }
                return _Instance;
            }
            private set { }
        }
        public DataTable DTSP;
        private int Sosanpham;
        private int Deleted;
        private DBSP()
        {
            DTSP = new DataTable();
            DTSP.Columns.AddRange(new DataColumn[]
            {
                new DataColumn { ColumnName = "Masanpham", DataType = typeof(string) },
                new DataColumn { ColumnName = "Tensanpham", DataType = typeof(string) },
                new DataColumn { ColumnName = "NN", DataType = typeof(DateTime) },
                new DataColumn { ColumnName = "NSS", DataType = typeof(string) },
                new DataColumn { ColumnName = "TT", DataType = typeof(bool) },
                new DataColumn { ColumnName = "TMH", DataType = typeof(string) }
            }
            );
            DTSP.Rows.Add("A", "Laptop", DateTime.Now, "VietNam", 1, "Asus");
            DTSP.Rows.Add("B", "PC", DateTime.Now, "NhatBan", 2, "Lenovo");
            Deleted = 0;
            Sosanpham = 2;
        }
        public void AddDTSP(SP s)
        {
            DTSP.Rows.Add(s.Masanpham, s.Tensanpham, s.Ngaynhap, s.Nhasanxuat, s.Tinhtrang, s.Tenmathang);
        }
        public void UpdateDTSP(SP s)
        {
            DTSP.Rows.Find(s.Masanpham).SetField("Masanpham", s.Tensanpham);
            DTSP.Rows.Find(s.Masanpham).SetField("NN", s.Ngaynhap);
            DTSP.Rows.Find(s.Masanpham).SetField("NSS", s.Nhasanxuat);
            DTSP.Rows.Find(s.Masanpham).SetField("TT", s.Tinhtrang);
            DTSP.Rows.Find(s.Masanpham).SetField("TMH", s.Tenmathang);
        }
        public void AddRow(SP s)
        {
            Sosanpham++;
            DTSP.Rows.Add(Convert.ToInt32(Sosanpham), s.Masanpham, s.Tensanpham, s.Ngaynhap, s.Nhasanxuat, s.Tinhtrang, s.Tenmathang);
        }
        public void UpdateRow(SP s)
        {
            foreach (DataRow dr in DTSP.Rows)
            {
                if (dr["Masanpham"].ToString() == s.Masanpham)
                {
                    dr["Tensanpham"] = s.Tensanpham;
                    dr["Ngaynhap"] = s.Ngaynhap;
                    dr["Nhasanxuat"] = s.Nhasanxuat;
                    dr["Tinhtrang"] = s.Tinhtrang;
                    dr["Tenmathang"] = s.Tenmathang;
                }
            }
        }
        public void UpdateSTT()
        {
            if (Deleted == 0) return;
            for (int i = 0; i < DTSP.Rows.Count; i++)
            {
                DataRow dr = DTSP.Rows[i];
                dr["STT"] = (i + 1).ToString();
            }
            Deleted = 0;
        }
        public void DelRow(string Masanpham)
        {
            Sosanpham--;
            Deleted = 1;
            for (int i = DTSP.Rows.Count - 1; i >= 0; i--)
            {
                DataRow dr = DTSP.Rows[i];
                if (dr["Masanpham"].ToString() == Masanpham)
                    dr.Delete();
            }
            DTSP.AcceptChanges();
        }
        public static DataTable Get()
        {
            DBSP.Instance.UpdateSTT();
            return DBSP.Instance.DTSP;
        }
    }
}
