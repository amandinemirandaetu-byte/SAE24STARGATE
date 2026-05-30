using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE24STARGATE
{
    public partial class frmAuthentification : Form
    {
        public frmAuthentification()
        {
            InitializeComponent();
        }

        bool oeilFerme = true;

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(e.KeyChar == (char)Keys.Return))
            {
                e.Handled = false;
            }

            if(!(e.KeyChar == (char)Keys.Enter))
            {
                e.Handled = false;
                btnLogin.PerformClick();
            }
            
            if (!(char.IsLetter(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtMDP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == (char)Keys.Enter))
            {
                btnLogin.PerformClick();
            }
        }

        private void btnMontrerMdp_Click(object sender, EventArgs e)
        {
            btnMontrerMdp.BackgroundImage = Image.FromFile("../../Resources/iconeOeilFerme.png");
        }

    }
}
