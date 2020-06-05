namespace Aquapark
{
    partial class Tables2
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
            this.label5 = new System.Windows.Forms.Label();
            this.page1Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.servicesGridView = new System.Windows.Forms.DataGridView();
            this.transactionTypesGridView = new System.Windows.Forms.DataGridView();
            this.discountsGridView = new System.Windows.Forms.DataGridView();
            this.watchId = new System.Windows.Forms.Label();
            this.visitsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.servicesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1010, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Strona 2";
            // 
            // page1Button
            // 
            this.page1Button.Location = new System.Drawing.Point(982, 329);
            this.page1Button.Name = "page1Button";
            this.page1Button.Size = new System.Drawing.Size(98, 82);
            this.page1Button.TabIndex = 28;
            this.page1Button.Text = "Strona 1";
            this.page1Button.UseVisualStyleBackColor = true;
            this.page1Button.Click += new System.EventHandler(this.page1Button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(647, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Lista dostępnych stref";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(659, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Rodzaje transakcji";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(142, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Dostępne zniżki";
            // 
            // servicesGridView
            // 
            this.servicesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicesGridView.Location = new System.Drawing.Point(418, 382);
            this.servicesGridView.Name = "servicesGridView";
            this.servicesGridView.Size = new System.Drawing.Size(541, 291);
            this.servicesGridView.TabIndex = 24;
            // 
            // transactionTypesGridView
            // 
            this.transactionTypesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionTypesGridView.Location = new System.Drawing.Point(608, 266);
            this.transactionTypesGridView.Name = "transactionTypesGridView";
            this.transactionTypesGridView.Size = new System.Drawing.Size(241, 90);
            this.transactionTypesGridView.TabIndex = 23;
            // 
            // discountsGridView
            // 
            this.discountsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.discountsGridView.Location = new System.Drawing.Point(12, 382);
            this.discountsGridView.Name = "discountsGridView";
            this.discountsGridView.Size = new System.Drawing.Size(352, 291);
            this.discountsGridView.TabIndex = 22;
            // 
            // watchId
            // 
            this.watchId.AutoSize = true;
            this.watchId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.watchId.Location = new System.Drawing.Point(190, 43);
            this.watchId.Name = "watchId";
            this.watchId.Size = new System.Drawing.Size(101, 20);
            this.watchId.TabIndex = 18;
            this.watchId.Text = "Historia wizyt";
            // 
            // visitsGridView
            // 
            this.visitsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitsGridView.Location = new System.Drawing.Point(-11, 66);
            this.visitsGridView.Name = "visitsGridView";
            this.visitsGridView.Size = new System.Drawing.Size(540, 291);
            this.visitsGridView.TabIndex = 16;
            // 
            // Tables2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 714);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.page1Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.servicesGridView);
            this.Controls.Add(this.transactionTypesGridView);
            this.Controls.Add(this.discountsGridView);
            this.Controls.Add(this.watchId);
            this.Controls.Add(this.visitsGridView);
            this.Name = "Tables2";
            this.Text = "Dane";
            this.Load += new System.EventHandler(this.Aquapark_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servicesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button page1Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView servicesGridView;
        private System.Windows.Forms.DataGridView transactionTypesGridView;
        private System.Windows.Forms.DataGridView discountsGridView;
        private System.Windows.Forms.Label watchId;
        private System.Windows.Forms.DataGridView visitsGridView;
    }
}