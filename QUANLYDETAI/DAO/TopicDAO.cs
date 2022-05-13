using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYDETAI.DAO;
using QUANLYDETAI.DTO;

namespace QUANLYDETAI.DAO
{
    public class TopicDAO
    {
        private static TopicDAO instance;
        public static TopicDAO Instance
        {
            get { if (instance == null) instance = new TopicDAO(); return instance; }
            private set { instance = value; }
        }
        private TopicDAO() { }

        public DataTable getListTopicNN()
        {
            string query=$"select madt, tendt from detai where macapdt='NN'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool insertTopic(string idDepartment, string idSubject, string tenDT, string maCN, string maCapDT, DateTime ngayBD, string maCD, string maQD, string maCT, List<Participants> list)
        {
            string query = $"exec insertTopic N'{idDepartment}', N'{idSubject}', N'{maCN}', N'{maCapDT}', N'{tenDT}', N'{ngayBD}', N'{maCD}', N'{maQD}', N'{maCT}'";
            string idTopic = DataProvider.Instance.ExcuteQuery(query).Rows[0]["madt"].ToString();
            foreach(Participants item in list)
            {
                query = $"exec insertStaffParti N'{item.MaNV}', N'{idTopic}', N'{item.Role}', N'{item.Point}'";
                DataProvider.Instance.ExcuteNonQuery(query);
            }
            return true;
        }

        public DataTable getFullTopic()
        {
            string query = $"exec getFullTopic";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public DataTable getTopicByidStaff(string idStaff)
        {
            string query = $"exec getTopicByIdStaff N'{idStaff}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool deleteTopic(string maDT)
        {
            string query = $"exec DeleteTopic N'{maDT}'";
            int data = (int)DataProvider.Instance.ExcuteScalar(query);
            if (data==0) return false;
            return true;
        }
        public Topic getTopicbyID(string maDT)
        {
            string query = $"select * from detai where madt=N'{maDT}'";
            Topic topic = new Topic(DataProvider.Instance.ExcuteQuery(query).Rows[0]);
            return topic;
        }
        public bool updateTopic(string maDT, string maCN, string maCapDT, string tenDT, string ngayBD, string ngayKT, string status, string maKhoa, string maBM, string maCD, string maQD, string mact)
        {
            string query = $"exec updatetopic '{maDT}','{maCN}','{maCapDT}',N'{tenDT}','{ngayBD}','{ngayKT}', N'{status}', '{maKhoa}',N'{maBM}','{maCD}','{maQD}','{mact}'";
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public DataTable SearchTopic(string key)
        {
            string query = $"exec SearchTopic N'{key}'";
            DataTable data= DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public DataTable getTopicOfDepartment(string id)
        {
            string query = $"exec getTopicOfDepartment N'{id}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public DataTable getTopicOfSubject(string id)
        {
            string query = $"exec getTopicOfSubject N'{id}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public DataTable getSearchTopicOfDepart(string key, string id)
        {
            string query = $"exec getSearchTopicOfDepart N'{id}', N'{key}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public DataTable getStatisticByResult(string year)
        {
            string query = $"exec getStatisticByResult N'{year}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public DataTable getStatisticByDepartment(string year)
        {
            string query = $"exec getStatisticByDepartment N'{year}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public DataTable getStatisticByStatus(string year)
        {
            string query = $"exec getStatisticByStatus N'{year}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public DataTable getTopicByStatus(string status, string year)
        {
            string query = $"exec getTopicByStatus N'{year}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public DataTable getStatisticByLevel(string year)
        {
            string query = $"exec getStatisticByLevel N'{year}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public DataTable getStatisticBySubject(string year)
        {
            string query = $"exec getStatisticBySubject N'{year}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool checkRoleToTopic(string idTopic, string userName)
        {
            string query = $"exec checkRoleToTopic N'{idTopic}', N'{userName}'";
            int data = (int)DataProvider.Instance.ExcuteScalar(query);
            return data > 0;
        }
        public int getNumOfReport(string idTopic)
        {
            string query = $"select count(MaBCTD) from baocao_td where madt=N'{idTopic}'";
            int data = (int)DataProvider.Instance.ExcuteScalar(query);
            return data;
        }
        public DataTable SearchTopicOfStaff(string idStaff, string key)
        {
            string query = $"exec SearchTopicOfStaff N'{idStaff}', N'{key}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }

        public bool UpdateAcceptCommitOfTopic(string idTopic, string idAcceptForm)
        {
            string query = $"update detai set mahdnt=N'{idAcceptForm}' where madt=N'{idTopic}'";
            int data = DataProvider.Instance.ExcuteNonQuery(query);
            return data>0;
        }
        public bool checkReportTopic(string idTopic)
        {
            string query = $"select count(madt) from baocao_td where madt=N'{idTopic}'";
            int data = (int)DataProvider.Instance.ExcuteScalar(query);
            return data <3;
        }
        public DataTable getStatisticByName(string name)
        {
            string query = $"exec getStatisticByName N'{name}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
    }
}
