using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CommunityServiceManagement
{
    public class DataAccess
    {
            private SqlConnection sqlcon;
            public SqlConnection Sqlcon
            {
                get { return sqlcon; }
                set { sqlcon = value; }
            }

            private SqlCommand sqlcom;
            public SqlCommand Sqlcom
            {
                get { return sqlcom; }
                set { sqlcom = value; }
            }

            private SqlDataAdapter sda;
            public SqlDataAdapter Sda
            {
                get { return sda; }
                set { sda = value; }
            }

            private DataSet ds;
            public DataSet Ds
            {
                get { return ds; }
                set { ds = value; }
            }

            //internal DataTable dt;

            public DataAccess()
            {
                
                this.Sqlcon = new SqlConnection(@"Data Source=LAPTOP-J24A8ACI\SQLEXPRESS;Initial Catalog=CommunityServiceManagement;Integrated Security=True");
                 Sqlcon.Open();
            }

            private void QueryText(string query)
            {
                this.Sqlcom = new SqlCommand(query, this.Sqlcon);
            }

            public DataSet ExecuteQuery(string sql)
            {
                this.QueryText(sql);
                this.Sda = new SqlDataAdapter(this.Sqlcom);
                this.Ds = new DataSet();
                this.Sda.Fill(this.Ds);
                return Ds;
            }

            public int ExecuteUpdateQuery(string sql)
            {
                this.QueryText(sql);
                int u = this.Sqlcom.ExecuteNonQuery();
                return u;
            }
        
    }
}


