using COMP123_S2019_A5_301035028.Models;
using COMP123_S2019_A5_301035028.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_A5_301035028
{
    public static class Program
    {
        //Forms declaration
        public static Product product;
        public static OrderForm orderForm;
        public static SelectForm selectForm;
        public static StartForm startForm;
        public static ProductInfoForm productInfoForm;
        public static SplashForm splashForm;
        public static AboutBox aboutBox;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            product = new Product();
            splashForm = new SplashForm();
            startForm = new StartForm();
            orderForm = new OrderForm();
            selectForm = new SelectForm();
            productInfoForm = new ProductInfoForm();
            aboutBox = new AboutBox();

            Application.Run(splashForm);
        }
    }
}
