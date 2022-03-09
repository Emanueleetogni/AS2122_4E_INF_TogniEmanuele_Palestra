using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2122_4E_INF_TogniEmanuele_Palestra
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int persone = Convert.ToInt32(txtPersone.Text);
            int mesi = Convert.ToInt32(nudMesi.Text);
            double preventivo = 0;
            int prezzoSpinning = 40, prezzoDanza = 50, prezzoPesi = 45;

            if(chkSpinning.Checked == true)
            {
                preventivo += prezzoSpinning * mesi*persone;
            }
            if (chkDanza.Checked == true)
            {
                preventivo += prezzoDanza * mesi;
            }
            if (chkPesi.Checked == true)
            {
                preventivo += prezzoPesi * mesi;
            }

            lblPreventivo.Text = preventivo.ToString();
        }

        
    }
}
