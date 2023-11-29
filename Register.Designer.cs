namespace Trabalho_Pratico
{
    partial class Register
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
            this.name_label = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.pass_textBox = new System.Windows.Forms.TextBox();
            this.pass_label = new System.Windows.Forms.Label();
            this.user_textBox = new System.Windows.Forms.TextBox();
            this.user_label = new System.Windows.Forms.Label();
            this.cpass_textBox = new System.Windows.Forms.TextBox();
            this.cpass_label = new System.Windows.Forms.Label();
            this.register_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.name_label.Location = new System.Drawing.Point(117, 63);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(290, 29);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Digite seu primeiro nome:";
            // 
            // name_textBox
            // 
            this.name_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.name_textBox.Location = new System.Drawing.Point(120, 95);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(534, 35);
            this.name_textBox.TabIndex = 1;
            // 
            // pass_textBox
            // 
            this.pass_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.pass_textBox.Location = new System.Drawing.Point(122, 240);
            this.pass_textBox.Name = "pass_textBox";
            this.pass_textBox.Size = new System.Drawing.Size(534, 35);
            this.pass_textBox.TabIndex = 3;
            // 
            // pass_label
            // 
            this.pass_label.AutoSize = true;
            this.pass_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.pass_label.Location = new System.Drawing.Point(119, 208);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(197, 29);
            this.pass_label.TabIndex = 2;
            this.pass_label.Text = "Digite sua senha:";
            // 
            // user_textBox
            // 
            this.user_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.user_textBox.Location = new System.Drawing.Point(120, 165);
            this.user_textBox.Name = "user_textBox";
            this.user_textBox.Size = new System.Drawing.Size(534, 35);
            this.user_textBox.TabIndex = 5;
            // 
            // user_label
            // 
            this.user_label.AutoSize = true;
            this.user_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.user_label.Location = new System.Drawing.Point(117, 133);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(232, 29);
            this.user_label.TabIndex = 4;
            this.user_label.Text = "Digite o seu usuário:";
            // 
            // cpass_textBox
            // 
            this.cpass_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cpass_textBox.Location = new System.Drawing.Point(122, 314);
            this.cpass_textBox.Name = "cpass_textBox";
            this.cpass_textBox.Size = new System.Drawing.Size(534, 35);
            this.cpass_textBox.TabIndex = 7;
            // 
            // cpass_label
            // 
            this.cpass_label.AutoSize = true;
            this.cpass_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cpass_label.Location = new System.Drawing.Point(119, 282);
            this.cpass_label.Name = "cpass_label";
            this.cpass_label.Size = new System.Drawing.Size(251, 29);
            this.cpass_label.TabIndex = 6;
            this.cpass_label.Text = "Confirme a sua senha:";
            // 
            // register_button
            // 
            this.register_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.register_button.Location = new System.Drawing.Point(571, 370);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(85, 29);
            this.register_button.TabIndex = 8;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.back_button.Location = new System.Drawing.Point(124, 370);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(283, 29);
            this.back_button.TabIndex = 9;
            this.back_button.Text = "Do you have already a account? Log in";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(741, 445);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(136, 41);
            this.exit_button.TabIndex = 10;
            this.exit_button.Text = "Sair";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 498);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.cpass_textBox);
            this.Controls.Add(this.cpass_label);
            this.Controls.Add(this.user_textBox);
            this.Controls.Add(this.user_label);
            this.Controls.Add(this.pass_textBox);
            this.Controls.Add(this.pass_label);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.name_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox pass_textBox;
        private System.Windows.Forms.Label pass_label;
        private System.Windows.Forms.TextBox user_textBox;
        private System.Windows.Forms.Label user_label;
        private System.Windows.Forms.TextBox cpass_textBox;
        private System.Windows.Forms.Label cpass_label;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button exit_button;
    }
}