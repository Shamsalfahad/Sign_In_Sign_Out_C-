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
    public partial class FromsignUp : Form
    {
        string conStr = @"Data Source= DESKTOP-DH67ULV\SQLEXPRESS;Initial Catalog=SignUp;Integrated Security=true";
        SqlConnection con;
        public FromsignUp()
        {
            InitializeComponent();
            con = new SqlConnection(conStr);
        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO [dbo].[Tbl_Signup]
           ([Username]
           ,[Password])
     VALUES
           ('"+TbUsername.Text+"','"+TbPassword+"')";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted");
            con.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLogin frm= new FrmLogin();
            con.Close();
            frm.Show();
        }
    }
}
