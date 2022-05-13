using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYDETAI.DTO
{
    public class Topic
    {
        private string maCN;
        private string maCapDT;
        private string maDT;
        private string tenDT;
        private DateTime? ngayBD;
        private DateTime? ngayKT;
        private string tinhTrangDT;
        private string maCD;
        private string maQD;
        private string maHDNT;
        private string maCT;
        private string maBM;
        private string maKhoa;
        public Topic(DataRow row)
        {
            this.maCD = row["MaCD"].ToString();
            this.maCapDT = row["MaCapDT"].ToString();
            this.maDT = row["MaDT"].ToString();
            this.tenDT = row["TenDT"].ToString();
            this.ngayBD = (DateTime)row["NgayBD"];
            this.tinhTrangDT = row["TinhTrang_DT"].ToString();
            this.maCN = row["MaCN"].ToString();
            this.maQD = row["MaQD"].ToString();
            this.maHDNT = row["MaHDNT"].GetType().Name=="DBNull"?"":row["MaHDNT"].ToString();
            this.maCT = row["maCT"].GetType().Name == "DBNull" ? "" : row["maCT"].ToString();
            this.ngayKT = row["ngayKT"].GetType().Name == "DBNull" ? null: (DateTime?)row["ngayKT"];
            this.maBM = row["maBM"].GetType().Name == "DBNull" ? "" : row["maBM"].ToString();
            this.maKhoa = row["maKhoa"].GetType().Name == "DBNull" ? "" : row["maKhoa"].ToString();
        }
        public string MaCN { get => maCN; set => maCN = value; }
        public string MaCapDT { get => maCapDT; set => maCapDT = value; }
        public string MaDT { get => maDT; set => maDT = value; }
        public string TenDT { get => tenDT; set => tenDT = value; }
        public DateTime? NgayBD { get => ngayBD; set => ngayBD = value; }
        public DateTime? NgayKT { get => ngayKT; set => ngayKT = value; }
        public string TinhTrangDT { get => tinhTrangDT; set => tinhTrangDT = value; }
        public string MaCD { get => maCD; set => maCD = value; }
        public string MaQD { get => maQD; set => maQD = value; }
        public string MaHDNT { get => maHDNT; set => maHDNT = value; }
        public string MaCT { get => maCT; set => maCT = value; }
        public string MaBM { get => maBM; set => maBM = value; }
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }

    }
   
}
