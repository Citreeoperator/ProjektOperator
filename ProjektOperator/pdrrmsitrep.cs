using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ProjektOperator
{
    public partial class pdrrmsitrep : Form
    {
        string responders = "";
        public pdrrmsitrep()
        {
            InitializeComponent();
        }

        private void conditionchecks()
        {
            if (check_mdrrmomedic.Checked && check_mdrrmovolunteer.Checked && check_bfp.Checked && check_pnp.Checked == true)
            {
                responders = "MDRRMO MEDICS, MDRRMO VOLUNTEERS, BFP, PNP";
            }
            else if (check_mdrrmomedic.Checked && check_mdrrmovolunteer.Checked && check_bfp.Checked == true)
            {
                responders = "MDRRMO MEDICS, MDRRMO VOLUNTEERS, BFP";
            }
            else if (check_mdrrmomedic.Checked && check_mdrrmovolunteer.Checked && check_pnp.Checked == true)
            {
                responders = "MDRRMO MEDICS, MDRRMO VOLUNTEERS, PNP";
            }
            else if (check_mdrrmomedic.Checked && check_bfp.Checked && check_pnp.Checked == true)
            {
                responders = "MDRRMO MEDICS, BFP, PNP";
            }
            else if (check_mdrrmovolunteer.Checked && check_bfp.Checked && check_pnp.Checked == true)
            {
                responders = "MDRRMO VOLUNTEERS, BFP, PNP";
            }
            else if (check_mdrrmomedic.Checked && check_mdrrmovolunteer.Checked == true)
            {
                responders = "MDRRMO MEDICS, MDRRMO VOLUNTEERS";
            }
            else if (check_mdrrmomedic.Checked && check_bfp.Checked == true)
            {
                responders = "MDRRMO MEDICS, BFP";
            }
            else if (check_mdrrmomedic.Checked && check_pnp.Checked == true)
            {
                responders = "MDRRMO MEDICS, PNP";
            }
            else if (check_mdrrmovolunteer.Checked && check_bfp.Checked == true)
            {
                responders = "MDRRMO VOLUNTEERS, BFP";
            }
            else if (check_mdrrmovolunteer.Checked && check_pnp.Checked == true)
            {
                responders = "MDRRMO VOLUNTEERS, PNP";
            }
            else if (check_bfp.Checked && check_pnp.Checked == true)
            {
                responders = "BFP, PNP";
            }
            else if (check_mdrrmomedic.Checked == true)
            {
                responders = "MDRRMO MEDICS";
            }
            else if (check_mdrrmovolunteer.Checked == true)
            {
                responders = "MDRRMO VOLUNTEERS";
            }
            else if (check_bfp.Checked == true)
            {
                responders = "BFP";
            }
            else if (check_pnp.Checked == true)
            {
                responders = "PNP";
            }
            else
            {
                responders = "";
            }
        }

        private void btn_headergenerate_Click(object sender, EventArgs e)
        {
            previewbox_generate.Text = "MDRRMO ATIMONAN, QUEZON OPERATIONS & WARNING SITUATIONAL REPORT" + "\n" + "DATE: " + DateTime.Now.ToString("MMMM dd, yyyy") + "\n" + "TIME: " + DateTime.Now.ToString("HH:mm");
        }

        private void btn_genweather_Click(object sender, EventArgs e)
        {
            if (txt_weather.Text == "")
            {
                MessageBox.Show("Please enter the weather condition", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                previewbox_generate.Text = previewbox_generate.Text + "\n\n" + "I. WEATHER CONDITION: " + txt_weather.Text;
            }
        }

        private void btn_pagasa_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://bagong.pagasa.dost.gov.ph/weather");
        }

        private void radio_yes_CheckedChanged(object sender, EventArgs e)
        {
            grp_incidentreports.Enabled = true;
            btn_addno.Enabled = false;
            btn_addno.Visible = false;
        }

        private void radio_no_CheckedChanged(object sender, EventArgs e)
        {
            grp_incidentreports.Enabled = false;
            btn_addno.Enabled = true;
            btn_addno.Visible = true;
        }

        private void btn_addincident_Click(object sender, EventArgs e)
        {
            conditionchecks();
            if (txt_what.Text == "")
            {
                MessageBox.Show("Please enter the WHAT of the incident", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_what.Focus();
            }
            else if (txt_when.Text == "")
            {
                MessageBox.Show("Please enter the WHEN of the incident", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_when.Focus();
            }
            else if (txt_where.Text == "")
            {
                MessageBox.Show("Please enter the WHERE of the incident", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_where.Focus();
            }
            else if (txt_natureofillness.Text == "")
            {
                MessageBox.Show("Please enter the nature of illness", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_natureofillness.Focus();
            }
            else if (txt_cause.Text == "")
            {
                MessageBox.Show("Please enter the cause of injury", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_cause.Focus();
            }
            else if (txt_vehicle.Text == "")
            {
                MessageBox.Show("Please enter the vehicle involved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_vehicle.Focus();
            }
            else if (txt_numofinjured.Text == "")
            {
                MessageBox.Show("Please enter the number of injured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_numofinjured.Focus();
            }
            else if (responders == "")
            {
                MessageBox.Show("Please select the responders", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check_mdrrmomedic.Focus();
            }
            else if (txt_actions.Text == "")
            {
                MessageBox.Show("Please enter the actions taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_actions.Focus();
            }
            else
            {
                previewbox_generate.Text = previewbox_generate.Text + "\n\n" + "II. INCIDENT:" + "\nWHAT: " + txt_what.Text + "\n" + "WHEN: " + txt_when.Text + "\n" + "WHERE: " + txt_where.Text + "\n" + "NATURE OF ILLNESS: " + txt_natureofillness.Text + "\n" + "CAUSE OF INJURY: " + txt_cause.Text + "\n" + "VEHICLE/S INVOLVED: " + txt_vehicle.Text + "\n" + "NUMBER OF INJURED: " + txt_numofinjured.Text + "\n" + "RESPONDERS: " + responders + "\n" + "ACTIONS TAKEN: " + txt_actions.Text;
                txt_what.Text = "";
                txt_when.Text = "";
                txt_where.Text = "";
                txt_natureofillness.Text = "";
                txt_cause.Text = "";
                txt_vehicle.Text = "";
                txt_numofinjured.Text = "";
                check_mdrrmomedic.Checked = false;
                check_mdrrmovolunteer.Checked = false;
                check_bfp.Checked = false;
                check_pnp.Checked = false;
                txt_actions.Text = "";
                responders = "";
            }
        }

        private void btn_addno_Click(object sender, EventArgs e)
        {
            previewbox_generate.Text = previewbox_generate.Text + "\n\n" + "II. INCIDENT:" + "\nWHAT: NONE \nWHEN: NONE \nWHERE: NONE \nNATURE OF ILLNESS: NONE \nCAUSE OF INJURY: NONE \nVEHICLE/S INVOLVED: NONE \nNUMBER OF INJURED: NONE \nRESPONDERS: NONE \nACTIONS TAKEN: NONE";
        }

        private void check_power_CheckedChanged(object sender, EventArgs e)
        {
            if (check_power.Checked == true)
            {
                txt_power.Enabled = false;
                txt_power.Text = "No Interruptions";
            }
            else
            {
                txt_power.Enabled = true;
                txt_power.Text = "";
            }
        }

        private void check_water_CheckedChanged(object sender, EventArgs e)
        {
            if (check_water.Checked == true)
            {
                txt_water.Enabled = false;
                txt_water.Text = "No Interruptions";
            }
            else
            {
                txt_water.Enabled = true;
                txt_water.Text = "";
            }
        }

        private void check_comms_CheckedChanged(object sender, EventArgs e)
        {
            if (check_comms.Checked == true)
            {
                txt_comms.Enabled = false;
                txt_comms.Text = "No Interruptions";
            }
            else
            {
                txt_comms.Enabled = true;
                txt_comms.Text = "";
            }
        }

        private void check_roadconditions_CheckedChanged(object sender, EventArgs e)
        {
            if (check_roadconditions.Checked == true)
            {
                txt_roadcondition.Enabled = false;
                txt_roadcondition.Text = "All roads are passable";
            }
            else
            {
                txt_roadcondition.Enabled = true;
                txt_roadcondition.Text = "";
            }
        }

        private void check_seatravel_CheckedChanged(object sender, EventArgs e)
        {
            if (check_seatravel.Checked == true)
            {
                txt_seatravel.Enabled = false;
                txt_seatravel.Text = "No Sea Travel";
            }
            else
            {
                txt_seatravel.Enabled = true;
                txt_seatravel.Text = "";
            }
        }

        private void btn_portofatimonan_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/atimonanport");
        }

        private void btn_lifeadd_Click(object sender, EventArgs e)
        {
            string inputString = txt_seatravel.Text;
            string outputString = inputString.Replace("(0950 248 3512)", "")
                .Replace("(0951 0627 357)", "")
                .Replace("(0917 169 1189)", "")
                .Replace("(0938 834 9973)", "")
                .Replace("(0910 768 9668)", "");
            previewbox_generate.Text = previewbox_generate.Text + "\n\n" + "III. LIFELINES:" + "\nPOWER: " + txt_power.Text + "\n" + "WATER: " + txt_water.Text + "\n" + "COMMUNICATIONS: " + txt_comms.Text + "\n" + "ROAD CONDITIONS: " + txt_roadcondition.Text + "\n" + "SEA TRAVEL: \nOperational\n" + outputString;
        }

        private void btn_footergenerate_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour < 12)
            {
                previewbox_generate.Text = previewbox_generate.Text + "\n\n" + "Magandang umaga po sa ating lahat";
            }
            else
            {
                previewbox_generate.Text = previewbox_generate.Text + "\n\n" + "Maganda hapon po sa ating lahat";
            }
        }

        private void btn_clipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(previewbox_generate.Text);
            MessageBox.Show("The text has been copied to the clipboard", "Copied", MessageBoxButtons.OK, MessageBoxIcon.Information);
            formreset();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reset the form?", "Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                formreset();
            }
            else
            {
                //Do nothing
            }
        }

        private void formreset()
        {
            responders = "";
            txt_weather.Text = "";
            txt_what.Text = "";
            txt_when.Text = "";
            txt_where.Text = "";
            txt_natureofillness.Text = "";
            txt_cause.Text = "";
            txt_vehicle.Text = "";
            txt_numofinjured.Text = "";
            check_mdrrmomedic.Checked = false;
            check_mdrrmovolunteer.Checked = false;
            check_bfp.Checked = false;
            check_pnp.Checked = false;
            txt_actions.Text = "";
            check_power.Checked = false;
            txt_power.Text = "";
            check_water.Checked = false;
            txt_water.Text = "";
            check_comms.Checked = false;
            txt_comms.Text = "";
            check_roadconditions.Checked = false;
            txt_roadcondition.Text = "";
            check_seatravel.Checked = false;
            txt_seatravel.Text = "";
            previewbox_generate.Text = "";
        }
    }
}
