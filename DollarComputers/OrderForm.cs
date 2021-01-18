using DollarComputers.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }
        double Sale_Tax;
        double Total;
        double Cost;
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutForm.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            MessageBox.Show("It is being sent to the printer");
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductInfoForm productInfoForm = new ProductInfoForm();
            //show the ProductInfoForm  form
            productInfoForm.Show();
            //close this form
            this.Hide();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            ProductInfoForm productInfoForm = new ProductInfoForm();
            //show the ProductInfoForm  form
            productInfoForm.Show();
            //close this form
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OrderForm_Activated(object sender, EventArgs e)
        {
            using (StreamReader inputStream = new StreamReader(File.Open("Dollar.txt", FileMode.Open)))
            {
                Program.dollar.ID = int.Parse(inputStream.ReadLine());
                Program.dollar.Cost = inputStream.ReadLine();
                Program.dollar.MFG = inputStream.ReadLine();
                Program.dollar.Model = inputStream.ReadLine();
                Program.dollar.Memory = inputStream.ReadLine();
                Program.dollar.LCDSize = inputStream.ReadLine();
                Program.dollar.CPUBrand = inputStream.ReadLine();
                Program.dollar.CPUType = inputStream.ReadLine();
                Program.dollar.CPUNumber = inputStream.ReadLine();
                Program.dollar.CPUSpeed = inputStream.ReadLine();
                Program.dollar.Condition = inputStream.ReadLine();
                Program.dollar.Platform = inputStream.ReadLine();
                Program.dollar.OS = inputStream.ReadLine();
                Program.dollar.HDD = inputStream.ReadLine();
                Program.dollar.GPUType = inputStream.ReadLine();
                Program.dollar.WebCam = inputStream.ReadLine();
                //close and cleanup
                inputStream.Close();
                inputStream.Dispose();

                Condition_textBox.Text = Program.dollar.Condition;
                Manfacturer_textBox.Text = Program.dollar.MFG;
                Model_textBox.Text = Program.dollar.Model;
                Platform_textBox.Text = Program.dollar.Platform;
                Price_textBox.Text = Program.dollar.Cost;
          
                Sale_Tax = 0.13 * Cost;
                SalesTax_textBox.Text = Convert.ToString(Sale_Tax);
                Total = Cost + Sale_Tax;
                Total_textBox.Text = Convert.ToString(Total);



            }

        }

        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Finish_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Your order will be processed in 7 - 10 business days", "Thank you for your purchase.",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void printPriviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductPrintForm.PrintAction = PrintAction.PrintToPreview;
            ProductPrintForm.Print();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            using (var db = new DollarComputerContext())
            {
                db.Products.Load();
                productBindingSource.DataSource = db.Products.Local.ToBindingList();
            }
        }
    }
}
