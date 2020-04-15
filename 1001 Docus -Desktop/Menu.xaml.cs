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
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        int c = MainWindow.ch;

        public Menu()
        {
            InitializeComponent();
            Owner = Application.Current.MainWindow;
        }

        private void hd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (c)
                {
                    case 1:
                        Process.Start("vlc.exe", "http://livecdnh2.tvanywhere.ae/hls/nat_geo_auh/05.m3u8");
                        break;
                    case 2:
                        Process.Start("vlc.exe", "http://livecdnh1.tvanywhere.ae/hls/nat_geo_wild/05.m3u8");
                        break;
                    case 3:
                        Process.Start("vlc.exe", "http://livecdnh1.tvanywhere.ae/hls/nat_geo_people/05.m3u8");
                        break;
                    case 4:
                        Process.Start("vlc.exe", "http://livecdnh1.tvanywhere.ae/hls/nat_geo/05.m3u8");
                        break;
                    case 7:
                        Process.Start("vlc.exe", "http://livecdnh1.tvanywhere.ae/hls/h2/05.m3u8");
                        break;
                    case 8:
                        Process.Start("vlc.exe", "https://artelive-lh.akamaihd.net/i/artelive_fr@344805/index_1_av-p.m3u8?sd=10&rebase=on");
                        break;
                    case 9:
                        Process.Start("vlc.exe", "https://artelive-lh.akamaihd.net/i/artelive_de@393591/index_1_av-p.m3u8?sd=10&rebase=on");
                        break;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Error..check if:" +Environment.NewLine+ "* VLC is installed." +Environment.NewLine+ "* Windows/Antivirus blocked the access.","Oups!",MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void sd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (c)
                {
                    case 1:
                        Process.Start("vlc.exe", "http://livecdnh2.tvanywhere.ae/hls/nat_geo_auh/04.m3u8");
                        break;
                    case 2:
                        Process.Start("vlc.exe", "http://livecdnh1.tvanywhere.ae/hls/nat_geo_wild/04.m3u8");
                        break;
                    case 3:
                        Process.Start("vlc.exe", "http://livecdnh1.tvanywhere.ae/hls/nat_geo_people/04.m3u8");
                        break;
                    case 4:
                        Process.Start("vlc.exe", "http://livecdnh1.tvanywhere.ae/hls/nat_geo/04.m3u8");
                        break;
                    case 7:
                        Process.Start("vlc.exe", "http://livecdnh1.tvanywhere.ae/hls/h2/04.m3u8");
                        break;
                    case 8:
                        Process.Start("vlc.exe", "https://artelive-lh.akamaihd.net/i/artelive_fr@344805/index_2_av-p.m3u8?sd=10&rebase=on");
                        break;
                    case 9:
                        Process.Start("vlc.exe", "https://artelive-lh.akamaihd.net/i/artelive_de@393591/index_2_av-p.m3u8?sd=10&rebase=on");
                        break;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Error..check if:" + Environment.NewLine + "* VLC is installed." + Environment.NewLine + "* Windows/Antivirus blocked the access.", "Oups!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void md_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (c)
                {
                    case 1:
                        Process.Start("vlc.exe", "http://livecdnh2.tvanywhere.ae/hls/nat_geo_auh/03.m3u8");
                        break;
                    case 2:
                        Process.Start("vlc.exe", "http://livecdnh1.tvanywhere.ae/hls/nat_geo_wild/03.m3u8");
                        break;
                    case 3:
                        Process.Start("vlc.exe", "http://livecdnh1.tvanywhere.ae/hls/nat_geo_people/03.m3u8");
                        break;
                    case 4:
                        Process.Start("vlc.exe", "http://livecdnh1.tvanywhere.ae/hls/nat_geo/03.m3u8");
                        break;
                    case 7:
                        Process.Start("vlc.exe", "http://livecdnh1.tvanywhere.ae/hls/h2/03.m3u8");
                        break;
                    case 8:
                        Process.Start("vlc.exe", "https://artelive-lh.akamaihd.net/i/artelive_fr@344805/index_3_av-p.m3u8?sd=10&rebase=on");
                        break;
                    case 9:
                        Process.Start("vlc.exe", "https://artelive-lh.akamaihd.net/i/artelive_de@393591/index_3_av-p.m3u8?sd=10&rebase=on");
                        break;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Error..check if:" + Environment.NewLine + "* VLC is installed." + Environment.NewLine + "* Windows/Antivirus blocked the access.", "Oups!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ld_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (c)
                {
                    case 1:
                        Process.Start("vlc.exe", "http://livecdnh2.tvanywhere.ae/hls/nat_geo_auh/02.m3u8");
                        break;
                    case 2:
                        Process.Start("vlc.exe", "http://livecdnh1.tvanywhere.ae/hls/nat_geo_wild/02.m3u8");
                        break;
                    case 3:
                        Process.Start("vlc.exe", "http://livecdnh1.tvanywhere.ae/hls/nat_geo_people/02.m3u8");
                        break;
                    case 4:
                        Process.Start("vlc.exe", "http://livecdnh1.tvanywhere.ae/hls/nat_geo/02.m3u8");
                        break;
                    case 7:
                        Process.Start("vlc.exe", "http://livecdnh1.tvanywhere.ae/hls/h2/02.m3u8");
                        break;
                    case 8:
                        Process.Start("vlc.exe", "https://artelive-lh.akamaihd.net/i/artelive_fr@344805/index_4_av-p.m3u8?sd=10&rebase=on");
                        break;
                    case 9:
                        Process.Start("vlc.exe", "https://artelive-lh.akamaihd.net/i/artelive_de@393591/index_4_av-p.m3u8?sd=10&rebase=on");
                        break;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Error..check if:" + Environment.NewLine + "* VLC is installed." + Environment.NewLine + "* Windows/Antivirus blocked the access.", "Oups!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ldd_Click(object sender, RoutedEventArgs e)
        {
            try {
                switch (c)
                {
                    case 1:
                        Process.Start("vlc.exe", "http://livecdnh2.tvanywhere.ae/hls/nat_geo_auh/01.m3u8");
                        break;
                    case 2:
                        Process.Start("vlc.exe", "http://livecdnh1.tvanywhere.ae/hls/nat_geo_wild/01.m3u8");
                        break;
                    case 3:
                        Process.Start("vlc.exe", "http://livecdnh1.tvanywhere.ae/hls/nat_geo_people/01.m3u8");
                        break;
                    case 4:
                        Process.Start("vlc.exe", "http://livecdnh1.tvanywhere.ae/hls/nat_geo/01.m3u8");
                        break;
                    case 7:
                        Process.Start("vlc.exe", "http://livecdnh1.tvanywhere.ae/hls/h2/01.m3u8");
                        break;
                    case 8:
                        Process.Start("vlc.exe", "https://artelive-lh.akamaihd.net/i/artelive_fr@344805/index_5_av-p.m3u8?sd=10&rebase=on");
                        break;
                    case 9:
                        Process.Start("vlc.exe", "https://artelive-lh.akamaihd.net/i/artelive_de@393591/index_5_av-p.m3u8?sd=10&rebase=on");
                        break;
                }                
            }
            catch (Exception)
            {
                MessageBox.Show("Error..check if:" + Environment.NewLine + "* VLC is installed." + Environment.NewLine + "* Windows/Antivirus blocked the access.", "Oups!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }
    }
}
