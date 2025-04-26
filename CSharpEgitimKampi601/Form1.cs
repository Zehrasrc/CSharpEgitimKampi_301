using CSharpEgitimKampi601.Entities;
using CSharpEgitimKampi601.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi601
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CustomerOperations customerOperations = new CustomerOperations();
        private void btnCustomerCreate_Click(object sender, EventArgs e)
        {
            var customer = new Customer()
            {
                CustomerName = txtCustomerName.Text,
                CustomerSurname = txtCustomerSurname.Text,
                CustomerBalance = decimal.Parse(txtCustomerBalance.Text),
                CustomerCity = txtCustomerCity.Text,
                CustomerShoppingCount =int.Parse(txtCustomerShoppingCount.Text),
            };
            customerOperations.AddCustomer(customer);
            MessageBox.Show("Müşteri Ekleme İşlemi Başarılı","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnCustomerList_Click(object sender, EventArgs e)
        {
            List<Customer> customers = customerOperations.GetAllCustomer(); 
            dataGridView1.DataSource = customers;
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            string customerId = txtCustomerId.Text;
            customerOperations.DeleteCustomer(customerId);
            MessageBox.Show("Müşteri Başarıyla Silindi");
        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            string id = txtCustomerId.Text;
            var customer = new Customer()
            {
                CustomerName = txtCustomerName.Text,
                CustomerBalance = decimal.Parse(txtCustomerBalance.Text),
                CustomerCity = txtCustomerCity.Text,
                CustomerShoppingCount = int.Parse(txtCustomerShoppingCount.Text),
                CustomerSurname = txtCustomerSurname.Text,
                CustomerId = id
            };
            customerOperations.UpdateCustomer(customer);
            MessageBox.Show("Müşteri Başarıyla Güncellendi");

        }

        private void btnGetByCustomerId_Click(object sender, EventArgs e)
        {
            string id =txtCustomerId.Text;
            Customer customers=customerOperations.GetCustomerById(id);
            dataGridView1.DataSource=new List<Customer> {customers };

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCustomerShoppingCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
