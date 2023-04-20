using CartagenaBuenaventura.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CartagenaBuenaventura
{
    public partial class Home : Screen
    {
        public Home()
        {
            InitializeComponent();
        }

        // Go to Matches
        private void btnPlayCartagena_Click(object sender, EventArgs e)
        {
            Panel.getInstance().ChangeForm(this, new Matches());
        }

        // Stop the program
        private void btnExit_Click(object sender, EventArgs e)
        {
            Panel.getInstance().Close();
        }
    }
}
