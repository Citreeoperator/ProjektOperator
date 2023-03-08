using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjektOperator
{
    public partial class login : Form
    {
        internal static bool loggedIn = false;

        public login()
        {
            InitializeComponent();
            copyrightchecker();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(connectionclass.myConnection);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM logininformation WHERE infousername = '" + this.txt_username.Text + "' AND infopassword= '" + this.txt_password.Text + "';", myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = cmd.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    loggedIn = true;
                    loading loadingform = new loading();
                    loadingform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username and password is not correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_username.Text = "";
                    txt_password.Text = "";
                    txt_username.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void copyrightchecker()
        {
            lbl_copyright.Text = "© " + DateTime.Now.Year.ToString() + " C3 - Project Operator - " + Application.ProductVersion + " - SkyeTech - All Rights Reserved.";
        }
    }
}
