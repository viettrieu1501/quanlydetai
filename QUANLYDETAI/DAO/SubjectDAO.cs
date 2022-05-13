using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYDETAI.DTO;

namespace QUANLYDETAI.DAO
{
    public class SubjectDAO
    {
        private static SubjectDAO instance;
        public static SubjectDAO Instance
        {
            get { if (instance == null) instance = new SubjectDAO(); return instance; }
            private set { instance = value; }
        }
        public List<Subject> getListBoMon()
        {
            string query = $"select * from bomon";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            List<Subject> list = new List<Subject>();
            foreach(DataRow item in data.Rows)
            {
                list.Add(new Subject(item));
            }
            return list;
        }
        public Subject getBoMonByID(string maBM)
        {
            string query = $"select * from bomon where mabm='{maBM}'";
            Subject data = new Subject(DataProvider.Instance.ExcuteQuery(query).Rows[0]);
            return data;
        }
        public DataTable getFullSubject()
        {
            string query = $"exec getFullSubject";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool deleteSubjectByID(string idSubject)
        {
            string query = $"exec deleteSubjectByID N'{idSubject}'";
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result>0;
        }
        public bool updateSubject(string idSubject, string nameSubject, string room, string phonenumber, string idManager, string idDepartment)
        {
            string query = $"exec updateSubject N'{idSubject}', N'{nameSubject}', N'{room}',N'{phonenumber}',N'{idManager}',N'{idDepartment}'";
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool InsertSubject(string nameSubject, string maManager, string idDepartment, string room, string phoneNumber)
        {
            string query = $"exec insertSubject N'{nameSubject}',N'{maManager}',N'{idDepartment}',N'{room}',N'{phoneNumber}'";
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public DataTable getSearchSubject(string key)
        {
            string query = $"exec searchSubject N'{key}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public DataTable getSubjectOfDepartment(string idDepartment)
        {
            string query = $"exec getSubjectOfDepartment N'{idDepartment}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool checkRoleToSubject(string idSubject, string userName)
        {
            string query = $"exec checkRoleToSubject N'{idSubject}', N'{userName}'";
            int data = (int)DataProvider.Instance.ExcuteScalar(query);
            return data > 0;
        }
        public DataTable getSearchSubjectOfDepart(string idDepartment, string key)
        {
            string query = $"exec getSearchSubjectOfDepart N'{idDepartment}', N'{key}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public List<Subject> getListBoMonByUserName(string userName)
        {
            string query = $"exec getListBoMonByUserName N'{userName}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            List<Subject> list = new List<Subject>();
            foreach (DataRow item in data.Rows)
            {
                list.Add(new Subject(item));
            }
            return list;
        }
        public List<Subject> getListBoMonOfDepartment(string idDepartment)
        {
            string query = $"exec getListBoMonOfDepartment N'{idDepartment}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            List<Subject> list = new List<Subject>();
            foreach (DataRow item in data.Rows)
            {
                list.Add(new Subject(item));
            }
            return list;
        }
    }
}
