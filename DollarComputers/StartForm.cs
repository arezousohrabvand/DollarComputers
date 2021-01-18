using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void NewOrder_button_Click(object sender, EventArgs e)
        {
            //Instantiate the selectForm
            SelectForm selectForm = new SelectForm();
            //Save a reference to the current form in a property of the selectForm
            //Show the next Form
            selectForm.Show();
            //Hide this form!
            this.Hide();

        }

        private void SaveOrder_button_Click(object sender, EventArgs e)
        {
            //Instantiate the Next Form
            ProductInfoForm productInfoForm = new ProductInfoForm();
            //Save a reference to the current form in a property of the nextForm
            //Show the next Form
            productInfoForm.Show();
            //Hide this form!
            this.Hide();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
