using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Aspose.Words;

namespace WordDocumentPrinterBySection
{
    static class Program
    {
        private static License _license;

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main() {
            InitAsposeWordsLicence();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form());
        }

        /// <summary>
        /// License Aspose.
        /// </summary>
        static void InitAsposeWordsLicence() {
            var applicationDirectoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var licenceFileName = applicationDirectoryName + "\\Aspose.Words.lic";

            try {
                using (var stream = new FileStream(licenceFileName, FileMode.Open)) {
                    _license = new License();
                    _license.SetLicense(stream);
                }
            } catch (FileNotFoundException) {
                // If no licence file, Aspose will be in "DEMO" mode.
            }
        }

    }
}
