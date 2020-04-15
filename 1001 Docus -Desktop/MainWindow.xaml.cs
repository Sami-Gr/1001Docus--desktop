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

namespace _1001_Docus__Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int ch;

        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void natar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ch = 1;
            Menu mm = new Menu();
            mm.ShowDialog();
        }               

        private void wild_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ch = 2;
            Menu mm = new Menu();
            mm.ShowDialog();
        }

        private void ppl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ch = 3;
            Menu mm = new Menu();
            mm.ShowDialog();
        }

        private void natgeo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ch = 4;
            Menu mm = new Menu();
            mm.ShowDialog();
        }

        private void doc_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ch = 5;
            Menu2 mm = new Menu2();
            mm.ShowDialog();
        }

        private void cgtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ch = 6;
            Menu3 mm = new Menu3();
            mm.ShowDialog();
        }

        private void his_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ch = 7;
            Menu mm = new Menu();
            mm.ShowDialog();
        }

        private void arte_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ch = 8;
            Menu mm = new Menu();
            mm.ShowDialog();
        }

        private void artede_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ch = 9;
            Menu mm = new Menu();
            mm.ShowDialog();
        }

        
    }
}
