using System.Drawing.Printing;
namespace MenuWF.Forms;

public class PrintHelper
{
    public PrintDocument printDocument = new PrintDocument();
    private Form formToPrint;

    public PrintHelper(Form form)
    {
        formToPrint = form;
        printDocument.PrintPage += new PrintPageEventHandler(PrintPage);
    }

    public void Print()
    {
        PrintDialog printDialog = new PrintDialog();
        printDialog.Document = printDocument;

        if (printDialog.ShowDialog() == DialogResult.OK)
            printDocument.Print();
    }

    private void PrintPage(object sender, PrintPageEventArgs e)
    {
        Bitmap bitmap = new Bitmap(formToPrint.Width, formToPrint.Height);
        formToPrint.DrawToBitmap(bitmap, new Rectangle(0, 0, formToPrint.Width, formToPrint.Height));
        e.Graphics.DrawImage(bitmap, 0, 0);
    }
}
