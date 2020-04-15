using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace _1001_Docus__Desktop
{
    /// <summary>
    /// Interaction logic for Menu3.xaml
    /// </summary>
    public partial class Menu3 : Window
    {
        public Menu3()
        {
            InitializeComponent();
            Owner = Application.Current.MainWindow;
        }

        private void sd2_Click(object sender, RoutedEventArgs e)
        {
            try { Process.Start("vlc.exe", "https://livedoc.cgtn.com/1000d/prog_index.m3u8"); }
            catch(Exception) { MessageBox.Show("Error..check if:" + Environment.NewLine + "* VLC is installed." + Environment.NewLine + "* Windows/Antivirus blocked the access.", "Oups!", MessageBoxButton.OK, MessageBoxImage.Error); }
        }
    }
}
