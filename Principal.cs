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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e){}

        private void brasil_pictureBox_Click(object sender, EventArgs e)
        {
            // call the List form sending the value of the country
            ListForm list = new ListForm("brasil");
            list.Show();
            this.Close();
        }

        private void usa_pictureBox_Click(object sender, EventArgs e)
        {
            // call the List form sending the value of the country
            ListForm list = new ListForm("usa");
            list.Show();
            this.Close();
        }

        private void canada_pictureBox_Click(object sender, EventArgs e)
        {
            // call the List form sending the value of the country
            ListForm list = new ListForm("canada");
            list.Show();
            this.Close();
        }

        private void portugal_pictureBox_Click(object sender, EventArgs e)
        {
            // call the List form sending the value of the country
            ListForm list = new ListForm("portugal");
            list.Show();
            this.Close();
        }

        private void italia_pictureBox_Click(object sender, EventArgs e)
        {
            // call the List form sending the value of the country
            ListForm list = new ListForm("italia");
            list.Show();
            this.Close();
        }

        private void japao_pictureBox_Click(object sender, EventArgs e)
        {
            // call the List form sending the value of the country
            ListForm list = new ListForm("japao");
            list.Show();
            this.Close();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            // Cleaning the cart.txt
            StreamWriter sw = new StreamWriter("..\\..\\txts\\cart.txt");
            sw.WriteLine("");
            sw.Close();

            // Return to the Login's form
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
