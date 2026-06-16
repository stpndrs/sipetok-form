using ClosedXML.Excel;
using sipetok_form.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace sipetok_form.Helpers.Export
{
    /// <summary>
    /// Komponen mesin pengekspor (Concrete Exporter) yang bertanggung jawab menghasilkan dokumen Microsoft Excel (.xlsx).
    /// </summary>
    internal class ExcelReportExporter : IReportExporter
    {
        private const string NumericFormat = "#,##0";
        private const string DateFormatShort = "yyyy-MM-dd";
        private const string DateFormatFull = "yyyy-MM-dd HH:mm";

        /// <summary>
        /// Mengekspor daftar pengeluaran operasional ke dalam format Excel.
        /// </summary>
        public void ExportOperationalList(List<Operational> operationalList, string filePath)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Laporan Operasional");

                // 1. Setup Header Tabel
                string[] headers = { "ID", "Nama Operasional", "Biaya (Cost)", "Tanggal" };
                for (int i = 0; i < headers.Length; i++)
                {
                    worksheet.Cell(1, i + 1).Value = headers[i];
                }
                ApplyHeaderStyle(worksheet.Row(1), "#2E7D32", XLColor.White);

                // 2. Isi Data Baris Demi Baris
                int currentRow = 2;
                foreach (var item in operationalList)
                {
                    worksheet.Cell(currentRow, 1).Value = item.Id;
                    worksheet.Cell(currentRow, 2).Value = item.Name;
                    worksheet.Cell(currentRow, 3).Value = item.OperationalCost;
                    worksheet.Cell(currentRow, 4).Value = item.OperationalDate;

                    worksheet.Cell(currentRow, 3).Style.NumberFormat.Format = NumericFormat;
                    worksheet.Cell(currentRow, 4).Style.DateFormat.Format = DateFormatShort;

                    currentRow++;
                }

                // 3. Finalisasi Layout Dokumen
                FinalizeWorksheetLayout(worksheet, filePath, workbook);
            }
        }

        /// <summary>
        /// Mengekspor daftar transaksi beserta relasi detail itemnya ke dalam format Excel dengan skema merge cell.
        /// </summary>
        public void ExportTransactionList(List<Transaction> transactionList, string filePath)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Laporan Transaksi");

                // 1. Setup Header Tabel
                string[] headers = {
                    "ID Transaksi", "Tanggal", "Nama Pelanggan", "No. HP",
                    "Status Pembayaran", "Status Pesanan", "Total Harga", "Jumlah Bayar",
                    "ID Detail", "Kategori", "Jumlah (Qty)", "Harga Satuan", "Subtotal"
                };
                for (int i = 0; i < headers.Length; i++)
                {
                    worksheet.Cell(1, i + 1).Value = headers[i];
                }
                ApplyHeaderStyle(worksheet.Row(1), "#2E7D32", XLColor.White);

                // 2. Isi Data Master-Detail
                int currentRow = 2;
                foreach (var transaction in transactionList)
                {
                    int startRow = currentRow;

                    if (transaction.Details == null || !transaction.Details.Any())
                    {
                        WriteTransactionMaster(worksheet, currentRow, transaction);
                        WriteEmptyTransactionDetails(worksheet, currentRow);
                        currentRow++;
                    }
                    else
                    {
                        foreach (var detail in transaction.Details)
                        {
                            WriteTransactionDetailRow(worksheet, currentRow, detail);
                            currentRow++;
                        }

                        int endRow = currentRow - 1;
                        WriteTransactionMaster(worksheet, startRow, transaction);
                        MergeTransactionMasterRows(worksheet, startRow, endRow);
                    }
                }

                // 3. Konfigurasi Format Kolom Global & Layouting
                FormatTransactionGlobalColumns(worksheet);
                FinalizeWorksheetLayout(worksheet, filePath, workbook);
            }
        }

        #region Helper Core Logic Methods (KISS & DRY)

        /// <summary>
        /// Menulis data kolom master transaksi pada baris yang ditentukan.
        /// </summary>
        private static void WriteTransactionMaster(IXLWorksheet worksheet, int row, Transaction transaction)
        {
            worksheet.Cell(row, 1).Value = transaction.Id;
            worksheet.Cell(row, 2).Value = transaction.Date;
            worksheet.Cell(row, 3).Value = transaction.CustomerName;
            worksheet.Cell(row, 4).Value = transaction.CustomerPhoneNumber;
            worksheet.Cell(row, 5).Value = transaction.PaymentStatus;
            worksheet.Cell(row, 6).Value = transaction.OrderStatus;
            worksheet.Cell(row, 7).Value = transaction.TotalPrice;
            worksheet.Cell(row, 8).Value = transaction.PaymentAmount;
        }

        /// <summary>
        /// Mengisi kolom detail transaksi dengan nilai default kosong atau strip (-) jika transaksi tidak memiliki detail item.
        /// </summary>
        private static void WriteEmptyTransactionDetails(IXLWorksheet worksheet, int row)
        {
            worksheet.Cell(row, 9).Value = "-";
            worksheet.Cell(row, 10).Value = "-";
            worksheet.Cell(row, 11).Value = 0;
            worksheet.Cell(row, 12).Value = 0;
            worksheet.Cell(row, 13).Value = 0;
        }

        /// <summary>
        /// Menulis satu baris data detail transaksi lengkap dengan format angka mata uang.
        /// </summary>
        private static void WriteTransactionDetailRow(IXLWorksheet worksheet, int row, TransactionDetail detail)
        {
            worksheet.Cell(row, 9).Value = detail.Id;
            worksheet.Cell(row, 10).Value = detail.Category?.Name ?? "-";
            worksheet.Cell(row, 11).Value = detail.Quantity;
            worksheet.Cell(row, 12).Value = detail.PriceAtPurchase;
            worksheet.Cell(row, 13).Value = detail.Subtotal;

            worksheet.Cell(row, 12).Style.NumberFormat.Format = NumericFormat;
            worksheet.Cell(row, 13).Style.NumberFormat.Format = NumericFormat;
        }

        /// <summary>
        /// Menggabungkan (Merge) baris-baris data master transaksi yang memiliki item detail melimpah agar terlihat rapi secara vertikal.
        /// </summary>
        private static void MergeTransactionMasterRows(IXLWorksheet worksheet, int startRow, int endRow)
        {
            for (int col = 1; col <= 8; col++)
            {
                var range = worksheet.Range(startRow, col, endRow, col);
                range.Merge();
                range.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                bool isCenterAlignedColumn = new[] { 1, 2, 4, 5, 6 }.Contains(col);
                if (isCenterAlignedColumn)
                {
                    range.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                }
                else if (col == 7 || col == 8)
                {
                    range.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
                }
            }
        }

        /// <summary>
        /// Mengatur penyesuaian gaya (Styling) warna latar belakang dan warna font untuk baris header tabel.
        /// </summary>
        private static void ApplyHeaderStyle(IXLRow headerRow, string htmlHexColor, XLColor fontColor)
        {
            headerRow.Style.Font.Bold = true;
            headerRow.Style.Fill.BackgroundColor = XLColor.FromHtml(htmlHexColor);
            headerRow.Style.Font.FontColor = fontColor;
        }

        /// <summary>
        /// Menerapkan format data numerik dan datetime global pada seluruh rentang kolom transaksi.
        /// </summary>
        private static void FormatTransactionGlobalColumns(IXLWorksheet worksheet)
        {
            worksheet.Column(2).Style.DateFormat.Format = DateFormatFull;
            worksheet.Column(7).Style.NumberFormat.Format = NumericFormat;
            worksheet.Column(8).Style.NumberFormat.Format = NumericFormat;
        }

        /// <summary>
        /// Menyelesaikan pembuatan layout dokumen dengan fitur auto-fit teks kolom dan menyimpan berkas ke penyimpanan komputer.
        /// </summary>
        private static void FinalizeWorksheetLayout(IXLWorksheet worksheet, string filePath, XLWorkbook workbook)
        {
            worksheet.Columns().AdjustToContents();
            workbook.SaveAs(filePath);
        }

        #endregion
    }
}