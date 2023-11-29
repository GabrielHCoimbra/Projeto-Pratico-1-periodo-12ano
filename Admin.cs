using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Pratico
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            // Return to the Login's form
            Login login = new Login();
            login.Show();
            this.Close();
        }

        OpenFileDialog dialog = new OpenFileDialog(); // Open a new File Dialog(Open the file explorer)

        public void add_button_Click(object sender, EventArgs e)
        {
            if (dialog.ShowDialog() == DialogResult.OK)// If the Show Dialog results ok...
            {
                product_pictureBox.ImageLocation = dialog.FileName.ToString();// the image in picture box is switched
            }
        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            product_pictureBox.Image=null; //Remove the image
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            // Getting the values of textBoxes
            string name = name_textBox.Text;
            string value = value_textBox.Text;
            string ctry = country_cB.Text;
            string desc = desc_textBox.Text;


            // Verifying if are all textBoxes filled
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(value) && !string.IsNullOrEmpty(ctry) && !string.IsNullOrEmpty(desc))
            {
                string path = Path.Combine(@"..\..\p_images\"); //Tells the Path constructor to match the directory location
                var fileName = Path.GetFileName(dialog.FileName); // Receive the File Name
                path = path + fileName; // Add the path with the file name

                string l = "..\\..\\txts\\foods.txt"; // string with the path of the file

                List<string> linhas = File.ReadAllLines(l).ToList(); // Save all old user in a list of strings

                linhas.Insert(0, (name.Replace(" ", "-") + " " + value + "€ " + ctry.ToLower() + " "+ desc.Replace(" ","-")+ " "+path)); // Insert the new product

                File.WriteAllLines(l, linhas); // Write the old users again
               
                try {
                    File.Copy(dialog.FileName, path); // Copy the image to the directory
                } catch {
                    MessageBox.Show("Imagem já existe na base de dados"); // Show error message
                }


                // Cleaning all inputs
                name_textBox.Clear();
                value_textBox.Clear();
                country_cB.Text="";
                desc_textBox.Clear();
                product_pictureBox.Image = null; //Remove the image

                // Show successful message
                MessageBox.Show("Cadastro efetuado com sucesso!");
            }
            else
            {
                // Show the message box asking for fill all inputs
                MessageBox.Show("Por favor, preencha todos os campos");
            }
        }
    }
}
