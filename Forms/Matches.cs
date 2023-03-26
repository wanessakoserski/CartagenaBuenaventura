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

namespace CartagenaBuenaventura.Forms
{
    public partial class Matches : Screen
    {
        public Matches()
        {
            InitializeComponent();
            SetListMatches();
        }

        private void SetListMatches()
        {
            lstMatches.GridLines = true;
            lstMatches.View = View.Details;
            lstMatches.FullRowSelect = true;

            lstMatches.Columns.Add("Id", 50, HorizontalAlignment.Center);
            lstMatches.Columns.Add("Nome", 100, HorizontalAlignment.Center);
            lstMatches.Columns.Add("Criação", 100, HorizontalAlignment.Center);
            lstMatches.Columns.Add("Status", 100, HorizontalAlignment.Center);

            ShowListMatches();
        }

        private void ShowListMatches()
        {
            lstMatches.Items.Clear();

            List<Match> ListMatches = Game.ListMatches();

            ListViewItem item;
            foreach (Match match in ListMatches)
            {
                item = new ListViewItem(match.id + "");
                item.SubItems.Add(match.name);
                item.SubItems.Add(match.creationDate.ToShortDateString());
                item.SubItems.Add(match.status + "");
                lstMatches.Items.Add(item);
            }
        }

        private void btnCreateMatch_Click(object sender, EventArgs e)
        {
            CreateMatchDialog createMatchDialog = new CreateMatchDialog(this);
            if (createMatchDialog.ShowDialog() == DialogResult.OK)
                Console.WriteLine("works");
        }

        private void btnRefreshListMatches_Click(object sender, EventArgs e)
        {
            ShowListMatches();
        }

        private void btnEnterMatch_Click(object sender, EventArgs e)
        {
            //EnterMatchDialog enterMatchDialog = new EnterMatchDialog(this,);
            //if (enterMatchDialog.ShowDialog() == DialogResult.OK)
            //    Console.WriteLine("works");
        }
    }
}
