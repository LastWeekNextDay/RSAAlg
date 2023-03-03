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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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

        private System.Windows.Forms.NumericUpDown PNumber;
        private System.Windows.Forms.NumericUpDown QNumber;

        private System.Windows.Forms.Label PLabel;
        private System.Windows.Forms.Label QLabel;

        #endregion
    }
}