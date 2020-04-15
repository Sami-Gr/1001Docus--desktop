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
    /// Interaction logic for Menu2.xaml
    /// </summary>
    public partial class Menu2 : Window
    {
        public Menu2()
        {
            InitializeComponent();
            Owner = Application.Current.MainWindow;
        }

        private void hdd_Click(object sender, RoutedEventArgs e)
        {
            try{ Process.Start("vlc.exe", "http://livecdnh3.tvanywhere.ae/hls/docubox/04.m3u8"); }
            catch(Exception) { MessageBox.Show("Error..check if:" + Environment.NewLine + "* VLC is installed." + Environment.NewLine + "* Windows/Antivirus blocked the access.", "Oups!", MessageBoxButton.OK, MessageBoxImage.Error); }
        }

        private void sdd_Click(object sender, RoutedEventArgs e)
        {
            try { Process.Start("vlc.exe", "http://livecdnh3.tvanywhere.ae/hls/docubox/03.m3u8"); }
            catch(Exception) { MessageBox.Show("Error..check if:" + Environment.NewLine + "* VLC is installed." + Environment.NewLine + "* Windows/Antivirus blocked the access.", "Oups!", MessageBoxButton.OK, MessageBoxImage.Error); }
        }

        private void mdd_Click(object sender, RoutedEventArgs e)
        {
            try { Process.Start("vlc.exe", "http://livecdnh3.tvanywhere.ae/hls/docubox/02.m3u8"); }
            catch(Exception) { MessageBox.Show("Error..check if:" + Environment.NewLine + "* VLC is installed." + Environment.NewLine + "* Windows/Antivirus blocked the access.", "Oups!", MessageBoxButton.OK, MessageBoxImage.Error); }
        }

        private void ld2_Click(object sender, RoutedEventArgs e)
        {
            try { Process.Start("vlc.exe", "http://livecdnh3.tvanywhere.ae/hls/docubox/01.m3u8"); }
            catch(Exception) { MessageBox.Show("Error..check if:" + Environment.NewLine + "* VLC is installed." + Environment.NewLine + "* Windows/Antivirus blocked the access.", "Oups!", MessageBoxButton.OK, MessageBoxImage.Error); }
        }
    }
}
