namespace BankRegistration
{
    partial class Form4
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
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.reenterTextBox = new System.Windows.Forms.Label();
            this.doneButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passwordTextBox.Location = new System.Drawing.Point(101, 78);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(171, 26);
            this.passwordTextBox.TabIndex = 7;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.passwordLabel.Location = new System.Drawing.Point(12, 84);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(40, 20);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "New";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usernameTextBox.Location = new System.Drawing.Point(101, 37);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PasswordChar = '*';
            this.usernameTextBox.Size = new System.Drawing.Size(171, 26);
            this.usernameTextBox.TabIndex = 5;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.passLabel.Location = new System.Drawing.Point(12, 37);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(78, 20);
            this.passLabel.TabIndex = 4;
            this.passLabel.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(101, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(171, 26);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // reenterTextBox
            // 
            this.reenterTextBox.AutoSize = true;
            this.reenterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.reenterTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.reenterTextBox.Location = new System.Drawing.Point(12, 124);
            this.reenterTextBox.Name = "reenterTextBox";
            this.reenterTextBox.Size = new System.Drawing.Size(74, 20);
            this.reenterTextBox.TabIndex = 8;
            this.reenterTextBox.Text = "Re-Enter";
            this.reenterTextBox.Click += new System.EventHandler(this.label1_Click);
            // 
            // doneButton
            // 
            this.doneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.doneButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.doneButton.Location = new System.Drawing.Point(16, 166);
            this.doneButton.Margin = new System.Windows.Forms.Padding(2);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(257, 28);
            this.doneButton.TabIndex = 10;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.reenterTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passLabel);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label reenterTextBox;
        private System.Windows.Forms.Button doneButton;
    }
}