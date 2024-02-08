using SalesWindow.Servises;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWindow
{
    public partial class Form1 : Form
    {
        private readonly ProductService service;

        public Form1(ProductService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
              => Application.Exit();

        private async void FirstCategory(string category)
        {
            var categories = await service.GetCategoryProduct(category);

            dataGridView1.DataSource = category;
        }
        private void CategoryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var category = CategoryCombo.SelectedItem.ToString();

            if (category != null) 
                FirstCategory(category);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var product = await service.GetProducts();
            dataGridView1.DataSource = product;
        }

        private async void Purchase()
        {
            int productId = Convert.ToInt32(ProductIdtxt.Text);
            int quantity = Convert.ToInt32(Quantitytxt.Text);

            var purchase = await service.SalesProduct(productId, quantity);
            MessageBox.Show($"Product sold {productId} product number {quantity}");
        }
        private void Purchasebtn_Click(object sender, EventArgs e)
        {
            Purchase();
        }
    }
}
