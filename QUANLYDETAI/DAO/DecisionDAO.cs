using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYDETAI.DTO;

namespace QUANLYDETAI.DAO
{
    public class DecisionDAO
    {
        private static DecisionDAO instance;
        public static DecisionDAO Instance
        {
            get { if (instance == null) instance = new DecisionDAO(); return instance; }
            private set { instance = value; }
        }
        private DecisionDAO() { }
        public List<Decision> getListQuyetDinh()
        {
            List<Decision> list = new List<Decision>();
            string query = $"select * from QD_giaoDT";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                list.Add(new Decision(item));
            }
            return list;
        }
        public Decision GetDecisionById(string id)
        {
            string query = $"select * from qd_giaodt";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            Decision decision = new Decision(data.Rows[0]);
            return decision;
        }
    }
}
