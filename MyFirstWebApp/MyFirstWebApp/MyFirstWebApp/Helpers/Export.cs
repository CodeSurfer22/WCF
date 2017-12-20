using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI.WebControls;

namespace MyFirstWebApp.Helpers
{
    public static class Export
    {
        public static String ExportHportIDXToOpenXMLCSV(GridView gv, string fileName, string sheetName = "")
        {
            string filePath = HttpContext.Current.Server.MapPath(fileName + sheetName.ToString() + ".xlsx");
            StringBuilder sbCSVString = new StringBuilder();
            try
            {
                using (var workbook = SpreadsheetDocument.Create(filePath, DocumentFormat.OpenXml.SpreadsheetDocumentType.Workbook))
                {
                    var workbookPart = workbook.AddWorkbookPart();
                    workbook.WorkbookPart.Workbook = new DocumentFormat.OpenXml.Spreadsheet.Workbook();
                    workbook.WorkbookPart.Workbook.Sheets = new DocumentFormat.OpenXml.Spreadsheet.Sheets();
                    var sheetPart = workbook.WorkbookPart.AddNewPart<WorksheetPart>();
                    var sheetData = new DocumentFormat.OpenXml.Spreadsheet.SheetData();
                    sheetPart.Worksheet = new DocumentFormat.OpenXml.Spreadsheet.Worksheet(sheetData);
                    DocumentFormat.OpenXml.Spreadsheet.Sheets sheets = workbook.WorkbookPart.Workbook.GetFirstChild<DocumentFormat.OpenXml.Spreadsheet.Sheets>();
                    string relationshipId = workbook.WorkbookPart.GetIdOfPart(sheetPart);
                    uint sheetId = 1;
                    if (sheets.Elements<DocumentFormat.OpenXml.Spreadsheet.Sheet>().Count() > 0)
                    {
                        sheetId = sheets.Elements<DocumentFormat.OpenXml.Spreadsheet.Sheet>().Select(s => s.SheetId.Value).Max() + 1;
                    }

                    DocumentFormat.OpenXml.Spreadsheet.Sheet sheet = new DocumentFormat.OpenXml.Spreadsheet.Sheet();
                    sheet.Id = relationshipId;
                    sheet.SheetId = sheetId;
                    if (sheetName != "")
                    {
                        sheet.Name = sheetName;
                    }
                    else
                    {
                        sheet.Name = fileName;
                    }

                    WorksheetPart newWorksheetPart;
                    newWorksheetPart = sheetPart.Worksheet.WorksheetPart;
                    SheetProperties sp = new SheetProperties(new PageSetupProperties());
                    sheetPart.Worksheet.SheetProperties = sp;
                    sheetPart.Worksheet.SheetProperties.PageSetupProperties.FitToPage = BooleanValue.FromBoolean(true);
                    DocumentFormat.OpenXml.Spreadsheet.PageSetup pgOr = new DocumentFormat.OpenXml.Spreadsheet.PageSetup();
                    pgOr.Orientation = DocumentFormat.OpenXml.Spreadsheet.OrientationValues.Portrait;
                    pgOr.FitToHeight = 3;
                    pgOr.FitToWidth = 1;
                    sheetPart.Worksheet.AppendChild(pgOr);
                    sheets.Append(sheet);
                    DocumentFormat.OpenXml.Spreadsheet.Row headerRow = new DocumentFormat.OpenXml.Spreadsheet.Row();
                    int rowCounter = 0;
                    int columnCounter = 0;
                    DocumentFormat.OpenXml.Spreadsheet.Row columnRow = new DocumentFormat.OpenXml.Spreadsheet.Row();
                    foreach (DataColumn col in ((DataTable)gv.DataSource).Columns)
                    {
                        String cellValue = col.ColumnName;
                        DocumentFormat.OpenXml.Spreadsheet.Cell cellCol = new DocumentFormat.OpenXml.Spreadsheet.Cell();
                        cellCol.DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.String;
                        cellCol.CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(cellValue);
                        columnRow.AppendChild(cellCol);
                        sbCSVString.Append(cellValue);
                        columnCounter++;
                        if (columnCounter < ((DataTable)gv.DataSource).Columns.Count)
                        {
                            sbCSVString.Append(",");
                        }
                    }
                    sheetData.AppendChild(columnRow);
                    sbCSVString.Append(Environment.NewLine);

                    foreach (GridViewRow dataSourceRow in gv.Rows)
                    {
                        DocumentFormat.OpenXml.Spreadsheet.Row newSheetRow = new DocumentFormat.OpenXml.Spreadsheet.Row();
                        //DataRow dataSourceRow = rowView.Row;
                        string cellValue = dataSourceRow.Cells[0].Text.ToString();
                        DocumentFormat.OpenXml.Spreadsheet.Cell cell = new DocumentFormat.OpenXml.Spreadsheet.Cell();
                        cell.DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.String;
                        cell.CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(cellValue);
                        newSheetRow.AppendChild(cell);
                        sbCSVString.Append(cellValue);
                        sbCSVString.Append(",");
                        cellValue = dataSourceRow.Cells[1].Text.ToString();
                        cell = new DocumentFormat.OpenXml.Spreadsheet.Cell();
                        cell.DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.String;
                        cell.CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(cellValue);
                        newSheetRow.AppendChild(cell);
                        sbCSVString.Append(cellValue);
                        sbCSVString.Append(",");
                        cellValue = dataSourceRow.Cells[2].Text.ToString();
                        cell = new DocumentFormat.OpenXml.Spreadsheet.Cell();
                        cell.DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.String;
                        cell.CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(cellValue);
                        newSheetRow.AppendChild(cell);
                        sbCSVString.Append(cellValue);
                        sbCSVString.Append(",");
                        cellValue = dataSourceRow.Cells[3].Text.ToString();
                        cell = new DocumentFormat.OpenXml.Spreadsheet.Cell();
                        cell.DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.Number;
                        cell.CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(cellValue);
                        newSheetRow.AppendChild(cell);
                        sbCSVString.Append(cellValue);
                        sbCSVString.Append(",");
                        cellValue = dataSourceRow.Cells[4].Text.ToString();
                        cell = new DocumentFormat.OpenXml.Spreadsheet.Cell();
                        cell.DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.String;
                        cell.CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(cellValue);
                        newSheetRow.AppendChild(cell);
                        sbCSVString.Append(cellValue);
                        sbCSVString.Append(",");
                        cellValue = dataSourceRow.Cells[5].Text.ToString();
                        cell = new DocumentFormat.OpenXml.Spreadsheet.Cell();
                        cell.DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.Number;
                        cell.CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(cellValue);
                        newSheetRow.AppendChild(cell);
                        sbCSVString.Append(cellValue);

                        sheetData.AppendChild(newSheetRow);
                        sbCSVString.Append(Environment.NewLine);
                        rowCounter = rowCounter + 1;
                    }
                }

                File.WriteAllText(filePath.Replace("xlsx", "csv"), sbCSVString.ToString());
            }
            catch (System.Exception ex)
            {
                string sError;
                sError = ex.ToString();
                throw ex;
            }
            return filePath;
        }
    }
}