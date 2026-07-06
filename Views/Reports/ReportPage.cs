using sipetok_form.Helpers;
using sipetok_form.Helpers.Export;
using sipetok_form.Models;
using sipetok_form.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sipetok_form.Views.Reports
{
    public partial class ReportPage : Form
    {
        private readonly ApiService _apiService = new ApiService();
        private const int MaxGridHeight = 600;

        /// <summary>
        /// Konstruktor utama untuk halaman LaporanPage.
        /// Berfungsi menginisialisasi komponen UI dan mendaftarkan event load halaman.
        /// </summary>
        public ReportPage()
        {
            InitializeComponent();
            SetupRoleBasedUI();
            this.Load += ReportPage_Load;
        }

        private void SetupRoleBasedUI()
        {
            if (UserSession.Role == 1)
            {
                UserMenu.Visible = true;
                TenantMenu.Visible = true;
                TransactionMenu.Visible = false;
                OperationalMenu.Visible = false;
                ReportMenu.Visible = false;
                StockMenu.Visible = false;
                EggCategoryMenu.Visible = false;
            }
            else if (UserSession.Role == 2)
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

        /// <summary>
        /// Event handler yang berjalan otomatis saat halaman pertama kali dimuat.
        /// Berfungsi untuk langsung menampilkan data transaksi secara default.
        /// </summary>
        private void ReportPage_Load(object sender, EventArgs e)
        {
            var columnStyles = PageBodyContainer.ColumnStyles;
            columnStyles[0].SizeType = SizeType.Percent;
            columnStyles[0].Width = 70;
            columnStyles[1].SizeType = SizeType.Percent;
            columnStyles[1].Width = 30;
            DataList.Width = 1300;

            TransactionButton.PerformClick();
        }

        /// <summary>
        /// Mengatur perpindahan atau interaksi menu navigasi utama pada aplikasi.
        /// </summary>
        private void HandleMenuClick(object sender, EventArgs e)
        {
            MenuHelper.HandleClick(sender, e, this);
        }

        /// <summary>
        /// Event handler saat tombol Transaksi diklik.
        /// Berfungsi memicu proses pemuatan data laporan transaksi dari API ke dalam grid.
        /// </summary>
        private async void TransaksiButton_Click(object sender, EventArgs e)
        {
            await LoadReportDataAsync(
                fetchDataFunc: () => _apiService.Transaction.GetTransactionsAsync(),
                configureGridAction: SetupTransactionColumns,
                loadingButton: TransactionButton,
                activeButton: TransactionButton,
                inactiveButton: OperationalButton,
                headerTitle: "Manage Transaction Report"
            );
        }

        /// <summary>
        /// Event handler saat tombol Operasional diklik.
        /// Berfungsi memicu proses pemuatan data laporan biaya operasional dari API ke dalam grid.
        /// </summary>
        private async void OperationalButton_Click(object sender, EventArgs e)
        {
            await LoadReportDataAsync(
                fetchDataFunc: () => _apiService.Operational.GetOperationalsAsync(),
                configureGridAction: SetupOperationalColumns,
                loadingButton: OperationalButton,
                activeButton: OperationalButton,
                inactiveButton: TransactionButton,
                headerTitle: "Manage Operational Report"
            );
        }

        /// <summary>
        /// Method generik reusable (DRY) untuk menangani alur pemuatan data dari API,
        /// manajemen state tombol loading, error handling, hingga pembaruan UI secara terpusat.
        /// </summary>
        private async Task LoadReportDataAsync<T>(
            Func<Task<List<T>?>> fetchDataFunc,
            Action configureGridAction,
            Button loadingButton,
            Button activeButton,
            Button inactiveButton,
            string headerTitle)
        {
            try
            {
                loadingButton.Enabled = false;

                List<T>? reportData = await fetchDataFunc();
                if (reportData == null || reportData.Count == 0)
                {
                    MessageBox.Show("Report data not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                BindGridData(reportData);
                configureGridAction();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show($"Failed to load report data: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                loadingButton.Enabled = true;
                UpdateUIState(activeButton, inactiveButton, headerTitle);
            }
        }

        /// <summary>
        /// Membersihkan data lama dan mengikat (binding) list data baru ke DataGridView.
        /// </summary>
        private void BindGridData<T>(List<T> data)
        {
            DataList.DataSource = null;
            DataList.Columns.Clear();
            DataList.DataSource = data;
            DataList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AdjustGridHeight();
        }

        /// <summary>
        /// Mengonfigurasi nama header kolom dan menyembunyikan properti internal untuk data Transaksi.
        /// </summary>
        private void SetupTransactionColumns()
        {
            SetColumnHeader("Id", "Transaction ID");
            SetColumnHeader("Date", "Date");
            SetColumnHeader("CustomerName", "Customer Name");
            SetColumnHeader("TotalPrice", "Total Price");
            SetColumnHeader("PaymentStatus", "Payment Status");
            SetColumnHeader("OrderStatus", "Order Status");

            HideColumns("Details", "TenantId", "Tenant", "PaymentAmount", "CustomerPhoneNumber");
        }

        /// <summary>
        /// Mengonfigurasi nama header kolom dan menyembunyikan properti internal untuk data Operasional.
        /// </summary>
        private void SetupOperationalColumns()
        {
            SetColumnHeader("Id", "Operational ID");
            SetColumnHeader("Name", "Expense Name");
            SetColumnHeader("OperationalCost", "Operational Cost");

            HideColumns("TenantId", "Tenant");
        }

        /// <summary>
        /// Event handler untuk tombol ekspor data.
        /// Berfungsi memvalidasi format & tanggal input, kemudian mengarahkan proses ekspor sesuai tipe data aktif.
        /// </summary>
        private void ExportButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormatTypeComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select an export file format (Excel or PDF)!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime startDate = StartDateTimePicker.Value.Date;
                DateTime endDate = EndDateTimePicker.Value.Date.AddDays(1).AddTicks(-1);

                if (startDate > endDate)
                {
                    MessageBox.Show("Start date cannot exceed end date!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string selectedFormat = FormatTypeComboBox.SelectedItem.ToString();

                if (DataList.DataSource is List<Transaction> transactionList)
                {
                    ExportTransactions(transactionList, startDate, endDate, selectedFormat);
                }
                else if (DataList.DataSource is List<Operational> operationalList)
                {
                    ExportOperationals(operationalList, startDate, endDate, selectedFormat);
                }
                else
                {
                    MessageBox.Show("No data available in the table to export. Please load data first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (NotImplementedException)
            {
                MessageBox.Show("Export feature for this format is not implemented yet.", "Developer Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during data export: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Melakukan penyaringan data transaksi berdasarkan tanggal dan mengekspornya via Factory Pattern.
        /// </summary>
        private void ExportTransactions(List<Transaction> transactions, DateTime start, DateTime end, string format)
        {
            var filteredData = transactions.Where(t => t.Date >= start && t.Date <= end).ToList();
            if (IsDataFilteredEmpty(filteredData.Count)) return;

            string defaultFileName = $"Transaction_Report_{start:yyyyMMdd}_to_{EndDateTimePicker.Value:yyyyMMdd}";
            string filePath = GetSaveFilePath(format, defaultFileName);

            if (!string.IsNullOrEmpty(filePath))
            {
                IReportExporter exporter = ExportFactoryProvider.GetExporter(format);
                exporter.ExportTransactionList(filteredData, filePath);
                ShowExportSuccessMessage(format);
            }
        }

        /// <summary>
        /// Melakukan penyaringan data operasional berdasarkan tanggal dan mengekspornya via Factory Pattern.
        /// </summary>
        private void ExportOperationals(List<Operational> operationals, DateTime start, DateTime end, string format)
        {
            var filteredData = operationals.Where(o => o.OperationalDate >= start && o.OperationalDate <= end).ToList();
            if (IsDataFilteredEmpty(filteredData.Count)) return;

            string defaultFileName = $"Operational_Report_{start:yyyyMMdd}_to_{EndDateTimePicker.Value:yyyyMMdd}";
            string filePath = GetSaveFilePath(format, defaultFileName);

            if (!string.IsNullOrEmpty(filePath))
            {
                IReportExporter exporter = ExportFactoryProvider.GetExporter(format);
                exporter.ExportOperationalList(filteredData, filePath);
                ShowExportSuccessMessage(format);
            }
        }

        /// <summary>
        /// Menampilkan Windows SaveFileDialog untuk mendapatkan lokasi penyimpanan file dari pengguna.
        /// </summary>
        private string GetSaveFilePath(string format, string defaultFileName)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                bool isExcel = format == "Excel";
                sfd.Filter = isExcel ? "Excel Workbook (*.xlsx)|*.xlsx" : "PDF Document (*.pdf)|*.pdf";
                sfd.FileName = defaultFileName + (isExcel ? ".xlsx" : ".pdf");

                return sfd.ShowDialog() == DialogResult.OK ? sfd.FileName : string.Empty;
            }
        }

        #region Helper UI Methods (KISS & DRY Execution)

        /// <summary>
        /// Mengubah teks judul header pada kolom DataGridView jika kolom tersebut ditemukan.
        /// </summary>
        private void SetColumnHeader(string columnName, string headerText)
        {
            if (DataList.Columns.Contains(columnName))
            {
                DataList.Columns[columnName].HeaderText = headerText;
            }
        }

        /// <summary>
        /// Menyembunyikan daftar kolom DataGridView berdasarkan array nama kolom yang dikirimkan.
        /// </summary>
        private void HideColumns(params string[] columnNames)
        {
            foreach (var name in columnNames)
            {
                if (DataList.Columns.Contains(name))
                {
                    DataList.Columns[name].Visible = false;
                }
            }
        }

        /// <summary>
        /// Mengatur kondisi visual UI (warna latar belakang tombol aktif/tidak aktif dan judul halaman).
        /// </summary>
        private void UpdateUIState(Button activeButton, Button inactiveButton, string headerTitle)
        {
            activeButton.BackColor = Color.LightGray;
            inactiveButton.BackColor = Color.White;
            FormLabel.Text = headerTitle;
        }

        /// <summary>
        /// Memeriksa apakah data hasil filter kosong, sekaligus menampilkan pesan informasi ke pengguna jika kosong.
        /// </summary>
        private bool IsDataFilteredEmpty(int count)
        {
            if (count == 0)
            {
                MessageBox.Show("No data found within the selected date range.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Menampilkan kotak pesan sukses setelah file laporan berhasil diekspor.
        /// </summary>
        private void ShowExportSuccessMessage(string format)
        {
            MessageBox.Show($"Report successfully exported to {format}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Menghitung total tinggi baris data secara dinamis guna menyesuaikan ukuran tinggi DataGridView agar pas di layar.
        /// </summary>
        private void AdjustGridHeight()
        {
            int totalHeight = DataList.ColumnHeadersHeight;
            foreach (DataGridViewRow row in DataList.Rows)
            {
                totalHeight += row.Height;
            }
            DataList.Height = totalHeight + 4;
        }

        #endregion
    }

    /// <summary>
    /// Provider eksternal (SRP) yang bertanggung jawab menentukan dan membuat objek exporter (Excel/PDF) berdasarkan string format.
    /// </summary>
    internal static class ExportFactoryProvider
    {
        /// <summary>
        /// Mengembalikan implementasi IReportExporter yang sesuai menggunakan Factory Pattern yang baru.
        /// </summary>
        public static IReportExporter GetExporter(string format)
        {
            ReportExporterFactory factory = format == "Excel"
                ? new ExcelReportExporterFactory()
                : new PdfReportExporterFactory();

            return factory.CreateExporter();
        }
    }
}