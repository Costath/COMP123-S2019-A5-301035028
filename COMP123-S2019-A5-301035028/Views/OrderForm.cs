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

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductPrintForm.PrintAction = PrintAction.PrintToPreview;
            ProductPrintForm.Print();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
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
                PriceDataLabel.Text = selectedRow.Cells[(int)Product.cost].Value.ToString();
                SalesTaxDataLabel.Text = (float.Parse(PriceDataLabel.Text) * 0.13).ToString();
                TotalDataLabel.Text = (float.Parse(PriceDataLabel.Text) * 1.13).ToString();
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
                PriceDataLabel.Text = loadedProduct[(int)Product.cost];
                SalesTaxDataLabel.Text = (float.Parse(PriceDataLabel.Text) * 0.13).ToString();
                TotalDataLabel.Text = (float.Parse(PriceDataLabel.Text) * 1.13).ToString();
            }
        }

        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.productInfoForm.Show();
        }
    }
}
