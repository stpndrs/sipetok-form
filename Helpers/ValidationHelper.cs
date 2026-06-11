using System;
using System.Windows.Forms; // Wajib di-import untuk membaca komponen Label
using sipetok_form.Models.dto.response; // Import namespace tempat ActionResponse berada

namespace sipetok_form.Helpers
{
    internal static class ValidationHelper
    {
        public static void ShowValidation<T>(ActionResponse<T> response, Label targetLabel)
        {
            if (targetLabel == null) return;

            if (response != null && response.Errors != null && response.Errors.Count > 0)
            {
                var sb = new System.Text.StringBuilder();
                // sb.AppendLine($"{response.Message}:");

                foreach (var item in response.Errors)
                {
                    foreach (var errorMsg in item.Value)
                    {
                        sb.AppendLine($"- {errorMsg}");
                    }
                }

                targetLabel.Text = sb.ToString();
                targetLabel.Visible = true;
            }
            else
            {
                targetLabel.Text = string.Empty;
                targetLabel.Visible = false;
            }
        }
    }
}