namespace BankRegistration
{
    partial class Details
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
            this.transferButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // transferButton
            // 
            this.transferButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transferButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.transferButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.transferButton.Location = new System.Drawing.Point(16, 194);
            this.transferButton.Margin = new System.Windows.Forms.Padding(2);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(257, 28);
            this.transferButton.TabIndex = 0;
            this.transferButton.Text = "Transfer";
            this.transferButton.UseVisualStyleBackColor = true;
            this.transferButton.Click += new System.EventHandler(this.transferButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            // 
            // LogOut
            // 
            this.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.LogOut.Location = new System.Drawing.Point(17, 226);
            this.LogOut.Margin = new System.Windows.Forms.Padding(2);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(256, 28);
            this.LogOut.TabIndex = 8;
            this.LogOut.Text = "LogOut";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transferButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Details";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button transferButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogOut;
    }
}