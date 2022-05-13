using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYDETAI.DTO
{
    public class Subject
    {
        private string maBM;
        private string tenBM;
        private string phong;
        private string dienThoai;
        private string truongBM;
        private string maKhoa;
        public Subject(DataRow row)
        {
            this.maBM = row["MaBM"].ToString();
            this.tenBM = row["TenBM"].ToString();
            this.phong = row["Phong"].ToString();
            this.dienThoai = row["DienThoai"].ToString();
            this.truongBM = row["TruongBM"].ToString();
            this.maKhoa = row["MaKhoa"].ToString();
        }
        public string MaBM { get => maBM; set => maBM = value; }
        public string TenBM { get => tenBM; set => tenBM = value; }
        public string Phong { get => phong; set => phong = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public string TruongBM { get => truongBM; set => truongBM = value; }
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
    }
}
