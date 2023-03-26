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
    public partial class CreateMatchDialog : Form
    {
        Screen screen;
        public CreateMatchDialog(Screen screen)
        {
            InitializeComponent();
            this.screen = screen;
        }

        private void btnCreateMatch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMatchName.Text.Length > 0 && txtMatchPassword.Text.Length > 0)
                {
                    Match match = Game.CreateMatch(txtMatchName.Text, txtMatchPassword.Text);
                    Panel.getInstance().ChangeForm(screen, new MatchLobby(match));
                    this.Close();
                }
                else
                {
                    lblWarning.Text = "* preencha os campos acima";
                }
            }
            catch (Exception ex)
            {
                lblWarning.Text = "* nome de partida já utilizada";
                txtMatchName.Text = "";
                txtMatchPassword.Text = "";
                Console.WriteLine(ex.Message);
            }
        }
    }
}
