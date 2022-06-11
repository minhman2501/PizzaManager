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
        public BSProduct()
        {
            db = new DBMain();
        }
        public DataSet getProducts()
        {
            return db.ExecuteQueryDataSet("select ID, ProductName, price from PRODUCT", CommandType.Text);
        }
        public DataSet getPizza()
        {
            return db.ExecuteQueryDataSet("select ID, ProductName, price from PRODUCT where Category='Pizza'", CommandType.Text);
        }
        public DataSet getDrink()
        {
            return db.ExecuteQueryDataSet("select ID, ProductName, price from PRODUCT where Category='Drink'", CommandType.Text);
        }

        public DataSet getProductsTable()
        {
            return db.ExecuteQueryDataSet("select * from PRODUCT", CommandType.Text);
        }
    }
}
