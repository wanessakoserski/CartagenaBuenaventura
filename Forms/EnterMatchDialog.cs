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
        public EnterMatchDialog(Screen screen, Match match)
        {
            InitializeComponent();
            this.screen = screen;
            this.match = match;
        }

        private void btnMatchEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPlayerName.Text.Length > 0 && txtMatchPassword.Text.Length > 0) 
                {
                    Player player = Game.EnterMatch(match.id, txtPlayerName.Text, txtMatchPassword.Text);
                    Panel.getInstance().ChangeForm(screen, new Lobby(match));
                    this.Close();
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
    }
}
