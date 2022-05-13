using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYDETAI.DTO;

namespace QUANLYDETAI.DAO
{
    public class TopicLevelDAO
    {
        private static TopicLevelDAO instance;
        public static TopicLevelDAO Instance
        {
            get { if (instance == null) instance = new TopicLevelDAO(); return instance; }
            private set { instance = value; }
        }
        private TopicLevelDAO() { }
        public List<TopicLevel> getListCapDT()
        {
            List<TopicLevel> list=new List<TopicLevel>();
            string query = $"select * from Cap_DT";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                list.Add(new TopicLevel(item));
            }
            return list;
        }
        public TopicLevel getTopicLevelbyID(string id)
        {
            string query = $"select * from cap_dt where macdt='{id}'";
            TopicLevel topic = new TopicLevel(DataProvider.Instance.ExcuteQuery(query).Rows[0]);
            return topic;
        }
    }
}
