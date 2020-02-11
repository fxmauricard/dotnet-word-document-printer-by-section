using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using Aspose.Words;

namespace WordDocumentPrinterBySection
{

    public partial class Form : System.Windows.Forms.Form
    {
        private string _fileName;
        private string _printerName;
        
        public string FileName
        {
            get => _fileName;
            set
            {
                _fileName = value;
                txtFileToPrint.Text = openFileDialog.FileName;
                pgrPrint.Value = 0;
                btnPrint.Enabled = !String.IsNullOrEmpty(_fileName.Trim());
                lblStatus.Text = String.Empty;
            }
        }

        public string PrinterName
        {
            get => _printerName;
            set
            {
                _printerName = value;
                txtOutputPrinter.Text = _printerName;
                txtStapling.Text = PrinterHelper.GetCurrentStapling(_printerName);
            }
        }

        public Form() {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e) {
            PrinterName = printDialog.PrinterSettings.PrinterName;
        }

        private void btnFileToPrint_Click(object sender, EventArgs e) {
            openFileDialog.ShowDialog();

        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e) {
            FileName = openFileDialog.FileName;
            if (openFileDialog.InitialDirectory == null)
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private void btnPrint_Click(object sender, EventArgs e) {
            Cursor = Cursors.WaitCursor;
            lblStatus.Font = new System.Drawing.Font(lblStatus.Font, FontStyle.Regular);
            lblStatus.ForeColor = Color.Black;
            lblStatus.Text = FormMessages.WordDocumentLoadingMessage;

            var printerSettings = new PrinterSettings {
                PrinterName = PrinterName
            };

            var document = new Document(FileName);

            pgrPrint.Value = 0;
            pgrPrint.Maximum = document.Sections.Count;

            var sections = document.Sections;
            foreach (Section section in sections) {
                lblStatus.Text = String.Format(FormMessages.SectionPrintingMessage, pgrPrint.Value + 1, pgrPrint.Maximum);

                var tempDocument = new Document();
                var tempSection = new Section(tempDocument);
                tempSection.AppendContent(section);
                tempDocument.Sections.Clear();
                tempDocument.Sections.Add(tempSection);
                tempDocument.Print(printerSettings);

                ++pgrPrint.Value;
            }

            Cursor = Cursors.Default;

            lblStatus.Text = FormMessages.PrintingStartCompletedMessage.ToUpperInvariant();
            lblStatus.Font = new System.Drawing.Font(lblStatus.Font, FontStyle.Bold);
            lblStatus.ForeColor = Color.DarkGreen;
        }

        private void btnOutputPrinter_Click(object sender, EventArgs e) {
            printDialog.ShowDialog();
            PrinterName = printDialog.PrinterSettings.PrinterName;
        }
    }
}
