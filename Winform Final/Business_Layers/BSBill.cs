using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Winform_Final.DBLayers;

namespace Winform_Final.Business_Layers
{
    internal class BSBill
    {
        DBMain db = null;
        string err = "nooo";
        public BSBill()
        {
            db = new DBMain();
        }
        public DataSet getBills_Full()
        {
            return db.ExecuteQueryDataSet("select * from BILLDETAIL", CommandType.Text);
        }
        public DataSet getBills_baseOnUser(int userId)
        {
            return db.ExecuteQueryDataSet("select * from BILLDETAIL where clientID=" + userId +"", CommandType.Text);
        }
        public bool addingBill(string userID, string totalPrice, string content, string address, string date, ref string err)
        {
            string sqlString = "Insert Into BILLDETAIL Values(" + Convert.ToInt32(userID) + "," + Convert.ToInt32(totalPrice) + ",N'" + content + "',N'" + address + "','" + date + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool deletingBill_basedOnUser(ref string err, string clientID)
        {
            string sqlString = "Delete From BILLDETAIL Where clientID=" + Convert.ToInt32(clientID) + "";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
