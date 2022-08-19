namespace QuickBarcodes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBarcode = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.lstBarcodes = new System.Windows.Forms.ListBox();
            this.txtBarcodes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBarcode
            // 
            this.lblBarcode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBarcode.Location = new System.Drawing.Point(14, 16);
            this.lblBarcode.MaximumSize = new System.Drawing.Size(669, 85);
            this.lblBarcode.MinimumSize = new System.Drawing.Size(669, 85);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(669, 85);
            this.lblBarcode.TabIndex = 2;
            this.lblBarcode.Text = "*0123456789012345*";
            this.lblBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblText
            // 
            this.lblText.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblText.Location = new System.Drawing.Point(215, 101);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(272, 43);
            this.lblText.TabIndex = 3;
            this.lblText.Text = "0123456789012345";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 104);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Create Barcodes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(14, 105);
            this.btnPaste.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(152, 39);
            this.btnPaste.TabIndex = 5;
            this.btnPaste.Text = "From Clipboard";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // lstBarcodes
            // 
            this.lstBarcodes.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstBarcodes.FormattingEnabled = true;
            this.lstBarcodes.ItemHeight = 25;
            this.lstBarcodes.Location = new System.Drawing.Point(689, 16);
            this.lstBarcodes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstBarcodes.Name = "lstBarcodes";
            this.lstBarcodes.Size = new System.Drawing.Size(181, 429);
            this.lstBarcodes.TabIndex = 6;
            this.lstBarcodes.SelectedIndexChanged += new System.EventHandler(this.lstBarcodes_SelectedIndexChanged);
            // 
            // txtBarcodes
            // 
            this.txtBarcodes.Location = new System.Drawing.Point(25, 168);
            this.txtBarcodes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBarcodes.Multiline = true;
            this.txtBarcodes.Name = "txtBarcodes";
            this.txtBarcodes.Size = new System.Drawing.Size(637, 279);
            this.txtBarcodes.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 481);
            this.Controls.Add(this.txtBarcodes);
            this.Controls.Add(this.lstBarcodes);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblBarcode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Barcode Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblBarcode;
        private Label lblText;
        private Button button1;
        private Button btnPaste;
        private ListBox lstBarcodes;
        private TextBox txtBarcodes;
    }
}