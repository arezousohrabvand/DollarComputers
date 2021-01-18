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

namespace DollarComputers
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            //Instantiate the Next Form
            OrderForm orderForm = new OrderForm();
            //Save a reference to the current form in a property of the nextForm
            //Show the next Form
            orderForm.Show();
            //Hide this form!
            this.Hide();
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Select_button_Click(object sender, EventArgs e)
        {
            SelectForm selectForm = new SelectForm();
            //Save a reference to the current form in a property of the nextForm
            //Show the next Form
            selectForm.Show();
            //Hide this form!
            this.Hide();
        }

        private void selectAnotherProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectForm selectForm = new SelectForm();
            //Save a reference to the current form in a property of the nextForm
            //Show the next Form
            selectForm.Show();
            //Hide this form!
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            //open file stream to read
            using (StreamReader inputStream = new StreamReader(File.Open("Dollar.txt", FileMode.Open)))
            {
                //Read stuff from  file
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



                ProductID_textBox.Text = Program.dollar.ID.ToString();
                Condition_textBox.Text = Program.dollar.Condition;
                Cost_textBox.Text = Program.dollar.Cost;
                Platform_textBox.Text = Program.dollar.Platform;
                Manufacturer_textBox.Text = Program.dollar.MFG;
                OS_textBox.Text = Program.dollar.OS;
                Model_textBox.Text = Program.dollar.Model;
                Memory_textBox.Text = Program.dollar.Memory;
                CPUBrand_textBox.Text = Program.dollar.CPUBrand;
                CPUType_textBox.Text = Program.dollar.CPUType;
                LCDSize_textBox.Text = Program.dollar.LCDSize;
                CPUNumber_textBox.Text = Program.dollar.CPUNumber;
                CPUSpeed_textBox.Text = Program.dollar.CPUSpeed;
                HDD_textBox.Text = Program.dollar.HDD;
                GPUType_textBox.Text = Program.dollar.GPUType;
                WebCam_textBox.Text = Program.dollar.WebCam;


            }
        }

        private void ProductInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //configure the file dialog
            DollarOpenFileDialog.FileName = "Dollar.txt";
            DollarOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            DollarOpenFileDialog.Filter = "Text Files (*.txt)|*.txt  |All Files (*.*)|*.*";
            var result = DollarSaveFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                using (StreamWriter outputString = new StreamWriter(File.Open(DollarSaveFileDialog.FileName, FileMode.Create)))
                {
                    //write stuff to file
                    outputString.WriteLine(Program.dollar.ID);
                    outputString.WriteLine(Program.dollar.Cost);
                    outputString.WriteLine(Program.dollar.MFG);
                    outputString.WriteLine(Program.dollar.Model);
                    outputString.WriteLine(Program.dollar.Memory);
                    outputString.WriteLine(Program.dollar.LCDSize);
                    outputString.WriteLine(Program.dollar.CPUBrand);
                    outputString.WriteLine(Program.dollar.CPUType);
                    outputString.WriteLine(Program.dollar.CPUNumber);
                    outputString.WriteLine(Program.dollar.CPUSpeed);
                    outputString.WriteLine(Program.dollar.Condition);
                    outputString.WriteLine(Program.dollar.Platform);
                    outputString.WriteLine(Program.dollar.OS);
                    outputString.WriteLine(Program.dollar.HDD);
                    outputString.WriteLine(Program.dollar.GPUType);
                    outputString.WriteLine(Program.dollar.WebCam);
                    //close and cleanup
                    outputString.Close();
                    outputString.Dispose();
                }
                MessageBox.Show("File Saved Successfully!", "Saving!...",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);

            }



        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DollarOpenFileDialog.FileName = "Dollar.txt";
            DollarOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            DollarOpenFileDialog.Filter = "Text Files (*.txt)|*.txt  |All Files (*.*)|*.*";
            var result = DollarOpenFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                //open file stream to read
                using (StreamReader inputStream = new StreamReader(File.Open("Dollar.txt", FileMode.Open)))
                {
                    //Read stuff from  file
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
                }
            }
        }

    }
}