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

namespace PaternExamNew
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        private Package _package { get; set; }
        public MainPage(Package package)
        {
            InitializeComponent();
            _package = package;
        }
        public MainPage(Package package, MyFile file)
        {
            InitializeComponent();
            _package = package;
            _package.FileManager.CreateFile(file);
        }

        private void CreateButtonClick(object sender, RoutedEventArgs e)
        {
            _package.Window.Content = new CreatePage(_package);
        }

        private void OpenButtonClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == false)
                return;
            string filename = openFileDialog1.FileName;
            string[] names = filename.Split(new char[] { '.' });
            TextRange doc = new TextRange(mainText.Document.ContentStart, mainText.Document.ContentEnd);
            MyFile file = _package.FileManager.OpenFile(filename, names[1], doc);

            fileListBox.Items.Add(file.FileName);
        }

        private void SaveButtonClick(object sender, RoutedEventArgs e)
        {
            _package.FileManager.SaveFile();
        }

        private void SaveNewNameButtonClick(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == false)
                return;
            string filename = saveFileDialog1.FileName;
            _package.FileManager.SaveNewNameFile(filename);
            MessageBox.Show("Файл сохранен");
        }

        private void PrintButtonClick(object sender, RoutedEventArgs e)
        {
            _package.FileManager.PrintFile();
        }

        private void CloseButtonClick(object sender, RoutedEventArgs e)
        {
            _package.FileManager.CloseFile();
        }
    }
}
