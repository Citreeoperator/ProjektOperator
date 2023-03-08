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
    public partial class monthlyreport : Form
    {
        MySqlConnection myConn = new MySqlConnection(connectionclass.myConnection);
        public monthlyreport()
        {
            InitializeComponent();
        }

        private void monthchanger()
        {
            lbl_title.Text = cmb_month.Text + " of " + cmb_year.Text + " Report";
        }

        private void capturedmonth()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(caseno) AS TOTALCAPTURED FROM db_c3blackops.c3_request_form WHERE recordeddate LIKE '%" + cmb_month.Text + "%' AND recordeddate LIKE '%" + cmb_year.Text +"%' AND outcomeofreq = 'Captured'", myConn);
            myConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) 
            {
                show_captured.Text = reader["TOTALCAPTURED"].ToString();
            }
            myConn.Close();
        }

        private void totalmonth()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(caseno) AS TOTALMONTH FROM db_c3blackops.c3_request_form WHERE recordeddate LIKE '%" + cmb_month.Text + "%' AND recordeddate LIKE '%" + cmb_year.Text + "%'", myConn);
            myConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                {
                show_month.Text = reader["TOTALMONTH"].ToString();
            }
            myConn.Close();
        }

        private void totalreleased()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(caseno) AS TOTALRELEASED FROM db_c3blackops.c3_request_form WHERE recordeddate LIKE '%" + cmb_month.Text + "%' AND recordeddate LIKE '%" + cmb_year.Text + "%' AND status = 'Released'", myConn);
            myConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                {
                show_released.Text = reader["TOTALRELEASED"].ToString();
            }
            myConn.Close();
        }

        private void totalnotreleased()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(caseno) AS TOTALNOTRELEASED from db_c3blackops.c3_request_form WHERE recordeddate LIKE '%" + cmb_month.Text + "%' AND recordeddate LIKE '%" + cmb_year.Text + "%' AND status = 'Not Released'", myConn);
            myConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {    
                show_notreleased.Text = reader["TOTALNOTRELEASED"].ToString();
            }
            myConn.Close();
        }
        private void commontype()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(caseno) AS TOTALTYPE, typeofrequest AS FREQTYPE FROM db_c3blackops.c3_request_form WHERE recordeddate LIKE '%" + cmb_month.Text + "%' AND recordeddate LIKE '%" + cmb_year.Text + "%' GROUP BY typeofrequest ORDER BY COUNT(typeofrequest) ASC", myConn);
            myConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                show_request.Text = reader["TOTALTYPE"].ToString() + "\n" + reader["FREQTYPE"].ToString();
            }
            myConn.Close();
        }

        private void commoncamera()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(caseno) AS TOTALCAMERA, camera as FREQCAMERA FROM db_c3blackops.c3_request_form WHERE recordeddate LIKE '%" + cmb_month.Text + "%' AND recordeddate LIKE '%" + cmb_year.Text + "%' GROUP BY camera ORDER BY COUNT(camera) ASC", myConn);
            myConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                show_camera.Text = reader["TOTALCAMERA"].ToString() + "\n" + reader["FREQCAMERA"].ToString();
            }
            myConn.Close();
        }

        private void barangay()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(caseno) AS TOTALBARANGAY, barangay as FREQBARANGAY FROM db_c3blackops.c3_request_form WHERE recordeddate LIKE '%" + cmb_month.Text + "%' AND recordeddate LIKE '%" + cmb_year.Text + "%' GROUP BY barangay ORDER BY COUNT(barangay) ASC", myConn);
            myConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                show_barangay.Text = reader["TOTALBARANGAY"].ToString() + "\n" + reader["FREQBARANGAY"].ToString();
            }
            myConn.Close();
        }

        private void incident()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(caseno) AS TOTALINCIDENT, typeofincident AS FREQINCIDENT FROM db_c3blackops.c3_request_form WHERE recordeddate LIKE '%" + cmb_month.Text + "%' AND recordeddate LIKE '%" + cmb_year.Text + "%' GROUP BY typeofincident ORDER BY COUNT(typeofincident) ASC", myConn);
            myConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                show_incident.Text = reader["TOTALINCIDENT"].ToString() + "\n" + reader["FREQINCIDENT"].ToString();
            }
            myConn.Close();
        }

        private void commonoperator()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(caseno) AS TOTALOPERATOR, releasedby AS FREQOPERATOR FROM db_c3blackops.c3_request_form WHERE recordeddate LIKE '%" + cmb_month.Text + "%' AND recordeddate LIKE '%" + cmb_year.Text + "%' GROUP BY releasedby ORDER BY COUNT(releasedby) ASC", myConn);
            myConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                show_operator.Text = reader["TOTALOPERATOR"].ToString() + "\n" + reader["FREQOPERATOR"].ToString();
            }
            myConn.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (cmb_month.Text == "" && cmb_year.Text == "")
            {
                MessageBox.Show("Please select a month and year to generate a report.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                monthchanger();
                capturedmonth();
                totalmonth();
                totalreleased();
                totalnotreleased();
                commontype();
                commoncamera();
                barangay();
                incident();
                commonoperator();
            }
        }
    }
}
