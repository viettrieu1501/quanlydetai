using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYDETAI.DTO;

namespace QUANLYDETAI.DAO
{
    public class TypeAccountDAO
    {
        private static TypeAccountDAO instance;
        public static TypeAccountDAO Instance
        {
            get { if (instance == null) instance = new TypeAccountDAO(); return instance; }
            private set { instance = value; }
        }
        private TypeAccountDAO() { }
        public TypeAccount GetTypeAccountByID(int id)
        {
            string query = $"select * from TypeAccount where id={id}";
            TypeAccount data = new TypeAccount(DataProvider.Instance.ExcuteQuery(query).Rows[0]);
            return data;
        }
    }
}
