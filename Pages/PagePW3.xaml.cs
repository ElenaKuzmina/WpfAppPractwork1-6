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
    /// Логика взаимодействия для PagePW3.xaml
    /// </summary>
    public partial class PagePW3 : Page
    {
        public PagePW3()
        {
            InitializeComponent();
        }

        private void BtnSolve_Click(object sender, RoutedEventArgs e)
        {
            double x0 = Convert.ToDouble(TxtInputX0.Text);
            double xk = Convert.ToDouble(TxtInputXk.Text);
            double dx = Convert.ToDouble(TxtInputDx.Text);
            double a = Convert.ToDouble(TxtInputA.Text);
            LstResult.Items.Clear();
            LstResult.Items.Add("Практ.раб.№3, МДК.01.01, ст.гр.ИСП.21.1 Кузьминой Е.Е.");
            for(double x=x0; x<=xk; x+=dx) 
            {
                double y = a*Math.Log(x);
                LstResult.Items.Add($"x={Math.Round(x,2)} y = {Math.Round(y,3)}");
            }
            
        }
    }
}
