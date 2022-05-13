using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYDETAI.DTO
{
    public class Theme
    {
        private string maCD;
        private string tenCD;
        public Theme(DataRow row)
        {
            this.maCD = row["MaCD"].ToString();
            this.tenCD = row["tenCD"].ToString();
        }
        public string MaCD { get => maCD; set => maCD = value; }
        public string TenCD { get => tenCD; set => tenCD = value; }
    }
}
