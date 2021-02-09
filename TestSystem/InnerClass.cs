using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace TestSystem
{
    public class InnerClass
    {
        private string constring = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
         public string insert_record(Questions q)
        {
            string msq = " ";
            SqlConnection conn = new SqlConnection(constring);
            try
            {
                SqlCommand cmd = new SqlCommand("[Insert_Questions]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@q_title", SqlDbType.NVarChar).Value = q.q_title;
                cmd.Parameters.Add("@q_opa", SqlDbType.NVarChar, 200).Value = q.q_opa;
                cmd.Parameters.Add("@q_opb", SqlDbType.NVarChar, 200).Value = q.q_opb;
                cmd.Parameters.Add("@q_opc", SqlDbType.NVarChar, 200).Value = q.q_opc;
                cmd.Parameters.Add("@q_opcorrect", SqlDbType.NVarChar, 200).Value = q.q_opcorrect;
                cmd.Parameters.Add("@q_fk_ex", SqlDbType.Int).Value = q.q_fk_ex;




                conn.Open();
                cmd.ExecuteNonQuery();
                msq = "data successfully inserted";
                 

            }
            catch(Exception)
            {
                msq = "data is not succcessfully inserted";
            }
            finally
            {
                conn.Close();
            }
            return msq;
        }
    }
}
