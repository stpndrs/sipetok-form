using sipetok_form.Helpers;
using sipetok_form.Views.Transactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sipetok_form.Views
{
    public partial class DashboardView : Form
    {
        public DashboardView()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void handleClickMenu(object sender, EventArgs e)
        {
            MenuHelper.HandleClick(sender, e, this);
        }

        private void kategoriMenu_Click(object sender, EventArgs e)
        {

        }

        private void penggunaMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
