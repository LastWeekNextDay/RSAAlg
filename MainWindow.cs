using System;
using System.IO;
using System.Windows.Forms;

namespace RSAAlgorithm
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            PublicKeyLabel.Visible = false;
            PublicKeyTextBox.Visible = false;
            DecryptCheckBox.Checked = false;
        }

        private void DecryptCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DecryptCheckBox.Checked)
            {
                PublicKeyLabel.Visible = true;
                PublicKeyTextBox.Visible = true;
                ActionButton.Text = @"Decrypt";
            }
            else
            {
                PublicKeyLabel.Visible = false;
                PublicKeyTextBox.Visible = false;
                ActionButton.Text = @"Encrypt";
            }
        }

        private void PickFromFileButton_Click(object sender, EventArgs e)
        {
            // Open file dialog looking for .txt files
            var openFileDialog = new OpenFileDialog
            {
                Filter = @"Text files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };
            // If user selected a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Read the contents of the file into a stream
                var fileStream = openFileDialog.OpenFile();
                using (var streamReader = new StreamReader(fileStream))
                {
                    // If the file contains " ||PKEY|| ", then divide it into two parts
                    // and set the first part to the text box and the second part to the public key text box
                    // also turn on the decrypt check box if the file contains a PKEY
                    var text = streamReader.ReadToEnd();
                    PublicKeyTextBox.Text = text.Contains(" ||PKEY|| ")
                        ? text.Substring(text.IndexOf(" ||PKEY|| ", StringComparison.Ordinal) + 10)
                        : "";
                    if (text.Contains(" ||PKEY|| "))
                    {
                        DecryptCheckBox.Checked = true;
                    }
                    OutputTextBox.Text = text.Contains(" ||PKEY|| ")
                        ? text.Substring(0, text.IndexOf(" ||PKEY|| ", StringComparison.Ordinal))
                        : text;
                }
            }
        }

        private void SaveToFileButton_Click(object sender, EventArgs e)
        {
            // If the output text box is not empty, open a save file dialog with ability to select
            // .txt files
            if (OutputTextBox.Text != "")
            {
                var saveFileDialog = new SaveFileDialog
                {
                    Filter = @"Text files (*.txt)|*.txt|All files (*.*)|*.*",
                    FilterIndex = 1,
                    RestoreDirectory = true
                };
                // If user selected a file, save the output text box to the file
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, OutputTextBox.Text);
                }
            }
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            if (DecryptCheckBox.Checked)
            {
                // If the decrypt check box is checked, then decrypt the text
                Rsa rsa = new Rsa(PNumber.Text, QNumber.Text, PublicKeyTextBox.Text);
                OutputTextBox.Text = ;
            }
            else
            {
                // If the decrypt check box is not checked, then encrypt the text
                OutputTextBox.Text = RsaUtil.Encrypt(OutputTextBox.Text);
            }
        }
    }
}