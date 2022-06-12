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
    internal class BSProduct
    {
        DBMain db = null;
        string err = "nooo";
        public BSProduct()
        {
            db = new DBMain();
        }
        public DataSet getProducts()
        {
            return db.ExecuteQueryDataSet("select ID, ProductName, price from PRODUCT", CommandType.Text);
        }
        public DataSet getProduct_baseOnCategory(string category)
        {
            return db.ExecuteQueryDataSet("select ID, ProductName, price from PRODUCT where Category='"+category+"'", CommandType.Text);
        }
        
        public int countProducts(ref string err)
        {
            return db.ExecuteCount("SELECT COUNT(*) FROM PRODUCT", CommandType.Text, ref err);
        }
        public int countProductTypes(ref string err, string category)
        {
            return db.ExecuteCount("SELECT COUNT(*) FROM PRODUCT where Category='"+category+"'", CommandType.Text, ref err);
        }
        public DataSet getProductFullDetail()
        {
            return db.ExecuteQueryDataSet("select * from PRODUCT", CommandType.Text);
        }
        public bool updateProduct(string foodID, string name, string price, ref string err)
        {
            string sqlString = "Update PRODUCT Set ProductName = N'" + name + "', price ='" + Convert.ToInt32(price) + "' Where ID='" + Convert.ToInt32(foodID) + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool addingProduct(string name, string category, string price, ref string err)
        {
            string sqlString = "Insert Into PRODUCT Values(" + "N'" + name + "','" + Convert.ToInt32(price) + "','" + category + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
