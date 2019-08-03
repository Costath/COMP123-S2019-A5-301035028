using COMP123_S2019_A5_301035028.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_A5_301035028
{
    static class Program
    {
        public static OrderForm orderForm;
        public static SelectForm selectForm;
        public static StartForm startForm;
        public static ProductInfoForm productInfoForm;
        public static SplashForm splashForm;
        public static AboutBox aboutBox;
        ///// db instance
        //public static Product product;
        ///// 

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            splashForm = new SplashForm();
            startForm = new StartForm();
            orderForm = new OrderForm();
            selectForm = new SelectForm();
            productInfoForm = new ProductInfoForm();
            
            aboutBox = new AboutBox();
            //product = new Product();

            Application.Run(splashForm);
        }
    }
}
