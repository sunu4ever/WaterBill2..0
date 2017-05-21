using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI;
using System.Data;
using System.Drawing;
using Telerik.WinControls.Data;
using System.ComponentModel;
using Telerik.WinControls;
using Telerik.WinControls.UI.Export;
using Telerik.WinControls.UI.Export.ExcelML;
using System.IO;

namespace WbLib.Helpers
{
    public static class CommonHelper
    {
        #region Common helper
        public static DateTime GetToday()
        {
            return DateTime.Now;
        }
        public static decimal GetNumericMaskTextboxvalue(string TextboxValue)
        {
            if (string.IsNullOrEmpty(TextboxValue)) return 0;
            return decimal.Parse(TextboxValue.Replace(",", ""));
        }
        public static decimal GetAmountWithoutTax(decimal Amount, decimal Tax)
        {
            return Amount - (Amount * (Tax / 100));
        }
        public static decimal GetTaxAmount(decimal Amount, decimal Tax)
        {
            return Amount * (Tax / 100);
        }
        #endregion

        #region radGridFormat
        public static void FormatRadGrid(RadGridView radGrid, DataView Source, string[] AggrCols, string[] GroupCol, string[] HiddenCol, bool IsGrandTotal, string[] colWidth)
        {
            // Fill Data To Grid
            radGrid.ViewCellFormatting -= new CellFormattingEventHandler(dgvRadGrid_ViewCellFormatting);
            radGrid.ViewCellFormatting += new CellFormattingEventHandler(dgvRadGrid_ViewCellFormatting);
            radGrid.DataSource = null;
            radGrid.DataSource = Source;
            //Disbale Column
            if (HiddenCol != null)
            {
                for (int i = 0; i < HiddenCol.Length; i++)
                {
                    radGrid.Columns[HiddenCol[i]].IsVisible = false;
                }
            }
            // Align each column in the grid
            int colInc = 0;
            foreach (var column in radGrid.Columns)
            {
                switch (column.DataType.Name)
                {
                    case "String":
                        column.TextAlignment = ContentAlignment.MiddleLeft;
                        break;
                    case "Int64":
                    case "Int32":
                        column.TextAlignment = ContentAlignment.MiddleCenter;
                        break;
                    case "Decimal":
                        column.TextAlignment = ContentAlignment.MiddleRight;
                        break;
                    default:
                        column.TextAlignment = ContentAlignment.MiddleLeft;
                        break;
                }
                //if (colWidth != null)
                //{
                //    column.Width = int.Parse(colWidth[colInc].ToString());
                //    colInc++;
                //}
            }

            // Setting the Grouped Column
            if (GroupCol != null)
            {
                GroupDescriptor descriptor;
                for (int i = 0; i < GroupCol.Length; i++)
                {
                    if (!string.IsNullOrEmpty(GroupCol[i].ToString()) && !string.IsNullOrWhiteSpace(GroupCol[i].ToString()))
                    {
                        descriptor = new GroupDescriptor();
                        descriptor.GroupNames.Add(GroupCol[i], ListSortDirection.Ascending);
                        radGrid.GroupDescriptors.Add(descriptor);
                    }
                }
            }

            //Auto fil the column in the grid
            // if (colWidth == null)
            //{
            radGrid.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            //}
            // Setting the Total for Columns
            if (AggrCols != null)
            {
                GridViewSummaryItem summaryItem;
                GridViewSummaryRowItem summaryRowItem = new GridViewSummaryRowItem();
                for (int i = 0; i < AggrCols.Length; i++)
                {
                    summaryItem = new GridViewSummaryItem();
                    summaryItem.Name = AggrCols[i];
                    summaryItem.Aggregate = GridAggregateFunction.Sum;
                    summaryItem.FormatString = "{0}";
                    summaryRowItem.Add(summaryItem);
                }
                if (radGrid.SummaryRowsBottom.Count > 0)
                {
                    radGrid.SummaryRowsBottom.RemoveAt(0);
                }
                radGrid.SummaryRowsBottom.Add(summaryRowItem);
            }
            // Adding the Grand Total Property
            radGrid.MasterTemplate.ShowTotals = IsGrandTotal;

        }
        private static void dgvRadGrid_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.CellElement.RowInfo is GridViewSummaryRowInfo)
            {
                e.CellElement.DrawFill = true;
                e.CellElement.GradientStyle = GradientStyles.Solid;
                e.CellElement.BackColor = Color.Beige;
                e.CellElement.TextAlignment = ContentAlignment.MiddleRight;
                e.CellElement.Font = new Font(e.CellElement.Font, FontStyle.Bold);
            }
        }
        #endregion

        #region Expot to Excel
        public static void ExportRadGridAsExcel(RadGridView radGrid, String ExportFilePath, String ReportHeaderName, HiddenOption ExportHiddenColumn, HiddenOption ExportHiddenrow, SummariesOption ExportSummary, bool ExportVisuals)
        {
            ExportToExcelML excelExporter = new ExportToExcelML(radGrid);
            excelExporter.FileExtension = "xls";
            //excelExporter.HiddenColumnOption = ExportHiddenColumn;
            //excelExporter.HiddenRowOption = ExportHiddenrow;
            //excelExporter.SummariesExportOption = ExportSummary;
            //excelExporter.ExportVisualSettings = ExportVisuals;
            //excelExporter.ExcelTableCreated += new ExcelTableCreatedEventHandler((sender, e) => exporter_ExcelTableCreated(sender, e, ReportHeaderName));
            // excelExporter.ExcelCellFormatting += new ExcelCellFormattingEventHandler(exporter_ExcelCellFormatting);
            excelExporter.RunExport(ExportFilePath);
        }
        private static void exporter_ExcelCellFormatting(object sender, ExcelCellFormattingEventArgs e)
        {
            BorderStyles borderBottom = new BorderStyles();
            borderBottom.Color = Color.Black;
            borderBottom.Weight = 1;
            borderBottom.LineStyle = LineStyle.Continuous;
            borderBottom.PositionType = PositionType.Bottom;
            e.ExcelStyleElement.Borders.Add(borderBottom);

            BorderStyles borderTop = new BorderStyles();
            borderTop.Color = Color.Black;
            borderTop.Weight = 1;
            borderTop.LineStyle = LineStyle.Continuous;
            borderTop.PositionType = PositionType.Top;
            e.ExcelStyleElement.Borders.Add(borderTop);

            BorderStyles borderLeft = new BorderStyles();
            borderLeft.Color = Color.Black;
            borderLeft.Weight = 1;
            borderLeft.LineStyle = LineStyle.Continuous;
            borderLeft.PositionType = PositionType.Left;
            e.ExcelStyleElement.Borders.Add(borderLeft);

            BorderStyles borderRight = new BorderStyles();
            borderRight.Color = Color.Black;
            borderRight.Weight = 1;
            borderRight.LineStyle = LineStyle.Continuous;
            borderRight.PositionType = PositionType.Right;
            e.ExcelStyleElement.Borders.Add(borderRight);

            if (e.GridRowInfoType == typeof(GridViewTableHeaderRowInfo))
            {
                e.ExcelStyleElement.FontStyle.Bold = true;
                e.ExcelStyleElement.FontStyle.Size = 11;
            }
        }
        private static void exporter_ExcelTableCreated(object sender, ExcelTableCreatedEventArgs e, String ReportHeaderName)
        {
            string headerText = "";
            SingleStyleElement style;

            headerText = "M/S . FMB ELETRONICS";
            style = ((ExportToExcelML)sender).AddCustomExcelRow(e.ExcelTableElement, 24, headerText);
            style.FontStyle.Bold = true;
            style.FontStyle.Size = 13;
            style.FontStyle.Color = Color.Black;
            style.InteriorStyle.Color = Color.White;
            style.InteriorStyle.Pattern = InteriorPatternType.Solid;
            style.AlignmentElement.HorizontalAlignment = HorizontalAlignmentType.Center;
            style.AlignmentElement.VerticalAlignment = VerticalAlignmentType.Center;

            headerText = "THAJ SHOPING CENTER,NEAR BUS STAND,BADIADKA";
            style = ((ExportToExcelML)sender).AddCustomExcelRow(e.ExcelTableElement, 19, headerText);
            style.FontStyle.Bold = true;
            style.FontStyle.Size = 9;
            style.FontStyle.Color = Color.Black;
            style.InteriorStyle.Color = Color.White;
            style.InteriorStyle.Pattern = InteriorPatternType.Solid;
            style.AlignmentElement.HorizontalAlignment = HorizontalAlignmentType.Center;
            style.AlignmentElement.VerticalAlignment = VerticalAlignmentType.Center;

            headerText = "PH:04998-285509,9446990708,9447651666,email-siddifmb@gmail.com";
            style = ((ExportToExcelML)sender).AddCustomExcelRow(e.ExcelTableElement, 19, headerText);
            style.FontStyle.Bold = true;
            style.FontStyle.Size = 9;
            style.FontStyle.Color = Color.Black;
            style.InteriorStyle.Color = Color.White;
            style.InteriorStyle.Pattern = InteriorPatternType.Solid;
            style.AlignmentElement.HorizontalAlignment = HorizontalAlignmentType.Center;
            style.AlignmentElement.VerticalAlignment = VerticalAlignmentType.Center;

            headerText = "The Kerala Value added Tax Rule,2005 Form  NO 8B(See rule 58(10)) , Tin No 32130595113";
            style = ((ExportToExcelML)sender).AddCustomExcelRow(e.ExcelTableElement, 19, headerText);
            style.FontStyle.Bold = true;
            style.FontStyle.Size = 9;
            style.FontStyle.Color = Color.Black;
            style.InteriorStyle.Color = Color.White;
            style.InteriorStyle.Pattern = InteriorPatternType.Solid;
            style.AlignmentElement.HorizontalAlignment = HorizontalAlignmentType.Center;
            style.AlignmentElement.VerticalAlignment = VerticalAlignmentType.Center;

            headerText = ReportHeaderName;
            style = ((ExportToExcelML)sender).AddCustomExcelRow(e.ExcelTableElement, 19, headerText);
            style.FontStyle.Bold = true;
            style.FontStyle.Size = 11;
            style.FontStyle.Color = Color.Black;
            style.InteriorStyle.Color = Color.White;
            style.InteriorStyle.Pattern = InteriorPatternType.Solid;
            style.AlignmentElement.HorizontalAlignment = HorizontalAlignmentType.Center;
            style.AlignmentElement.VerticalAlignment = VerticalAlignmentType.Center;

        }
        #endregion

        #region Image Convertion
        //Image to Byte array 
        public static byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        //Byte array to Image
        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        #endregion

    }
}
