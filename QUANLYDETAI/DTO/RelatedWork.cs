using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYDETAI.DTO
{
    public class RelatedWork
    {
        private string maCT;
        private string tenCT;
        private string donviTH;
        public RelatedWork(DataRow row)
        {
            this.maCT = row["MaCT"].ToString();
            this.tenCT = row["TenCT"].ToString();
            this.donviTH = row["DonVi_TH"].ToString();
        }
        public string MaCT { get => maCT; set => maCT = value; }
        public string TenCT { get => tenCT; set => tenCT = value; }
        public string DonviTH { get => donviTH; set => donviTH = value; }
    }
}
