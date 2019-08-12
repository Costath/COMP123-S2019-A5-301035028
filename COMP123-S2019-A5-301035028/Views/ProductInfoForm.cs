using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_A5_301035028.Views
{
    public partial class ProductInfoForm : Form
    {
        public enum Product
        {
            productID,
            cost,
            manufacturer,
            model,
            RAM_type,
            RAM_size,
            displaytype,
            screensize,
            resolution,
            CPU_Class,
            CPU_brand,
            CPU_type,
            CPU_speed,
            CPU_number,
            condition,
            OS,
            platform,
            HDD_size,
            HDD_speed,
            GPU_Type,
            optical_drive,
            Audio_type,
            LAN,
            WIFI,
            width,
            height,
            depth,
            weight,
            moust_type,
            power,
            webcam
        }
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductInfoSelectAnotherProductbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.selectForm.Show();
        }

        private void ProductInfoForm_VisibleChanged(object sender, EventArgs e)
        {

            try
            {
                if (this.Visible && !Program.loadFromFile)
                {
                    var selectedRow = Program.selectForm.ProductDataGridView.SelectedRows[0];
                    ProductIDValueLabel.Text = selectedRow.Cells[(int)Product.productID].Value.ToString();
                    ConditionValueLabel.Text = selectedRow.Cells[(int)Product.condition].Value.ToString();
                    CostValueLabel.Text = selectedRow.Cells[(int)Product.cost].Value.ToString();
                    PlatformValueLabel.Text = selectedRow.Cells[(int)Product.platform].Value.ToString();
                    ManufacturerValueLabel.Text = selectedRow.Cells[(int)Product.manufacturer].Value.ToString();
                    OSValueLabel.Text = selectedRow.Cells[(int)Product.OS].Value.ToString();
                    ModelValueLabel.Text = selectedRow.Cells[(int)Product.model].Value.ToString();
                    MemoryValueLabel.Text = selectedRow.Cells[(int)Product.RAM_size].Value.ToString();
                    CPUBrandValueLabel.Text = selectedRow.Cells[(int)Product.CPU_brand].Value.ToString();
                    CPUTypeValueLabel.Text = selectedRow.Cells[(int)Product.CPU_type].Value.ToString();
                    LCDSizeValueLabel.Text = selectedRow.Cells[(int)Product.screensize].Value.ToString();
                    CPUNumberValueLabel.Text = selectedRow.Cells[(int)Product.CPU_number].Value.ToString();
                    CPUSpeedValueLabel.Text = selectedRow.Cells[(int)Product.CPU_speed].Value.ToString();
                    HDDValueLabel.Text = selectedRow.Cells[(int)Product.HDD_size].Value.ToString();
                    GPUTypeValueLabel.Text = selectedRow.Cells[(int)Product.GPU_Type].Value.ToString();
                    WebcamValueLabel.Text = selectedRow.Cells[(int)Product.webcam].Value.ToString();

                    ProductInfoNextButton.Enabled = true;

                    ProductInfoToolStripStatusLabel.Text = "";
                }
                else if (this.Visible && Program.loadFromFile)
                {
                    using (StreamReader streamReader = new StreamReader(Program.productInfoForm.ProductInfoFormOpenFileDialog.FileName))
                    {
                        string productRow;
                        List<string> loadedProduct = new List<string> { };
                        // Read all elements into the list.
                        while (streamReader.Peek() != -1)
                        {
                            productRow = streamReader.ReadLine();
                            loadedProduct.Add(productRow);
                        }

                        ProductIDValueLabel.Text = loadedProduct[(int)ProductInfoForm.Product.productID];
                        ConditionValueLabel.Text = loadedProduct[(int)ProductInfoForm.Product.condition];
                        CostValueLabel.Text = loadedProduct[(int)ProductInfoForm.Product.cost];
                        PlatformValueLabel.Text = loadedProduct[(int)ProductInfoForm.Product.platform];
                        ManufacturerValueLabel.Text = loadedProduct[(int)ProductInfoForm.Product.manufacturer];
                        OSValueLabel.Text = loadedProduct[(int)ProductInfoForm.Product.OS];
                        ModelValueLabel.Text = loadedProduct[(int)ProductInfoForm.Product.model];
                        MemoryValueLabel.Text = loadedProduct[(int)ProductInfoForm.Product.RAM_size];
                        CPUBrandValueLabel.Text = loadedProduct[(int)ProductInfoForm.Product.CPU_brand];
                        CPUTypeValueLabel.Text = loadedProduct[(int)ProductInfoForm.Product.CPU_type];
                        LCDSizeValueLabel.Text = loadedProduct[(int)ProductInfoForm.Product.screensize];
                        CPUNumberValueLabel.Text = loadedProduct[(int)ProductInfoForm.Product.CPU_number];
                        CPUSpeedValueLabel.Text = loadedProduct[(int)ProductInfoForm.Product.CPU_speed];
                        HDDValueLabel.Text = loadedProduct[(int)ProductInfoForm.Product.HDD_size];
                        GPUTypeValueLabel.Text = loadedProduct[(int)ProductInfoForm.Product.GPU_Type];
                        WebcamValueLabel.Text = loadedProduct[(int)ProductInfoForm.Product.webcam];

                        ProductInfoNextButton.Enabled = true;

                        ProductInfoToolStripStatusLabel.Text = "Information successfully loaded from file.";
                    }
                    
                    Program.loadFromFile = false;
                }
            }// Handles exception returned when no file is chosen or the file is not in accordance with Save format and don't let program crash on others Exceptions that may occur
            catch (Exception exception)
            {
                ProductIDValueLabel.Text = string.Empty;
                ConditionValueLabel.Text = string.Empty;
                CostValueLabel.Text = string.Empty;
                PlatformValueLabel.Text = string.Empty;
                ManufacturerValueLabel.Text = string.Empty;
                OSValueLabel.Text = string.Empty;
                ModelValueLabel.Text = string.Empty;
                MemoryValueLabel.Text = string.Empty;
                CPUBrandValueLabel.Text = string.Empty;
                CPUTypeValueLabel.Text = string.Empty;
                LCDSizeValueLabel.Text = string.Empty;
                CPUNumberValueLabel.Text = string.Empty;
                CPUSpeedValueLabel.Text = string.Empty;
                HDDValueLabel.Text = string.Empty;
                GPUTypeValueLabel.Text = string.Empty;
                WebcamValueLabel.Text = string.Empty;

                Debug.WriteLine(exception);

                ProductInfoNextButton.Enabled = false;
                Program.loadFromFile = false;
                ProductInfoToolStripStatusLabel.Text = "Error opening the file.";
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductInfoFormOpenFileDialog.FileName = "";
            ProductInfoFormOpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (ProductInfoFormOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader streamReader = new StreamReader(Program.productInfoForm.ProductInfoFormOpenFileDialog.FileName))
                    {
                        string productRow;
                        List<string> loadedProduct = new List<string> { };
                        // Read all elements into the list.
                        while (streamReader.Peek() != -1)
                        {
                            productRow = streamReader.ReadLine();
                            loadedProduct.Add(productRow);
                        }

                        ProductIDValueLabel.Text = loadedProduct[(int)ProductInfoForm.Product.productID];
                        ConditionValueLabel.Text = loadedProduct[(int)ProductInfoForm.Product.condition];
                        CostValueLabel.Text = loadedProduct[(int)ProductInfoForm.Product.cost];
                        PlatformValueLabel.Text = loadedProduct[(int)ProductInfoForm.Product.platform];
                        ManufacturerValueLabel.Text = loadedProduct[(int)ProductInfoForm.Product.manufacturer];
                        OSValueLabel.Text = loadedProduct[(int)ProductInfoForm.Product.OS];
                        ModelValueLabel.Text = loadedProduct[(int)ProductInfoForm.Product.model];
                        MemoryValueLabel.Text = loadedProduct[(int)ProductInfoForm.Product.RAM_size];
                        CPUBrandValueLabel.Text = loadedProduct[(int)ProductInfoForm.Product.CPU_brand];
                        CPUTypeValueLabel.Text = loadedProduct[(int)ProductInfoForm.Product.CPU_type];
                        LCDSizeValueLabel.Text = loadedProduct[(int)ProductInfoForm.Product.screensize];
                        CPUNumberValueLabel.Text = loadedProduct[(int)ProductInfoForm.Product.CPU_number];
                        CPUSpeedValueLabel.Text = loadedProduct[(int)ProductInfoForm.Product.CPU_speed];
                        HDDValueLabel.Text = loadedProduct[(int)ProductInfoForm.Product.HDD_size];
                        GPUTypeValueLabel.Text = loadedProduct[(int)ProductInfoForm.Product.GPU_Type];
                        WebcamValueLabel.Text = loadedProduct[(int)ProductInfoForm.Product.webcam];

                        ProductInfoToolStripStatusLabel.Text = "Information successfully loaded from file.";
                    }
                    ProductInfoNextButton.Enabled = true;
                }
                catch (Exception exception)
                {
                    ProductIDValueLabel.Text = string.Empty;
                    ConditionValueLabel.Text = string.Empty;
                    CostValueLabel.Text = string.Empty;
                    PlatformValueLabel.Text = string.Empty;
                    ManufacturerValueLabel.Text = string.Empty;
                    OSValueLabel.Text = string.Empty;
                    ModelValueLabel.Text = string.Empty;
                    MemoryValueLabel.Text = string.Empty;
                    CPUBrandValueLabel.Text = string.Empty;
                    CPUTypeValueLabel.Text = string.Empty;
                    LCDSizeValueLabel.Text = string.Empty;
                    CPUNumberValueLabel.Text = string.Empty;
                    CPUSpeedValueLabel.Text = string.Empty;
                    HDDValueLabel.Text = string.Empty;
                    GPUTypeValueLabel.Text = string.Empty;
                    WebcamValueLabel.Text = string.Empty;

                    Debug.WriteLine(exception);

                    ProductInfoNextButton.Enabled = false;
                    Program.loadFromFile = false;
                    ProductInfoToolStripStatusLabel.Text = "Error opening the file.";
                }
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductInfoFormSaveFileDialog.FileName = "Product.txt";
            ProductInfoFormOpenFileDialog.Filter = "Text Files (*.txt)|*.txt | All Files (*.*)|*.*";

            try
            {
                if(ProductInfoFormSaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Open the File.StreamWriter 
                    using (StreamWriter streamWriter = new StreamWriter(ProductInfoFormSaveFileDialog.FileName, false))
                    {
                        int NumberOfItems = Program.selectForm.ProductDataGridView.SelectedRows[0].Cells.Count;
                        var selectedRow = Program.selectForm.ProductDataGridView.SelectedRows[0];
                        for (int i = 0; i < NumberOfItems; i++)
                        {
                            streamWriter.WriteLine(selectedRow.Cells[i].Value.ToString());
                        }
                        // Close the file.
                        streamWriter.Close();
                        ProductInfoToolStripStatusLabel.Text = "File saved.";
                    }
                    // Save the items in the file
                }
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
                ProductInfoToolStripStatusLabel.Text = "Error saving the file.";
            }


        }

        private void ProductInfoNextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.orderForm.Show();
        }
    }
}
