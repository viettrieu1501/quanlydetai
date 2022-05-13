using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYDETAI.DTO;

namespace QUANLYDETAI.DAO
{
    public class RelatedWorkDAO
    {
        private static RelatedWorkDAO instance;
        public static RelatedWorkDAO Instance
        {
            get { if (instance == null) instance = new RelatedWorkDAO(); return instance; }
            private set { instance = value; }
        }
        private RelatedWorkDAO() { }
        public List<RelatedWork> getListDetail()
        {
            List<RelatedWork> list = new List<RelatedWork>();
            string query = $"select * from CT_LQ";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                list.Add(new RelatedWork(item));
            }
            return list;
        }
        public RelatedWork GetRelatedWorkByid(string id)
        {
            string query = $"select * from ct_lq where mact=N'{id}'";
            RelatedWork data = new RelatedWork(DataProvider.Instance.ExcuteQuery(query).Rows[0]);
            return data;
        }
    }
}
