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
            lblBarcode = new Label();
            lblText = new Label();
            btnGenerate = new Button();
            btnPaste = new Button();
            lstBarcodes = new ListBox();
            txtBarcodes = new TextBox();
            SuspendLayout();
            // 
            // lblBarcode
            // 
            lblBarcode.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblBarcode.Location = new Point(18, 20);
            lblBarcode.Margin = new Padding(4, 0, 4, 0);
            lblBarcode.MaximumSize = new Size(836, 106);
            lblBarcode.MinimumSize = new Size(836, 106);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(836, 106);
            lblBarcode.TabIndex = 2;
            lblBarcode.Text = "*0123456789012345*";
            lblBarcode.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblText
            // 
            lblText.Font = new Font("Cascadia Code", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblText.Location = new Point(269, 126);
            lblText.Margin = new Padding(4, 0, 4, 0);
            lblText.Name = "lblText";
            lblText.Size = new Size(340, 54);
            lblText.TabIndex = 3;
            lblText.Text = "0123456789012345";
            lblText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(632, 130);
            btnGenerate.Margin = new Padding(4, 5, 4, 5);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(190, 50);
            btnGenerate.TabIndex = 4;
            btnGenerate.Text = "Create Barcodes";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnPaste
            // 
            btnPaste.Location = new Point(18, 131);
            btnPaste.Margin = new Padding(4, 5, 4, 5);
            btnPaste.Name = "btnPaste";
            btnPaste.Size = new Size(190, 49);
            btnPaste.TabIndex = 5;
            btnPaste.Text = "From Clipboard";
            btnPaste.UseVisualStyleBackColor = true;
            btnPaste.Click += btnPaste_Click;
            // 
            // lstBarcodes
            // 
            lstBarcodes.Font = new Font("Cascadia Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lstBarcodes.FormattingEnabled = true;
            lstBarcodes.ItemHeight = 30;
            lstBarcodes.Location = new Point(861, 20);
            lstBarcodes.Margin = new Padding(4, 5, 4, 5);
            lstBarcodes.Name = "lstBarcodes";
            lstBarcodes.Size = new Size(225, 514);
            lstBarcodes.TabIndex = 6;
            lstBarcodes.SelectedIndexChanged += lstBarcodes_SelectedIndexChanged;
            // 
            // txtBarcodes
            // 
            txtBarcodes.Location = new Point(31, 210);
            txtBarcodes.Margin = new Padding(4, 5, 4, 5);
            txtBarcodes.Multiline = true;
            txtBarcodes.Name = "txtBarcodes";
            txtBarcodes.Size = new Size(795, 348);
            txtBarcodes.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 601);
            Controls.Add(txtBarcodes);
            Controls.Add(lstBarcodes);
            Controls.Add(btnPaste);
            Controls.Add(btnGenerate);
            Controls.Add(lblText);
            Controls.Add(lblBarcode);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Barcode Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblBarcode;
        private Label lblText;
        private Button btnGenerate;
        private Button btnPaste;
        private ListBox lstBarcodes;
        private TextBox txtBarcodes;
    }
}