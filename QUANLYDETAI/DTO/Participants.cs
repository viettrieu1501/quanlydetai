using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYDETAI.DTO
{
    public class Participants
    {
        private string maNV;
        private string idTopic;
        private string nameStaff;
        private string role;
        private int point;
        public Participants(string maNV, string nameStaff, string idTopic, string role, int point)
        {
            this.maNV = maNV;
            this.nameStaff = nameStaff;
            this.idTopic = idTopic;
            this.role = role;
            this.point = point;
        }
        public string MaNV { get => maNV; set => maNV = value; }
        public string NameStaff { get => nameStaff; set => nameStaff = value; }
        public string IDTopic { get => idTopic; set => idTopic = value; }
        public string Role { get => role; set => role = value; }
        public int Point { get => point; set => point = value; }
    }
}
