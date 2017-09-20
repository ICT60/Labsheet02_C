using System;
using System.Windows.Forms;

namespace Labsheet02_C
{
    public partial class frmMain : Form
    {
        const string TEXT_OF_NUMBER = "2.01";

        public frmMain()
        {
            InitializeComponent();
        }

        void btnShowResult_Click(object sender, EventArgs e)
        {
            _PrintResult(TEXT_OF_NUMBER);
        }

        void _PrintResult(string value)
        {
            var result = _GetResultText(value);
            MessageBox.Show(result,
                "Result^^",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
        }

        string _GetResultText(string value)
        {
            var numResult = 0.0m;
            var isCanParse = decimal.TryParse(value, out numResult);

            var textResult = String.Empty;

            if (isCanParse)
            {
                textResult += String.Format("Text: {0}\n", TEXT_OF_NUMBER);
                textResult += String.Format("Decimal: {0}\n", numResult);
                textResult += String.Format("Double: {0}\n", (double)numResult);
                textResult += String.Format("Float: {0}\n", (float)numResult);
                textResult += String.Format("Int: {0}\n", (int)numResult);
            }

            return textResult;
        }
    }
}
