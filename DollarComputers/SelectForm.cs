using DollarComputers.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers
{
    public partial class SelectForm : Form
    {
        DollarComputerContext DollarComputerDB = new DollarComputerContext();
        public SelectForm()
        {
            InitializeComponent();
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            //Instantiate the Next Form
            ProductInfoForm productInfoForm = new ProductInfoForm();
            //Save a reference to the current form in a property of the nextForm
            //Show the next Form
            productInfoForm.Show();
            this.Hide();
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            using (var db = new DollarComputerContext())
            {
                db.Products.Load();
                productBindingSource.DataSource = db.Products.Local.ToBindingList();
            }


            
        }

        private void SelectOrder_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //local scope aliases
            var rowIndex = SelectOrder_dataGridView.CurrentCell.RowIndex;
            var rows = SelectOrder_dataGridView.Rows;
            var cells = rows[rowIndex].Cells;
            var columnCount = SelectOrder_dataGridView.ColumnCount;
            rows[rowIndex].Selected = true;
            string outputString = string.Empty;
            for (int index = 0; index < columnCount; index++)
            {
                outputString += cells[index].Value.ToString() + " ";
            }
            SelectiontextBox.Text = outputString;



            Program.dollar.ID = int.Parse(cells[(int)DollarField.ID].Value.ToString());
            Program.dollar.Cost = cells[(int)DollarField.COST].Value.ToString();
            Program.dollar.MFG = cells[(int)DollarField.MFG].Value.ToString();
            Program.dollar.Model = cells[(int)DollarField.MODEL].Value.ToString();
            Program.dollar.Memory = cells[(int)DollarField.MEMORY].Value.ToString();
            Program.dollar.LCDSize = cells[(int)DollarField.LCDSIZE].Value.ToString();
            Program.dollar.CPUBrand = cells[(int)DollarField.CPUBRAND].Value.ToString();
            Program.dollar.CPUType = cells[(int)DollarField.CPUTYPE].Value.ToString();
            Program.dollar.CPUNumber = cells[(int)DollarField.CPUNUMBER].Value.ToString();
            Program.dollar.CPUSpeed = cells[(int)DollarField.CPUSPEED].Value.ToString();
            Program.dollar.Condition = cells[(int)DollarField.CONDITION].Value.ToString();
            Program.dollar.Platform = cells[(int)DollarField.MEMORY].Value.ToString();
            Program.dollar.OS = cells[(int)DollarField.OS].Value.ToString();
            Program.dollar.HDD = cells[(int)DollarField.HDD].Value.ToString();
            Program.dollar.GPUType = cells[(int)DollarField.GPUTYPE].Value.ToString();
            Program.dollar.WebCam = cells[(int)DollarField.WEBCAM].Value.ToString();
            
        }

        private void Save_button_Click(object sender, EventArgs e)
        {

           

            //open stream to write
            using (StreamWriter outputString = new StreamWriter(File.Open("Dollar.txt",FileMode.Create)))
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
    }

