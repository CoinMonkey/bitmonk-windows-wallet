namespace BitMonk
{
    partial class SuccessTxForm
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
            this.successLabel = new System.Windows.Forms.Label();
            this.txIdInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // successLabel
            // 
            this.successLabel.AutoSize = true;
            this.successLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.successLabel.ForeColor = System.Drawing.Color.Green;
            this.successLabel.Location = new System.Drawing.Point(134, 22);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(219, 55);
            this.successLabel.TabIndex = 0;
            this.successLabel.Text = "Success!";
            // 
            // txIdInput
            // 
            this.txIdInput.Location = new System.Drawing.Point(12, 124);
            this.txIdInput.Name = "txIdInput";
            this.txIdInput.Size = new System.Drawing.Size(454, 20);
            this.txIdInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Transaction ID:";
            // 
            // SuccessTxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 157);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txIdInput);
            this.Controls.Add(this.successLabel);
            this.Name = "SuccessTxForm";
            this.Text = "Success!";
            this.Load += new System.EventHandler(this.SuccessTxForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label successLabel;
        private System.Windows.Forms.TextBox txIdInput;
        private System.Windows.Forms.Label label1;
    }
}