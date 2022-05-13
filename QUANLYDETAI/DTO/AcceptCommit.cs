using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYDETAI.DTO
{
    public class AcceptCommit
    {
        private string maHDNT;
        private string tenHDNT;
        private DateTime? ngayNT;
        public AcceptCommit(DataRow row)
        {
            this.maHDNT = row["MaHDNT"].ToString();
            this.tenHDNT = row["TenHDNT"].ToString();
            this.ngayNT =(DateTime) row["NgayNT"];
        }
        public string MaHDNT { get => maHDNT; set => maHDNT = value; }
        public string TenHDNT { get => tenHDNT; set => tenHDNT = value; }
        public DateTime? NgayNT { get => ngayNT; set => ngayNT = value; }
    }
}
