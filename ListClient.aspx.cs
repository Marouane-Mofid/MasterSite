using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace MasterSite
{
    public partial class ListClient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            charger();
        }

        private void charger()
        {
            string chaine ="";
            string sql = "select* from client";
            SqlConnection con = new SqlConnection(chaine);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql,con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable t = new DataTable();
            t.Load(dr);
            GridView1.DataSource = t;
            GridView1.DataBind();
            con.Close();
        }
    }
}