using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Pratico
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            //back to Login form
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            // Getting the values of textBoxes
            string name = name_textBox.Text;
            string user = user_textBox.Text;
            string pass = pass_textBox.Text;    
            string cpass = cpass_textBox.Text;


            // Verifying if are all textBoxes filled
            if(!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(pass) && !string.IsNullOrEmpty(cpass) && pass == cpass)
            {
                string l = "..\\..\\txts\\logins.txt"; // string with the path of the file
                
                List<string> linhas = File.ReadAllLines(l).ToList(); // Save all old user in a list of strings

                linhas.Insert(0, (user.ToLower() + " " + pass + " " + name + " user")); // Insert the new user

                File.WriteAllLines(l, linhas); // Write the old users again

                // Cleaning all inputs
                name_textBox.Clear();
                user_textBox.Clear();
                pass_textBox.Clear();
                cpass_textBox.Clear();

                // Show successful message
                MessageBox.Show("Cadastro efetuado com sucesso!");
            }
            else
            {
                // Show the message box asking for fill all inputs
                MessageBox.Show("Por favor, preencha todos os campos");
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
