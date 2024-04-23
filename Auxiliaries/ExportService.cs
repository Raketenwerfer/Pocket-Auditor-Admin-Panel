using System.Data;
using System.IO;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

public class ExportService
{
    public void ExportToPdf(string filename, DataTable dataTable)
    {
        PdfWriter writer = new PdfWriter(filename);
        PdfDocument pdf = new PdfDocument(writer);
        Document document = new Document(pdf);

        string currentChapter = null;
        Table table = null;

        foreach (DataRow row in dataTable.Rows)
        {
            string chapterName = row["Chapter"].ToString();
            string category = row["Category"].ToString();
            string categoryScore = row["Score"] == DBNull.Value ? "0" : row["Score"].ToString();
            string actionPlanDetails = row["Action Plan"].ToString();

            // Check if we need to start a new table for a new chapter
            if (currentChapter == null || !currentChapter.Equals(chapterName))
            {
                // Close the previous table if it exists
                if (table != null)
                {
                    document.Add(table);
                    document.Add(new Paragraph("\n")); // Add empty line between chapters
                }

                // Start a new table for the current chapter
                currentChapter = chapterName;
                table = new Table(3);
                table.AddCell(new Cell(1, 3).Add(new Paragraph(currentChapter).SetBold().SetFontSize(16)));
                table.AddCell(new Cell().Add(new Paragraph("Category")));
                table.AddCell(new Cell().Add(new Paragraph("Category Score")));
                table.AddCell(new Cell().Add(new Paragraph("Action Plan Details")));
            }

            // Add category, category score, and action plan details to the current table
            table.AddCell(new Cell().Add(new Paragraph(category)));
            table.AddCell(new Cell().Add(new Paragraph(categoryScore)));
            table.AddCell(new Cell().Add(new Paragraph(actionPlanDetails)));
        }

        // Add the last table to the document
        if (table != null)
        {
            document.Add(table);
        }

        document.Close();
    }
}
