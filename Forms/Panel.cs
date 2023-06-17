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
        private static Panel instance;

        private Panel()
        {
            InitializeComponent();
            this.Icon = new Icon("../../Resources/parrot.ico");
            this.Controls.Add(new Home());
        }

        // Ensures that only a single instance of panel will be created and used
        public static Panel getInstance()
        {
            if (instance == null)
                instance = new Panel();

            return instance;
        }

        // Remove all controls from Panel and add a new class full of them to it
        // (i.e. buttons, lists, textboxes, etc), therefore, changing the displayed
        // screen in the application window.
        public void ChangeForm(Screen current, Screen next) 
        {
            current.Close();
            this.Controls.Clear();
            this.Controls.Add(next);
        }
    }
}
