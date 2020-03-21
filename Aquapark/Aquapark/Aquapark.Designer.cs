namespace Aquapark
{
    partial class Aquapark
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
            this.customersGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.customersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customersGridView
            // 
            this.customersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersGridView.Location = new System.Drawing.Point(12, 12);
            this.customersGridView.Name = "customersGridView";
            this.customersGridView.Size = new System.Drawing.Size(299, 190);
            this.customersGridView.TabIndex = 0;
            // 
            // Aquapark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1798, 669);
            this.Controls.Add(this.customersGridView);
            this.Name = "Aquapark";
            this.Text = "Aquapark";
            this.Load += new System.EventHandler(this.Aquapark_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView customersGridView;
    }
}

