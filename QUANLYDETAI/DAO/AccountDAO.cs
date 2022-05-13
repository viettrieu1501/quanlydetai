using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using QUANLYDETAI.DTO;

namespace QUANLYDETAI.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountDAO() { }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
        public bool Login(string userName, string passWord)
        {
            string hasspass = MD5Hash(Base64Encode(passWord));
            string query = $"select * from account where username='{userName}' and password='{hasspass}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
        public Account getAccountbyUserName(string userName)
        {
            string query = $"select * from account where username='{userName}'";
            Account account = new Account(DataProvider.Instance.ExcuteQuery(query).Rows[0]);
            return account;
        }
        public bool changePass(string userName, string password)
        {
            string query = $"update account set password='{MD5Hash(Base64Encode(password))}' where username='{userName}'";
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool updateAccount(string userName, string displayName, string idStaff)
        {
            string query = $"update account set displayname='{displayName}', magv=N'{idStaff}' where username='{userName}'";
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public DataTable getFullAccount()
        {
            string query = $"exec getFullAccount";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool deleteAccount(string userName)
        {
            string query = $"delete from account where username=N'{userName}'";
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool insertAccount(string userName, string displayName, string idStaff, string password)
        {
            string query = $"exec insertAccount N'{userName}', N'{displayName}', N'{idStaff}', N'{MD5Hash(Base64Encode(password))}'";
            int result =(int) DataProvider.Instance.ExcuteScalar(query);
            return result > 0;
        }
    }
}
