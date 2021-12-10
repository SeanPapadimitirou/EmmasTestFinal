//Alex McMullen
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexsLibrary
{
    public static class ADO
    {
        internal static SqlConnection con = new SqlConnection();

        static ADO()
        {
            con.ConnectionString = global::AlexsLibrary.Properties.Settings.Default.EmmasConnectionString;
        }

        public static bool DeleteCustomer(int id, out string error)
        {
			bool flag = false;
			SqlCommand cmd = new SqlCommand();
			error = "";

			cmd.Connection = con;
			cmd.CommandText = "DELETE FROM customer WHERE id = " + id;

			try
			{
				con.Open();
				cmd.ExecuteNonQuery();
				flag = true;
			}
			catch (Exception ex)
			{
				error = ex.Message;
			}
			finally
			{
				if (con.State == ConnectionState.Open)
					con.Close();
			}

			return flag;
		}

		public static bool UpdateCustomer(int id, string custFirst, string custLast, string custPhone, string custAddress, string custCity, string custPostal, string custEmail, out string error)
		{
			bool flag = false;
			SqlCommand cmd = new SqlCommand();
			error = "";

			cmd.Connection = con;
			cmd.CommandText = "UPDATE customer SET custFirst = '" + custFirst + "', custLast = '" + custLast + "', custPhone = '" + custPhone +"', custAddress = '" + custAddress
				+ "', custCity = '" + custCity + "', custPostal = '" + custPostal + "', custEmail = '" + custEmail + "' WHERE id = " + id;

			try
			{
				con.Open();
				cmd.ExecuteNonQuery();
				flag = true;
			}
			catch (Exception ex)
			{
				error = ex.Message;
			}
			finally
			{
				if (con.State == ConnectionState.Open)
					con.Close();
			}

			return flag;
		}

		public static bool DeleteEmployee(int id, out string error)
		{
			bool flag = false;
			SqlCommand cmd = new SqlCommand();
			error = "";

			cmd.Connection = con;
			cmd.CommandText = "DELETE FROM employee WHERE id = " + id;

			try
			{
				con.Open();
				cmd.ExecuteNonQuery();
				flag = true;
			}
			catch (Exception ex)
			{
				error = ex.Message;
			}
			finally
			{
				if (con.State == ConnectionState.Open)
					con.Close();
			}

			return flag;
		}

		public static bool AddEmployee(string empFirst, string empLast, int posID, out string error)
		{
			bool flag = false;
			SqlCommand cmd = new SqlCommand();
			error = "";

			cmd.Connection = con;
			cmd.CommandText = "INSERT INTO employee (empFirst, empLast, posID) VALUES ('" + empFirst + "', '" + empLast + "', " + posID + ")";

			try
			{
				con.Open();
				cmd.ExecuteNonQuery();
				flag = true;
			}
			catch (Exception ex)
			{
				error = ex.Message;
			}
			finally
			{
				if (con.State == ConnectionState.Open)
					con.Close();
			}

			return flag;
		}

		public static bool UpdateEmployee(int id, string empFirst, string empLast, int posID, out string error)
		{
			bool flag = false;
			SqlCommand cmd = new SqlCommand();
			error = "";

			cmd.Connection = con;
			cmd.CommandText = "UPDATE employee SET empFirst = '" + empFirst + "', empLast = '" + empLast + "', posID = " + posID + " WHERE id = " + id;

			try
			{
				con.Open();
				cmd.ExecuteNonQuery();
				flag = true;
			}
			catch (Exception ex)
			{
				error = ex.Message;
			}
			finally
			{
				if (con.State == ConnectionState.Open)
					con.Close();
			}

			return flag;
		}
	}
}
