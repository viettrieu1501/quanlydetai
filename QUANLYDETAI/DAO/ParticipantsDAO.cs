using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYDETAI.DAO
{
    public class ParticipantsDAO
    {
        private static ParticipantsDAO instance;
        public static ParticipantsDAO Instance
        {
            get { if (instance == null) instance = new ParticipantsDAO(); return instance; }
            private set { instance = value; }
        }
        private ParticipantsDAO() { }
        public bool insertParticipants(string idTopic, string idStaff)
        {
            string query = $"exec insertParticipants N'{idTopic}', N'{idStaff}'";
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool deleteParticipants(string idTopic, string idStaff)
        {
            string query = $"delete from gv_thamgia where madt=N'{idTopic}' and manv=N'{idStaff}'";
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}
