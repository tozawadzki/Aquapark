namespace Aquapark
{
    partial class Entrance
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.discount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.entryButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.service = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.entranceMethod = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.hours = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // discount
            // 
            this.discount.FormattingEnabled = true;
            this.discount.Location = new System.Drawing.Point(66, 100);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(121, 21);
            this.discount.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwisko";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(66, 21);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(119, 20);
            this.firstName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Imię";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(66, 47);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(119, 20);
            this.lastName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Zniżka";
            // 
            // entryButton
            // 
            this.entryButton.Location = new System.Drawing.Point(85, 178);
            this.entryButton.Name = "entryButton";
            this.entryButton.Size = new System.Drawing.Size(75, 23);
            this.entryButton.TabIndex = 6;
            this.entryButton.Text = "Wchodzę";
            this.entryButton.UseVisualStyleBackColor = true;
            this.entryButton.Click += new System.EventHandler(this.entryButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(396, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // adminButton
            // 
            this.adminButton.Location = new System.Drawing.Point(10, 226);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(107, 23);
            this.adminButton.TabIndex = 8;
            this.adminButton.Text = "Jestem adminem";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Strefa";
            // 
            // service
            // 
            this.service.FormattingEnabled = true;
            this.service.Location = new System.Drawing.Point(66, 73);
            this.service.Name = "service";
            this.service.Size = new System.Drawing.Size(121, 21);
            this.service.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Typ płatności";
            // 
            // entranceMethod
            // 
            this.entranceMethod.FormattingEnabled = true;
            this.entranceMethod.Location = new System.Drawing.Point(85, 127);
            this.entranceMethod.Name = "entranceMethod";
            this.entranceMethod.Size = new System.Drawing.Size(100, 21);
            this.entranceMethod.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ilość godzin";
            // 
            // hours
            // 
            this.hours.Location = new System.Drawing.Point(85, 152);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(19, 20);
            this.hours.TabIndex = 15;
            // 
            // Entrance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 261);
            this.Controls.Add(this.hours);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.entranceMethod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.service);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.entryButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.discount);
            this.Name = "Entrance";
            this.Text = "Witaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox discount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button entryButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox service;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox entranceMethod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hours;
    }
}