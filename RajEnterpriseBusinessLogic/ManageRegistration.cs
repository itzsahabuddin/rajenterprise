using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajEnterpriseBusinessLogic
{
    public class ManageRegistration
    {
        public string cns { get; set; }
        public ManageRegistration(string connectionString)
        {
            this.cns = connectionString;
        }
        public bool CheckAvailability(string contectNo)
        {
            bool flag = false;
            SqlConnection sqlCon = new SqlConnection(cns);
            try
            {
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.CommandText = string.Format("select count(*) from registration where contactno='{0}'", contectNo);
                sqlCom.Connection = sqlCon;
                sqlCon.Open();
                int count = (int)sqlCom.ExecuteScalar();
                if (count == 0)
                    flag = true;
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
        public int DoRegistration(UserModel userModel)
        {
            int flag = 0;
            SqlConnection sqlCon = new SqlConnection(cns);
            try
            {
                SqlCommand sqlCom = new SqlCommand();
                //insert into registration values ('name', 'address', 'email', 'contactno', 'pass', 'bname', 'baddress', 'gst', 'pan', qid, role, 'answer' )
                sqlCom.CommandText = string.Format("insert into registration values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', {9}, {10}, '{11}' )",
                    userModel.Name, userModel.Address, userModel.Email, userModel.ContactNo, userModel.Password, userModel.BusinessName, userModel.BusinessAddress, userModel.GST, userModel.PAN, userModel.Qid, userModel.Role, userModel.Answer);
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
        public List<QuestionModel> GetAllQuestion()
        {
            List<QuestionModel> questionList = new List<QuestionModel>();
            SqlConnection sqlCon = new SqlConnection(cns);
            try
            {
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.CommandText = string.Format("select * from question");
                sqlCom.Connection = sqlCon;
                sqlCon.Open();
                SqlDataReader dr = sqlCom.ExecuteReader();
                while (dr.Read())
                {
                    QuestionModel qModel = new RajEnterpriseBusinessLogic.QuestionModel()
                    {
                        Qid = (int)dr["qid"],
                        Question = dr["question"] as string
                    };
                    questionList.Add(qModel);
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
            return questionList;
        }

        public string GetPassword(string contectNo, int qId, string answer)
        {
            string password = string.Empty;
            SqlConnection sqlCon = new SqlConnection(cns);
            try
            {
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.CommandText = string.Format("select password from registration where contactno='{0}' and qid={1} and answer='{2}'", contectNo, qId, answer.ToLower());
                sqlCom.Connection = sqlCon;
                sqlCon.Open();
                password = sqlCom.ExecuteScalar() as string;                
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
            return password;
        }
    }
}
