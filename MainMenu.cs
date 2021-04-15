using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_02
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ShowManageTransactionView(object sender, EventArgs e)
        {
            ManageTransactionParty manageTransactionParty = new ManageTransactionParty();
            manageTransactionParty.Activate();
            manageTransactionParty.ShowDialog();
        }
    }
}
