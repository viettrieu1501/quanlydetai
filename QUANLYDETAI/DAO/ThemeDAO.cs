using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYDETAI.DTO;

namespace QUANLYDETAI.DAO
{
    public class ThemeDAO
    {
        private static ThemeDAO instance;
        public static ThemeDAO Instance
        {
            get { if (instance == null) instance = new ThemeDAO(); return instance; }
            private set { instance = value; }
        }
        private ThemeDAO() { }
        public List<Theme> getListCD()
        {
            List<Theme> list = new List<Theme>();
            string query = $"select * from ChuDe";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                list.Add(new Theme(item));
            }
            return list;
        }
        public Theme getThemeByIdTheme(string idTheme)
        {
            string query = $"select * from chude where macd=N'{idTheme}'";
            Theme data = new Theme(DataProvider.Instance.ExcuteQuery(query).Rows[0]);
            return data;
        }
    }
}
