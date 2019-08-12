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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartFormNextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.orderForm.Show();
        }

        private void StartFormPrevButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.productInfoForm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.selectForm.Show();
        }

        private void LoadOrderButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.ProductInfoFormOpenFileDialog.FileName = "";
            Program.productInfoForm.ProductInfoFormOpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (Program.productInfoForm.ProductInfoFormOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                Program.loadFromFile = true;
                this.Hide();
                Program.productInfoForm.Show();
            }
        }
    }
}
