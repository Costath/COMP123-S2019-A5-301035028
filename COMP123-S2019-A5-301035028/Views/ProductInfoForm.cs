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
    /// Implements the ProductInfoForm Form
    /// </summary>
    public partial class ProductInfoForm : Form
    {   
        /// <summary>
        /// Enum holding all information fields that a product has.
        /// </summary>
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
        // Holds the information loaded from file when the user loads an order previously saved
        public List<string> loadedProductSpecs = null;

        public ProductInfoForm()
        {
            InitializeComponent();
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
        /// This is the event handler for the ProductInfoSelectAnotherProductbutton_Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoSelectAnotherProductbutton_Click(object sender, EventArgs e)
        {
            Program.startForm.loadFromFile = false;
            this.Hide();
            Program.selectForm.Show();
        }
        /// <summary>
        /// This is the event handler for the ProductInfoForm_VisibleChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoForm_VisibleChanged(object sender, EventArgs e)
        {
            // Local variable that will flag when the user loads information from a file
            bool _loadFromFile = Program.startForm.loadFromFile;
            try
            {
                /* if the visibility changed to visible and loadFromFile == false, it means the information should be 
                   loaded from Program.selectForm.ProductDataGridView */
                if (this.Visible && !_loadFromFile)
                {
                    // Multiselect is off in ProductDataGridView, so the list containing the selected rows will always have only index 0
                    // Local variable that holds the information from the selected row
                    var _selectedRow = Program.selectForm.ProductDataGridView.SelectedRows[0];
                    ProductIDValueLabel.Text = _selectedRow.Cells[(int)Product.productID].Value.ToString();
                    ConditionValueLabel.Text = _selectedRow.Cells[(int)Product.condition].Value.ToString();
                    string _aux = _selectedRow.Cells[(int)Product.cost].Value.ToString(); // auxiliary string to make the code more readable
                    CostValueLabel.Text = "$" + _aux.Substring(0, _aux.Length - 2); /* Removes the 2 extra zeros from the data and concatenates 
                                                                                       with a "$" */
                    PlatformValueLabel.Text = _selectedRow.Cells[(int)Product.platform].Value.ToString();
                    ManufacturerValueLabel.Text = _selectedRow.Cells[(int)Product.manufacturer].Value.ToString();
                    OSValueLabel.Text = _selectedRow.Cells[(int)Product.OS].Value.ToString();
                    ModelValueLabel.Text = _selectedRow.Cells[(int)Product.model].Value.ToString();
                    MemoryValueLabel.Text = _selectedRow.Cells[(int)Product.RAM_size].Value.ToString();
                    CPUBrandValueLabel.Text = _selectedRow.Cells[(int)Product.CPU_brand].Value.ToString();
                    CPUTypeValueLabel.Text = _selectedRow.Cells[(int)Product.CPU_type].Value.ToString();
                    LCDSizeValueLabel.Text = _selectedRow.Cells[(int)Product.screensize].Value.ToString();
                    CPUNumberValueLabel.Text = _selectedRow.Cells[(int)Product.CPU_number].Value.ToString();
                    CPUSpeedValueLabel.Text = _selectedRow.Cells[(int)Product.CPU_speed].Value.ToString();
                    HDDValueLabel.Text = _selectedRow.Cells[(int)Product.HDD_size].Value.ToString();
                    GPUTypeValueLabel.Text = _selectedRow.Cells[(int)Product.GPU_Type].Value.ToString();
                    WebcamValueLabel.Text = _selectedRow.Cells[(int)Product.webcam].Value.ToString();

                    ProductInfoNextButton.Enabled = true;
                    /* Assures OrderForm labels will be filled with info from ProductDataGridView again until 
                       the user chooses to load from a file */
                    loadedProductSpecs = null;
                    Program.startForm.loadFromFile = false;

                    ProductInfoToolStripStatusLabel.Text = "";
                }
                else if (this.Visible && _loadFromFile && loadedProductSpecs != null)
                {
                    using (StreamReader _streamReader = new StreamReader(ProductInfoFormOpenFileDialog.FileName))
                    {
                        string _productRow;
                        loadedProductSpecs = new List<string> { };

                        while (_streamReader.Peek() != -1)
                        {
                            _productRow = _streamReader.ReadLine();
                            loadedProductSpecs.Add(_productRow);
                        }

                        ProductIDValueLabel.Text = loadedProductSpecs[(int)ProductInfoForm.Product.productID];
                        ConditionValueLabel.Text = loadedProductSpecs[(int)ProductInfoForm.Product.condition];
                        string _aux = loadedProductSpecs[(int)ProductInfoForm.Product.cost]; // auxiliary string to make the code more readable
                        CostValueLabel.Text = "$" + _aux.Substring(0, _aux.Length - 2); /* Removes the 2 extra zeros from the data and 
                                                                                           concatenates with a "$" */
                        PlatformValueLabel.Text = loadedProductSpecs[(int)ProductInfoForm.Product.platform];
                        ManufacturerValueLabel.Text = loadedProductSpecs[(int)ProductInfoForm.Product.manufacturer];
                        OSValueLabel.Text = loadedProductSpecs[(int)ProductInfoForm.Product.OS];
                        ModelValueLabel.Text = loadedProductSpecs[(int)ProductInfoForm.Product.model];
                        MemoryValueLabel.Text = loadedProductSpecs[(int)ProductInfoForm.Product.RAM_size];
                        CPUBrandValueLabel.Text = loadedProductSpecs[(int)ProductInfoForm.Product.CPU_brand];
                        CPUTypeValueLabel.Text = loadedProductSpecs[(int)ProductInfoForm.Product.CPU_type];
                        LCDSizeValueLabel.Text = loadedProductSpecs[(int)ProductInfoForm.Product.screensize];
                        CPUNumberValueLabel.Text = loadedProductSpecs[(int)ProductInfoForm.Product.CPU_number];
                        CPUSpeedValueLabel.Text = loadedProductSpecs[(int)ProductInfoForm.Product.CPU_speed];
                        HDDValueLabel.Text = loadedProductSpecs[(int)ProductInfoForm.Product.HDD_size];
                        GPUTypeValueLabel.Text = loadedProductSpecs[(int)ProductInfoForm.Product.GPU_Type];
                        WebcamValueLabel.Text = loadedProductSpecs[(int)ProductInfoForm.Product.webcam];

                        ProductInfoNextButton.Enabled = true;
                        ProductInfoToolStripStatusLabel.Text = "Information successfully loaded from file."; // User feedback message
                    }
                }
            }// Handles exception returned when no file is chosen or the file is not according with Save format. Also don't let program crash on others Exceptions that may occur
            catch (Exception exception)
            {
                // Clear the form in case of an error
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
                Program.startForm.loadFromFile = false; // Assures the form will not be filled with wrong information or half filled
                ProductInfoToolStripStatusLabel.Text = "Error opening the file."; // User feedback message
            }
        }
        /// <summary>
        /// This is the event handler for the OpenToolStripMenuItem_Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductInfoFormOpenFileDialog.FileName = "";
            ProductInfoFormOpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (ProductInfoFormOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader _streamReader = new StreamReader(Program.productInfoForm.ProductInfoFormOpenFileDialog.FileName))
                    {
                        string _productRow;
                        loadedProductSpecs = new List<string> { };

                        while (_streamReader.Peek() != -1)
                        {
                            _productRow = _streamReader.ReadLine();
                            loadedProductSpecs.Add(_productRow);
                        }

                        ProductIDValueLabel.Text = loadedProductSpecs[(int)ProductInfoForm.Product.productID];
                        ConditionValueLabel.Text = loadedProductSpecs[(int)ProductInfoForm.Product.condition];
                        string _aux = loadedProductSpecs[(int)ProductInfoForm.Product.cost]; // auxiliary string to make the code more readable
                        CostValueLabel.Text = "$" + _aux.Substring(0, _aux.Length - 2); // Removes the 2 extra zeros from the data and concatenates with a "$"
                        PlatformValueLabel.Text = loadedProductSpecs[(int)ProductInfoForm.Product.platform];
                        ManufacturerValueLabel.Text = loadedProductSpecs[(int)ProductInfoForm.Product.manufacturer];
                        OSValueLabel.Text = loadedProductSpecs[(int)ProductInfoForm.Product.OS];
                        ModelValueLabel.Text = loadedProductSpecs[(int)ProductInfoForm.Product.model];
                        MemoryValueLabel.Text = loadedProductSpecs[(int)ProductInfoForm.Product.RAM_size];
                        CPUBrandValueLabel.Text = loadedProductSpecs[(int)ProductInfoForm.Product.CPU_brand];
                        CPUTypeValueLabel.Text = loadedProductSpecs[(int)ProductInfoForm.Product.CPU_type];
                        LCDSizeValueLabel.Text = loadedProductSpecs[(int)ProductInfoForm.Product.screensize];
                        CPUNumberValueLabel.Text = loadedProductSpecs[(int)ProductInfoForm.Product.CPU_number];
                        CPUSpeedValueLabel.Text = loadedProductSpecs[(int)ProductInfoForm.Product.CPU_speed];
                        HDDValueLabel.Text = loadedProductSpecs[(int)ProductInfoForm.Product.HDD_size];
                        GPUTypeValueLabel.Text = loadedProductSpecs[(int)ProductInfoForm.Product.GPU_Type];
                        WebcamValueLabel.Text = loadedProductSpecs[(int)ProductInfoForm.Product.webcam];

                        ProductInfoToolStripStatusLabel.Text = "Information successfully loaded from file."; // User feedback message
                        Program.startForm.loadFromFile = true;
                        ProductInfoNextButton.Enabled = true;
                    }
                }// Handles exception returned when no file is chosen or the file is not according with Save format. Also don't let program crash on others Exceptions that may occur
                catch (Exception exception)
                {
                    // Clear the form in case of an error
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
                    Program.startForm.loadFromFile = false; // Assures the form will not be filled with wrong information or half filled
                    ProductInfoToolStripStatusLabel.Text = "Error opening the file."; // User feedback message
                }
            }
        }
        /// <summary>
        /// This is the event handler for the SaveToolStripMenuItem_Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductInfoFormSaveFileDialog.FileName = "Product.txt";
            ProductInfoFormSaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            try
            {
                if(ProductInfoFormSaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter _streamWriter = new StreamWriter(ProductInfoFormSaveFileDialog.FileName, false))
                    {
                        int _NumberOfItems = Program.selectForm.ProductDataGridView.SelectedRows[0].Cells.Count;
                        var _selectedRow = Program.selectForm.ProductDataGridView.SelectedRows[0];
                        for (int _i = 0; _i < _NumberOfItems; _i++)
                        {
                           _streamWriter.WriteLine(_selectedRow.Cells[_i].Value.ToString());
                        }
                        _streamWriter.Close();
                        ProductInfoToolStripStatusLabel.Text = "File saved."; // User feedback message
                    }
                }
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
                ProductInfoToolStripStatusLabel.Text = "Error saving the file."; // User feedback message
            }
        }
        /// <summary>
        /// This is the event handler for the ProductInfoNextButton_Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoNextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.orderForm.Show();
        }
    }
}
