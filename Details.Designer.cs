namespace Trabalho_Pratico
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
            this.exit_button = new System.Windows.Forms.Button();
            this.name_label = new System.Windows.Forms.Label();
            this.desc_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(741, 445);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(136, 41);
            this.exit_button.TabIndex = 11;
            this.exit_button.Text = "Voltar";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.name_label.Location = new System.Drawing.Point(39, 33);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(153, 31);
            this.name_label.TabIndex = 14;
            this.name_label.Text = "name_label";
            // 
            // desc_TextBox
            // 
            this.desc_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.desc_TextBox.Enabled = false;
            this.desc_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.desc_TextBox.Location = new System.Drawing.Point(45, 354);
            this.desc_TextBox.Multiline = true;
            this.desc_TextBox.Name = "desc_TextBox";
            this.desc_TextBox.ReadOnly = true;
            this.desc_TextBox.Size = new System.Drawing.Size(526, 108);
            this.desc_TextBox.TabIndex = 15;
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 498);
            this.Controls.Add(this.desc_TextBox);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.exit_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhes do prato";
            this.Load += new System.EventHandler(this.Details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox desc_TextBox;
    }
}