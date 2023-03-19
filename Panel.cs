using CartagenaServer;
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
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
        }

        // Remove all controls from Panel and add a new class full of them to it
        // (i.e. buttons, lists, textboxes, etc), therefore, changing the displayed
        // screen in the application window.
        public void ChangeForm(Form current, Form next) 
        {
            current.Close();
            this.Controls.Clear();
            this.Controls.Add(next);
        }
    }
}
