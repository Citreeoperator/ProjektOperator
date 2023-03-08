using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektOperator
{
    public partial class cctvdatabase : Form
    {
        string conditionfilter = "";
        public cctvdatabase()
        {
            InitializeComponent();
            DisplayValue();
        }

        private void DisplayValue()
        {
            MySqlConnection myConn = new MySqlConnection(connectionclass.myConnection);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM db_c3blackops.c3_request_form GROUP BY caseno DESC", myConn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridReports.DataSource = dt;
            dataGridReports.Update();
            dataGridReports.Refresh();
        }

        private void cctvdatabase_Load(object sender, EventArgs e)
        {
            DisplayValue();
            txt_search.Text = "";
            drop_searchfilter.Text = "";
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            dataGridReports.Update();
            dataGridReports.Refresh();
        }

        private void conditionsearch()
        {
            if (drop_searchfilter.Text == "Case Number")
            {
                conditionfilter = "caseno";
            }
            else if (drop_searchfilter.Text == "Recorded Date")
            {
                conditionfilter = "recordeddate";
            }
            else if (drop_searchfilter.Text == "First Name")
            {
                conditionfilter = "fname";
            }
            else if (drop_searchfilter.Text == "Last Name")
            {
                conditionfilter = "lname";
            }
            else if (drop_searchfilter.Text == "Address")
            {
                conditionfilter = "address_r";
            }
            else if (drop_searchfilter.Text == "Date of Incident")
            {
                conditionfilter = "dateofincident";
            }
            else if (drop_searchfilter.Text == "Type of Incident")
            {
                conditionfilter = "typeofincident";
            }
            else if (drop_searchfilter.Text == "Barangay")
            {
                conditionfilter = "barangay";
            }
            else if (drop_searchfilter.Text == "Camera")
            {
                conditionfilter = "camera";
            }
            else if (drop_searchfilter.Text == "Accompanied by")
            {
                conditionfilter = "accompaniedby";
            }
            else if (drop_searchfilter.Text == "Type of Request")
            {
                conditionfilter = "typeofrequest";
            }
            else if (drop_searchfilter.Text == "Outcome of the Request")
            {
                conditionfilter = "outcomeofreq";
            }
            else if (drop_searchfilter.Text == "Released by")
            {
                conditionfilter = "releasedby";
            }
            else if (drop_searchfilter.Text == "Status")
            {
                conditionfilter = "status";
            }
            else 
            {
                //do nothing
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            conditionsearch();
            if (drop_searchfilter.Text == "" && txt_search.Text == "")
            {
                MessageBox.Show("Please select a filter and enter a search keyword", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    MySqlConnection myConn = new MySqlConnection(connectionclass.myConnection);
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM db_c3blackops.c3_request_form WHERE " + conditionfilter + " LIKE '%" + txt_search.Text + "%' ", myConn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridReports.DataSource = dt;
                    dataGridReports.Update();
                    dataGridReports.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nPlease try again." + " If the problem persists, please contact your system administrator.");
                }
            }
        }
    }
}
