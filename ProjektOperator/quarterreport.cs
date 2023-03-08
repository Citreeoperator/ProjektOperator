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
    public partial class quarterreport : Form
    {
        string con1 = "";
        string con2 = "";
        string con3 = "";
        MySqlConnection myConn = new MySqlConnection(connectionclass.myConnection);
        public quarterreport()
        {
            InitializeComponent();
        }

        private void quarterchange()
        {
            lbl_title.Text = cmb_quarter.Text + " of " + cmb_year.Text + " Report";
        }

        private void quarterconditions()
        {
            if (cmb_quarter.Text == "1st Quarter")
            {
                con1 = "January";
                con2 = "February";
                con3 = "March";
            }
            else if (cmb_quarter.Text == "2nd Quarter")
            {
                con1 = "April";
                con2 = "May";
                con3 = "June";
            }
            else if (cmb_quarter.Text == "3rd Quarter")
            {
                con1 = "July";
                con2 = "August";
                con3 = "September";

            }
            else if (cmb_quarter.Text == "4th Quarter")
            {
                con1 = "October";
                con2 = "November";
                con3 = "December";
            }
            else
            {
                //Do nothing
            }
        }

        private void totalcaptured()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(caseno) AS TOTALCAPTURED FROM db_c3blackops.c3_request_form WHERE (recordeddate LIKE '%" + con1 + "%' OR recordeddate LIKE '%" + con2 + "%' OR recordeddate LIKE '%" + con3 + "%') AND recordeddate LIKE '%" + cmb_year.Text + "%' AND outcomeofreq = 'Captured'", myConn);
            myConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                show_captured.Text = reader["TOTALCAPTURED"].ToString();
            }
            myConn.Close();
        }

        private void totalrequest()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(caseno) AS TOTALREQUEST FROM db_c3blackops.c3_request_form WHERE (recordeddate LIKE '%" + con1 + "%' OR recordeddate LIKE '%" + con2 + "%' OR recordeddate LIKE '%" + con3 + "%') AND recordeddate LIKE '%" + cmb_year.Text + "%'", myConn);
            myConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                show_quarter.Text = reader["TOTALREQUEST"].ToString();
            }
            myConn.Close();
        }

        private void totalreleased()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(caseno) AS TOTALRELEASED FROM db_c3blackops.c3_request_form WHERE (recordeddate LIKE '%" + con1 + "%' OR recordeddate LIKE '%" + con2 + "%' OR recordeddate LIKE '%" + con3 + "%') AND recordeddate LIKE '%" + cmb_year.Text + "%' AND status = 'Released'", myConn);
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
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(caseno) AS TOTALNOTRELEASED FROM db_c3blackops.c3_request_form WHERE (recordeddate LIKE '%" + con1 + "%' OR recordeddate LIKE '%" + con2 + "%' OR recordeddate LIKE '%" + con3 + "%') AND recordeddate LIKE '%" + cmb_year.Text + "%' AND status = 'Not Released'", myConn);
            myConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                show_notreleased.Text = reader["TOTALNOTRELEASED"].ToString();
            }
            myConn.Close();
        }

        private void totaltype()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(caseno) AS TOTALTYPE, typeofrequest AS FREQTYPE FROM db_c3blackops.c3_request_form WHERE (recordeddate LIKE '%" + con1 + "%' OR recordeddate LIKE '%" + con2 + "%' OR recordeddate LIKE '%" + con3 + "%') AND recordeddate LIKE '%" + cmb_year.Text + "%' GROUP BY typeofrequest ORDER BY COUNT(typeofrequest) ASC", myConn);
            myConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                show_request.Text = reader["TOTALTYPE"].ToString() + "\n" + reader["FREQTYPE"].ToString();
            }
            myConn.Close();
        }

        private void totalcams()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(caseno) AS TOTALCAMS, camera AS FREQCAMS FROM db_c3blackops.c3_request_form WHERE (recordeddate LIKE '%" + con1 + "%' OR recordeddate LIKE '%" + con2 + "%' OR recordeddate LIKE '%" + con3 + "%') AND recordeddate LIKE '%" + cmb_year.Text + "%' GROUP BY camera ORDER BY COUNT(camera) ASC", myConn);
            myConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                show_camera.Text = reader["TOTALCAMS"].ToString() + "\n" + reader["FREQCAMS"].ToString();
            }
            myConn.Close();
        }

        private void totalbrgy()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(caseno) AS TOTALBRGY, barangay AS FREQBRGY FROM db_c3blackops.c3_request_form WHERE (recordeddate LIKE '%" + con1 + "%' OR recordeddate LIKE '%" + con2 + "%' OR recordeddate LIKE '%" + con3 + "%') AND recordeddate LIKE '%" + cmb_year.Text + "%' GROUP BY barangay ORDER BY COUNT(barangay) ASC", myConn);
            myConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                show_barangay.Text = reader["TOTALBRGY"].ToString() + "\n" + reader["FREQBRGY"].ToString();
            }
            myConn.Close();
        }

        private void totalincident()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(caseno) AS TOTALINCIDENT, typeofincident AS FREQINCIDENT FROM db_c3blackops.c3_request_form WHERE (recordeddate LIKE '%" + con1 + "%' OR recordeddate LIKE '%" + con2 + "%' OR recordeddate LIKE '%" + con3 + "%') AND recordeddate LIKE '%" + cmb_year.Text + "%' GROUP BY typeofincident ORDER BY COUNT(typeofincident) ASC", myConn);
            myConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                show_incident.Text = reader["TOTALINCIDENT"].ToString() + "\n" + reader["FREQINCIDENT"].ToString();
            }
            myConn.Close();
        }

        private void totaloperator()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(caseno) AS TOTALOP, releasedby AS FREQOP FROM db_c3blackops.c3_request_form WHERE (recordeddate LIKE '%" + con1 + "%' OR recordeddate LIKE '%" + con2 + "%' OR recordeddate LIKE '%" + con3 + "%') AND recordeddate LIKE '%" + cmb_year.Text + "%' GROUP BY releasedby ORDER BY COUNT(releasedby)", myConn);
            myConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) 
            {
                show_operator.Text = reader["TOTALOP"].ToString() + "\n" + reader["FREQOP"].ToString();
            }
            myConn.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            quarterconditions();
            if (cmb_quarter.Text == "" || cmb_year.Text == "")
            {
                MessageBox.Show("Please select the Quarter and Year to generate a report.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                quarterchange();
                totalcaptured();
                totalrequest();
                totalreleased();
                totalnotreleased();
                totaltype();
                totalcams();
                totalbrgy();
                totalincident();
                totaloperator();
            }
        }

        private void resetter()
        {
            lbl_title.Text = "Quarterly Report Generator";
            show_captured.Text = "0";
            show_request.Text = "0";
            show_released.Text = "0";
            show_notreleased.Text = "0";
            show_request.Text = "0\nRequest";
            show_camera.Text = "0\nCamera";
            show_barangay.Text = "0\nBarangay";
            show_incident.Text = "0\nIncident";
            show_operator.Text = "0\nOperator";
            cmb_quarter.Text = "";
            cmb_year.Text = "";
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            resetter();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            resetter();
        }
    }
}
