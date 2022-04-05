using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simpel_algoritme
{
    public partial class Form1 : Form
    {
        Order order = new Order();
        public Form1()
        {
            InitializeComponent();
            generateProducts();
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            order.products.Add(ProductBox.SelectedItem as Product);
            listBox1.Items.Clear();
            foreach (var product in order.products)
            {
                listBox1.Items.Add(product.Name + " $" + product.Price.ToString());
            }

        }

        public void generateProducts()
        {
            ProductBox.DisplayMember = "Name";
            ProductBox.Items.Add(new Product("pizza", 9.95));
            ProductBox.Items.Add(new Product("donet", 2.00));
            ProductBox.Items.Add(new Product("fanta", 0.95));
            ProductBox.Items.Add(new Product("cola", 0.99));
            ProductBox.Items.Add(new Product("peren", 1.20));
            ProductBox.Items.Add(new Product("wijn", 15.00));
            ProductBox.Items.Add(new Product("brokkoli", 0.89));
        }

        private void maxButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(order.GiveMaxiumPrice().ToString());
        }

        private void averageButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(order.GiveAveragePrice().ToString());
        }

        private void minPriceButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var product in order.GetAllProducts(double.Parse(textBox1.Text)))
            {
                listBox1.Items.Add(product.Name + " $" + product.Price.ToString());
            }
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            order.SortProductsByPrice();

            listBox1.Items.Clear();
            foreach (var product in order.products)
            {
                listBox1.Items.Add(product.Name + " $" + product.Price.ToString());
            }
        }
    }
}
