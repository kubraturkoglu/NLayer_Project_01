using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace NLayer.WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();


            client.BaseAddress = new Uri("https://localhost:7016/api/");

            HttpResponseMessage response = await client.GetAsync("Product/2");

            var products = response.Content.ReadAsStringAsync();
            dataGridView1.DataSource= products;

          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
