using System.Collections.Generic;
using System.Printing;

namespace WordDocumentPrinterBySection
{
    class PrinterHelper
    {
        public static IEnumerable<Stapling> GetStaplings(string printerName) {
            var localPrintServer = new LocalPrintServer();
            var printQueue = localPrintServer.GetPrintQueue(printerName, new string[0] { });
            var printCapabilities = printQueue.GetPrintCapabilities();

            return printCapabilities.StaplingCapability;
        }

        public static string GetCurrentStapling(string printerName) {
            var localPrintServer = new LocalPrintServer();
            var printQueue = localPrintServer.GetPrintQueue(printerName, new string[0] { });

            if (printQueue.UserPrintTicket.Stapling == null)
                return PrinterHelperMessages.StaplingNotSupportedMessage;

            switch (printQueue.UserPrintTicket.Stapling) {
                case Stapling.None : ;
                    return PrinterHelperMessages.StaplingNoneMessage;
                case Stapling.SaddleStitch :
                    return PrinterHelperMessages.StaplingSaddleStitchMessage;
                case Stapling.StapleBottomLeft :
                    return PrinterHelperMessages.StaplingStapleBottomLeftMessage;
                case Stapling.StapleBottomRight :
                    return PrinterHelperMessages.StaplingStapleBottomRightMessage;
                case Stapling.StapleDualBottom :
                    return PrinterHelperMessages.StaplingStapleDualBottomMessage;
                case Stapling.StapleDualLeft :
                    return PrinterHelperMessages.StaplingStapleDualLeftMessage;
                case Stapling.StapleDualRight :
                    return PrinterHelperMessages.StaplingStapleDualRightMessage;
                case Stapling.StapleDualTop :
                    return PrinterHelperMessages.StaplingStapleDualTopMessage;
                case Stapling.StapleTopLeft :
                    return PrinterHelperMessages.StaplingStapleTopLeftMessage;
                case Stapling.StapleTopRight :
                    return PrinterHelperMessages.StaplingStapleTopRightMessage;
                case Stapling.Unknown :
                default :
                    return PrinterHelperMessages.StaplingUnknownMessage;
            }
        }
    }
}
