using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYDETAI.DTO;

namespace QUANLYDETAI.DAO
{
    public class DepartmentDAO
    {
        private static DepartmentDAO instance;
        public static DepartmentDAO Instance
        {
            get { if (instance == null) instance = new DepartmentDAO(); return instance; }
            private set { instance = value; }
        }
        private DepartmentDAO() { }
        public DataTable getFullDepartment()
        {
            string query = $"exec getFullDepartment";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool deleteDepartmentByID(string idDepartment)
        {
            string query = $"delete from khoa where makhoa=N'{idDepartment}'";
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result>0;
        }
        public Department getDepartmentByID(string idDepartment)
        {
            string query = $"select * from khoa where maKhoa=N'{idDepartment}'";
            Department data = new Department(DataProvider.Instance.ExcuteQuery(query).Rows[0]);
            return data;
        }
        public bool updateDepartment(string idDepartment, string nameDepartment, string namtl, string idManager, string room, string phoneNumber)
        {
            string query = $"exec updateDepartment N'{idDepartment}', N'{nameDepartment}', {namtl}, N'{idManager}', N'{room}', N'{phoneNumber}'";
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool insertDepartment(string nameDepartment, string namtl, string idManager, string room, string phoneNumber)
        {
            string query = $"exec insertDepartment N'{nameDepartment}', {namtl}, N'{idManager}', N'{room}', N'{phoneNumber}'";
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public List<Department> getListDepartment()
        {
            List<Department> list = new List<Department>();
            string query = $"select * from khoa";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                list.Add(new Department(item));
            }
            return list;
        }
        public DataTable getSearchDepartment(string key)
        {
            string query = $"exec getSearchDepartment N'{key}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        
    }
}
