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
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }

        private void tmr_loading_Tick(object sender, EventArgs e)
        {
            int i;
            Random random = new Random();
            i = random.Next(5, 10);
            pb_load.Increment(i);
            if (pb_load.Value == 100)
            {
                tmr_loading.Stop();
                this.Hide();
            }

        }
    }
}
