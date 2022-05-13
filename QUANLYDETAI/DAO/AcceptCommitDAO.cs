using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYDETAI.DTO;

namespace QUANLYDETAI.DAO
{
    public class AcceptCommitDAO
    {
        private static AcceptCommitDAO instance;
        public static AcceptCommitDAO Instance
        {
            get { if (instance == null) instance = new AcceptCommitDAO(); return instance; }
            private set { instance = value; }
        }
        private AcceptCommitDAO() { }
        public List<AcceptCommit> getListHDNT()
        {
            List<AcceptCommit> list = new List<AcceptCommit>();
            string query = $"select * from HD_NT";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                list.Add(new AcceptCommit(item));
            }
            return list;
        }
        public AcceptCommit GetAcceptCommitById(string id)
        {
            string query = $"select * from hd_nt where mahdnt='{id}'";
            AcceptCommit acceptCommit = new AcceptCommit(DataProvider.Instance.ExcuteQuery(query).Rows[0]);
            return acceptCommit;
        }
    }
}
