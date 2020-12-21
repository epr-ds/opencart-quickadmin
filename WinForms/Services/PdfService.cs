using Models;
using SelectPdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace WinForms.Services
{
    internal static class PdfService
    {
        public static async Task<string> BuildPdf(OrderDataModel order)
        {
            string template = Properties.Settings.Default.template;

            if (string.IsNullOrWhiteSpace(template))
                throw new InvalidOperationException("No se puede generar el archivo solicitado, debido a que la plantilla no está establecida.");

            if (!File.Exists(template))
                throw new InvalidOperationException("La plantilla para generar el arhcivo no existe, por favor, verifique la ruta al archivo.");

            string html = File.ReadAllText(template);
            html = ModeltoHtml(order, html);
            
            string tmpDir = Path.GetTempPath();
            string filename = $"{tmpDir}\\{order.ID}_{order.Customer.Firstname}{order.Customer.Lastname}.pdf";
            
            await HTMLtoPDF(html, filename, template);

            return filename;
        }

        private static Task HTMLtoPDF(string html, string filename, string templateDir)
        {
            HtmlToPdf converter = new HtmlToPdf();
            //Setting up
            converter.Options.PdfPageSize = PdfPageSize.A4;
            converter.Options.PdfPageOrientation = PdfPageOrientation.Portrait;
            converter.Options.AutoFitWidth = HtmlToPdfPageFitMode.AutoFit;
            converter.Options.PdfDocumentInformation.Title = "Tecnomarketing: Comprobante de venta";
            converter.Options.PdfDocumentInformation.Author = "Tecnomarketing";
            converter.Options.PdfDocumentInformation.Subject = "Comprobante de venta";
            return Task.Run(() =>
            {
                // Make file
                PdfDocument doc = converter.ConvertHtmlString(html, templateDir);
                doc.Save(filename);
                doc.Close();
            });
        }

        private static string ModeltoHtml(OrderDataModel order, string html)
        {
            // Order Products
            string html_products = string.Empty;
            foreach (OrderProductModel or in order.Cart)
            {
                html_products += $"<tr><td>{or.Name}</td><td>{or.Model}</td><td>${or.Price:#.##}</td><td>{or.Quantity}</td><td>${or.Total:#.##}</td><td><ul>[FLAG_SERIALS]<ul></td></tr>";
                string html_serials = string.Empty;
                if (or.SerialNumbers != null)
                {
                    foreach (ProductSerialModel serial in or.SerialNumbers)
                    {
                        html_serials += $"<li>{serial.SerialNumber} | {serial.DateStart.ToShortDateString()} - {serial.DateEnd.ToShortDateString()}</li>";
                    }
                }
                html_products = html_products.Replace("[FLAG_SERIALS]", html_serials);
            }

            // Totals
            string html_totals_header = string.Empty;
            string html_totals_value = string.Empty;
            foreach (OrderTotalModel t in order.OrderTotals)
            {
                html_totals_header += $"<th>{t.Title}</th>";
                html_totals_value += $"<td>{(t.Value != 0 ? $"${t.Value:#.##}" : "N/A")}</td>";
            }

            var flags = new Dictionary<string, string>()
            {
                // Order
                { "[FLAG_DATE_EXPEDITION]", DateTime.Today.ToShortDateString() },
                { "[FLAG_FOLIO]", order.ID.ToString() },
                { "[FLAG_DATE_ORDER]", order.DateAdded.ToShortDateString() },
                // Customer
                { "[FLAG_CNAME]", $"{order.Customer.Firstname} {order.Customer.Lastname}"},
                { "[FLAG_TELEPHONE]", $"{order.Customer.Telephone}" },
                { "[FLAG_EMAIL]", $"{order.Customer.Email}" },
                { "[FLAG_INVOICE]", $"{order.InvoicePrefix}{order.InvoiceNo}" },
                { "[FLAG_PAYMETHOD]", order.PaymentMethod.ToString() },
                { "[FLAG_SHIPMETHOD]", order.ShippingMethod.ToString() },
                // Payment
                { "[FLAG_PAYMENT_NAME]", $"{order.PaymentAddress.Firstname} {order.PaymentAddress.Lastname}" },
                { "[FLAG_PAYMENT_COMPANY]", order.PaymentAddress.Company },
                { "[FLAG_PAYMENT_ADDRESS]", order.PaymentAddress.Address1 },
                { "[FLAG_PAYMENT_CITY]", order.PaymentAddress.City },
                { "[FLAG_PAYMENT_POSTCODE]", order.PaymentAddress.Postcode },
                { "[FLAG_PAYMENT_ZONE]", order.PaymentAddress.Zone.ToString() },
                { "[FLAG_PAYMENT_COUNTRY]", order.PaymentAddress.Country.ToString() },
                // Shipping
                { "[FLAG_SHIPPING_NAME]", $"{order.ShippingAddress.Firstname} {order.ShippingAddress.Lastname}" },
                { "[FLAG_SHIPPING_COMPANY]", order.ShippingAddress.Company },
                { "[FLAG_SHIPPING_ADDRESS]", order.ShippingAddress.Address1 },
                { "[FLAG_SHIPPING_CITY]", order.ShippingAddress.City },
                { "[FLAG_SHIPPING_POSTCODE]", order.ShippingAddress.Postcode },
                { "[FLAG_SHIPPING_ZONE]", order.ShippingAddress.Zone.ToString() },
                { "[FLAG_SHIPPING_COUNTRY]", order.ShippingAddress.Country.ToString() },
                // Products
                { "[FLAG_PRODS]", html_products },
                // Totals
                { "[FLAG_TOTALS_HEADER]", html_totals_header },
                { "[FLAG_TOTALS_VALUE]", html_totals_value },
                { "[FLAG_IVA]", "16%" }
            };

            foreach (var flag in flags)
            {
                html = html.Replace(flag.Key, flag.Value);
            }

            return html;
        }
    }
}
