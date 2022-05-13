using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYDETAI.DTO
{
    public class TypeAccount
    {
        private int id;
        private string name;
        public TypeAccount(DataRow row)
        {
            this.id =(int) row["id"];
            this.name = row["name"].ToString();
        }
        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
