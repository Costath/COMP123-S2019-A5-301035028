using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static COMP123_S2019_A5_301035028.Views.ProductInfoForm;

/*
 * App name: Dollar Computers Order App
 * Author's name: Thales Costa
 * Student ID: 301035028
 * App creation date: August 2019
 * 
 */

namespace COMP123_S2019_A5_301035028.Views
{
    /// <summary>
    /// Implements the OrderForm Form
    /// </summary>
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for the PrintToolStripMenuItem_Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ProductPrintForm.PrintAction = PrintAction.PrintToPreview;
            //ProductPrintForm.Print();

            MessageBox.Show("Your selection is printing", "Printing Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// This is the event handler for the ExitToolStripMenuItem_Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is the event handler for the AboutToolStripMenuItem_Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutBox.ShowDialog();
        }
        /// <summary>
        /// This is the event handler for the OrderForm_VisibleChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderForm_VisibleChanged(object sender, EventArgs e)
        {
            // Local variable that will hold the product information loaded from the file
            List<string> _loadedProduct = Program.productInfoForm.loadedProductSpecs;
            /* if the visibility changed to visible and loadedProduct == null, it means the information should be 
               loaded from Program.selectForm.ProductDataGridView */
            if (this.Visible && _loadedProduct == null)
            {
                var _selectedRow = Program.selectForm.ProductDataGridView.SelectedRows[0];
                ConditionDataLabel.Text = _selectedRow.Cells[(int)Product.condition].Value.ToString();
                ManufacturerDataLabel.Text = _selectedRow.Cells[(int)Product.manufacturer].Value.ToString();
                PlatformDataLabel.Text = _selectedRow.Cells[(int)Product.platform].Value.ToString();
                ModelDataLabel.Text = _selectedRow.Cells[(int)Product.model].Value.ToString();
                LCDSizeDataLabel.Text = _selectedRow.Cells[(int)Product.screensize].Value.ToString();
                MemoryDataLabel.Text = _selectedRow.Cells[(int)Product.RAM_size].Value.ToString();
                CPUBrandDataLabel.Text = _selectedRow.Cells[(int)Product.CPU_brand].Value.ToString();
                CPUTypeDataLabel.Text = _selectedRow.Cells[(int)Product.CPU_type].Value.ToString();
                CPUNumberDataLabel.Text = _selectedRow.Cells[(int)Product.CPU_number].Value.ToString();
                CPUSpeedDataLabel.Text = _selectedRow.Cells[(int)Product.CPU_speed].Value.ToString();
                HDDDataLabel.Text = _selectedRow.Cells[(int)Product.HDD_size].Value.ToString();
                GPUTypeDataLabel.Text = _selectedRow.Cells[(int)Product.GPU_Type].Value.ToString();
                WebcamDataLabel.Text = _selectedRow.Cells[(int)Product.webcam].Value.ToString();
                string _aux = _selectedRow.Cells[(int)Product.cost].Value.ToString(); // auxiliary string to make the code more readable
                PriceDataLabel.Text = "$" + _aux.Substring(0, _aux.Length - 2); /* Removes the 2 extra zeros from the data and concatenates
                                                                                 with a "$" */
                // Parse the string to float to perform the calculations and format as currency later
                SalesTaxDataLabel.Text = (float.Parse(_aux) * 0.13).ToString("c"); // only tax
                TotalDataLabel.Text = (float.Parse(_aux) * 1.13).ToString("c"); // tax + item
                // Changes the picture in ProductPictureBox according to the plataform
                if (PlatformDataLabel.Text == "Desktop PC")
                {
                    ProductPictureBox.Image = Properties.Resources.desktop;
                }
                else if (PlatformDataLabel.Text == "Laptop")
                {
                    ProductPictureBox.Image = Properties.Resources.laptop;
                }
            }/* if the visibility changed to visible and loadedProduct == null, it means the information should be loaded 
                from Program.productInfoForm.loadedProductSpecs, which contains the information loaded from the file */
            else if (this.Visible && _loadedProduct != null)
            {
                ConditionDataLabel.Text = _loadedProduct[(int)Product.condition];
                ManufacturerDataLabel.Text = _loadedProduct[(int)Product.manufacturer];
                PlatformDataLabel.Text = _loadedProduct[(int)Product.platform];
                ModelDataLabel.Text = _loadedProduct[(int)Product.model];
                LCDSizeDataLabel.Text = _loadedProduct[(int)Product.screensize];
                MemoryDataLabel.Text = _loadedProduct[(int)Product.RAM_size];
                CPUBrandDataLabel.Text = _loadedProduct[(int)Product.CPU_brand];
                CPUTypeDataLabel.Text = _loadedProduct[(int)Product.CPU_type];
                CPUNumberDataLabel.Text = _loadedProduct[(int)Product.CPU_number];
                CPUSpeedDataLabel.Text = _loadedProduct[(int)Product.CPU_speed];
                HDDDataLabel.Text = _loadedProduct[(int)Product.HDD_size];
                GPUTypeDataLabel.Text = _loadedProduct[(int)Product.GPU_Type];
                WebcamDataLabel.Text = _loadedProduct[(int)Product.webcam];
                string _aux = _loadedProduct[(int)Product.cost]; // auxiliary string to make the code more readable
                PriceDataLabel.Text = "$" + _aux.Substring(0, _aux.Length - 2); // Removes the 2 extra zeros from the data and concatenates with a "$"
                SalesTaxDataLabel.Text = (float.Parse(PriceDataLabel.Text.Substring(1)) * 0.13).ToString("c");
                TotalDataLabel.Text = (float.Parse(PriceDataLabel.Text.Substring(1)) * 1.13).ToString("c");
            }
        }
        /// <summary>
        /// This is the event handler for the BackToolStripMenuItem_Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.productInfoForm.Show();
        }
        /// <summary>
        /// This is the event handler for the FinishButton_Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for your business. Your order will be processed in 7 - 10 business days.", "Order confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
