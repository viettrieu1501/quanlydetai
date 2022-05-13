using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYDETAI.DTO;

namespace QUANLYDETAI.DAO
{
    public class ReportProgressDAO
    {
        private static ReportProgressDAO instance;
        public static ReportProgressDAO Instance
        {
            get { if (instance == null) instance = new ReportProgressDAO(); return instance; }
            private set { instance = value; }
        }
        private ReportProgressDAO() { }
        public bool insertProgress(string maDT, string noiDung, string kNHT, string kHTT, string ngayBC, float phantramHT)
        {
            string query = $"exec insertBCTD '{maDT}','{noiDung}','{kNHT}','{kHTT}','{ngayBC}',{phantramHT}";
            int result=DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public ReportProgress GetReportProgressByID(string idTopic)
        {
            string query = $"select * from baocao_td where madt=N'{idTopic}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            if (data.Rows.Count > 0)
            {
                ReportProgress reportProgress = new ReportProgress(data.Rows[data.Rows.Count-1]);
                return reportProgress;
            }
            return null;
        }
        public DataTable getFullReportByid(string idTopic)
        {
            string query = $"exec getReportProgressByid N'{idTopic}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
    }
}
