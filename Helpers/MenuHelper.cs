using sipetok_form.Views;
using sipetok_form.Views.Eggs;
using sipetok_form.Views.Laporan;
using sipetok_form.Views.Operationals;
using sipetok_form.Views.Tenant;
using sipetok_form.Views.Transactions;
using sipetok_form.Views.EggCategoryForm;
using sipetok_form.Views.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace sipetok_form.Helpers
{
    internal class MenuHelper
    {
        public static void HandleClick(object sender, EventArgs e, Form thisForm)
        {
            // Mendapatkan komponen menu yang sedang diklik
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            if (menuItem == null) return;

            string namaMenu = menuItem.Name;

            switch (namaMenu)
            {
                case "DashboardMenu":
                    DashboardView dashboardView = new DashboardView();
                    dashboardView.Show();
                    thisForm.Close();
                    break;

                case "UserMenu":
                    UserPage userLists = new UserPage();
                    userLists.Show();
                    thisForm.Close();
                    break;

                case "TenantMenu":
                    TenantPage tenantList = new TenantPage();
                    tenantList.Show();
                    thisForm.Close();
                    break;
                    
                case "TransactionMenu":
                    TransactionPage transactionLists = new TransactionPage();
                    transactionLists.Show();
                    thisForm.Close();
                    break;
                
                case "ReportMenu":
                    ReportsPage laporanList = new ReportsPage();
                    laporanList.Show();
                    thisForm.Close();
                    break;

                case "EggCategoryMenu":
                    EggCategoryPage categoryList = new EggCategoryPage();
                    categoryList.Show();
                    thisForm.Close();
                    break;

                case "LogoutMenu":
                    DialogResult result = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                    break;

                case "StockMenu":
                    EggStockPage eggStockPage = new EggStockPage();
                    eggStockPage.Show();
                    thisForm.Close();
                    break;

                case "OperationalMenu":
                    OperationalPage operationalPage = new OperationalPage();
                    operationalPage.Show();
                    thisForm.Close();
                    break;

                default:
                    MessageBox.Show($"Menu {menuItem.Text} belum dikonfigurasi.");
                    break;
            }
        }
    }
}
