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
    public partial class atimonanendorsement : Form
    {
        string s1 = "\n\n- Monitoring of CCTV Live Footages and CCTV Recording Footages" +
                    "\n- Operating and Maintaining CCTV and C3 Equipments" +
                    "\n- Maintaining Reviewed Footages logs ";

        string s2 = "\n- Update PDRRMO SITREP" +
            "\n- Posted a newly updated weather forecast on the MDDRMO Atimonan Facebook page" +
            "\n- Updated the PAGASA Weather forecast loop";

        public atimonanendorsement()
        {
            InitializeComponent();
            radio_no.Checked = true;
            radio_ir_no.Checked = true;
            radio_cctv_no.Checked = true;
        }

        private void btn_headergenerate_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour < 12)
            {
                previewbox_generate.Text = "Good Morning!\n" +
                    "Endorsement of Duties, Accomplishments and Reports to Outgoing to the Incoming C3 Operators from " + DateTime.Now.AddDays(-1).ToString("MMMM dd, yyyy") + " 0800H to " + DateTime.Now.ToString("MMMM dd, yyyy") + " 0800H" + s1;
            }
            else
            {
                previewbox_generate.Text = "Good Evening!\n" +
                    "Endorsement of Duties, Accomplishments and Reports to Outgoing to the Incoming C3 Operators from " + DateTime.Now.ToString("MMMM dd, yyyy") + " 0800H to " + DateTime.Now.ToString("MMMM dd, yyyy") + " 0800H" + s1;
            }
        }

        private void check_mon1_CheckedChanged(object sender, EventArgs e)
        {
            if (check_mon1.Checked == true)
            {
                txt_mon1.Enabled = false;
                txt_mon1.Text = "No blackouts";
            }
            else
            {
                txt_mon1.Enabled = true;
                txt_mon1.Text = "";
            }
        }

        private void check_mon2_CheckedChanged(object sender, EventArgs e)
        {
            if (check_mon2.Checked == true)
            {
                txt_mon2.Enabled = false;
                txt_mon2.Text = "No blackouts";
            }
            else
            {
                txt_mon2.Enabled = true;
                txt_mon2.Text = "";

            }
        }

        private void check_mon3_CheckedChanged(object sender, EventArgs e)
        {
            if (check_mon3.Checked == true)
            {
                txt_mon3.Enabled = false;
                txt_mon3.Text = "No blackouts";
            }
            else
            {
                txt_mon3.Enabled = true;
                txt_mon3.Text = "";
            }
        }

        private void check_mon4_CheckedChanged(object sender, EventArgs e)
        {
            if (check_mon4.Checked == true)
            {
                txt_mon4.Enabled = false;
                txt_mon4.Text = "No blackouts";
            }
            else
            {
                txt_mon4.Enabled = true;
                txt_mon4.Text = "";
            }
        }

        private void check_mon5_CheckedChanged(object sender, EventArgs e)
        {
            if (check_mon5.Checked == true)
            {
                txt_mon5.Enabled = false;
                txt_mon5.Text = "No blackouts";
            }
            else
            {
                txt_mon5.Enabled = true;
                txt_mon5.Text = "";
            }
        }

        private void check_mon6_CheckedChanged(object sender, EventArgs e)
        {
            if (check_mon6.Checked == true)
            {
                txt_mon6.Enabled = false;
                txt_mon6.Text = "No blackouts";
            }
            else
            {
                txt_mon6.Enabled = true;
                txt_mon6.Text = "";
            }
        }

        private void check_mon7_CheckedChanged(object sender, EventArgs e)
        {
            if (check_mon7.Checked == true)
            {
                txt_mon7.Enabled = false;
                txt_mon7.Text = "No blackouts";
            }
            else
            {
                txt_mon7.Enabled = true;
                txt_mon7.Text = "";
            }
        }

        private void check_mon8_CheckedChanged(object sender, EventArgs e)
        {
            if (check_mon8.Checked == true)
            {
                txt_mon8.Enabled = false;
                txt_mon8.Text = "No blackouts";
            }
            else
            {
                txt_mon8.Enabled = true;
                txt_mon8.Text = "";
            }
        }



        private void radio_no_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_no.Checked == true)
            {
                txt_mon1.Enabled = false;
                check_mon1.Checked = true;
                txt_mon2.Enabled = false;
                check_mon2.Checked = true;
                txt_mon3.Enabled = false;
                check_mon3.Checked = true;
                txt_mon4.Enabled = false;
                check_mon4.Checked = true;
                txt_mon5.Enabled = false;
                check_mon5.Checked = true;
                txt_mon6.Enabled = false;
                check_mon6.Checked = true;
                txt_mon7.Enabled = false;
                check_mon7.Checked = true;
                txt_mon8.Enabled = false;
                check_mon8.Checked = true;
            }
            else
            {
                txt_mon1.Enabled = true;
                check_mon1.Checked = false;
                txt_mon2.Enabled = true;
                check_mon2.Checked = false;
                txt_mon3.Enabled = true;
                check_mon3.Checked = false;
                txt_mon4.Enabled = true;
                check_mon4.Checked = false;
                txt_mon5.Enabled = true;
                check_mon5.Checked = false;
                txt_mon6.Enabled = true;
                check_mon6.Checked = false;
                txt_mon7.Enabled = true;
                check_mon7.Checked = false;
                txt_mon8.Enabled = true;
                check_mon8.Checked = false;

            }
        }

        private void btn_addcam_Click(object sender, EventArgs e)
        {
            previewbox_generate.Text = previewbox_generate.Text + "\n\nOffline Cameras - Camera Status:"
              + "\n Monitor 1: " + txt_mon1.Text + " Cameras" 
              + "\n Monitor 2: " + txt_mon2.Text + " Cameras" 
              + "\n Monitor 3: " + txt_mon3.Text + " Cameras" 
              + "\n Monitor 4: " + txt_mon4.Text + " Cameras" 
              + "\n Monitor 5: " + txt_mon5.Text + " Cameras" 
              + "\n Monitor 6: " + txt_mon6.Text + " Cameras"
              + "\n Monitor 7: " + txt_mon7.Text + " Cameras"
              + "\n Monitor 8: " + txt_mon8.Text + " Cameras";
            btn_addcam.Enabled = false;
        }

        private void txt_mon1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_mon1.Text))
            {
                check_mon1.Enabled = true;
            }
            else
            {
                check_mon1.Enabled = false;
            }
        }

        private void txt_mon2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_mon2.Text))
            {
                check_mon2.Enabled = true;
            }
            else
            {
                check_mon2.Enabled = false;
            }
        }

        private void txt_mon3_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_mon3.Text))
            {
                check_mon3.Enabled = true;
            }
            else
            {
                check_mon3.Enabled = false;
            }
        }

        private void txt_mon4_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_mon4.Text))
            {
                check_mon4.Enabled = true;
            }
            else
            {
                check_mon4.Enabled = false;
            }
        }

        private void txt_mon5_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_mon5.Text))
            {
                check_mon5.Enabled = true;
            }
            else
            {
                check_mon5.Enabled = false;
            }
        }

        private void txt_mon6_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_mon6.Text))
            {
                check_mon6.Enabled = true;
            }
            else
            {
                check_mon6.Enabled = false;
            }
        }

        private void txt_mon7_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_mon7.Text))
            {
                check_mon7.Enabled = true;
            }
            else
            {
                check_mon7.Enabled = false;
            }
        }

        private void txt_mon8_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_mon8.Text))
            {
                check_mon8.Enabled = true;
            }
            else
            {
                check_mon8.Enabled = false;
            }
        }



        private void radio_ir_no_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_ir_no.Checked == true)
            {
                txt_ir_what.Enabled = false;
                txt_ir_when.Enabled = false;
                txt_ir_where.Enabled = false;
                txt_ir_involve.Enabled = false;
                txt_ir_add.Enabled = false;
            }
            else
            {
                txt_ir_what.Enabled = true;
                txt_ir_when.Enabled = true;
                txt_ir_where.Enabled = true;
                txt_ir_involve.Enabled = true;
                txt_ir_add.Enabled = true;
            }
        }

        private void btn_ir_add_Click(object sender, EventArgs e)
        {
            if (radio_ir_yes.Checked == true)
            {
                previewbox_generate.Text = previewbox_generate.Text + "\n\nIncident Report: " +
                    "\nWhat: " + txt_ir_what.Text + 
                    "\nWhen: " + txt_ir_when.Text + 
                    "\nWhere: " + txt_ir_where.Text + 
                    "\nInvolved: " + txt_ir_involve.Text + 
                    "\nAdditional Info: " + txt_ir_add.Text;
            }
            else
            {
                previewbox_generate.Text = previewbox_generate.Text + "\n\nIncident Report: No reported incidents during the shift.";
            }
        }

        private void radio_cctv_no_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_cctv_no.Checked == true)
            {
                txt_cctv_req.Enabled = false;
                txt_cctv_accompanied.Enabled = false;
                txt_cctv_concern.Enabled = false;
                txt_cctv_type.Enabled = false;
                txt_cctv_location.Enabled = false;
                txt_cctv_when.Enabled = false;
                txt_cctv_add.Enabled = false;
            }
            else
            {
                txt_cctv_req.Enabled = true;
                txt_cctv_accompanied.Enabled = true;
                txt_cctv_concern.Enabled = true;
                txt_cctv_type.Enabled = true;
                txt_cctv_location.Enabled = true;
                txt_cctv_when.Enabled = true;
                txt_cctv_add.Enabled = true;
            }
        }

        private void btn_cctv_add_Click(object sender, EventArgs e)
        {
            if (radio_cctv_no.Checked == true)
            {
                previewbox_generate.Text = previewbox_generate.Text + "\n\nCCTV Request: No CCTV requests during the shift.";
            }
            else
            {
                previewbox_generate.Text = previewbox_generate.Text + "\n\nCCTV Request: \nRequested by: " + txt_cctv_req.Text + "\nAccompanied by: " + txt_cctv_accompanied.Text + "\nConcern: " + txt_cctv_concern.Text + "\nType of Request: " + txt_cctv_type.Text + "\nLocation: " + txt_cctv_location.Text + "\nWhen: " + txt_cctv_when.Text + "\nAdditional Info: " + txt_cctv_add.Text;
            }
        }

        private void txt_more_Enter(object sender, EventArgs e)
        {
            if (txt_more.Text == "Enter any additional information here.")
            {
                txt_more.Text = "";
                txt_more.ForeColor = Color.Black;
            }
        }

        private void txt_more_Leave(object sender, EventArgs e)
        {
            if (txt_more.Text == "")
            {
                txt_more.Text = "Enter any additional information here.";
                txt_more.ForeColor = Color.Gray;
            }
        }

        private void atimonanendorsement_Load(object sender, EventArgs e)
        {
            txt_more.Text = "Enter any additional information here.";
            txt_more.ForeColor = Color.Gray;
            radio_no.Checked = true;
            radio_ir_no.Checked = true;
            radio_cctv_no.Checked = true;
        }

        private void btn_more_add_Click(object sender, EventArgs e)
        {
            previewbox_generate.Text = previewbox_generate.Text + "\n\n" + txt_more.Text;
        }

        private void btn_footergenerate_Click(object sender, EventArgs e)
        {
            previewbox_generate.Text = previewbox_generate.Text + s2;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reset the form?", "Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Controls.Clear();
                this.InitializeComponent();
                radio_no.Checked = true;
                radio_ir_no.Checked = true;
                radio_cctv_no.Checked = true;

            }
            else
            {
                //Do nothing
            }
        }

        private void btn_clipboard_Click(object sender, EventArgs e)
        {
            if (previewbox_generate.Text == "")
            {
                MessageBox.Show("Nothing to copy!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Clipboard.SetText(previewbox_generate.Text);
                MessageBox.Show("Copied to clipboard!", "Copied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Controls.Clear();
                this.InitializeComponent();
                radio_no.Checked = true;
                radio_ir_no.Checked = true;
                radio_cctv_no.Checked = true;
            }
        }


    }
}
