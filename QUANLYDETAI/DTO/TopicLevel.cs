using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYDETAI.DTO
{
    public class TopicLevel
    {
        private string maCap;
        private string tenCap;
        private float kinhPhi;
        public TopicLevel(DataRow row)
        {
            this.maCap = row["MaCDT"].ToString();
            this.tenCap = row["TenCap"].ToString();
            this.kinhPhi= (float)Convert.ToDouble(row["KinhPhi"].ToString());
        }
        public string MaCap { get => maCap; set => maCap = value; }
        public string TenCap { get => tenCap; set => tenCap = value; }
        public float KinhPhi { get => kinhPhi; set => kinhPhi = value; }
    }
}
