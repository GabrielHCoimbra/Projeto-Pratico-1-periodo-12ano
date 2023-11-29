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
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            double sum = 0;// Creating the Sum variable
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader("..\\..\\txts\\cart.txt");
            //Read the first line of text
            String line = sr.ReadLine();
            if (line!=null && line!="")
            {
                //Continue to read until you reach end of file
                do
                {
                    var palavras = line.Split(' '); // splits the line into many words
                    if (line != null && line != "")
                    {
                        var current_food = palavras[0]; // getting the first word of the line separated by space
                        var current_food_value = palavras[1]; // getting the second word of the line separated by space

                        double current_food_v = Convert.ToDouble(palavras[1]); // getting the second word of the line separated by space

                        //adding up all items in the cart
                        sum = sum + current_food_v;

                        ListViewItem lv1 = new ListViewItem(current_food.Replace("-", " "), 0); // Creating a new item with index 0 in the list view
                        lv1.SubItems.Add(current_food_value + "€"); // Creating a new subitem for the principal item

                        //adding the product in the list
                        lv_products.Items.Add(lv1);
                    }
                    //Read the next line
                    line = sr.ReadLine();


                } while (line != null);

                // Close the Stream Reader
                sr.Close();

                // Attributing to the value label the total value for the cart
                value_textBox.Text = Convert.ToString(sum);
            }
            else
            {
                MessageBox.Show("Carrinho Vazio!");
            }
            
            
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            //Return to the Principal's Form
            Principal principal = new Principal();
            principal.Show();
            this.Close();
        }
    }
}
