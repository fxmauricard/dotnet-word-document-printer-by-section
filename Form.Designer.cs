namespace WordDocumentPrinterBySection
{
    partial class Form
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblFileToPrint = new System.Windows.Forms.Label();
            this.txtFileToPrint = new System.Windows.Forms.TextBox();
            this.btnFileToPrint = new System.Windows.Forms.Button();
            this.pgrPrint = new System.Windows.Forms.ProgressBar();
            this.lblHelp = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.btnOutputPrinter = new System.Windows.Forms.Button();
            this.lblOutputPrinter = new System.Windows.Forms.Label();
            this.txtOutputPrinter = new System.Windows.Forms.TextBox();
            this.lblStapling = new System.Windows.Forms.Label();
            this.txtStapling = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            resources.ApplyResources(this.openFileDialog, "openFileDialog");
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // lblFileToPrint
            // 
            resources.ApplyResources(this.lblFileToPrint, "lblFileToPrint");
            this.lblFileToPrint.Name = "lblFileToPrint";
            // 
            // txtFileToPrint
            // 
            resources.ApplyResources(this.txtFileToPrint, "txtFileToPrint");
            this.txtFileToPrint.Name = "txtFileToPrint";
            this.txtFileToPrint.ReadOnly = true;
            // 
            // btnFileToPrint
            // 
            resources.ApplyResources(this.btnFileToPrint, "btnFileToPrint");
            this.btnFileToPrint.Name = "btnFileToPrint";
            this.btnFileToPrint.UseVisualStyleBackColor = true;
            this.btnFileToPrint.Click += new System.EventHandler(this.btnFileToPrint_Click);
            // 
            // pgrPrint
            // 
            resources.ApplyResources(this.pgrPrint, "pgrPrint");
            this.pgrPrint.Name = "pgrPrint";
            // 
            // lblHelp
            // 
            resources.ApplyResources(this.lblHelp, "lblHelp");
            this.lblHelp.Name = "lblHelp";
            // 
            // btnPrint
            // 
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // btnOutputPrinter
            // 
            resources.ApplyResources(this.btnOutputPrinter, "btnOutputPrinter");
            this.btnOutputPrinter.Name = "btnOutputPrinter";
            this.btnOutputPrinter.UseVisualStyleBackColor = true;
            this.btnOutputPrinter.Click += new System.EventHandler(this.btnOutputPrinter_Click);
            // 
            // lblOutputPrinter
            // 
            this.lblOutputPrinter.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.lblOutputPrinter, "lblOutputPrinter");
            this.lblOutputPrinter.Name = "lblOutputPrinter";
            // 
            // txtOutputPrinter
            // 
            resources.ApplyResources(this.txtOutputPrinter, "txtOutputPrinter");
            this.txtOutputPrinter.Name = "txtOutputPrinter";
            this.txtOutputPrinter.ReadOnly = true;
            // 
            // lblStapling
            // 
            resources.ApplyResources(this.lblStapling, "lblStapling");
            this.lblStapling.Name = "lblStapling";
            // 
            // txtStapling
            // 
            resources.ApplyResources(this.txtStapling, "txtStapling");
            this.txtStapling.Name = "txtStapling";
            this.txtStapling.ReadOnly = true;
            // 
            // lblStatus
            // 
            resources.ApplyResources(this.lblStatus, "lblStatus");
            this.lblStatus.Name = "lblStatus";
            // 
            // Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtStapling);
            this.Controls.Add(this.lblStapling);
            this.Controls.Add(this.txtOutputPrinter);
            this.Controls.Add(this.btnOutputPrinter);
            this.Controls.Add(this.lblOutputPrinter);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.pgrPrint);
            this.Controls.Add(this.btnFileToPrint);
            this.Controls.Add(this.txtFileToPrint);
            this.Controls.Add(this.lblFileToPrint);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lblFileToPrint;
        private System.Windows.Forms.TextBox txtFileToPrint;
        private System.Windows.Forms.Button btnFileToPrint;
        private System.Windows.Forms.ProgressBar pgrPrint;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.Button btnOutputPrinter;
        private System.Windows.Forms.Label lblOutputPrinter;
        private System.Windows.Forms.TextBox txtOutputPrinter;
        private System.Windows.Forms.Label lblStapling;
        private System.Windows.Forms.TextBox txtStapling;
        private System.Windows.Forms.Label lblStatus;
    }
}

