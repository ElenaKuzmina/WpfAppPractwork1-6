using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppPractwork1.Pages
{
    /// <summary>
    /// Логика взаимодействия для PagePW1.xaml
    /// </summary>
    public partial class PagePW1 : Page
    {
        public PagePW1()
        {
            InitializeComponent();
        }

        private void BtnSolve_Click(object sender, RoutedEventArgs e)
        {
            //double x = Convert.ToDouble(TxtInputX.Text);
            double y = Convert.ToDouble(TxtInputY.Text);
            double z = Convert.ToDouble(TxtInputZ.Text);
            double x;
            if (double.TryParse(TxtInputX.Text, out x) != true)
                     {
                MessageBox.Show("Error Input");
                TxtInputX.Text = string.Empty;
                TxtInputX.Focus();
                return;
            }

            try
            {
            
                double u = Math.Sqrt(x + y);
              //double u = Math.Pow(Math.Tan(x+y), 2) - Math.Exp(y-z)*Math.Sqrt(Math.Cos(x*x) + Math.Sin(z*z));
            LstResult.Items.Clear();
            LstResult.Items.Add("Практ.раб.№1, МДК.01.01, ст.гр.ИСП.21.1 Кузьминой Е.Е.");
            LstResult.Items.Add($"x = {x}");
            LstResult.Items.Add($"y = {y}");
            LstResult.Items.Add($"z = {z}");
            LstResult.Items.Add($"Результат u = {u}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Проверьте ввод исходных данных: {ex.Message}");
            }
            
           
        }
    }
}
