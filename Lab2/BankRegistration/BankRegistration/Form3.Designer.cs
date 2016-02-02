namespace BankRegistration
{
    partial class Form3
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
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.beneficiaryLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.transferButton = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usernameTextBox.Location = new System.Drawing.Point(101, 65);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(171, 26);
            this.usernameTextBox.TabIndex = 3;
            // 
            // beneficiaryLabel
            // 
            this.beneficiaryLabel.AutoSize = true;
            this.beneficiaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.beneficiaryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.beneficiaryLabel.Location = new System.Drawing.Point(12, 65);
            this.beneficiaryLabel.Name = "beneficiaryLabel";
            this.beneficiaryLabel.Size = new System.Drawing.Size(87, 20);
            this.beneficiaryLabel.TabIndex = 2;
            this.beneficiaryLabel.Text = "Beneficiary";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.amountTextBox.Location = new System.Drawing.Point(101, 109);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(171, 26);
            this.amountTextBox.TabIndex = 5;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.amountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.amountLabel.Location = new System.Drawing.Point(12, 109);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(65, 20);
            this.amountLabel.TabIndex = 4;
            this.amountLabel.Text = "Amount";
            // 
            // transferButton
            // 
            this.transferButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transferButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.transferButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.transferButton.Location = new System.Drawing.Point(16, 164);
            this.transferButton.Margin = new System.Windows.Forms.Padding(2);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(256, 28);
            this.transferButton.TabIndex = 6;
            this.transferButton.Text = "Transfer";
            this.transferButton.UseVisualStyleBackColor = true;
            this.transferButton.Click += new System.EventHandler(this.transferButton_Click);
            // 
            // LogOut
            // 
            this.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.LogOut.Location = new System.Drawing.Point(17, 205);
            this.LogOut.Margin = new System.Windows.Forms.Padding(2);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(256, 28);
            this.LogOut.TabIndex = 7;
            this.LogOut.Text = "LogOut";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.transferButton);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.beneficiaryLabel);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label beneficiaryLabel;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Button transferButton;
        private System.Windows.Forms.Button LogOut;
    }
}