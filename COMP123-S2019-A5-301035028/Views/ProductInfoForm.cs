using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_A5_301035028.Views
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void ProductInfoFormNextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.startForm.Show();

        }

        private void ProductInfoFormPrevButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.selectForm.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductInfoCancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
