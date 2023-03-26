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
    public partial class MatchLobby : Screen
    {
        Match match;
        public MatchLobby(Match match)
        {
            InitializeComponent();
            this.match = match;
        }
    }
}
