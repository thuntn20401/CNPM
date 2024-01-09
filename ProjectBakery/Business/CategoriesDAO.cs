using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beans;
using DBProvider;

namespace Business
{
    public class CategoriesDAO
    {
        DBLayer db;
        public CategoriesDAO()
        {
            db = new DBLayer();
        }
        public DataSet getAllNameCategories()
        {
            return db.ExecuteQueryDataSet(
                "select id, cate_name from [dbo].[Categories]", CommandType.Text, null);
        }

        public int getCategoriesID(string cate_name)
        {
            DataSet ds = db.ExecuteQueryDataSet("select id from [dbo].[Categories] where cate_name = '" + cate_name + "'", CommandType.Text, null);
            int id = Convert.ToInt32(ds.Tables[0].Rows[0]["id"]);
            return id;
        }
    }
}
