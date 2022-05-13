using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYDETAI.DTO
{
    public class Staff
    {
        private string maNV;
        private string tenNV;
        private DateTime? ngaySinh;
        private string gioiTinh;
        private string capBac;
        private string maBM;
        private string sdt;
        private string email;
        public Staff()
        {

        }
        public Staff(DataRow row)
        {
            this.maNV = row["MaNV"].ToString();
            this.tenNV = row["TenNV"].ToString();
            this.ngaySinh = (DateTime)row["NgaySinh"];
            this.gioiTinh = row["GioiTinh"].ToString();
            this.capBac = row["capBac"].ToString();
            this.maBM = row["MaBM"].ToString();
            this.sdt = row["SDT"].ToString();
            this.email = row["Email"].ToString();
        }
        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public DateTime? NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string CapBac { get => capBac; set => capBac = value; }
        public string MaBM { get => maBM; set => maBM = value; }
        public string SDT { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
    }
}
