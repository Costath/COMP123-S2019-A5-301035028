using COMP123_S2019_A5_301035028.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
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
    /// Implements the SelectForm Form
    /// </summary>
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for the SelectForm_Load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_Load(object sender, EventArgs e)
        {
            // loads db.products and assigns to ProductDataGridView data source
            using (var _db = new ProductModel())
            {
                _db.products.Load();

                productBindingSource.DataSource = _db.products.Local.ToBindingList();
            }
        }

        /// <summary>
        /// This is the event handler for the CancelButton_Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is the event handler for the NextButton_Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.productInfoForm.Show();
        }
        /// <summary>
        /// This is the event handler for the ProductDataGridView_SelectionChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            NextButton.Enabled = true;
            try
            {
                // SelectedTextBox.Text receives the value in 'Manufacturer' column
                SelectedTextBox.Text = ProductDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                // appends a space to SelectedTextBox.Text if the last character of "Manufacturer" field is not a space
                if (SelectedTextBox.Text.Substring(SelectedTextBox.Text.Length - 1) != " ")
                {
                    SelectedTextBox.Text += " ";
                }
                // appends the value in 'Model' column to SelectedTextBox.Text
                SelectedTextBox.Text += ProductDataGridView.SelectedRows[0].Cells[3].Value.ToString();
                SelectedTextBox.Text += " $";
                // appends the value in 'Cost' column to SelectedTextBox.Text
                string _aux = ProductDataGridView.SelectedRows[0].Cells[1].Value.ToString(); // auxiliary string to make the code more readable
                SelectedTextBox.Text += _aux.Substring(0, _aux.Length - 2);
            }
            catch (ArgumentOutOfRangeException)
            {
                Debug.WriteLine("ProductDataGridView not populated yet");
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
            }
        }
        /// <summary>
        /// This is the event handler for the SelectForm_FormClosing event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is the event handler for the SelectForm_VisibleChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                /* As ProductDataGridView has Multiselect option off, is will always have only index 0. 
                 * The below line assures no row is selected when the form is showed */
                ProductDataGridView.SelectedRows[0].Selected = false;
                SelectedTextBox.Text = "";
                // assures that NextButton is disabled disabled
                NextButton.Enabled = false;
            }
        }
    }
}
