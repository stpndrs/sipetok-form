using sipetok_form.Helpers;
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
            SetupRoleBasedUI();
        }

        private void SetupRoleBasedUI()
        {
            if(UserSession.Role == 1)
            {
                UserMenu.Visible = true;
                TenantMenu.Visible = true;
                TransactionMenu.Visible = false;
                OperationalMenu.Visible = false;
                ReportMenu.Visible = false;
                StockMenu.Visible = false;
                EggCategoryMenu.Visible = false;
            } else if(UserSession.Role == 2)
            {
                UserMenu.Visible = false;
                TenantMenu.Visible = false;
                TransactionMenu.Visible = true;
                OperationalMenu.Visible = true;
                ReportMenu.Visible = true;
                StockMenu.Visible = true;
                EggCategoryMenu.Visible = true;
            }
            else
            {
                UserMenu.Visible = false;
                TenantMenu.Visible = false;
                TransactionMenu.Visible = false;
                OperationalMenu.Visible = false;
                ReportMenu.Visible = false;
                StockMenu.Visible = false;
                EggCategoryMenu.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void handleClickMenu(object sender, EventArgs e)
        {
            MenuHelper.HandleClick(sender, e, this);
        }

    }
}
