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
    /// Implements the StartForm Form
    /// </summary>
    public partial class StartForm : Form
    {
        // Flags when the user loads information from a file
        public bool loadFromFile;
        public StartForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for the ExitButton_Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This is the event handler for the NewOrderButton_Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            loadFromFile = false;
            this.Hide();
            Program.selectForm.Show();
        }

        /// <summary>
        /// This is the event handler for the LoadOrderButton_Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadOrderButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.ProductInfoFormOpenFileDialog.FileName = "";
            Program.productInfoForm.ProductInfoFormOpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            // Change forms only if the user click OK in the ProductInfoFormOpenFileDialog
            if (Program.productInfoForm.ProductInfoFormOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                loadFromFile = true;
                this.Hide();
                Program.productInfoForm.Show();
            }
        }
    }
}
