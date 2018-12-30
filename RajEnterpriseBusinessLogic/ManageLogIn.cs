using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajEnterpriseBusinessLogic
{
    public class ManageLogIn
    {
        public string cns { get; set; }
        public ManageLogIn(string connectionString)
        {
            this.cns = connectionString;
        }
        public bool DoLogIn(string username, string password)
        {
            SqlConnection sqlCon = new SqlConnection(cns);
            int count;
            try
            {
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.CommandText = string.Format("select COUNT(*) from registration where contactno='{0}' and password='{1}'", username, password);
                sqlCom.Connection = sqlCon;
                sqlCon.Open();
                count = (int)sqlCom.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                if (ConnectionState.Open == sqlCon.State)
                    sqlCon.Close();
            }
            return count != 0 ? true : false;
        }
    }
}
