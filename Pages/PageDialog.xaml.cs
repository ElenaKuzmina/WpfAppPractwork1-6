using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
            OpenFileDialog ofd = new OpenFileDialog(); //диалог.окно открытия файла
            //ofd.DefaultExt = "*.psw";
            ofd.Filter = "(*.txt)|*.txt";
            ofd.InitialDirectory = "H:\\";
           if  (ofd.ShowDialog() == false)
                return;
               
            // получаем выбранный файл
            string filename = ofd.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);

            LstText.Items.Add($"Содержимое файла {filename}");
            LstText.Items.Add($"{fileText}");

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "(*.txt)|*.txt";
            //sfd.InitialDirectory = ;
            if (sfd.ShowDialog() == false)
            {
                return;
            }
            string fileName = sfd.FileName;
            string content = LstText.SelectedValue.ToString();
            System.IO.File.WriteAllText(fileName, $"МДК01.01 Диалоговые окна {content}");

        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
                printDialog.PrintVisual(PageDlg, "Печать из списка");

        }

        private void btnFont_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnColor_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
