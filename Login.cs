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
    public partial class Login : Form
    {
        //user was declared like a global variable
        string user;
        public Login()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            //Getting user and password
            user = user_textBox.Text;
            string pass = pass_textBox.Text;
            

            if (string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(user)) 
            {
                // Show the message box saying that user and password don't was typed
                MessageBox.Show("Digite o usuário e a senha");
            }
            else
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("..\\..\\txts\\logins.txt");
                //Read the first line of text
                String line = sr.ReadLine();

                //Continue to read until you reach end of file
                do
                {
                    var palavras = line.Split(' '); // splits the line into many words
                    var current_user = palavras[0]; // getting the first word of the line separated by space
                    var current_pass = palavras[1]; // getting the second word of the line separated by space
                    var access_lvl = palavras[3]; // getting the fourth word of the line separated by space

                    // Check if exists this user and password
                    if (current_user == user.ToLower() && current_pass == pass)
                    {
                        // Verifying the access level
                        if (access_lvl == "admin")
                        {
                            // This send to the admins menu
                            Admin admin = new Admin();
                            admin.Show();
                            this.Hide();
                            //close the Login's file
                            sr.Close();
                            break;
                        }
                        else
                        { 
                            // This send to the principal menu
                            Principal principal = new Principal();
                            principal.Show();
                            this.Hide();
                            //close the Login's file
                            sr.Close();
                            break;
                        }
                    }
                    else
                    {
                        //Read the next line
                        line = sr.ReadLine();
                    }
                    if(line == null)
                    {
                        // Show the message box saying that user don't exist
                        MessageBox.Show("Usuário não cadastrado");
                    }

                } while (line != null);
               
            }
        }

        private void register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Cleaning the cart.txt
            StreamWriter sw = new StreamWriter("..\\..\\txts\\cart.txt");
            sw.WriteLine("");
            sw.Close();
        }
    }

}
