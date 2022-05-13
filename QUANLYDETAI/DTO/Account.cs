using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYDETAI.DTO
{
    public class Account
    {
        private string userName;
        private string displayName;
        private string password;
        private string maGV;
        private int maType;
        public Account(DataRow row)
        {
            this.userName = row["UserName"].ToString();
            this.displayName = row["DisplayName"].ToString();
            this.password = row["password"].ToString();
            this.maGV = row["MaGV"].ToString();
            this.maType =(int) row["MaType"];
        }
        public string UserName { get => userName; set => userName = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public string Password { get => password; set => password = value; }
        public string MaGV { get => maGV; set => maGV = value; }
        public int MaType { get => maType; set => maType = value; }
    }
}
