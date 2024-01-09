using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProvider
{
	public class DBLayer
	{
		SqlConnection cnn;
		SqlCommand cmd;
		SqlDataAdapter adp;

		string strConnect =
			@"Data Source=DESKTOP-765RTBQ;Initial Catalog=BAKERY;Integrated Security=True";

		public DBLayer()
		{
			cnn = new SqlConnection(strConnect);
			cmd = cnn.CreateCommand();
		}
		// Select query
		public DataSet ExecuteQueryDataSet(         //get du lieu select * from user
			string strSQL, CommandType ct,
			params SqlParameter[] param)
		{
			Console.WriteLine(strSQL);
			cmd.Parameters.Clear();
			cmd.CommandText = strSQL;
			cmd.CommandType = ct;
			if (param != null)
			{
				foreach (SqlParameter p in param)
					cmd.Parameters.Add(p);
			}

			adp = new SqlDataAdapter(cmd);
			DataSet ds = new DataSet();
			adp.Fill(ds);
			return ds;
		}


		public bool MyExecuteNonQuery(string strSQL,        //xử lý hàm có sẵn ở csdl
			CommandType ct, ref string error,
			params SqlParameter[] param)
		{
			Console.WriteLine(strSQL);
			bool f = false;
			cnn.Open();
			cmd.Parameters.Clear();
			cmd.CommandText = strSQL;
			cmd.CommandType = ct;
			foreach (SqlParameter p in param)
				cmd.Parameters.Add(p);
			try
			{
				cmd.ExecuteNonQuery();
				f = true;
			}
			catch (SqlException ex)
			{
				error = ex.Message;
			}
			finally
			{
				cnn.Close();
			}
			return f;
		}

	}
}
