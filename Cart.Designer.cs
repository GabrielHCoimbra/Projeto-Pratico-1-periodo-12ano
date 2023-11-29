namespace Trabalho_Pratico
{
    partial class Cart
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
            this.euro_label = new System.Windows.Forms.Label();
            this.value_textBox = new System.Windows.Forms.TextBox();
            this.t_pedido_label = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.lv_products = new System.Windows.Forms.ListView();
            this.ch_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // euro_label
            // 
            this.euro_label.AutoSize = true;
            this.euro_label.Location = new System.Drawing.Point(1063, 424);
            this.euro_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.euro_label.Name = "euro_label";
            this.euro_label.Size = new System.Drawing.Size(14, 16);
            this.euro_label.TabIndex = 21;
            this.euro_label.Text = "€";
            // 
            // value_textBox
            // 
            this.value_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.value_textBox.Enabled = false;
            this.value_textBox.Location = new System.Drawing.Point(974, 422);
            this.value_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.value_textBox.Name = "value_textBox";
            this.value_textBox.ReadOnly = true;
            this.value_textBox.Size = new System.Drawing.Size(82, 22);
            this.value_textBox.TabIndex = 20;
            // 
            // t_pedido_label
            // 
            this.t_pedido_label.AutoSize = true;
            this.t_pedido_label.Location = new System.Drawing.Point(823, 424);
            this.t_pedido_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.t_pedido_label.Name = "t_pedido_label";
            this.t_pedido_label.Size = new System.Drawing.Size(135, 16);
            this.t_pedido_label.TabIndex = 19;
            this.t_pedido_label.Text = "Valor total do pedido:";
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(974, 524);
            this.exit_button.Margin = new System.Windows.Forms.Padding(4);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(181, 50);
            this.exit_button.TabIndex = 18;
            this.exit_button.Text = "Voltar";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // lv_products
            // 
            this.lv_products.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_name,
            this.ch_value});
            this.lv_products.HideSelection = false;
            this.lv_products.Location = new System.Drawing.Point(29, 38);
            this.lv_products.Margin = new System.Windows.Forms.Padding(4);
            this.lv_products.MultiSelect = false;
            this.lv_products.Name = "lv_products";
            this.lv_products.Size = new System.Drawing.Size(1051, 372);
            this.lv_products.TabIndex = 17;
            this.lv_products.UseCompatibleStateImageBehavior = false;
            this.lv_products.View = System.Windows.Forms.View.Details;
            // 
            // ch_name
            // 
            this.ch_name.Text = "Nome do Prato";
            this.ch_name.Width = 700;
            // 
            // ch_value
            // 
            this.ch_value.Text = "Valor";
            this.ch_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ch_value.Width = 80;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 613);
            this.Controls.Add(this.euro_label);
            this.Controls.Add(this.value_textBox);
            this.Controls.Add(this.t_pedido_label);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.lv_products);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carrinho";
            this.Load += new System.EventHandler(this.Cart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label euro_label;
        private System.Windows.Forms.TextBox value_textBox;
        private System.Windows.Forms.Label t_pedido_label;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.ListView lv_products;
        private System.Windows.Forms.ColumnHeader ch_name;
        private System.Windows.Forms.ColumnHeader ch_value;
    }
}