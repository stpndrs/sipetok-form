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
using System.Text;
using System.Windows.Forms;

namespace sipetok_form.Views.Laporan
{
    public partial class LaporanPage : Form
    {
        private readonly ApiLaporan _LaporanService = new ApiLaporan();
        public LaporanPage()
        {
            InitializeComponent();
            this.Load += LaporanPage_Load;
        }

        private void handleClickMenu(object sender, EventArgs e)
        {
            MenuHelper.HandleClick(sender, e, this);
        }

        private void LaporanPage_Load(object sender, EventArgs e)
        {
            btnTransaksi.PerformClick();
        }

        private async void btnTransaksi_Click(object sender, EventArgs e)
        {
            try
            {
                btnTransaksi.Enabled = false; // Matikan tombol sementara saat loading

                // 1. Ambil data transaksi dari API
                List<Transaction>? dataTransaksi = await _LaporanService.GetTransaksiAsync();

                if (dataTransaksi != null)
                {
                    // 2. Reset Grid agar kolom lama hilang
                    dataGridView1.DataSource = null;
                    dataGridView1.Columns.Clear();

                    // 3. Ikat data baru ke Grid
                    dataGridView1.DataSource = dataTransaksi;

                    // 4. Atur susunan Header Kolom untuk Transaksi
                    dataGridView1.Columns["Id"].HeaderText = "ID Transaksi";
                    dataGridView1.Columns["Date"].HeaderText = "Tanggal";
                    dataGridView1.Columns["CustomerName"].HeaderText = "Nama Pelanggan";
                    dataGridView1.Columns["TotalPrice"].HeaderText = "Total Harga";
                    dataGridView1.Columns["PaymentStatus"].HeaderText = "Status Pembayaran";
                    dataGridView1.Columns["OrderStatus"].HeaderText = "Status Pesanan";

                    // Sembunyikan kolom Detail atau kolom lain yang tidak ingin ditampilkan langsung di grid utama
                    if (dataGridView1.Columns.Contains("Details")) dataGridView1.Columns["Details"].Visible = false;
                    if (dataGridView1.Columns.Contains("TenantId")) dataGridView1.Columns["TenantId"].Visible = false;
                    if (dataGridView1.Columns.Contains("Tenant")) dataGridView1.Columns["Tenant"].Visible = false;
                    if (dataGridView1.Columns.Contains("PaymentAmount")) dataGridView1.Columns["PaymentAmount"].Visible = false;
                    if (dataGridView1.Columns.Contains("CustomerPhoneNumber")) dataGridView1.Columns["CustomerPhoneNumber"].Visible = false;

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    AdjustGridHeight();
                }
                else
                {
                    MessageBox.Show("Data transaksi tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show($"Gagal memuat laporan transaksi: {ex.Message}", "Error Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnTransaksi.Enabled = true;
                btnTransaksi.BackColor = Color.LightGray;
                btnOperational.BackColor = Color.White;
                label2.Text = "Kelola Laporan Transaksi";
            }
        }

        private async void btnOperational_Click(object sender, EventArgs e)
        {
            try
            {
                btnOperational.Enabled = false; // Matikan tombol sementara saat loading

                // 1. Ambil data operasional dari service yang sudah kita bahas sebelumnya
                List<Operational>? dataOperational = await _LaporanService.GetOperationalAsync();

                if (dataOperational != null)
                {
                    // 2. Reset Grid agar kolom lama hilang
                    dataGridView1.DataSource = null;
                    dataGridView1.Columns.Clear();

                    // 3. Ikat data baru ke Grid
                    dataGridView1.DataSource = dataOperational;

                    // 4. Atur susunan Header Kolom untuk Operasional
                    // (Sesuaikan nama properti di dalam tanda kutip dengan yang ada di class Operational Anda)
                    dataGridView1.Columns["Id"].HeaderText = "ID Operasional";
                    dataGridView1.Columns["Name"].HeaderText = "Nama Pengeluaran";
                    dataGridView1.Columns["OperationalCost"].HeaderText = "Biaya Operasional";

                    if (dataGridView1.Columns.Contains("TenantId")) dataGridView1.Columns["TenantId"].Visible = false;
                    if (dataGridView1.Columns.Contains("Tenant")) dataGridView1.Columns["Tenant"].Visible = false;

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    AdjustGridHeight();
                }
                else
                {
                    MessageBox.Show("Data operasional tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show($"Gagal memuat laporan operasional: {ex.Message}", "Error Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnOperational.Enabled = true;
                btnOperational.BackColor = Color.LightGray;
                btnTransaksi.BackColor = Color.White;
                label2.Text = "Kelola Laporan Operational";
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validasi: Pastikan user sudah memilih format file (Excel / PDF)
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Silakan pilih format file ekspor (Excel atau Pdf)!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Ambil nilai filter dari komponen UI Anda
                DateTime tanggalMulai = dateTimePickerMulai.Value.Date;
                DateTime tanggalSelesai = dateTimePickerSelesai.Value.Date.AddDays(1).AddTicks(-1); // Mengcakup penuh sampai jam 23:59:59

                if (tanggalMulai > tanggalSelesai)
                {
                    MessageBox.Show("Tanggal mulai tidak boleh melebihi tanggal selesai!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string formatTerpilih = comboBox1.SelectedItem.ToString();

                // 3. Deteksi Jenis Data yang Sedang Aktif di Grid
                if (dataGridView1.DataSource is List<Transaction> listTransaksi)
                {
                    // Saring data Transaksi berdasarkan rentang tanggal
                    var dataFiltered = listTransaksi
                        .Where(t => t.Date >= tanggalMulai && t.Date <= tanggalSelesai)
                        .ToList();

                    if (dataFiltered.Count == 0)
                    {
                        MessageBox.Show("Tidak ada data transaksi pada rentang tanggal tersebut.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Jalankan Windows Save Dialog
                    string fileName = $"Laporan_Transaksi_{tanggalMulai:yyyyMMdd}_sd_{dateTimePickerSelesai.Value:yyyyMMdd}";
                    string filePath = GetSaveFilePath(formatTerpilih, fileName);

                    if (!string.IsNullOrEmpty(filePath))
                    {
                        // Gunakan Factory Pattern 
                        ExportFactory factory = formatTerpilih == "Excel" ? new ExcelFactory() : new PdfFactory();
                        IExport exporter = factory.CreateExporter();

                        exporter.ExportTransactionList(dataFiltered, filePath);
                        MessageBox.Show($"Laporan Transaksi sukses diekspor ke {formatTerpilih}!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (dataGridView1.DataSource is List<Operational> listOperasional)
                {
                    // Saring data Operasional berdasarkan rentang tanggal
                    var dataFiltered = listOperasional
                        .Where(o => o.OperationalDate >= tanggalMulai && o.OperationalDate <= tanggalSelesai)
                        .ToList();

                    if (dataFiltered.Count == 0)
                    {
                        MessageBox.Show("Tidak ada data operasional pada rentang tanggal tersebut.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Jalankan Windows Save Dialog
                    string fileName = $"Laporan_Operasional_{tanggalMulai:yyyyMMdd}_sd_{dateTimePickerSelesai.Value:yyyyMMdd}";
                    string filePath = GetSaveFilePath(formatTerpilih, fileName);

                    if (!string.IsNullOrEmpty(filePath))
                    {
                        // Gunakan Factory Pattern 
                        ExportFactory factory = formatTerpilih == "Excel" ? new ExcelFactory() : new PdfFactory();
                        IExport exporter = factory.CreateExporter();

                        exporter.ExportOperationalList(dataFiltered, filePath);
                        MessageBox.Show($"Laporan Operasional sukses diekspor ke {formatTerpilih}!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Tidak ada data di tabel yang dapat diekspor. Silakan muat data terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (NotImplementedException)
            {
                MessageBox.Show($"Fitur ekspor ke format tersebut belum diimplementasikan di kelas Exporter Anda.", "Info Pengembang", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat mengekspor data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper Fungsi untuk memunculkan SaveFileDialog agar kode bersih tidak duplikat
        private string GetSaveFilePath(string format, string defaultFileName)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                if (format == "Excel")
                {
                    sfd.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
                    sfd.FileName = defaultFileName + ".xlsx";
                }
                else
                {
                    sfd.Filter = "PDF Document (*.pdf)|*.pdf";
                    sfd.FileName = defaultFileName + ".pdf";
                }

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    return sfd.FileName;
                }
            }
            return string.Empty;
        }

        private void AdjustGridHeight()
        {
            // 1. Hitung tinggi Header Kolom (Tempat tulisan ID, Tanggal, dll)
            int totalHeight = dataGridView1.ColumnHeadersHeight;

            // 2. Tambahkan tinggi dari setiap baris data yang muncul
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Visible)
                {
                    totalHeight += row.Height;
                }
            }

            // 3. Tambahkan sedikit pixel untuk border/garis pembatas tabel (sekitar 3-9 pixel)
            totalHeight += (dataGridView1.BorderStyle == BorderStyle.None) ? 3 : 9;

            // 4. Batasi tinggi maksimal agar tidak menembus bawah Form/layar Laptop
            // Misal kita set tinggi maksimalnya adalah 600 pixel
            int maxAllowedHeight = 600;

            if (totalHeight > maxAllowedHeight)
            {
                dataGridView1.Height = maxAllowedHeight;
            }
            else
            {
                dataGridView1.Height = totalHeight;
            }
        }
    }
}
