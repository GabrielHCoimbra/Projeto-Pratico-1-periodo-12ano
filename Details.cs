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
    public partial class Details : Form
    {
        string prato, ctry; // Creating the global variables
        public Details(string current_food, string country)
        {
            InitializeComponent();
            //Attributing values to global variables
            prato = current_food;
            ctry = country;
        }

        private void Details_Load(object sender, EventArgs e)
        {
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader("..\\..\\txts\\foods.txt");
            //Read the first line of text
            String line = sr.ReadLine();

            //Continue to read until you reach end of file
            do
            {
                var palavras = line.Split(' '); // splits the line into many words
                var current_food = palavras[0].Replace("-", " "); // getting the first word of the line separated by space
                var current_food_desc = palavras[3].Replace("-", " "); // getting the second word of the line separated by space
                var current_food_image = palavras[4]; // getting the thrird word of the line separated by space

                if (current_food == prato)// Verifying if the current food is equal the selected food
                {
                    name_label.Text = current_food;// Attributing the food name in the label
                    desc_TextBox.Text = current_food_desc; // Attributing the description in the text box
                    Image myimage = new Bitmap(current_food_image); // Creating the image path
                    this.BackgroundImage = myimage;// Attributing the image in the background
                    break;
                }



                //Read the next line
                line = sr.ReadLine();


            } while (line != null);
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            // Return to the List form
            ListForm list = new ListForm(ctry);
            list.Show();
            this.Close();
        }
    }
}
