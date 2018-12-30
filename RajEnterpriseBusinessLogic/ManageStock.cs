using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajEnterpriseBusinessLogic
{
    public class ManageStock
    {
        public string cns { get; set; }
        public ManageStock(string connectionString)
        {
            this.cns = connectionString;
        }
        public List<StockModels> GetAllStock()
        {
            List<StockModels> lstModel = new List<RajEnterpriseBusinessLogic.StockModels>();
            SqlConnection sqlCon = new SqlConnection(cns);
            try
            {
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.CommandText = "select st.sid as Id, coll.name as Product,cmp.company_name as Company,st.mrp,st.rate,st.sgst,st.cgst,st.igst,st.stock,pd.weight,pd.details from stocks st join products pd on st.pid = pd.pid join companies cmp on cmp.cid = pd.cid join collection coll on coll.coll = pd.coll where st.stock > 0";
                sqlCom.Connection = sqlCon;
                sqlCon.Open();
                SqlDataReader sqlDr= sqlCom.ExecuteReader();
                while (sqlDr.Read())
                {
                    StockModels stModel = new StockModels();
                    stModel.ID = Convert.ToInt32(sqlDr["Id"].ToString());
                    stModel.ProductName = sqlDr["Product"].ToString();
                    stModel.Company = sqlDr["Company"].ToString();
                    stModel.MRP = string.IsNullOrEmpty(sqlDr["mrp"] as string) ? "0" : (sqlDr["mrp"] as string);
                    stModel.Rate = string.IsNullOrEmpty(sqlDr["rate"] as string) ? "0" : (sqlDr["rate"] as string);
                    stModel.IGST = sqlDr["igst"].ToString();
                    stModel.SGST = sqlDr["sgst"].ToString();
                    stModel.CGST = sqlDr["cgst"].ToString();
                    stModel.Stock = sqlDr["stock"].ToString();
                    stModel.Weight = sqlDr["weight"].ToString();
                    stModel.Details = sqlDr["details"].ToString();
                    stModel.TotalAmount = (Convert.ToDouble(stModel.Rate) * Convert.ToDouble(stModel.Stock)).ToString();
                    lstModel.Add(stModel);
                }
            }
            catch(Exception ex)
            {
                throw (ex);
            }
            finally
            {
                if (ConnectionState.Open == sqlCon.State)
                    sqlCon.Close();
            }
            return lstModel;
        }


        // Manage Product
        public List<Product> GetProduct()
        {
            List<Product> lstProduct = new List<Product>();
            SqlConnection sqlCon = new SqlConnection(cns);
            try
            {
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.CommandText = "select coll as Id,name as ProductName from collection";
                sqlCom.Connection = sqlCon;
                sqlCon.Open();
                SqlDataReader sqlDr = sqlCom.ExecuteReader();
                while (sqlDr.Read())
                {
                    Product prd = new Product();
                    prd.ID = Convert.ToInt32(sqlDr["Id"].ToString());
                    prd.ProductName = sqlDr["ProductName"].ToString();
                    lstProduct.Add(prd);
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
            return lstProduct;
        }
        public void CreateOrUpdateProduct(Product prd)
        {
            SqlConnection sqlCon = new SqlConnection(cns);
            try
            {
                SqlCommand sqlCom = new SqlCommand();
                if (prd.ID == 0)
                    sqlCom.CommandText = string.Format(" insert into collection(name) values ('{0}')", prd.ProductName);
                else
                    sqlCom.CommandText = string.Format(" update collection set name ='{0}' where coll='{1}'", prd.ProductName, prd.ID);
                sqlCom.Connection = sqlCon;
                sqlCon.Open();
                sqlCom.ExecuteNonQuery();
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
        public void DeleteProduct(int pid)
        {
            SqlConnection sqlCon = new SqlConnection(cns);
            try
            {
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.CommandText = string.Format("delete collection where coll='{0}'", pid);
                sqlCom.Connection = sqlCon;
                sqlCon.Open();
                sqlCom.ExecuteNonQuery();
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
        //Manage Company
        public List<Company> GetCompany()
        {
            List<Company> lstCmp = new List<Company>();
            SqlConnection sqlCon = new SqlConnection(cns);
            try
            {
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.CommandText = "select cid as Id,company_name as CmpName from companies";
                sqlCom.Connection = sqlCon;
                sqlCon.Open();
                SqlDataReader sqlDr = sqlCom.ExecuteReader();
                while (sqlDr.Read())
                {
                    Company cmp = new Company();
                    cmp.ID = Convert.ToInt32(sqlDr["Id"].ToString());
                    cmp.CompanyName = sqlDr["CmpName"].ToString();
                    lstCmp.Add(cmp);
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
            return lstCmp;
        }
        public void CreateOrUpdateCompany(Company comp)
        {
            SqlConnection sqlCon = new SqlConnection(cns);
            try
            {
                SqlCommand sqlCom = new SqlCommand();
                if (comp.ID == 0)
                    sqlCom.CommandText = string.Format(" insert into companies(company_name) values ('{0}')", comp.CompanyName);
                else
                    sqlCom.CommandText = string.Format(" update companies set company_name ='{0}' where cid='{1}'", comp.CompanyName, comp.ID);
                sqlCom.Connection = sqlCon;
                sqlCon.Open();
                sqlCom.ExecuteNonQuery();
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
        public void DeleteCompany(int cid)
        {
            SqlConnection sqlCon = new SqlConnection(cns);
            try
            {
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.CommandText = string.Format("delete companies where cid='{0}'", cid);
                sqlCom.Connection = sqlCon;
                sqlCon.Open();
                sqlCom.ExecuteNonQuery();
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

        //
        public List<ProductModel> GetProductDetails()
        {
            List<ProductModel> lstModel = new List<ProductModel>();
            SqlConnection sqlCon = new SqlConnection(cns);
            try
            {
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.CommandText = "select pdt.pid as Id,cll.name as Product,cmp.company_name as Company,pdt.weight,pdt.details from products pdt join collection cll on cll.coll = pdt.coll join companies cmp on cmp.cid=pdt.cid";
                sqlCom.Connection = sqlCon;
                sqlCon.Open();
                SqlDataReader sqlDr = sqlCom.ExecuteReader();
                while (sqlDr.Read())
                {
                    ProductModel stModel = new ProductModel();
                    stModel.ID = Convert.ToInt32(sqlDr["Id"].ToString());
                    stModel.ProductName = sqlDr["Product"].ToString();
                    stModel.CompanyName = sqlDr["Company"].ToString();
                    stModel.Weight = sqlDr["weight"].ToString();
                    stModel.Details = sqlDr["details"].ToString();
                    lstModel.Add(stModel);
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
            return lstModel;
        }

        public void IncreaseStock(int coll, int cid, string weight, string details, string mrp,string rate,int stock,string sgst,string cgst,string igst)
        {
            SqlConnection sqlCon = new SqlConnection(cns);
            try
            {
                SqlCommand sqlCom = new SqlCommand("increaseStock", sqlCon);
                sqlCom.CommandType = CommandType.StoredProcedure;
                //(@coll int,@cid int,@weigth varchar(50),@details varchar(50),@mrp varchar(50),@rate varchar(50),@stock int,@sgst varchar(50),@cgst varchar(50),@igst varchar(50))
                sqlCom.Parameters.Add("@coll", SqlDbType.Int).Value = coll;
                sqlCom.Parameters.Add("@cid", SqlDbType.Int).Value = cid;
                sqlCom.Parameters.Add("@weigth", SqlDbType.VarChar).Value = weight;
                sqlCom.Parameters.Add("@details", SqlDbType.VarChar).Value = details;
                sqlCom.Parameters.Add("@mrp", SqlDbType.VarChar).Value = mrp;
                sqlCom.Parameters.Add("@rate", SqlDbType.VarChar).Value = rate;
                sqlCom.Parameters.Add("@stock", SqlDbType.Int).Value = stock;
                sqlCom.Parameters.Add("@sgst", SqlDbType.VarChar).Value = sgst;
                sqlCom.Parameters.Add("@cgst", SqlDbType.VarChar).Value = cgst;
                sqlCom.Parameters.Add("@igst", SqlDbType.VarChar).Value = igst;
                sqlCon.Open();
                sqlCom.ExecuteNonQuery();                
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

        public void UpdateStock(int sid,int coll, int cid, string weight,string details,string mrp, string rate, int stock, string sgst, string cgst, string igst)
        {
            SqlConnection sqlCon = new SqlConnection(cns);
            try
            {
                SqlCommand sqlCom = new SqlCommand("updateStock", sqlCon);
                sqlCom.CommandType = CommandType.StoredProcedure;
                //updateStock(@sid int,@coll int,@cid int,@weigth varchar(50),@details varchar(50),@mrp varchar(50),@rate varchar(50),@stock int,@sgst varchar(50),@cgst varchar(50),@igst varchar(50))
                sqlCom.Parameters.Add("@sid", SqlDbType.Int).Value = sid;
                sqlCom.Parameters.Add("@coll", SqlDbType.Int).Value = coll;
                sqlCom.Parameters.Add("@cid", SqlDbType.Int).Value = cid;
                sqlCom.Parameters.Add("@weigth", SqlDbType.VarChar).Value = weight;
                sqlCom.Parameters.Add("@details", SqlDbType.VarChar).Value = details;
                sqlCom.Parameters.Add("@mrp", SqlDbType.VarChar).Value = mrp;
                sqlCom.Parameters.Add("@rate", SqlDbType.VarChar).Value = rate;
                sqlCom.Parameters.Add("@stock", SqlDbType.Int).Value = stock;
                sqlCom.Parameters.Add("@sgst", SqlDbType.VarChar).Value = sgst;
                sqlCom.Parameters.Add("@cgst", SqlDbType.VarChar).Value = cgst;
                sqlCom.Parameters.Add("@igst", SqlDbType.VarChar).Value = igst;
                sqlCon.Open();
                sqlCom.ExecuteNonQuery();
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

        public void DeleteStock(int sid)
        {
            SqlConnection sqlCon = new SqlConnection(cns);
            try
            {
                SqlCommand sqlCom = new SqlCommand("removeStock", sqlCon);
                sqlCom.CommandType = CommandType.StoredProcedure;
                //removeStock(@sid int)
                sqlCom.Parameters.Add("@sid", SqlDbType.Int).Value = sid;                
                sqlCon.Open();
                sqlCom.ExecuteNonQuery();
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
