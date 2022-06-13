using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winform_Final.DBLayers;

using System.Data;
using System.Data.SqlClient;

namespace Winform_Final.Business_Layers
{
    internal class BSUser
    {
        DBMain db = null;
        string err = "nooo";
        public BSUser()
        {
            db = new DBMain();
        }
        public DataSet getUserDetails()
        {
            return db.ExecuteQueryDataSet("select * from ACCOUNT", CommandType.Text);
        }
        public int countUsers_username(ref string err, string username)
        {
            return db.ExecuteCount("SELECT COUNT(*) FROM ACCOUNT where username='" + username + "'", CommandType.Text, ref err);
        }
        public int countUsers_login(ref string err, string username, string password)
        {
            return db.ExecuteCount("SELECT COUNT(*) FROM ACCOUNT where username='" + username + "' AND password='"+password+"'", CommandType.Text, ref err);
        }
        public bool addingUser(string username, string password, string fullName, string address, ref string err)
        {
            string sqlString = "Insert Into ACCOUNT Values(" + "'" + username + "','" + password + "',N'" + fullName + "',N'" + address + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet getUser_withUsername(string username)
        {
            return db.ExecuteQueryDataSet("select * from ACCOUNT where username='"+username+"'", CommandType.Text);
        }


    }
}
