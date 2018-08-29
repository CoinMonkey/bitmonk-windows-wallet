namespace BitMonk
{
    partial class InputsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputsForm));
            this.inputsGridView = new System.Windows.Forms.DataGridView();
            this.inputBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inputsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // inputsGridView
            // 
            this.inputsGridView.AutoGenerateColumns = false;
            this.inputsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inputsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.amountDataGridViewTextBoxColumn,
            this.Address});
            this.inputsGridView.DataSource = this.inputBindingSource;
            this.inputsGridView.Location = new System.Drawing.Point(3, 2);
            this.inputsGridView.Name = "inputsGridView";
            this.inputsGridView.Size = new System.Drawing.Size(414, 285);
            this.inputsGridView.TabIndex = 0;
            // 
            // inputBindingSource
            // 
            this.inputBindingSource.DataSource = typeof(BitMonk.Entities.Input);
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 110;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.Width = 250;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(306, 294);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(37, 13);
            this.totalLabel.TabIndex = 1;
            this.totalLabel.Text = "Total: ";
            // 
            // InputsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 310);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.inputsGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InputsForm";
            this.Text = "Unspended inputs";
            this.Load += new System.EventHandler(this.InputsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView inputsGridView;
        private System.Windows.Forms.BindingSource inputBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.Label totalLabel;
    }
}