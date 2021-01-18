//Wrote by Arezou Sohrabvand
using DollarComputers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers
{
    static class Program
    {
        public static AboutForm aboutForm { get; private set; }
        private static ProductInfoForm productInfoForm;
        private static Product product;
        private static OrderForm orderForm;
        private static SelectForm selectForm;
        private static SplashForm splashForm;
        public static Dollar dollar;

        public static object ProductInfoForm { get; internal set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            aboutForm = new AboutForm();
            product = new Product();
            orderForm = new OrderForm();
            selectForm = new SelectForm();
            splashForm = new SplashForm();
            productInfoForm = new ProductInfoForm();
            dollar = new Dollar();
            Application.Run(new SplashForm());
        }
    }
}
