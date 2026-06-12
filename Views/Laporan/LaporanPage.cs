using sipetok_form.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sipetok_form.Views.Laporan
{
    public partial class LaporanPage : Form
    {
        public LaporanPage()
        {
            InitializeComponent();
        }

        private void handleClickMenu(object sender, EventArgs e)
        {
            MenuHelper.HandleClick(sender, e, this);
        }
    }
}
