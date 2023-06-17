using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CartagenaBuenaventura.Classes;

namespace CartagenaBuenaventura.Forms
{
    public partial class EnterMatchDialog : Form
    {
        Match match;
        Screen screen;
        Player player;
        public EnterMatchDialog(Screen screen, Match match)
        {
            InitializeComponent();
            this.screen = screen;
            this.match = match;
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnMatchEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPlayerName.Text.Length > 0 && txtMatchPassword.Text.Length > 0) 
                {
                    this.player = Game.EnterMatch(match.id, txtPlayerName.Text, txtMatchPassword.Text);
                    this.DialogResult = DialogResult.OK;
                }
                else 
                {
                    lblWarnig.Text = "* Preencha os campos";
                }
            }
            catch (Exception ex) 
            {
                lblWarnig.Text = "Senha Invalida";
                txtPlayerName.Text = string.Empty;
                txtMatchPassword.Text = string.Empty;
                Console.WriteLine(ex.Message);
            }
        }

        public Player getPlayer()
        {
            return this.player;
        }
    }
}
