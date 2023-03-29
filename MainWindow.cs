using System;
using System.IO;
using System.Numerics;
using System.Windows.Forms;

namespace RSAAlgorithm
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            DecryptCheckBox.Checked = false;
        }

        private void DecryptCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ActionButton.Text = DecryptCheckBox.Checked ? @"Decrypt" : @"Encrypt";
        }

        private void PickFromFileButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = @"Text files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            using (var streamReader = new StreamReader(openFileDialog.OpenFile()))
            {
                var text = streamReader.ReadToEnd();
                if (text.Contains(" ||PKEY|| "))
                {
                    DecryptCheckBox.Checked = true;
                    var primeNumbers = RsaUtil.ConvertPublicKeyToPrimeNumbers(
                        int.Parse(text.Substring(text.IndexOf(" ||PKEY|| ", StringComparison.Ordinal) + 10)));
                    PNumber.Value = (decimal)primeNumbers[0];
                    QNumber.Value = (decimal)primeNumbers[1];
                    InputTextBox.Text = text.Substring(0, text.IndexOf(" ||PKEY|| ",
                        StringComparison.Ordinal));
                }
                else
                {
                    InputTextBox.Text = text;
                }
            }
        }

        private void SaveToFileButton_Click(object sender, EventArgs e)
        {
            if (OutputTextBox.Text == "") return;
            var saveFileDialog = new SaveFileDialog
            {
                Filter = @"Text files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, OutputTextBox.Text + @" ||PKEY|| " +
                                                           WindowFunctionsHolder.RsaInstance.PublicKey);
            }
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            if (DecryptCheckBox.Checked)
            {
                WindowFunctionsHolder.RsaInstance = new Rsa((int)PNumber.Value, (int)QNumber.Value);
                OutputTextBox.Text =
                    WindowFunctionsHolder.RsaInstance.DecryptAscii(BigInteger.Parse(InputTextBox.Text));
            }
            else
            {
                WindowFunctionsHolder.RsaInstance = new Rsa(int.Parse(PNumber.Text), int.Parse(QNumber.Text));
                OutputTextBox.Text = WindowFunctionsHolder.RsaInstance.EncryptAscii(InputTextBox.Text).ToString();
            }
        }
    }
}