using sipetok_form.Views;
using sipetok_form.Views.Transactions;
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
                case "dashboardMenu":
                    DashboardView dashboardView = new DashboardView();
                    dashboardView.Show();
                    thisForm.Close();
                    break;

                case "penggunaMenu":
                    UserPage userLists = new UserPage();
                    userLists.Show();
                    thisForm.Close();
                    break;

                case "transaksiMenu":
                    TransactionPage transactionLists = new TransactionPage();
                    transactionLists.Show();
                    thisForm.Close();
                    break;

                case "menuLogout":
                    DialogResult result = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                    break;

                default:
                    MessageBox.Show($"Menu {menuItem.Text} belum dikonfigurasi.");
                    break;
            }
        }
    }
}
