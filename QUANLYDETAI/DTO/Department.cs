using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYDETAI.DTO
{
    public class Department
    {
        private string maKhoa;
        private string tenKhoa;
        private int namTL;
        private string phong;
        private string dienThoai;
        private string truongKhoa;

        public Department(DataRow row)
        {
            this.maKhoa = row["maKhoa"].ToString();
            this.tenKhoa = row["tenKhoa"].ToString();
            this.namTL = (int)row["namTL"];
            this.phong = row["phong"].ToString();
            this.dienThoai = row["dienThoai"].ToString();
            this.truongKhoa = row["truongKhoa"].ToString();
        }
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
        public string TenKhoa { get => tenKhoa; set => tenKhoa = value; }
        public int NamTL { get => namTL; set => namTL = value; }
        public string Phong { get => phong; set => phong = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public string TruongKhoa { get => truongKhoa; set => truongKhoa = value; }
    }
}
