using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYDETAI.DTO
{
    public class ReportByTopicLevel
    {
        private string name;
        private int rate;
        public ReportByTopicLevel(DataRow row)
        {
            this.name = row["tencap"].ToString();
            this.rate = (int)row["tl"];
        }
        public string Name { get => name; set => name = value; }
        public int Rate { get => rate; set => rate = value; }
    }
}
