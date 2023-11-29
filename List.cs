using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Trabalho_Pratico
{
    public partial class ListForm : Form
    {
        string country;
        public ListForm(string ctry)
        {
            InitializeComponent();
            // Saving the Country name in a global variable
            country = ctry;
            // Changing the form text
            this.Text = "Pratos do país "+country.ToUpper();
        }

        private void lv_products_SelectedIndexChanged(object sender, EventArgs e)
        {
            //If the counting of selected items is bigger than 0...
            if (lv_products.SelectedItems.Count > 0)
            {
                // Reveals the details and add button
                details_button.Visible = true;
                add_button.Visible = true; 
            }

            //If the counting of selected items is lower or equal than 0...
            if (lv_products.SelectedItems.Count <= 0)
            {
                // Hide the details and add button
                details_button.Visible = false;
                add_button.Visible = false;
            }

        }

        private void List_Load(object sender, EventArgs e)
        {
            var current_country=""; // country variable
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader("..\\..\\txts\\foods.txt");
            //Read the first line of text
            String line = sr.ReadLine();

            //Continue to read until you reach end of file
            do
            {
                if (line!=null)
                {
                    var palavras = line.Split(' '); // splits the line into many words
                    var current_food = palavras[0]; // getting the first word of the line separated by space
                    var current_food_value = palavras[1]; // getting the second word of the line separated by space
                    current_country = palavras[2]; // getting the thrird word of the line separated by space

                    if (current_country == country)// Verifying if the current country is equal the selected country
                    {
                        ListViewItem lv1 = new ListViewItem(current_food.Replace("-", " "), 0); // Creating a new item with index 0 in the list view
                        lv1.SubItems.Add(current_food_value); // Creating a new subitem for the principal item

                        //adding the product in the list
                        lv_products.Items.Add(lv1);
                    }



                    //Read the next line
                    line = sr.ReadLine();

                }


            } while (line != null);

            sr.Close();
            
            /////////////////////////////////////////////////////////////

            double sum = 0;// Creating the Sum variable
            //Pass the file path and file name to the StreamReader constructor
            sr = new StreamReader("..\\..\\txts\\cart.txt");
            //Read the first line of text
            line = sr.ReadLine();
            if (line != null && line!="")
            {
                //Continue to read until you reach end of file
                while (line != null)
                {
                    var palavras = line.Split(' '); // splits the line into many words
                    if (line != null && line != "")
                    {
                        var current_food = palavras[0]; // getting the first word of the line separated by space
                        var current_food_value = palavras[1]; // getting the second word of the line separated by space

                        double current_food_v = Convert.ToDouble(palavras[1]); // getting the second word of the line separated by space

                        //adding up all items in the cart
                        sum = sum + current_food_v;
                    }
                    //Read the next line
                    line = sr.ReadLine();


                } 

                // Attributing to the value label the total value for the cart
                value_textBox.Text = Convert.ToString(sum);
            }
            // Close the Stream Reader
            sr.Close();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            // Return to the Principal's form
            Principal principal = new Principal();
            principal.Show();
            this.Close();
        }

        private void details_button_Click(object sender, EventArgs e)
        {
            //Get the selected item 
            string prato = Convert.ToString(lv_products.SelectedItems[0].SubItems[0].Text);

            // Go to Details form
            Details details = new Details(prato, country);//Sending the selected item and the country to the Details
            details.Show();
            this.Close();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            //Get the selected item 
            string prato = (lv_products.SelectedItems[0].SubItems[0].Text).Replace(" ","-");

            // Getting the value of the selected item
            double food_value = 0;
            double sum = 0;
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader("..\\..\\txts\\foods.txt");
            //Read the first line of text
            string line = sr.ReadLine();

            //Continue to read until you reach end of file
            do
            {
                var palavras = line.Split(' '); // splits the line into many words
                var current_food = palavras[0]; // getting the first word of the line separated by space
                var current_food_value = palavras[1]; // getting the second word of the line separated by space
                

                if (current_food == prato)// Verifying if the current food is equal the selected food
                { 
                    food_value = Convert.ToDouble(current_food_value.Replace("€", ""));
                    
                }



                //Read the next line
                line = sr.ReadLine();


            } while (line != null);

            // Close the Stream Reader
            sr.Close();

            //////////////////////////////////////////////////////////////////////////

            //Reveals the cart button
            cart_button.Visible = true;

            string l = "..\\..\\txts\\cart.txt"; // string with the path of the file

            List<string> linhas = File.ReadAllLines(l).ToList(); // Save all old user in a list of strings

            linhas.Insert(0, ((prato) + " " + food_value)); // Adding the food in the cart
            File.WriteAllLines(l, linhas); // Write the old users again

            // Reading Cart.txt

            //Pass the file path and file name to the StreamReader constructor
            sr = new StreamReader(l);
            //Read the first line of text
            line = sr.ReadLine();

            
            //Continue to read until you reach end of file
            do
            {
                var palavras = line.Split(' '); // splits the line into many words
                if (line != null && line != "")
                {
                    double current_food_value = Convert.ToDouble(palavras[1]); // getting the second word of the line separated by space

                    //adding up all items in the cart
                    sum = sum + current_food_value;
                }



                //Read the next line
                line = sr.ReadLine();


            } while (line != null);
            

            // Close the Stream Reader
            sr.Close();

            // Attributing to the value label the total value for the cart
            value_textBox.Text = Convert.ToString(sum);

        }

        private void cart_button_Click(object sender, EventArgs e)
        {
            // Sending to the Cart's form
            Cart cart = new Cart();
            cart.Show();
            this.Close();
        }
    }
}
