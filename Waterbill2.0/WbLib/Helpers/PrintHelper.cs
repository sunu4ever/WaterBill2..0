using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Drawing;

namespace WbLib.Helpers
{
    public static class PrintHelper
    {
        static PrintDocument pdoc = null;
        public static string PrintFontName = "Courier New";
        public static string GetDefaultPrinter()
        {
            PrinterSettings settings = new PrinterSettings();
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                settings.PrinterName = printer;

                if (settings.IsDefaultPrinter)
                    return printer;
            }
            return string.Empty;
        }
        public static PrintDocument PrintToPrinter(PaperSize PSize,int PaperHeight,int PaperWidth)
        {
            PrintDialog pd = new PrintDialog();
            pdoc = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            Font font = new Font(PrintFontName, 15);
            pd.Document = pdoc;
            pd.Document.DefaultPageSettings.PaperSize = PSize;
            pd.PrinterSettings.PrinterName = GetDefaultPrinter();
            pdoc.DefaultPageSettings.PaperSize.Height = PaperHeight;
            pdoc.DefaultPageSettings.PaperSize.Width = PaperWidth;
            pdoc.DefaultPageSettings.PaperSize = PSize;
            return pdoc;
        }
    }
}
