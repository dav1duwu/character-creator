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
using System.Windows.Shapes;

namespace chara_crt
{
    /// <summary>
    /// Interakční logika pro Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private bool dark_mode = false;     
        public Window1(bool _dark_mode)
        {            
            InitializeComponent();                        
            dark_mode = _dark_mode;

            cbx_class.Items.Add("člověk");
            cbx_class.Items.Add("bestie");

            cbx_class.SelectedIndex = 0;

            if(dark_mode == true)
            {
                this.Background = Brushes.Black;

                lol.Foreground = Brushes.White;
                lol.Background = Brushes.Black;

                lul.Foreground = Brushes.White;
                lul.Background = Brushes.Black;

                lal.Foreground = Brushes.White;
                lal.Background = Brushes.Black;
            }
        }
        private void btn_class_mec_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btn_class_luk_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btn_class_hul_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btn_class_horda_Click(object sender, RoutedEventArgs e)
        {
            border_color.BorderBrush = new SolidColorBrush(Colors.Red);
        }
        private void btn_class_aliance_Click(object sender, RoutedEventArgs e)
        {
            border_color.BorderBrush = new SolidColorBrush(Colors.Cyan);
        }
        private void btn_save_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
