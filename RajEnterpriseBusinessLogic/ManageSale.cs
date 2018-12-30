using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajEnterpriseBusinessLogic
{
    public class ManageSale
    {
        public string cns { get; set; }
        public ManageSale(string connectionString)
        {
            this.cns = connectionString;
        }

        public List<Company> GetCompanyOnPdtSelect(Product pdt)
        {
            List<Company> lstCompany = new List<RajEnterpriseBusinessLogic.Company>();
            SqlConnection sqlCon = new SqlConnection(cns);
            try
            {
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.CommandText = string.Format("select pdt.cid,cmp.company_name from products pdt join companies cmp on pdt.cid=cmp.cid where pdt.coll={0}", pdt.ID);
                sqlCom.Connection = sqlCon;
                sqlCon.Open();
                SqlDataReader sqlDr = sqlCom.ExecuteReader();
                while (sqlDr.Read())
                {
                    Company cmpModel = new Company();
                    cmpModel.ID = (int)sqlDr["cid"];
                    cmpModel.CompanyName = sqlDr["company_name"] as string;
                    lstCompany.Add(cmpModel);
                }
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
            return lstCompany;
        }

        public string GenerateInvoive(int custId, string xmlData)
        {
            string invoidId = string.Empty;
            //proc generate_invoice(@custid int, @xmlData varchar(max))
            SqlConnection sqlCon = new SqlConnection(cns);
            try
            {
                SqlCommand sqlCom = new SqlCommand("generate_invoice", sqlCon);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@custid", SqlDbType.Int).Value = custId;
                sqlCom.Parameters.Add("@xmlData", SqlDbType.VarChar).Value = xmlData;
                sqlCom.Parameters.Add("@id", SqlDbType.Int);
                sqlCom.Parameters["@id"].Direction = ParameterDirection.Output;
                sqlCon.Open();
                sqlCom.ExecuteNonQuery();
                invoidId = sqlCom.Parameters["@id"].Value.ToString();
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
            return invoidId;
        }

        public void BulkUpdate(DataTable dt)
        {
            //proc generate_invoice(@custid int, @xmlData varchar(max))
            SqlConnection sqlCon = new SqlConnection(cns);
            try
            {
                using (SqlCommand sqlCom = new SqlCommand("_updateStockAfterSale", sqlCon))
                {
                    sqlCom.CommandType = CommandType.StoredProcedure;
                    sqlCom.Parameters.AddWithValue("@saleTable", dt);
                    sqlCon.Open();
                    sqlCom.ExecuteNonQuery();
                }
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
        }
    }
}
