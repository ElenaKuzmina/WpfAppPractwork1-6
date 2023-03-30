using Microsoft.Win32;
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
    /// Логика взаимодействия для PageDialog.xaml
    /// </summary>
    public partial class PageDialog : Page
    {
        public PageDialog()
        {
            InitializeComponent();
        }

       
        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "*.psw";
            ofd.InitialDirectory = "D:\\";
           if  (ofd.ShowDialog() == false)
                return;
               
            // получаем выбранный файл
            string filename = ofd.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            
            MessageBox.Show($"Файл {filename} открыт. Пароль: {fileText}");

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
