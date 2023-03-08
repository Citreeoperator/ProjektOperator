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
    public partial class cctvrequestform : Form
    {
        //All Strings
        string typeofrequest;
        string outcomerequest;
        string statusrequest;

        public cctvrequestform()
        {
            InitializeComponent();
            btn_edit.Enabled = false;
            btn_delete.Enabled = false;
            txt_additional.TextChanged += new EventHandler(txt_additional_TextChanged);
            txt_remarks.TextChanged += new EventHandler(txt_remarks_TextChanged);
            uppercasesystem();
        }

        public void dateformat()
        {
            picker_dateofincident.Format = DateTimePickerFormat.Custom;
            picker_dateofincident.CustomFormat = "MMMM dd yyyy";

            picker_recorded.Format = DateTimePickerFormat.Custom;
            picker_recorded.CustomFormat = "MMMM dd yyyy";
        }

        public void typeofrequestcondition()
        {
            if (check_video.Checked == true && check_screenshot.Checked == true && check_viewing.Checked == true)
            {
                typeofrequest = "Video, Screenshot, Viewing";
            }
            else if (check_video.Checked == true && check_screenshot.Checked == true)
            {
                typeofrequest = "Video, Screenshot";
            }
            else if (check_video.Checked == true && check_viewing.Checked == true)
            {
                typeofrequest = "Video, Viewing";
            }
            else if (check_screenshot.Checked == true && check_viewing.Checked == true)
            {
                typeofrequest = "Screenshot, Viewing";
            }
            else if (check_video.Checked == true)
            {
                typeofrequest = "Video";
            }
            else if (check_screenshot.Checked == true)
            {
                typeofrequest = "Screenshot";
            }
            else if (check_viewing.Checked == true)
            {
                typeofrequest = "Viewing";
            }
        }

        public void outcomerequestcondition()
        {
            if (radio_captured.Checked == true)
            {
                outcomerequest = "Captured";
            }
            else if (radio_notcaptured.Checked == true)
            {
                outcomerequest = "Not Captured";
            }
        }

        public void statusrequestcondition()
        {
            if (radio_released.Checked == true)
            {
                statusrequest = "Released";
            }
            else if (radio_notreleased.Checked == true)
            {
                statusrequest = "Not Released";
            }
            else if (radio_cancelled.Checked == true)
            {
                statusrequest = "Cancelled";
            }
        }
        public void conditionalbranches()
        {
            if (typeofrequest == "Video, Screenshot, Viewing")
            {
                check_video.Checked = true;
                check_screenshot.Checked = true;
                check_viewing.Checked = true;
            }
            else if (typeofrequest == "Video, Screenshot")
            {
                check_video.Checked = true;
                check_screenshot.Checked = true;
                check_viewing.Checked = false;
            }
            else if (typeofrequest == "Video, Viewing")
            {
                check_video.Checked = true;
                check_screenshot.Checked = false;
                check_viewing.Checked = true;
            }
            else if (typeofrequest == "Screenshot, Viewing")
            {
                check_video.Checked = false;
                check_screenshot.Checked = true;
                check_viewing.Checked = true;
            }
            else if (typeofrequest == "Video")
            {
                check_video.Checked = true;
                check_screenshot.Checked = false;
                check_viewing.Checked = false;
            }
            else if (typeofrequest == "Screenshot")
            {
                check_video.Checked = false;
                check_screenshot.Checked = true;
                check_viewing.Checked = false;
            }
            else if (typeofrequest == "Viewing")
            {
                check_video.Checked = false;
                check_screenshot.Checked = false;
                check_viewing.Checked = true;
            }
            else
            {
                //Do nothing
            }

            if (outcomerequest == "Captured")
            {
                radio_captured.Checked = true;
                radio_notcaptured.Checked = false;
            }
            else if (outcomerequest == "Not Captured")
            {
                radio_captured.Checked = false;
                radio_notcaptured.Checked = true;
            }
            else
            {
                //Do nothing
            }

            if (statusrequest == "Released")
            {
                radio_released.Checked = true;
                radio_notreleased.Checked = false;
                radio_cancelled.Checked = false;
            }
            else if (statusrequest == "Not Released")
            {
                radio_released.Checked = false;
                radio_notreleased.Checked = true;
                radio_cancelled.Checked = false;
            }
            else if (statusrequest == "Cancelled")
            {
                radio_released.Checked = false;
                radio_notreleased.Checked = false;
                radio_cancelled.Checked = true;
            }
            else
            {
                //Do nothing
            }
        }
        private void uppercasesystem()
        {
            txt_lname.CharacterCasing = CharacterCasing.Upper;
            txt_fname.CharacterCasing = CharacterCasing.Upper;
            txt_officeorg.CharacterCasing = CharacterCasing.Upper;
            txt_address.CharacterCasing = CharacterCasing.Upper;
            txt_contactno.CharacterCasing = CharacterCasing.Upper;
            txt_email.CharacterCasing = CharacterCasing.Upper;
            txt_timeofincident.CharacterCasing = CharacterCasing.Upper;
            txt_location.CharacterCasing = CharacterCasing.Upper;
            txt_accompanied.CharacterCasing = CharacterCasing.Upper;
        }

        private void txt_additional_TextChanged(object sender, EventArgs e)
        {
            lbl_character10k.Text = "Characters Remaining: " + (10000 - txt_additional.Text.Length).ToString();
        }

        private void txt_remarks_TextChanged(object sender, EventArgs e)
        {
            lbl_characters5k.Text = "Characters Remaining: " + (5000 - txt_remarks.Text.Length).ToString();
        }

        private void formresetter()
        {
            txt_lname.Clear();
            txt_fname.Clear();
            txt_officeorg.Clear();
            txt_address.Clear();
            txt_contactno.Clear();
            txt_email.Clear();
            txt_timeofincident.Clear();
            txt_location.Clear();
            txt_accompanied.Clear();
            txt_additional.Clear();
            txt_remarks.Clear();
            picker_dateofincident.Value = DateTime.Now;
            picker_recorded.Value = DateTime.Now;
            drop_typeofincident.SelectedIndex = -1;
            drop_brgy.SelectedIndex = -1;
            drop_camera.SelectedIndex = -1;
            drop_released.SelectedIndex = -1;
            check_video.Checked = false;
            check_screenshot.Checked = false;
            check_viewing.Checked = false;
            radio_captured.Checked = false;
            radio_notcaptured.Checked = false;
            radio_released.Checked = false;
            radio_notreleased.Checked = false;
            radio_cancelled.Checked = false;
            txt_lname.Focus();
            txt_searchbox.Text = "";
            info_caseno.Text = "####";
        }
        private void SearchData(string search)
        {
            MySqlConnection myConn = new MySqlConnection(connectionclass.myConnection);
            try
            {
                myConn.Open();
                String searchsql = "SELECT * FROM db_c3blackops.c3_request_form WHERE caseno = '" + search + "'";
                MySqlCommand cmd = new MySqlCommand(searchsql, myConn);
                MySqlDataReader myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    conditionalbranches();
                    picker_recorded.Text = myReader.GetString("recordeddate");
                    txt_lname.Text = myReader.GetString("lname");
                    txt_fname.Text = myReader.GetString("fname");
                    txt_officeorg.Text = myReader.GetString("officeorg");
                    txt_address.Text = myReader.GetString("address_r");
                    txt_contactno.Text = myReader.GetString("contactno");
                    txt_email.Text = myReader.GetString("emailadd");
                    picker_dateofincident.Text = myReader.GetString("dateofincident");
                    txt_timeofincident.Text = myReader.GetString("timeofincident");
                    drop_typeofincident.Text = myReader.GetString("typeofincident");
                    txt_location.Text = myReader.GetString("locationofincident");
                    drop_brgy.Text = myReader.GetString("barangay");
                    drop_camera.Text = myReader.GetString("camera");
                    txt_accompanied.Text = myReader.GetString("accompaniedby");
                    typeofrequest = myReader.GetString("typeofrequest");
                    outcomerequest = myReader.GetString("outcomeofreq");
                    txt_additional.Text = myReader.GetString("additionalinfo");
                    txt_remarks.Text = myReader.GetString("remarks");
                    drop_released.Text = myReader.GetString("releasedby");
                    statusrequest = myReader.GetString("status");
                    info_caseno.Text = myReader.GetString("caseno");
                }
                myReader.Close();
                myConn.Close();
                if (txt_lname.Text == "")
                {
                    MessageBox.Show("No record found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_lname.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nPlease try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SearchData(txt_searchbox.Text);
            if (txt_searchbox.Text == "")
            {
                MessageBox.Show("Please enter a case number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SearchData(txt_searchbox.Text);
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            DateTime dt = picker_dateofincident.Value;
            DateTime gt = picker_recorded.Value;
            typeofrequestcondition();
            outcomerequestcondition();
            statusrequestcondition();

            if (string.IsNullOrWhiteSpace(txt_lname.Text) ||
                string.IsNullOrWhiteSpace(txt_fname.Text) ||
                string.IsNullOrWhiteSpace(txt_address.Text) ||
                string.IsNullOrWhiteSpace(txt_contactno.Text) ||
                string.IsNullOrWhiteSpace(txt_timeofincident.Text) ||
                string.IsNullOrWhiteSpace(txt_timeofincident.Text) ||
                string.IsNullOrWhiteSpace(txt_accompanied.Text))
            {
                MessageBox.Show("Please fill up all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(drop_typeofincident.Text))
            {
                MessageBox.Show("Please select the type of incident", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(drop_brgy.Text))
            {
                MessageBox.Show("Please select the barangay", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(drop_camera.Text))
            {
                MessageBox.Show("Please select the camera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txt_additional.Text))
            {
                MessageBox.Show("Please provide an additional information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (check_video.Checked == false
                && check_screenshot.Checked == false
                && check_viewing.Checked == false)
            {
                MessageBox.Show("Please select the type of request", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (radio_captured.Checked == false
                && radio_notcaptured.Checked == false)
            {
                MessageBox.Show("Please select the outcome of request", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(drop_released.Text))
            {
                MessageBox.Show("Please select the CCTV Operator who reviewed the request", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (radio_released.Checked == false
                && radio_notreleased.Checked == false
                && radio_cancelled.Checked == false)
            {
                MessageBox.Show("Please select the status of the request", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MySqlConnection myConn = new MySqlConnection(connectionclass.myConnection);
                string strquery = "INSERT INTO db_c3blackops.c3_request_form (recordeddate, lname, fname, officeorg, address_r, contactno, emailadd, dateofincident, timeofincident, typeofincident, locationofincident, barangay, camera, accompaniedby, typeofrequest, outcomeofreq, additionalinfo, remarks, releasedby, status) VALUES ('" + gt.ToString("MMMM dd yyyy") + "', '" + txt_lname.Text + "', '" + txt_fname.Text + "', '" + txt_officeorg.Text + "', '" + txt_address.Text + "', '" + txt_contactno.Text + "', '" + txt_email.Text + "', '" + dt.ToString("MMMM dd yyyy") + "', '" + txt_timeofincident.Text + "', '" + drop_typeofincident.Text + "', '" + txt_location.Text + "', '" + drop_brgy.Text + "', '" + drop_camera.Text + "', '" + txt_accompanied.Text + "', '" + typeofrequest + "', '" + outcomerequest + "', '" + txt_additional.Text + "', '" + txt_remarks.Text + "', '" + drop_released.Text + "', '" + statusrequest + "')";
                MySqlCommand cmd = new MySqlCommand(strquery, myConn);
                MySqlDataReader myReader;
                try
                {
                    myConn.Open();
                    myReader = cmd.ExecuteReader();
                    MessageBox.Show("CCTV Request Form has been submitted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    formresetter();
                    myReader.Close();
                    myConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nPlease try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            DateTime dt = picker_dateofincident.Value;
            DateTime gt = picker_recorded.Value;
            typeofrequestcondition();
            outcomerequestcondition();
            statusrequestcondition();

            try
            {
                MySqlConnection myConn = new MySqlConnection(connectionclass.myConnection);
                myConn.Open();

                using (MySqlCommand cmd = new MySqlCommand("UPDATE db_c3blackops.c3_request_form SET recordeddate = @recordeddate, lname = @lname, fname = @fname, officeorg = @officeorg, address_r = @address_r, contactno = @contactno, emailadd = @emailadd, dateofincident = @dateofincident, timeofincident = @timeofincident, typeofincident = @typeofincident, locationofincident = @locationofincident, barangay = @barangay, camera = @camera, accompaniedby = @accompaniedby, typeofrequest = @typeofrequest, outcomeofreq = @outcomeofreq, additionalinfo = @additionalinfo, remarks = @remarks, releasedby = @releasedby, status = @status WHERE caseno = @caseno", myConn))
                {
                    cmd.Parameters.AddWithValue("@recordeddate", gt.ToString("MMMM dd yyyy"));
                    cmd.Parameters.AddWithValue("@lname", txt_lname.Text);
                    cmd.Parameters.AddWithValue("@fname", txt_fname.Text);
                    cmd.Parameters.AddWithValue("@officeorg", txt_officeorg.Text);
                    cmd.Parameters.AddWithValue("@address_r", txt_address.Text);
                    cmd.Parameters.AddWithValue("@contactno", txt_contactno.Text);
                    cmd.Parameters.AddWithValue("@emailadd", txt_email.Text);
                    cmd.Parameters.AddWithValue("@dateofincident", dt.ToString("MMMM dd yyyy"));
                    cmd.Parameters.AddWithValue("@timeofincident", txt_timeofincident.Text);
                    cmd.Parameters.AddWithValue("@typeofincident", drop_typeofincident.Text);
                    cmd.Parameters.AddWithValue("@locationofincident", txt_location.Text);
                    cmd.Parameters.AddWithValue("@barangay", drop_brgy.Text);
                    cmd.Parameters.AddWithValue("@camera", drop_camera.Text);
                    cmd.Parameters.AddWithValue("@accompaniedby", txt_accompanied.Text);
                    cmd.Parameters.AddWithValue("@typeofrequest", typeofrequest);
                    cmd.Parameters.AddWithValue("@outcomeofreq", outcomerequest);
                    cmd.Parameters.AddWithValue("@additionalinfo", txt_additional.Text);
                    cmd.Parameters.AddWithValue("@remarks", txt_remarks.Text);
                    cmd.Parameters.AddWithValue("@releasedby", drop_released.Text);
                    cmd.Parameters.AddWithValue("@status", statusrequest);
                    cmd.Parameters.AddWithValue("@caseno", Convert.ToInt32(txt_searchbox.Text));
                    cmd.ExecuteNonQuery();
                    myConn.Close();
                    MessageBox.Show("Data Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    formresetter();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nPlease try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConn = new MySqlConnection(connectionclass.myConnection);
                myConn.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM db_c3blackops.c3_request_form WHERE caseno = '" + txt_searchbox.Text + "'", myConn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formresetter();

                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nPlease try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_searchbox_TextChanged(object sender, EventArgs e)
        {
            if (txt_searchbox.Text == "")
            {
                btn_delete.Enabled = false;
                btn_edit.Enabled = false;
                btn_submit.Enabled = true;
            }
            else
            {
                btn_delete.Enabled = true;
                btn_edit.Enabled = true;
                btn_submit.Enabled = false;
            }
            txt_lname.Clear();
            txt_fname.Clear();
            txt_officeorg.Clear();
            txt_address.Clear();
            txt_contactno.Clear();
            txt_email.Clear();
            txt_timeofincident.Clear();
            txt_location.Clear();
            txt_accompanied.Clear();
            txt_additional.Clear();
            txt_remarks.Clear();
            picker_dateofincident.Value = DateTime.Now;
            drop_typeofincident.SelectedIndex = -1;
            drop_brgy.SelectedIndex = -1;
            drop_camera.SelectedIndex = -1;
            drop_released.SelectedIndex = -1;
            check_video.Checked = false;
            check_screenshot.Checked = false;
            check_viewing.Checked = false;
            radio_captured.Checked = false;
            radio_notcaptured.Checked = false;
            radio_released.Checked = false;
            radio_notreleased.Checked = false;
            radio_cancelled.Checked = false;
            info_caseno.Text = "####";
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to reset the form?", "Reset Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                formresetter();
            }
            else if (dialogResult == DialogResult.No)
            {
                //Do nothing
            }
        }
    }
}
