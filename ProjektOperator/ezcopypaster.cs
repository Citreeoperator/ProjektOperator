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
    public partial class ezcopypaster : Form
    {
        public ezcopypaster()
        {
            InitializeComponent();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Files (*.*)|*.*";
            ofd.FilterIndex = 1;
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txt_open_path.Text = ofd.FileName;
                txt_open_path.Refresh();
            }
        }

        private void btn_destinationpath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txt_output_path.Text = fbd.SelectedPath;
                txt_output_path.Refresh();
            }
        }

        private void btn_initiate_Click(object sender, EventArgs e)
        {
            if (txt_open_path.Text == "" || txt_output_path.Text == "" || txt_quantity.Text == "")
            {
                MessageBox.Show("Please check your input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bg_worker.RunWorkerAsync();
            }
        }

        private void bg_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            int num_quantity = int.Parse(txt_quantity.Text);
            for (int i = 0; i < num_quantity; i++)
            {
                System.IO.File.Copy(txt_open_path.Text, txt_output_path.Text + "\\" + System.IO.Path.GetFileNameWithoutExtension(txt_open_path.Text) + "_" + i + System.IO.Path.GetExtension(txt_open_path.Text));
                int percentage = (i + 1) * 100 / num_quantity;
                bg_worker.ReportProgress(percentage);
            }
        }

        private void bg_worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pb_progressbar.Value = e.ProgressPercentage;
        }

        private void bg_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Successfully made copies of the file", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_open_path.Text = "";
            txt_output_path.Text = "";
            txt_quantity.Text = "";
            pb_progressbar.Value = 0;
        }

        private void txt_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
