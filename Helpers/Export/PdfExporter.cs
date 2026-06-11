using sipetok_form.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace sipetok_form.Helpers.Export
{
    internal class PdfExporter : IExport
    {
        public void ExportOperationalList(List<Operational> operationalList, string filePath)
        {
            throw new NotImplementedException();
        }

        public void ExportTransactionList(List<Transaction> transactionList, string filePath)
        {
            throw new NotImplementedException();
        }
    }
}
