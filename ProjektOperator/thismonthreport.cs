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
    public partial class thismonthreport : Form
    {
        MySqlConnection myConn = new MySqlConnection(connectionclass.myConnection);
        public thismonthreport()
        {
            InitializeComponent();
            monthtext();
            today();
            month();
            released();
            notreleased();
            commonrequest();
            camera();
            barangay();
            incident();
            operators();
        }

        private void monthtext() 
        {
            lbl_title.Text = DateTime.Now.ToString("MMMM") + ("'s Summary Report");
        }
        private void today()
        {
            if (myConn.State == ConnectionState.Open)
            {
                myConn.Close();
            }
            else 
            {
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(caseno) as TOTALTODAY from db_c3blackops.c3_request_form WHERE recordeddate LIKE '%" + DateTime.Now.ToString("MMMM dd yyyy") + "%'", myConn);
                myConn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    show_today.Text = reader["TOTALTODAY"].ToString();
                }
                myConn.Close();
            }
        }
        private void month()
        {
            if (myConn.State == ConnectionState.Open)
            {
                myConn.Close();
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(caseno) as TOTALMONTH from db_c3blackops.c3_request_form WHERE recordeddate LIKE '%" + DateTime.Now.ToString("MMMM") + "%' AND recordeddate LIKE '%"+DateTime.Now.ToString("yyyy")+"%'", myConn);
                myConn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    show_month.Text = reader["TOTALMONTH"].ToString();
                }
                myConn.Close();
            }
        }
        private void released()
        {
            if (myConn.State == ConnectionState.Open)
            {
                myConn.Close();
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(caseno) as TOTALRELEASED from db_c3blackops.c3_request_form WHERE recordeddate LIKE '%" + DateTime.Now.ToString("MMMM") + "%' AND recordeddate LIKE '%"+DateTime.Now.ToString("yyyy")+"%' AND status = 'Released'", myConn);
                myConn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    show_released.Text = reader["TOTALRELEASED"].ToString();
                }
                myConn.Close();
            }
        }
        private void notreleased()
        {
            if (myConn.State == ConnectionState.Open)
            {
                myConn.Close();
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(caseno) as TOTALNOTRELEASED from db_c3blackops.c3_request_form WHERE recordeddate LIKE '%" + DateTime.Now.ToString("MMMM") + "%' AND recordeddate LIKE '%"+DateTime.Now.ToString("yyyy")+"%' AND status = 'Not Released'", myConn);
                myConn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    show_notreleased.Text = reader["TOTALNOTRELEASED"].ToString();
                }
                myConn.Close();
            }
        }
        private void commonrequest()
        {
            if (myConn.State == ConnectionState.Open)
            {
                myConn.Close();
            }
            else 
            {
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(caseno) AS TOTALTYPE, typeofrequest as TYPEOFREQ from db_c3blackops.c3_request_form WHERE recordeddate LIKE '%"+DateTime.Now.ToString("MMMM")+"%' AND recordeddate LIKE '%"+DateTime.Now.ToString("yyyy")+"%' GROUP BY typeofrequest ORDER BY COUNT(typeofrequest) ASC",myConn);
                myConn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) 
                {
                    show_request.Text = reader["TOTALTYPE"].ToString() + "\n" + reader["TYPEOFREQ"].ToString();
                }
                myConn.Close();
            }
        }
        private void camera()
        {
            if (myConn.State == ConnectionState.Open)
            {
                myConn.Close();
            }
            else 
            {
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(caseno) as COUNTCAM, camera as FREQCAMERA from db_c3blackops.c3_request_form WHERE recordeddate LIKE '%"+DateTime.Now.ToString("MMMM")+"%' AND recordeddate LIKE '%"+DateTime.Now.ToString("yyyy")+"%' GROUP BY camera ORDER BY COUNT(camera) ASC",myConn);
                myConn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    show_camera.Text = reader["COUNTCAM"].ToString() + "\n" + reader["FREQCAMERA"].ToString();
                }
                myConn.Close();
            }
        }
        private void barangay()
        {
            if (myConn.State == ConnectionState.Open)
            {
                myConn.Close();
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(caseno) as COUNTBRGY, barangay as FREQBRGY from db_c3blackops.c3_request_form WHERE recordeddate LIKE '%"+DateTime.Now.ToString("MMMM")+"%' AND recordeddate LIKE '%"+DateTime.Now.ToString("yyyy")+"%' GROUP BY barangay ORDER BY COUNT(barangay) ASC",myConn);
                myConn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    show_barangay.Text = reader["COUNTBRGY"].ToString() + "\n" + reader["FREQBRGY"].ToString();
                }
                myConn.Close();
            }
        }
        private void incident()
        {
            if (myConn.State == ConnectionState.Open)
            {
                myConn.Close();
            }
            else 
            {
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(caseno) as COUNTINC, typeofincident as FREQINC from db_c3blackops.c3_request_form WHERE recordeddate LIKE '%" + DateTime.Now.ToString("MMMM")+"%' AND recordeddate LIKE '%"+DateTime.Now.ToString("yyyy")+"%' GROUP BY typeofincident ORDER BY COUNT(typeofincident) ASC",myConn);
                myConn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) 
                {
                    show_incident.Text = reader["COUNTINC"].ToString() + "\n" + reader["FREQINC"].ToString();
                }
                myConn.Close();
            }
        }
        private void operators() 
        {
            if (myConn.State == ConnectionState.Open)
            {
                myConn.Close();
            }
            else 
            {
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(caseno) AS COUNTOP, releasedby as FREQOP from db_c3blackops.c3_request_form WHERE recordeddate LIKE '%" + DateTime.Now.ToString("MMMM")+"%' AND recordeddate LIKE '%"+DateTime.Now.ToString("yyyy")+"%' GROUP by releasedby ORDER BY COUNT(releasedby) ASC",myConn);
                myConn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    show_operator.Text = reader["COUNTOP"].ToString() + "\n" + reader["FREQOP"].ToString();
                }
                myConn.Close();
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            month();
            released();
            notreleased();
            commonrequest();
            camera();
            barangay();
            incident();
            operators();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
