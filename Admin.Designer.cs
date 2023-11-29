namespace Trabalho_Pratico
{
    partial class Admin
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
            this.cadastro_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.value_textBox = new System.Windows.Forms.TextBox();
            this.value_label = new System.Windows.Forms.Label();
            this.euro_label = new System.Windows.Forms.Label();
            this.desc_label = new System.Windows.Forms.Label();
            this.desc_textBox = new System.Windows.Forms.TextBox();
            this.alert_label = new System.Windows.Forms.Label();
            this.submit_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.remove_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.country_cB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.product_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.product_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cadastro_label
            // 
            this.cadastro_label.AutoSize = true;
            this.cadastro_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cadastro_label.Location = new System.Drawing.Point(80, 60);
            this.cadastro_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cadastro_label.Name = "cadastro_label";
            this.cadastro_label.Size = new System.Drawing.Size(251, 31);
            this.cadastro_label.TabIndex = 0;
            this.cadastro_label.Text = "Cadastrar Cardápio";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.name_label.Location = new System.Drawing.Point(81, 121);
            this.name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(142, 25);
            this.name_label.TabIndex = 1;
            this.name_label.Text = "Nome do Prato";
            // 
            // name_textBox
            // 
            this.name_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.name_textBox.Location = new System.Drawing.Point(88, 155);
            this.name_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(487, 32);
            this.name_textBox.TabIndex = 2;
            // 
            // value_textBox
            // 
            this.value_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.value_textBox.Location = new System.Drawing.Point(88, 233);
            this.value_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.value_textBox.Name = "value_textBox";
            this.value_textBox.Size = new System.Drawing.Size(132, 32);
            this.value_textBox.TabIndex = 3;
            this.value_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // value_label
            // 
            this.value_label.AutoSize = true;
            this.value_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.value_label.Location = new System.Drawing.Point(81, 198);
            this.value_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.value_label.Name = "value_label";
            this.value_label.Size = new System.Drawing.Size(136, 25);
            this.value_label.TabIndex = 4;
            this.value_label.Text = "Valor do Prato";
            // 
            // euro_label
            // 
            this.euro_label.AutoSize = true;
            this.euro_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.euro_label.Location = new System.Drawing.Point(217, 236);
            this.euro_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.euro_label.Name = "euro_label";
            this.euro_label.Size = new System.Drawing.Size(23, 25);
            this.euro_label.TabIndex = 5;
            this.euro_label.Text = "€";
            // 
            // desc_label
            // 
            this.desc_label.AutoSize = true;
            this.desc_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.desc_label.Location = new System.Drawing.Point(81, 276);
            this.desc_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.desc_label.Name = "desc_label";
            this.desc_label.Size = new System.Drawing.Size(99, 25);
            this.desc_label.TabIndex = 6;
            this.desc_label.Text = "Descrição";
            // 
            // desc_textBox
            // 
            this.desc_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.desc_textBox.Location = new System.Drawing.Point(88, 311);
            this.desc_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.desc_textBox.Multiline = true;
            this.desc_textBox.Name = "desc_textBox";
            this.desc_textBox.Size = new System.Drawing.Size(487, 181);
            this.desc_textBox.TabIndex = 7;
            // 
            // alert_label
            // 
            this.alert_label.AutoSize = true;
            this.alert_label.Location = new System.Drawing.Point(749, 420);
            this.alert_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.alert_label.Name = "alert_label";
            this.alert_label.Size = new System.Drawing.Size(399, 16);
            this.alert_label.TabIndex = 9;
            this.alert_label.Text = "*Lembre-se de que quanto maior a qualidade da imagem, melhor.";
            // 
            // submit_button
            // 
            this.submit_button.Location = new System.Drawing.Point(88, 516);
            this.submit_button.Margin = new System.Windows.Forms.Padding(4);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(133, 37);
            this.submit_button.TabIndex = 10;
            this.submit_button.Text = "Enviar";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.add_button.Location = new System.Drawing.Point(603, 454);
            this.add_button.Margin = new System.Windows.Forms.Padding(4);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(269, 38);
            this.add_button.TabIndex = 11;
            this.add_button.Text = "Adcionar Foto";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // remove_button
            // 
            this.remove_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.remove_button.Location = new System.Drawing.Point(900, 455);
            this.remove_button.Margin = new System.Windows.Forms.Padding(4);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(269, 38);
            this.remove_button.TabIndex = 12;
            this.remove_button.Text = "Remover Foto";
            this.remove_button.UseVisualStyleBackColor = true;
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(988, 550);
            this.exit_button.Margin = new System.Windows.Forms.Padding(4);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(181, 50);
            this.exit_button.TabIndex = 13;
            this.exit_button.Text = "Sair";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // country_cB
            // 
            this.country_cB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.country_cB.FormattingEnabled = true;
            this.country_cB.Items.AddRange(new object[] {
            "Brasil",
            "Italia",
            "Portugal",
            "Japao",
            "USA",
            "Canada"});
            this.country_cB.Location = new System.Drawing.Point(365, 233);
            this.country_cB.Name = "country_cB";
            this.country_cB.Size = new System.Drawing.Size(210, 33);
            this.country_cB.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(360, 198);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "País de Origem";
            // 
            // product_pictureBox
            // 
            this.product_pictureBox.Location = new System.Drawing.Point(603, 121);
            this.product_pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.product_pictureBox.Name = "product_pictureBox";
            this.product_pictureBox.Size = new System.Drawing.Size(567, 295);
            this.product_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.product_pictureBox.TabIndex = 8;
            this.product_pictureBox.TabStop = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 613);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.country_cB);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.alert_label);
            this.Controls.Add(this.product_pictureBox);
            this.Controls.Add(this.desc_textBox);
            this.Controls.Add(this.desc_label);
            this.Controls.Add(this.euro_label);
            this.Controls.Add(this.value_label);
            this.Controls.Add(this.value_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.cadastro_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.product_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cadastro_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox value_textBox;
        private System.Windows.Forms.Label value_label;
        private System.Windows.Forms.Label euro_label;
        private System.Windows.Forms.Label desc_label;
        private System.Windows.Forms.TextBox desc_textBox;
        private System.Windows.Forms.PictureBox product_pictureBox;
        private System.Windows.Forms.Label alert_label;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.ComboBox country_cB;
        private System.Windows.Forms.Label label1;
    }
}