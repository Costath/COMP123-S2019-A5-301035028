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

namespace COMP123_S2019_A5_301035028.Views
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void PrintToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //ProductPrintForm.PrintAction = PrintAction.PrintToPreview;
            //ProductPrintForm.Print();

            MessageBox.Show("Your selection is printing", "Printing Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutBox.ShowDialog();
        }

        private void OrderForm_VisibleChanged(object sender, EventArgs e)
        {
            List<string> loadedProduct = Program.productInfoForm.loadedProductSpecs;
            if (this.Visible && loadedProduct == null)
            {
                var selectedRow = Program.selectForm.ProductDataGridView.SelectedRows[0];
                ConditionDataLabel.Text = selectedRow.Cells[(int)Product.condition].Value.ToString();
                ManufacturerDataLabel.Text = selectedRow.Cells[(int)Product.manufacturer].Value.ToString();
                PlatformDataLabel.Text = selectedRow.Cells[(int)Product.platform].Value.ToString();
                ModelDataLabel.Text = selectedRow.Cells[(int)Product.model].Value.ToString();
                LCDSizeDataLabel.Text = selectedRow.Cells[(int)Product.screensize].Value.ToString();
                MemoryDataLabel.Text = selectedRow.Cells[(int)Product.RAM_size].Value.ToString();
                CPUBrandDataLabel.Text = selectedRow.Cells[(int)Product.CPU_brand].Value.ToString();
                CPUTypeDataLabel.Text = selectedRow.Cells[(int)Product.CPU_type].Value.ToString();
                CPUNumberDataLabel.Text = selectedRow.Cells[(int)Product.CPU_number].Value.ToString();
                CPUSpeedDataLabel.Text = selectedRow.Cells[(int)Product.CPU_speed].Value.ToString();
                HDDDataLabel.Text = selectedRow.Cells[(int)Product.HDD_size].Value.ToString();
                GPUTypeDataLabel.Text = selectedRow.Cells[(int)Product.GPU_Type].Value.ToString();
                WebcamDataLabel.Text = selectedRow.Cells[(int)Product.webcam].Value.ToString();
                // Removes the 2 extra zeros from the data and concatenates with a "$"
                string aux = selectedRow.Cells[(int)Product.cost].Value.ToString(); // auxiliary string to make the code more readable
                PriceDataLabel.Text = "$" + aux.Substring(0, aux.Length - 2);
                SalesTaxDataLabel.Text = (float.Parse(PriceDataLabel.Text.Substring(1)) * 0.13).ToString("c2");
                TotalDataLabel.Text = (float.Parse(PriceDataLabel.Text.Substring(1)) * 1.13).ToString("c2");

                if (PlatformDataLabel.Text == "Desktop PC")
                {
                    ProductPictureBox.Image = Properties.Resources.desktop;
                }
                else if (PlatformDataLabel.Text == "Laptop")
                {
                    ProductPictureBox.Image = Properties.Resources.laptop;
                }
            }
            else if (this.Visible && loadedProduct != null)
            {
                ConditionDataLabel.Text = loadedProduct[(int)Product.condition];
                ManufacturerDataLabel.Text = loadedProduct[(int)Product.manufacturer];
                PlatformDataLabel.Text = loadedProduct[(int)Product.platform];
                ModelDataLabel.Text = loadedProduct[(int)Product.model];
                LCDSizeDataLabel.Text = loadedProduct[(int)Product.screensize];
                MemoryDataLabel.Text = loadedProduct[(int)Product.RAM_size];
                CPUBrandDataLabel.Text = loadedProduct[(int)Product.CPU_brand];
                CPUTypeDataLabel.Text = loadedProduct[(int)Product.CPU_type];
                CPUNumberDataLabel.Text = loadedProduct[(int)Product.CPU_number];
                CPUSpeedDataLabel.Text = loadedProduct[(int)Product.CPU_speed];
                HDDDataLabel.Text = loadedProduct[(int)Product.HDD_size];
                GPUTypeDataLabel.Text = loadedProduct[(int)Product.GPU_Type];
                WebcamDataLabel.Text = loadedProduct[(int)Product.webcam];
                string aux = loadedProduct[(int)Product.cost]; // auxiliary string to make the code more readable
                PriceDataLabel.Text = "$" + aux.Substring(0, aux.Length - 2);
                SalesTaxDataLabel.Text = (float.Parse(PriceDataLabel.Text.Substring(1)) * 0.13).ToString("c2");
                TotalDataLabel.Text = (float.Parse(PriceDataLabel.Text.Substring(1)) * 1.13).ToString("c2");
            }
        }

        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.productInfoForm.Show();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for your business. Your order will be processed in 7 - 10 business days.", "Order confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
