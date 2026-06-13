using ClosedXML.Excel;
using sipetok_form.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace sipetok_form.Helpers.Export
{
    internal class ExcelExporter : IExport
    {
        public void ExportOperationalList(List<Operational> operationalList, string filePath)
        {
            // 1. Membuat Workbook baru
            using (var workbook = new XLWorkbook())
            {
                // 2. Membuat Worksheet baru di dalam workbook
                var worksheet = workbook.Worksheets.Add("Laporan Operasional");

                // 3. Membuat Header Tabel
                worksheet.Cell("A1").Value = "ID";
                worksheet.Cell("B1").Value = "Nama Operasional";
                worksheet.Cell("C1").Value = "Biaya (Cost)";
                //worksheet.Cell("D1").Value = "Tenant ID";
                //worksheet.Cell("E1").Value = "Tanggal";
                worksheet.Cell("D1").Value = "Tanggal";

                // Desain Header sedikit biar rapi (Opsional)
                var headerRow = worksheet.Row(1);
                headerRow.Style.Font.Bold = true;
                headerRow.Style.Fill.BackgroundColor = XLColor.LightGray;

                // 4. Melakukan looping untuk memasukkan data dari List
                int currentRow = 2; // Data dimulai dari baris ke-2
                foreach (var item in operationalList)
                {
                    worksheet.Cell(currentRow, 1).Value = item.Id;
                    worksheet.Cell(currentRow, 2).Value = item.Name;
                    worksheet.Cell(currentRow, 3).Value = item.OperationalCost; // Jika ini berupa angka berformat string, excel akan membacanya sebagai teks
                    //worksheet.Cell(currentRow, 4).Value = item.TenantId;
                    worksheet.Cell(currentRow, 4).Value = item.OperationalDate;

                    // Mengatur format tanggal di Excel agar rapi
                    //worksheet.Cell(currentRow, 5).Style.DateFormat.Format = "yyyy-mm-dd";
                    worksheet.Cell(currentRow, 4).Style.DateFormat.Format = "yyyy-mm-dd";

                    currentRow++;
                }

                // 5. Auto-fit kolom agar lebar kolom menyesuaikan panjang teks otomatis
                worksheet.Columns().AdjustToContents();

                // 6. Menyimpan file Excel ke lokasi yang ditentukan
                workbook.SaveAs(filePath);
            }
        }

        public void ExportTransactionList(List<Transaction> transactionList, string filePath)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Laporan Transaksi");

                // 1. Membuat Header Tabel
                string[] headers = {
                    "ID Transaksi", "Tanggal", "Nama Pelanggan", "No. HP",
                    "Status Pembayaran", "Status Pesanan", "Total Harga", "Jumlah Bayar",
                    "ID Detail", "Kategori", "Jumlah (Qty)", "Harga Satuan", "Subtotal"
                };

                for (int i = 0; i < headers.Length; i++)
                {
                    worksheet.Cell(1, i + 1).Value = headers[i];
                }

                // Styling Header
                var headerRow = worksheet.Row(1);
                headerRow.Style.Font.Bold = true;
                headerRow.Style.Fill.BackgroundColor = XLColor.FromHtml("#2E7D32"); // Hijau gelap formal
                headerRow.Style.Font.FontColor = XLColor.White;

                // 2. Mengisi Data
                int currentRow = 2;

                foreach (var tx in transactionList)
                {
                    // Jika transaksi tidak memiliki detail (list kosong)
                    if (tx.Details == null || tx.Details.Count == 0)
                    {
                        WriteTransactionMaster(worksheet, currentRow, tx);
                        currentRow++;
                    }
                    else
                    {
                        // Jika ada detailnya, looping setiap detail item
                        foreach (var detail in tx.Details)
                        {
                            // Tulis data utama transaksi
                            WriteTransactionMaster(worksheet, currentRow, tx);

                            // Tulis data detail transaksi
                            worksheet.Cell(currentRow, 9).Value = detail.Id;
                            worksheet.Cell(currentRow, 10).Value = detail.Category.Name;
                            worksheet.Cell(currentRow, 11).Value = detail.Quantity;

                            // Menggunakan tipe decimal langsung agar Excel bisa menghitung (bukan string)
                            worksheet.Cell(currentRow, 12).Value = detail.PriceAtPurchase;
                            worksheet.Cell(currentRow, 13).Value = detail.Subtotal;

                            // Format Currency untuk Harga & Subtotal Detail
                            worksheet.Cell(currentRow, 12).Style.NumberFormat.Format = "#,##0";
                            worksheet.Cell(currentRow, 13).Style.NumberFormat.Format = "#,##0";

                            currentRow++;
                        }
                    }
                }

                // 3. Merapikan Format Kolom & Layout
                // Format Kolom Tanggal
                worksheet.Column(2).Style.DateFormat.Format = "yyyy-mm-dd hh:mm";

                // Format Currency untuk Total Harga & Jumlah Bayar Master
                worksheet.Column(7).Style.NumberFormat.Format = "#,##0";
                worksheet.Column(8).Style.NumberFormat.Format = "#,##0";

                // Auto-fit ukuran kolom
                worksheet.Columns().AdjustToContents();

                // 4. Simpan ke File
                workbook.SaveAs(filePath);
            }
        }

        // Helper method untuk menulis data master transaksi agar kode tidak duplikat
        private static void WriteTransactionMaster(IXLWorksheet worksheet, int row, Transaction tx)
        {
            worksheet.Cell(row, 1).Value = tx.Id;
            worksheet.Cell(row, 2).Value = tx.Date;
            worksheet.Cell(row, 3).Value = tx.CustomerName;
            worksheet.Cell(row, 4).Value = tx.CustomerPhoneNumber;
            worksheet.Cell(row, 5).Value = tx.PaymentStatus;
            worksheet.Cell(row, 6).Value = tx.OrderStatus;
            worksheet.Cell(row, 7).Value = tx.TotalPrice;
            worksheet.Cell(row, 8).Value = tx.PaymentAmount;
        }
    }
}
