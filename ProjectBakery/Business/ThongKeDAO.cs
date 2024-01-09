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
    public class ThongKeDAO
    {
        DBLayer db;
        public ThongKeDAO()
        {
            db = new DBLayer();
        }
        public DataSet getAllBaoCaoDoanhThu()
        {
            DataSet tmp = db.ExecuteQueryDataSet(
                "select * from View_BaoCaoDoanhThu", CommandType.Text, null);
            return tmp;
        }
        public DataSet getBaoCaoDoanhThuDate(string from, string to)
        {
            DataSet tmp = db.ExecuteQueryDataSet(
                "select * from View_BaoCaoDoanhThu where createdate >='" + from + "' and " + "createdate <='" + to + "'", CommandType.Text, null);
            return tmp;
        }
    }
}
