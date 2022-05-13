using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYDETAI.DTO
{
    public class ReportProgress
    {
        private string maDT;
        private string maBCTD;
        private float hT;
        private string noiDung;
        private string keHoachTT;
        private string khaNangHT;
        private string lanBC;
        public ReportProgress(DataRow row)
        {
            this.maDT = row["maDT"].ToString();
            this.maBCTD = row["maBCTD"].ToString();
            this.noiDung = row["ND"].ToString();
            this.keHoachTT = row["KH_TT"].ToString();
            this.khaNangHT = row["KNHT"].ToString();
            this.lanBC =row["Lan_BC"].ToString();
            this.hT = (float)Convert.ToDouble(row["HT(%)"].ToString());
        }
        public string MaDT { get => maDT; set => maDT = value; }
        public string MaBCTD { get => maBCTD; set => maBCTD = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public string KeHoachTT { get => keHoachTT; set => keHoachTT = value; }
        public string KhaNangHT { get => khaNangHT; set => khaNangHT = value; }
        public string LanBC { get => lanBC; set => lanBC = value; }
        public float HT { get => hT; set => hT = value; }

    }
}
