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

namespace COMP123_S2019_A5_301035028.Views
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handles Load event of SelectForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_Load(object sender, EventArgs e)
        {
            // loads db.products and assigns to ProductDataGridView data source
            using (var db = new ProductModel())
            {
                db.products.Load();

                productBindingSource.DataSource = db.products.Local.ToBindingList();
            }
        }
        
        private void SelectFormNextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.productInfoForm.Show();
        }

        private void SelectFormPrevButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.orderForm.Show();
        }
        /// <summary>
        /// Handles Click event of CancelButton.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Handles Click event of NextButton.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.productInfoForm.Show();
        }
        /// <summary>
        /// Handles SelectionChanged event of ProductDataGridView.
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
                SelectedTextBox.Text += ProductDataGridView.SelectedRows[0].Cells[1].Value.ToString();
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
        /// Handles ForClosing event of SelectForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SelectForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                /* This assures no row is selected when the form is showed*/
                ProductDataGridView.SelectedRows[0].Selected = false;
                SelectedTextBox.Text = "";
                // assures that NextButton is disabled disabled
                NextButton.Enabled = false;
            }
        }
    }
}
