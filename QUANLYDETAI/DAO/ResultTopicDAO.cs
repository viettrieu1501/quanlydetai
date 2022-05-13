using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYDETAI.DTO;

namespace QUANLYDETAI.DAO
{
    public class ResultTopicDAO
    {
        private static ResultTopicDAO instance;
        public static ResultTopicDAO Instance
        {
            get { if (instance == null) instance = new ResultTopicDAO(); return instance; }
            private set { instance = value; }
        }
        private ResultTopicDAO() { }
        public ResultTopic GetResultTopicByIdTopic(string idTopic)
        {
            string query = $"select * from kq_dt where madt=N'{idTopic}'";
            if(DataProvider.Instance.ExcuteQuery(query).Rows.Count>0)
            {
                ResultTopic data = new ResultTopic(DataProvider.Instance.ExcuteQuery(query).Rows[0]);
                return data;
            }
            return null;
        }
        public bool UpdateResultTopic(string idTopic, string dayProctec, string content,string RewardForm, string point)
        {
            string query = $"exec UpdateResultTopic N'{idTopic}',  N'{dayProctec}', N'{content}', N'{RewardForm}', N'{point}'";
            int data = DataProvider.Instance.ExcuteNonQuery(query);
            return data>0;
        }
    }
}
