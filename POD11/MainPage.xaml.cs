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
using System.Drawing;

namespace POD11
{
    /// <summary>
    /// Logika interakcji dla klasy MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        Wiz wiz;

        public MainPage()
        {
            InitializeComponent();
        }

        private void open_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
                dlg.DefaultExt = ".bmp";
                dlg.ShowDialog();
                string path = dlg.FileName;
                input.Source = new ImageSourceConverter().ConvertFromString(path) as ImageSource;
                wiz = new Wiz(path);
            }
            catch
            {
               MessageBox.Show("       Error");
            }
        }

        private void dokumentation_Click(object sender, RoutedEventArgs e)
        {
            Documentation dok = new Documentation();
            this.NavigationService.Navigate(dok);
        }

        private void encrypt_Click(object sender, RoutedEventArgs e)
        {
            wiz.encrypt();
            part1.Source = new ImageSourceConverter().ConvertFromString(wiz.getPathPart1()) as ImageSource;
            part2.Source = new ImageSourceConverter().ConvertFromString(wiz.getPathPart2()) as ImageSource;
            MessageBox.Show("       Done");
        }

        private void decrypt_Click(object sender, RoutedEventArgs e)
        {
            wiz.decrypt();
            output.Source = new ImageSourceConverter().ConvertFromString(wiz.getPathOutput()) as ImageSource;
            MessageBox.Show("       Done");
        }
    }
}
