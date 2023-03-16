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
using System.IO;

namespace WpfAppPractwork1.Pages
{
    /// <summary>
    /// Логика взаимодействия для PagePW6.xaml
    /// </summary>
    public partial class PagePW6 : Page
    {
        public PagePW6()
        {
            InitializeComponent();
        }

        private void btnListFromFile_Click(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader(@"Lines.txt", Encoding.UTF8);

            while (!sr.EndOfStream) 
            {
                lstInput.Items.Add(sr.ReadLine());
            }
            sr.Close();
        }

        private void btnRezult_Click(object sender, RoutedEventArgs e)
        {
            int index = lstInput.SelectedIndex;
            string line = lstInput.SelectedItem.ToString();
            string[] reverseLine = line.Split();
            txbRezult.Text = String.Join(' ', reverseLine.Reverse());

            StreamWriter sw = new StreamWriter(@"Rezult.txt");
            sw.WriteLine($"Номер строки: {index}");
            sw.WriteLine($"Исходная строка: {line}");
            sw.WriteLine($"Новая срока: {txbRezult.Text}");
            sw.Close();

        }
    }
}
