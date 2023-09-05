using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace weekthree
{
    public class database
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=week3;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

        public void save(string fullname, string email, string phone, string message)
        {
            con.Open();
                SqlCommand cmd = new SqlCommand("insert into tblweb values ('" + fullname + "','" + email + "','" + phone + "','" + message + "')", con);
                cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}