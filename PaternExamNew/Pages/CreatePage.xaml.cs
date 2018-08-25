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
    /// Логика взаимодействия для CreatePage.xaml
    /// </summary>
    public partial class CreatePage : Page
    {
        private Package _package;
        private MyFile _file;
        public CreatePage(Package package)
        {
            InitializeComponent();
            _package = package;
            _file = new MyFile();
        }

        private void CreateButtonClick(object sender, RoutedEventArgs e)
        {
            _file.FileName = fileNameTextBox.Text;
            _file.FilePath = filePathTextBox.Text;
            _file.Extension = extensionTextBox.Text;

            _package.Window.Content = new MainPage(_package, _file);
        }
    }
}
