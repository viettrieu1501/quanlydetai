using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYDETAI.DTO
{
    public class ResultTopic
    {
        public string idTopic;
        public string idPKQ;
        public DateTime? protecDay;
        public string content;
        public float point;
        public string rewardForm;
        public ResultTopic(DataRow row)
        {
            this.idTopic = row["madt"].ToString();
            this.idPKQ = row["mapkq"].ToString();
            this.protecDay =(DateTime) row["ngaybv"];
            this.content = row["nd"].ToString();
            this.point= (float)Convert.ToDouble(row["diem"].ToString());
            this.rewardForm = row["htkt"].ToString();
        }
        public string IDTopic { get => idTopic; set => idTopic = value; }
        public string IdPKQ { get => idPKQ; set => idPKQ = value; }
        public DateTime? ProtecDay { get => protecDay; set => protecDay = value; }
        public string Content { get => content; set => content = value; }
        public float Point { get => point; set => point = value; }
        public string RewardForm { get => rewardForm; set => rewardForm = value; }
    }
}
