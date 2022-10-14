using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp4
{
    public partial class FrmLogin : Form
    {
        string conStr = @"Data Source= DESKTOP-DH67ULV\SQLEXPRESS;Initial Catalog=SignUp;Integrated Security=true";
        SqlConnection con;
        SqlDataReader dr;
        public FrmLogin()
        {
            InitializeComponent();
            con = new SqlConnection(conStr);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string query = @"SELECT
      [Username]
      ,[Password]
  FROM [dbo].[Tbl_Signup] Where Username='"+TbUsername.Text+"' AND Password='"+TbPassword.Text+"'";
            con.Open();
            SqlCommand cmd=new SqlCommand(query,con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FrmMain frm = new FrmMain();
                con.Close();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password please try again :) ");
            }
        }
    }
}
