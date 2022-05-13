using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYDETAI.DTO;

namespace QUANLYDETAI.DAO
{
    public class StaffDAO
    {
        private static StaffDAO instance;
        public static StaffDAO Instance
        {
            get { if (instance == null) instance = new StaffDAO(); return instance; }
            private set { instance = value; }
        }
        private StaffDAO() { }
        public List<Staff> getListGiaoVien()
        {
            List<Staff> list = new List<Staff>();
            string query = $"select * from GiaoVien";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                list.Add(new Staff(item));
            }
            return list;
        }
        public bool checkRoleToStaff(string userName, string idStaff)
        {
            string query = $"exec checkRoleToStaff N'{userName}',N'{idStaff}'";
            int result =(int) DataProvider.Instance.ExcuteScalar(query);
            return result > 0;
        }
        public Staff getGiaovien(string maGV)
        {
            string query = $"select * from giaovien where manv=N'{maGV}'";
            Staff gv = new Staff(DataProvider.Instance.ExcuteQuery(query).Rows[0]);
            return gv;
        }
        public DataTable getFullStaff()
        {
            string query = $"exec getFullStaff";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool deleteStaff(string MaGV)
        {
            string query = $"delete from giaovien where manv='{MaGV}'";
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool updateStaff(string maNV, string tenNV, string sex, string ngaySinh, string maBM,string email, string sdt)
        {
            string query = $"exec updateStaff N'{maNV}', N'{tenNV}', N'{sex}', N'{ngaySinh}', N'{maBM}', N'{email}',N'{sdt}'";
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool insertStaff(string capBac, string tenNV, string sex, string ngaySinh, string maBM, string email, string sdt)
        {
            string query = $"exec insertStaff N'{capBac}', N'{tenNV}', N'{sex}', N'{ngaySinh}', N'{maBM}', N'{email}',N'{sdt}'";
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        
        public DataTable getSearchStaff(string key)
        {
            string query = $"exec SearchStaff N'{key}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public DataTable getSearchStaffByIDSubject(string idSubject, string key)
        {
            string query = $"exec getSearchStaffByIDSubject N'{idSubject}', N'{key}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public DataTable getSearchStaffByIDDepartment(string idDepartment, string key)
        {
            string query = $"exec getSearchStaffByIDDepartment N'{idDepartment}', N'{key}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public DataTable getStaffByIDSubject(string id)
        {
            string query = $"exec getStaffByIDSubject N'{id}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public DataTable getStaffToSelect()
        {
            string query = $"exec getFullStaffToSelect";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public DataTable SearchStaffToSelect(string key)
        {
            string query = $"exec SearchStaffToSelect N'{key}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public DataTable getFullStaffNotPart(string idTopic)
        {
            string query = $"exec getFullStaffToAdd N'{idTopic}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public DataTable getFullStaffPart(string idTopic)
        {
            string query = $"exec getFullStaffToRemove N'{idTopic}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public List<Staff> getListStaffByIdTopic(string id)
        {
            List<Staff> list = new List<Staff>();
            string query = $"exec getListStaffByIdTopic N'{id}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                list.Add(new Staff(item));
            }
            return list;
        }
        public bool deleteStaffParti(string idStaff, string idTopic)
        {
            string query = $"exec deleteStaffParti N'{idStaff}', N'{idTopic}'";
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool insertStaffParti(string idStaff, string idTopic, string role, string ParticipationPoints)
        {
            string query = $"exec insertStaffParti N'{idStaff}', N'{idTopic}',  N'{role}', N'{ParticipationPoints}'";
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public DataTable getFullStaffToParti()
        {
            string query = $"exec getFullStaffToParti";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public DataTable getStaffByIDDepartment(string idDepartment)
        {
            string query = $"exec getStaffByIDDepartment N'{idDepartment}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
    }
}
