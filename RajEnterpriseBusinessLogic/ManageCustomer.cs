using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajEnterpriseBusinessLogic
{
    public class ManageCustomer
    {
        public string cns { get; set; }
        public ManageCustomer(string connectionString)
        {
            this.cns = connectionString;
        }
        public List<CustomerModel> GetAllCustomer()
        {
            //custId int primary key identity(1, 1),name varchar(50), address varchar(50), email varchar(50), mobile int, panGst varchar(50), isActive bit 
             List <CustomerModel> lstCustomer = new List<CustomerModel>();
            SqlConnection sqlCon = new SqlConnection(cns);
            try
            {
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.CommandText = "select * from customers";
                sqlCom.Connection = sqlCon;
                sqlCon.Open();
                SqlDataReader sqlDr = sqlCom.ExecuteReader();
                while (sqlDr.Read())
                {
                    CustomerModel cust = new CustomerModel();
                    cust.ID = Convert.ToInt32(sqlDr["custId"].ToString());
                    cust.CustomerName = sqlDr["name"].ToString();
                    cust.Address = sqlDr["address"] != null ? sqlDr["address"].ToString() : "";
                    cust.EmailId = sqlDr["email"] != null ? sqlDr["email"].ToString() : "";
                    cust.MobileNo=sqlDr["mobile"] != null ? sqlDr["mobile"].ToString() : "";
                    cust.GstNo = sqlDr["panGst"] != null ? sqlDr["panGst"].ToString() : "";
                    cust.Diactivate = Convert.ToBoolean(sqlDr["isActive"]) ? true : false; 
                    lstCustomer.Add(cust);
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
            return lstCustomer;
        }
        public int CreateOrUpdateCustomer(CustomerModel cust)
        {
            int flag = 0;
            //name varchar(50), address varchar(50), email varchar(50), mobile int, panGst varchar(50), isActive bit
            SqlConnection sqlCon = new SqlConnection(cns);
            try
            {
                SqlCommand sqlCom = new SqlCommand();
                if (cust.ID == 0)
                    sqlCom.CommandText = string.Format(" insert into customers values ('{0}','{1}','{2}',{3},'{4}',{5})", cust.CustomerName, cust.Address, cust.EmailId, cust.MobileNo, cust.GstNo, cust.Diactivate ? 1 : 0);
                else
                    sqlCom.CommandText = string.Format(" update customers set name ='{1}',address='{2}',email='{3}',mobile={4},panGst='{5}',isActive={6} where custId='{0}'", cust.ID, cust.CustomerName, cust.Address, cust.EmailId, cust.MobileNo, cust.GstNo, cust.Diactivate ? 1 : 0);
                sqlCom.Connection = sqlCon;
                sqlCon.Open();
                flag = sqlCom.ExecuteNonQuery();
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
            return flag;
        }
    }
}
