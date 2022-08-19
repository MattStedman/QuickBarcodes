using System.Collections;
using System.Drawing.Text;
using System.Text;
using System.Text.RegularExpressions;

namespace QuickBarcodes
{
    public partial class Form1 : Form
    {

        ArrayList barcodes;
        String data;
        String characters = "0123456789 ABCDEFGHIJKLMNOPQRSTUVWXYZ-.$/+%";
        PrivateFontCollection Fonts;

        public Form1()
        {
            InitializeComponent();
            barcodes = new ArrayList();
            Fonts = new PrivateFontCollection();
            Fonts.AddFontFile("LibreBarcode39-Regular.ttf");
            Font BarcodeFont = new Font(Fonts.Families[0], 48);
            lblBarcode.Font = BarcodeFont;
        }

        private void txtBarcodeList_TextChanged(object sender, EventArgs e)
        {

            lblText.Text = "0123456789012345";
            lblBarcode.Text = "*0123456789012345*";

            barcodes = new ArrayList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            data = txtBarcodes.Text;
            generateList();
            updateTextBox();
            lstBarcodes.DataSource = barcodes;

        }

        private void updateTextBox()
        {

            StringBuilder list = new StringBuilder();
            foreach (string s in barcodes)
            {
                list.Append(s + Environment.NewLine);
            }
            txtBarcodes.Text = list.ToString();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            data = Clipboard.GetText();
            generateList();
            updateTextBox();
        }

        private void generateList()
        {


            String[] delimeters = { Environment.NewLine, "," };
            string[] input = data.Split(delimeters, StringSplitOptions.None);
            barcodes = new ArrayList();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length != 0 && input[i].Length <= 15)
                {
                    String barcode = input[i].ToUpper();
                    StringBuilder valid = new StringBuilder();
                    foreach (char c in barcode.ToCharArray())
                    {
                        if (characters.Contains(c))
                        {
                            valid.Append(c);
                        }
                    }

                    barcodes.Add(valid.ToString().Trim());
                }
            }

            lstBarcodes.DataSource = barcodes;

            if (barcodes.Count != 0)
            {
                lstBarcodes.SelectedIndex = 0;

                updateBarcode();
            }
        }

        private void updateBarcode()
        {
            lblText.Text = lstBarcodes.Text;
            lblBarcode.Text = "*" + lstBarcodes.Text + "*";
        }

        private void lstBarcodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateBarcode();
        }




    }
}