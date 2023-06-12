using CartagenaBuenaventura.Classes;
using CartagenaBuenaventura.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CartagenaBuenaventura.Forms
{
    public partial class Matches : Screen
    {
        public Matches()
        {
            InitializeComponent();

            ShowListMatches();

            btnViewMatch.Enabled = false;
            btnEnterMatch.Enabled = false;
            btnViewMatch.BackColor = Color.LightSteelBlue;
            btnEnterMatch.BackColor = Color.LightSteelBlue;
        }

        // Clean the current data in list
        // Fill the matches list with current data from server
        private void ShowListMatches()
        {
            dgdMatches.Rows.Clear();

            List<Match> ListMatches = Game.ListMatches();

            int index = 0;
            foreach (Match match in ListMatches)
            {
                dgdMatches.Rows.Add(new object[]
                {
                    match.id,
                    match.name,
                    match.creationDate.ToShortDateString(),
                    match.status
                });

                dgdMatches.Rows[index].Tag = match;

                index++;
            }

            dgdMatches.ClearSelection();
        }

        // Open create match dialog
        private void btnCreateMatch_Click(object sender, EventArgs e)
        {
            CreateMatchDialog createMatchDialog = new CreateMatchDialog(this);
            if (createMatchDialog.ShowDialog() == DialogResult.OK)
                Console.WriteLine("works");
        }

        // Refill the matches list with current data from server
        // Disables the buttons for not having any item selected anymore
        private void btnRefreshListMatches_Click(object sender, EventArgs e)
        {
            ShowListMatches();
            btnViewMatch.Enabled = false;
            btnEnterMatch.Enabled = false;
            btnViewMatch.BackColor = Color.LightSteelBlue;
            btnEnterMatch.BackColor = Color.LightSteelBlue;
        }

        // Open enter match dialog
        private void btnEnterMatch_Click(object sender, EventArgs e)
        {
            Player player = new Player();
            using (EnterMatchDialog enterMatchDialog = new EnterMatchDialog(this, GetSelectedMatch()))
            {
                if (enterMatchDialog.ShowDialog() == DialogResult.OK)
                {
                    Console.WriteLine("works");
                    player = enterMatchDialog.getPlayer();
                }
            }
            Panel.getInstance().ChangeForm(this, new Lobby(GetSelectedMatch(), player));
        }

        // Get current clicked match on matches list
        private Match GetSelectedMatch()
        {
            try
            {
                DataGridViewSelectedRowCollection selected = dgdMatches.SelectedRows;
                Match match = (Match)selected[0].Tag;
                return match;
            } catch (Exception ex)
            {
                return null;
            }

        }

        // Attempt to enter lobby match
        private void btnViewMatch_Click(object sender, EventArgs e)
        {
            try
            {
                Panel.getInstance().ChangeForm(this, new Lobby(GetSelectedMatch()));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar lobby da partida\n\n" + ex.Message,
                    "Error Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Ables button when a item is selected
        private void dgdMatches_SelectionChanged(object sender, EventArgs e)
        {
            btnEnterMatch.Enabled = false;
            btnEnterMatch.BackColor = Color.LightBlue;

            btnViewMatch.Enabled = false;
            btnViewMatch.BackColor = Color.LightBlue;

            Match match = GetSelectedMatch();
            if (match != null)
            {
                btnViewMatch.Enabled = true;
                btnViewMatch.BackColor = Color.Teal;

                if (match.status == enums.MatchStatus.Open)
                {
                    btnEnterMatch.Enabled = true;
                    btnEnterMatch.BackColor = Color.Teal;
                }
            }
        }

        // Come back to Home
        private void pnlGoBackHome_Click(object sender, EventArgs e)
        {
            Panel.getInstance().ChangeForm(this, new Home());
        }


        /* Appearance */

        private void pnlGoBackHome_MouseEnter(object sender, EventArgs e)
        {
            pnlGoBackHome.BackgroundImage = Resources.back_arrow;
        }

        private void pnlGoBackHome_MouseLeave(object sender, EventArgs e)
        {
            pnlGoBackHome.BackgroundImage = Resources.go_back_arrow;
        }

        private void btnRefreshListMatches_MouseEnter(object sender, EventArgs e)
        {
            btnRefreshListMatches.BackColor = Color.LightBlue;
            btnRefreshListMatches.ForeColor = Color.Teal;
        }

        private void btnViewMatch_MouseEnter(object sender, EventArgs e)
        {
            btnViewMatch.BackColor = Color.LightBlue;
            btnViewMatch.ForeColor = Color.Teal;
        }

        private void btnCreateMatch_MouseEnter(object sender, EventArgs e)
        {
            btnCreateMatch.BackColor = Color.LightBlue;
            btnCreateMatch.ForeColor = Color.Teal;
        }

        private void btnEnterMatch_MouseEnter(object sender, EventArgs e)
        {
            btnEnterMatch.BackColor = Color.LightBlue;
            btnEnterMatch.ForeColor = Color.Teal;
        }

        private void btnRefreshListMatches_MouseLeave(object sender, EventArgs e)
        {
            btnRefreshListMatches.BackColor = Color.Teal;
            btnRefreshListMatches.ForeColor = Color.LightBlue;
        }

        private void btnViewMatch_MouseLeave(object sender, EventArgs e)
        {
            btnViewMatch.BackColor = Color.Teal;
            btnViewMatch.ForeColor = Color.LightBlue;
        }

        private void btnCreateMatch_MouseLeave(object sender, EventArgs e)
        {
            btnCreateMatch.BackColor = Color.Teal;
            btnCreateMatch.ForeColor = Color.LightBlue;
        }

        private void btnEnterMatch_MouseLeave(object sender, EventArgs e)
        {
            btnEnterMatch.BackColor = Color.Teal;
            btnEnterMatch.ForeColor = Color.LightBlue;
        }
    }
}
