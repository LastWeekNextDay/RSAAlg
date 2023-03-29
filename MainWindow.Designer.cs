namespace RSAAlgorithm
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PLabel = new System.Windows.Forms.Label();
            this.QLabel = new System.Windows.Forms.Label();
            this.PNumber = new System.Windows.Forms.NumericUpDown();
            this.QNumber = new System.Windows.Forms.NumericUpDown();
            this.ActionButton = new System.Windows.Forms.Button();
            this.InputTextBox = new System.Windows.Forms.RichTextBox();
            this.DecryptCheckBox = new System.Windows.Forms.CheckBox();
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.ArrowLabel = new System.Windows.Forms.Label();
            this.PickFromFileButton = new System.Windows.Forms.Button();
            this.SaveToFileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // PLabel
            // 
            this.PLabel.Location = new System.Drawing.Point(12, 18);
            this.PLabel.Name = "PLabel";
            this.PLabel.Size = new System.Drawing.Size(126, 23);
            this.PLabel.TabIndex = 1;
            this.PLabel.Text = "Prime Number 1";
            // 
            // QLabel
            // 
            this.QLabel.Location = new System.Drawing.Point(177, 18);
            this.QLabel.Name = "QLabel";
            this.QLabel.Size = new System.Drawing.Size(126, 23);
            this.QLabel.TabIndex = 3;
            this.QLabel.Text = "Prime Number 2";
            // 
            // PNumber
            // 
            this.PNumber.Location = new System.Drawing.Point(12, 44);
            this.PNumber.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.PNumber.Name = "PNumber";
            this.PNumber.Size = new System.Drawing.Size(126, 22);
            this.PNumber.TabIndex = 4;
            // 
            // QNumber
            // 
            this.QNumber.Location = new System.Drawing.Point(177, 44);
            this.QNumber.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.QNumber.Name = "QNumber";
            this.QNumber.Size = new System.Drawing.Size(126, 22);
            this.QNumber.TabIndex = 5;
            // 
            // ActionButton
            // 
            this.ActionButton.Location = new System.Drawing.Point(105, 211);
            this.ActionButton.Name = "ActionButton";
            this.ActionButton.Size = new System.Drawing.Size(108, 48);
            this.ActionButton.TabIndex = 7;
            this.ActionButton.Text = "Encrypt";
            this.ActionButton.UseVisualStyleBackColor = true;
            this.ActionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(12, 97);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(291, 96);
            this.InputTextBox.TabIndex = 8;
            this.InputTextBox.Text = "";
            // 
            // DecryptCheckBox
            // 
            this.DecryptCheckBox.Location = new System.Drawing.Point(219, 235);
            this.DecryptCheckBox.Name = "DecryptCheckBox";
            this.DecryptCheckBox.Size = new System.Drawing.Size(84, 24);
            this.DecryptCheckBox.TabIndex = 9;
            this.DecryptCheckBox.Text = "Decrypt";
            this.DecryptCheckBox.UseVisualStyleBackColor = true;
            this.DecryptCheckBox.CheckedChanged += new System.EventHandler(this.DecryptCheckBox_CheckedChanged);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(347, 97);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(314, 96);
            this.OutputTextBox.TabIndex = 12;
            this.OutputTextBox.Text = "";
            // 
            // ArrowLabel
            // 
            this.ArrowLabel.Location = new System.Drawing.Point(309, 128);
            this.ArrowLabel.Name = "ArrowLabel";
            this.ArrowLabel.Size = new System.Drawing.Size(32, 23);
            this.ArrowLabel.TabIndex = 13;
            this.ArrowLabel.Text = "--->";
            // 
            // PickFromFileButton
            // 
            this.PickFromFileButton.Location = new System.Drawing.Point(12, 72);
            this.PickFromFileButton.Name = "PickFromFileButton";
            this.PickFromFileButton.Size = new System.Drawing.Size(126, 23);
            this.PickFromFileButton.TabIndex = 14;
            this.PickFromFileButton.Text = "Select file...";
            this.PickFromFileButton.UseVisualStyleBackColor = true;
            this.PickFromFileButton.Click += new System.EventHandler(this.PickFromFileButton_Click);
            // 
            // SaveToFileButton
            // 
            this.SaveToFileButton.Location = new System.Drawing.Point(349, 72);
            this.SaveToFileButton.Name = "SaveToFileButton";
            this.SaveToFileButton.Size = new System.Drawing.Size(170, 23);
            this.SaveToFileButton.TabIndex = 15;
            this.SaveToFileButton.Text = "Save to file...";
            this.SaveToFileButton.UseVisualStyleBackColor = true;
            this.SaveToFileButton.Click += new System.EventHandler(this.SaveToFileButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveToFileButton);
            this.Controls.Add(this.PickFromFileButton);
            this.Controls.Add(this.ArrowLabel);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.DecryptCheckBox);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.ActionButton);
            this.Controls.Add(this.QNumber);
            this.Controls.Add(this.PNumber);
            this.Controls.Add(this.QLabel);
            this.Controls.Add(this.PLabel);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.PNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QNumber)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button SaveToFileButton;

        private System.Windows.Forms.Button PickFromFileButton;

        private System.Windows.Forms.RichTextBox InputTextBox;
        private System.Windows.Forms.Label ArrowLabel;

        private System.Windows.Forms.Button ActionButton;
        private System.Windows.Forms.RichTextBox OutputTextBox;
        private System.Windows.Forms.CheckBox DecryptCheckBox;

        private System.Windows.Forms.NumericUpDown PNumber;
        private System.Windows.Forms.NumericUpDown QNumber;

        private System.Windows.Forms.Label PLabel;
        private System.Windows.Forms.Label QLabel;

        #endregion
    }
}