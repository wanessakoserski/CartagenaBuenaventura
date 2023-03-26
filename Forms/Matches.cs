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
            ShowListMatches();
        }

        private void ShowListMatches()
        {
            DataTable datatable = new DataTable();

            datatable.Columns.Add("Id", typeof(uint));
            datatable.Columns.Add("Nome", typeof(string));
            datatable.Columns.Add("Criação", typeof(DateTime));
            datatable.Columns.Add("Status", typeof(enums.MatchStatus));

            List<Match> ListMatches = Game.ListMatches();

            foreach (Match match in ListMatches)
            {
                datatable.Rows.Add(match.id, match.name, match.creationDate, match.status);
            }

            grdMatches.DataSource = datatable;
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
    }
}
