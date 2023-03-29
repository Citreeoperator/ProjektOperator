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
    public partial class dashboard : Form
    {
        thismonthreport thismonthreportForm = new thismonthreport();
        cctvrequestform cctvrequestform = new cctvrequestform();
        cctvdatabase cctvdatabase = new cctvdatabase();
        monthlyreport monthlyreport = new monthlyreport();
        quarterreport quarterreport = new quarterreport();
        pdrrmsitrep pdrrmsitrep = new pdrrmsitrep();
        atimonanendorsement atimonanendorsement = new atimonanendorsement();
        ezcopypaster ezcopypaster = new ezcopypaster();
        aboutus aboutus = new aboutus();
        public dashboard()
        {
            login loginForm = new login();
            loginForm.ShowDialog();
            if (!login.loggedIn)
            {
                Application.Exit();
            }
            InitializeComponent();

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                //Do nothing
            }
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            thismonthreportForm.TopLevel = false;
            pnl_main.Controls.Add(thismonthreportForm);
            thismonthreportForm.BringToFront();
            thismonthreportForm.Show();
        }

        private void tmr_time_Tick(object sender, EventArgs e)
        {
            lbl_timeanddate.Text = DateTime.Now.ToString("MMMM dd, yyyy \nHH:mm:ss");
        }

        private void cCTVReviewRequestFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cctvrequestform.TopLevel = false;
            pnl_main.Controls.Add(cctvrequestform);
            cctvrequestform.BringToFront();
            cctvrequestform.Show();
        }

        private void dashboardHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thismonthreportForm.TopLevel = false;
            pnl_main.Controls.Add(thismonthreportForm);
            thismonthreportForm.BringToFront();
            thismonthreportForm.Show();
        }

        private void cCTVRequestDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cctvdatabase.TopLevel = false;
            pnl_main.Controls.Add(cctvdatabase);
            cctvdatabase.BringToFront();
            cctvdatabase.Show();
        }

        private void reportingDashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            monthlyreport.TopLevel = false;
            pnl_main.Controls.Add(monthlyreport);
            monthlyreport.BringToFront();
            monthlyreport.Show();
        }

        private void quarterlyReportDashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quarterreport.TopLevel = false;
            pnl_main.Controls.Add(quarterreport);
            quarterreport.BringToFront();
            quarterreport.Show();
        }

        private void quezonOperationAndWarningOfficersSitRepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pdrrmsitrep.TopLevel = false;
            pnl_main.Controls.Add(pdrrmsitrep);
            pdrrmsitrep.BringToFront();
            pdrrmsitrep.Show();
        }

        private void atimonanDRRMOfficialEndorsementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            atimonanendorsement.TopLevel = false;
            pnl_main.Controls.Add(atimonanendorsement);
            atimonanendorsement.BringToFront();
            atimonanendorsement.Show();
        }

        private void eZCopypasterForWeatherForecastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ezcopypaster.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutus.Show();
        }
    }
}
