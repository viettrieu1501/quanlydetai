using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYDETAI.DTO
{
    public class Decision
    {
        private string maQD;
        private string noiDung;
        private DateTime ngayQD;
        public Decision(DataRow row)
        {
            this.maQD = row["MaQD"].ToString();
            this.noiDung = row["ND"].ToString();
            this.ngayQD = (DateTime)row["NgayQD"];
        }
        public string MaQD { get => maQD; set => maQD = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public DateTime NgayQD { get => ngayQD; set => ngayQD = value; }
    }
}
