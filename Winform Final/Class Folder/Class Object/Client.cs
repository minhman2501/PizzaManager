using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using Winform_Final.Business_Layers;

namespace Winform_Final.Class_Folder.Class_Object
{
    public class Client
    {
        private int id;
        private string username;
        private string fullName;
        private string address;

        public Client(string username)
        {
            this.username = username;
        }   
        public string getFullName()
        {
            return fullName;
        }
        public string getAddress()
        {
            return address;
        }
        public void getClientDetails()
        {
            DataSet data = new DataSet();
            BSUser userDatabase = new BSUser();
            data = userDatabase.getUser_withUsername(this.username);
            this.id = Convert.ToInt32(data.Tables[0].Rows[0]["userID"].ToString());
            this.fullName = data.Tables[0].Rows[0]["FullName"].ToString();
            this.address = data.Tables[0].Rows[0]["Address"].ToString();
        }

    }
}
