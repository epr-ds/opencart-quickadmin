using Models;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using Tool.Printing.Ticket;

namespace WinForms.Services
{
    internal class TicketService
    {
        private static int TicketLen { get; } = 45 - 7;

        public static void PrintTicket(string document_name, PrinterSettings settings, OrderDataModel order, int font_size = 8)
        {
            TicketDocument ticket = new TicketDocument(document_name, font_size, TicketLen)
            {
                Logo = Properties.Resources.logotipo
            };

            ticket.PrinterSettings = settings;

            BuildHeader(ticket);
            BuildBody(ticket, order);
            BuildFooter(ticket);

            ticket.Print();
        }

        private static void BuildBody(TicketDocument ticket, OrderDataModel order)
        {
            CustomerModel customer = order.Customer;
            ticket.TextLocationMode = TextTicketLocation.Body;
            ticket.SideText("Fecha de expedición:", DateTime.Today.ToShortDateString());
            ticket.SideText("Fecha de venta:", order.DateAdded.ToShortDateString());
            ticket.SideText("Folio:", $"#{order.ID}");
            ticket.Separator(TicketSeparator.Dash);

            // Cliente
            ticket.CenterText("[Datos del cliente]");
            ticket.LeftText($"Nombre: {customer.Firstname} {customer.Lastname}");
            if (!string.IsNullOrWhiteSpace(customer.Email))
            {
                ticket.LeftText($"Email: {customer.Email}");
            }

            ticket.Separator(TicketSeparator.Asterisk);

            // Venta
            ticket.CenterText("[Datos de venta]");
            ticket.SideText("Método de pago:", order.PaymentMethod.ToString());
            ticket.SideText("Método de envío:", order.ShippingMethod.ToString());
            ticket.Separator(TicketSeparator.Blank);
            ticket.Separator(TicketSeparator.Dash);
            ticket.LeftText("Producto\tP/U\tCant\tTotal");
            ticket.Separator(TicketSeparator.Dash);

            // Productos
            StringBuilder serials = new StringBuilder();
            bool hasSerials = false;
            foreach (OrderProductModel op in order.Cart)
            {
                string prod = (op.Name.Length < 8) ? op.Name.PadRight(8) : op.Name.Substring(0, 8);

                ticket.LeftText($"-{prod}\t${op.Price:#.##}\t{op.Quantity}\t${op.Total:#.##}");

                if (op.SerialNumbers.Count() > 0)
                {
                    hasSerials = true;
                    foreach (ProductSerialModel serial in op.SerialNumbers)
                    {
                        serials
                            .Append($"-{prod} {serial.SerialNumber}"
                            .PadRight(TicketLen))
                            .Append($"{serial.DateStart.ToShortDateString()} {serial.DateEnd.ToShortDateString()}"
                            .PadRight(TicketLen));
                    }
                }
            }
            if (hasSerials)
            {
                ticket.Separator(TicketSeparator.Dash);
                // Serials
                ticket.CenterText("# Serie | Garantía");
                ticket.Separator(TicketSeparator.Blank);
                ticket.LeftText(serials.ToString());
            }

            ticket.Separator(TicketSeparator.Dash);

            // Totales
            var orderTotals = order.OrderTotals.OrderBy(o => o.SortOrder);
            foreach (OrderTotalModel ot in orderTotals)
            {
                ticket.RightText($"{ot.Title}: {((ot.Value != 0) ? $"{ot.Value:#.##}" : "N/A")}");
            }
            ticket.RightText($"IVA: 16%");
            ticket.Separator(TicketSeparator.Dash);
        }

        private static void BuildFooter(TicketDocument ticket)
        {
            ticket.TextLocationMode = TextTicketLocation.Footer;
            ticket.Text[TextTicketLocation.Footer].Font = new Font(FontFamily.GenericMonospace.Name, 7, FontStyle.Regular);
            string[] terms = new string[]
            {
                "*Toda garantía o reparación de equipos de almacenamiento, aplica respecto a daño físico y no sobre la información contenida.",
                "*El cliente tendrá un plazo máximo de 5 días hábiles para recoger su equipo, posteriores a la notificación de que el mismo se encuentre listo. Después del plazo, no nos hacemos responsables de equipos no reclamados.",
                "*Toda reparación dentro del período de garantía, se encuentra sujeta a los términos que la póliza marque.",
                "*De ser necesario el envío por paquetería dentro o fuera de la zona metropolitana, el cliente cubrirá los gastos que éste genere.",
                "*El cliente se hace responsable de que la información presentada en el documento es correcta y accepta los términos y condiciones en el mismo."
            };
            foreach (string tc in terms)
            {
                ticket.LeftText(tc);
            }
        }

        private static void BuildHeader(TicketDocument ticket)
        {
            string[] header = new string[]
            {
                "Rosalio Barajas Amezquita",
                "R.F.C. BAAR820625AH9",
                "Av. de los Normalistas 564, Colinas de La Normal, 44270 Guadalajara, Jal.",
                "Tel: (33) 3854-54-63 Ext 4",
                "E-mail: ventas@tecnomarketing.com.mx",
                "www.tecnomarketing.com.mx",
                "Horario: L-V. De 9-14 hrs y 16-19 hrs",
                "Sábados de 9 a 14 hrs"
            };
            foreach (string ht in header)
            {
                ticket.CenterText(ht);
            }

            ticket.Separator(TicketSeparator.Dash);
        }
    }
}
