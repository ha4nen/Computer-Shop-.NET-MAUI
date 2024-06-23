using lab12.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12.DataTransactions
{
    public class DBTrans
    {
        public string dbPath;
        private SQLiteConnection conn;

        public DBTrans(string _dbPath)
        {
            this.dbPath = _dbPath;
        }

        public void Init()
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.CreateTable<UserInfo>();
        }
        public List<UserInfo> GetAllUsers() 
        {
            Init(); 
            return conn.Table<UserInfo>().ToList();
        }

        public void Add(UserInfo user)
        {
            conn= new SQLiteConnection(this.dbPath);
            conn.Insert(user);
        }
        public void Delete(int user_ID) 
        {
            conn=new SQLiteConnection(this.dbPath);
            conn.Delete(new UserInfo { ID=user_ID });   
                }
    }
}
