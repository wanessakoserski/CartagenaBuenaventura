using CartagenaBuenaventura.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace CartagenaBuenaventura.Forms
{
    public partial class Matches : Screen
    {
        public Matches()
        {
            InitializeComponent();
            SetListMatches();
        }

        // Sets the information to create the matches list on the screen
        private void SetListMatches()
        {
            lstMatches.GridLines = true;
            lstMatches.View = View.Details;
            lstMatches.FullRowSelect = true;
            lstMatches.MultiSelect = false;

            lstMatches.Columns.Add("Id", 50, HorizontalAlignment.Center);
            lstMatches.Columns.Add("Nome", 100, HorizontalAlignment.Center);
            lstMatches.Columns.Add("Criação", 100, HorizontalAlignment.Center);
            lstMatches.Columns.Add("Status", 100, HorizontalAlignment.Center);

            ShowListMatches();
        }

        // Clean the current data in list
        // Fill the matches list with current data from server
        private void ShowListMatches()
        {
            lstMatches.Items.Clear();

            List<Match> ListMatches = Game.ListMatches();

            ListViewItem item;
            foreach (Match match in ListMatches)
            {
                item = new ListViewItem(match.id.ToString());
                item.SubItems.Add(match.name);
                item.SubItems.Add(match.creationDate.ToShortDateString());
                item.SubItems.Add(match.status.ToString());
                item.Tag = match;
                lstMatches.Items.Add(item);
            }
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
        }

        // Open enter match dialog
        private void btnEnterMatch_Click(object sender, EventArgs e)
        {
            EnterMatchDialog enterMatchDialog = new EnterMatchDialog(this, GetSelectedMatch());
            if (enterMatchDialog.ShowDialog() == DialogResult.OK)
                Console.WriteLine("works");
        }

        // Get current clicked match on matches list
        private Match GetSelectedMatch()
        {
            SelectedListViewItemCollection item = lstMatches.SelectedItems;
            Match match = (Match)item[0].Tag;

            return match;
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
        private void lstMatches_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEnterMatch.Enabled = true;
            btnViewMatch.Enabled = true;
        }
    }
}
