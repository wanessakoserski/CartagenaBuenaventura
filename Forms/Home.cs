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
            try
            {
                Panel.getInstance().ChangeForm(this, new Matches());
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar a lista de partidas\n\n" + ex.Message, 
                    "Error Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Stop the program
        private void btnExit_Click(object sender, EventArgs e)
        {
            Panel.getInstance().Close();
        }

        /* Appearance */

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.FromArgb(173, 202, 255);
            button.ForeColor = Color.FromArgb(60, 85, 142);
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.FromArgb(110, 145, 202);
            button.ForeColor = Color.White;
        }
    }
}
