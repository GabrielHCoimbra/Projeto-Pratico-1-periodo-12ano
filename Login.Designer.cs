namespace Trabalho_Pratico
{
    partial class Login
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
            this.user_label = new System.Windows.Forms.Label();
            this.pass_label = new System.Windows.Forms.Label();
            this.user_textBox = new System.Windows.Forms.TextBox();
            this.pass_textBox = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.cr_account = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_label
            // 
            this.user_label.AutoSize = true;
            this.user_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.user_label.Location = new System.Drawing.Point(153, 116);
            this.user_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(78, 36);
            this.user_label.TabIndex = 0;
            this.user_label.Text = "User";
            // 
            // pass_label
            // 
            this.pass_label.AutoSize = true;
            this.pass_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.pass_label.Location = new System.Drawing.Point(153, 257);
            this.pass_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(147, 36);
            this.pass_label.TabIndex = 1;
            this.pass_label.Text = "Password";
            // 
            // user_textBox
            // 
            this.user_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.user_textBox.Location = new System.Drawing.Point(160, 182);
            this.user_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.user_textBox.Name = "user_textBox";
            this.user_textBox.Size = new System.Drawing.Size(755, 41);
            this.user_textBox.TabIndex = 2;
            // 
            // pass_textBox
            // 
            this.pass_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.pass_textBox.Location = new System.Drawing.Point(160, 329);
            this.pass_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pass_textBox.Name = "pass_textBox";
            this.pass_textBox.PasswordChar = '*';
            this.pass_textBox.Size = new System.Drawing.Size(755, 41);
            this.pass_textBox.TabIndex = 3;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(735, 437);
            this.submit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(181, 50);
            this.submit.TabIndex = 4;
            this.submit.Text = "Login";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // cr_account
            // 
            this.cr_account.Location = new System.Drawing.Point(16, 548);
            this.cr_account.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cr_account.Name = "cr_account";
            this.cr_account.Size = new System.Drawing.Size(181, 50);
            this.cr_account.TabIndex = 5;
            this.cr_account.Text = "Create a account";
            this.cr_account.UseVisualStyleBackColor = true;
            this.cr_account.Click += new System.EventHandler(this.register_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(988, 548);
            this.exit_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(181, 50);
            this.exit_button.TabIndex = 6;
            this.exit_button.Text = "Sair";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1185, 613);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.cr_account);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.pass_textBox);
            this.Controls.Add(this.user_textBox);
            this.Controls.Add(this.pass_label);
            this.Controls.Add(this.user_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user_label;
        private System.Windows.Forms.Label pass_label;
        private System.Windows.Forms.TextBox user_textBox;
        private System.Windows.Forms.TextBox pass_textBox;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button cr_account;
        private System.Windows.Forms.Button exit_button;
    }
}

