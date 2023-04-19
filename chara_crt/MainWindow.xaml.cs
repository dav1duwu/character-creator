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
using System.Xml.Serialization;
using System.IO;

namespace chara_crt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool _dark_mode = false;
        public bool _light_mode = true;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void btn_tma_Click(object sender, RoutedEventArgs e)
        {
            if (this.Background == Brushes.White)
            {
                this.Background = Brushes.Black;
            }
            uwu.Foreground = Brushes.White;
            uwu.Background = Brushes.Black;

            _dark_mode = true;
        }
        private void btn_crt_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1(_dark_mode);
            window1.Show();            
        }
        private void btn_sv_Click(object sender, RoutedEventArgs e)
        {
            if (this.Background == Brushes.Black)
            {
                this.Background = Brushes.White;
            }
            uwu.Foreground = Brushes.Black;
            uwu.Background = Brushes.White;

            _ = false;
        }
        private void btn_load_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2(_dark_mode);
            window2.Show();
        }
    }
}
