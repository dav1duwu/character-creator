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
using System.Xml.Serialization;
using System.IO;

namespace chara_crt
{
    public partial class Window1 : Window
    {
        private bool dark_mode = false;

        private int _zbran = 1; // 1 = meč , 2 = luk, 3 = hůl
        private int _rasa = 1; // 1 = člověk, 2 = kočkoholka, 3 = beast
        private int _frakce = 1; //1 = aliance, 2 = horda

        private int obr_hrac = 1;        

        public Window1(bool _dark_mode)
        {            
            InitializeComponent();
            dark_mode = _dark_mode;

            cbx_class.Items.Add("člověk");
            cbx_class.Items.Add("kočkoholka");
            cbx_class.Items.Add("tombeast");

            cbx_class.SelectedIndex = 0;

            /*data_to_save data = new data_to_save();
            {
                _zbran = data.Zbran;
                _rasa = data.Rasa;
                _frakce = data.Frakce;
                obr_hrac = data.ObrHrac;
                txt_input.Text = data.Meno;
            }*/

            if (dark_mode == true)
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
        private void cbx_class_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbx_class.SelectedIndex == 0 && _zbran == 1)
            {
                obr_hrac = 1;
                player.Source = new BitmapImage(new Uri($"imgs/img{obr_hrac}.png", UriKind.Relative));
            }
            else if (cbx_class.SelectedIndex == 0 && _zbran == 2)
            {
                obr_hrac = 2;
                player.Source = new BitmapImage(new Uri($"imgs/img{obr_hrac}.png", UriKind.Relative));
            }
            else if (cbx_class.SelectedIndex == 0 && _zbran == 3)
            {
                obr_hrac = 3;
                player.Source = new BitmapImage(new Uri($"imgs/img{obr_hrac}.png", UriKind.Relative));
            }
            else if (cbx_class.SelectedIndex == 1 && _zbran == 1)
            {
                obr_hrac = 4;
                player.Source = new BitmapImage(new Uri($"imgs/img{obr_hrac}.png", UriKind.Relative));
            }
            else if (cbx_class.SelectedIndex == 1 && _zbran == 2)
            {
                obr_hrac = 5;
                player.Source = new BitmapImage(new Uri($"imgs/img{obr_hrac}.png", UriKind.Relative));
            }
            else if (cbx_class.SelectedIndex == 1 && _zbran == 3)
            {
                obr_hrac = 6;
                player.Source = new BitmapImage(new Uri($"imgs/img{obr_hrac}.png", UriKind.Relative));
            }
            else if (cbx_class.SelectedIndex == 2 && _zbran == 1)
            {
                obr_hrac = 7;
                player.Source = new BitmapImage(new Uri($"imgs/img{obr_hrac}.png", UriKind.Relative));
            }
            else if (cbx_class.SelectedIndex == 2 && _zbran == 2)
            {
                obr_hrac = 8;
                player.Source = new BitmapImage(new Uri($"imgs/img{obr_hrac}.png", UriKind.Relative));
            }
            else
            {
                obr_hrac = 9;
                player.Source = new BitmapImage(new Uri($"imgs/img{obr_hrac}.png", UriKind.Relative));
            }
        }
        private void btn_class_mec_Click(object sender, RoutedEventArgs e)
        {
            _zbran = 1;
            if (cbx_class.SelectedIndex == 0 && _zbran == 1)
            {
                obr_hrac = 1;
                player.Source = new BitmapImage(new Uri($"imgs/img{obr_hrac}.png", UriKind.Relative));

            }
            else if (cbx_class.SelectedIndex == 1 && _zbran == 1)
            {
                obr_hrac = 4;
                player.Source = new BitmapImage(new Uri($"imgs/img{obr_hrac}.png", UriKind.Relative));
            }
            else
            {
                obr_hrac = 7;
                player.Source = new BitmapImage(new Uri($"imgs/img{obr_hrac}.png", UriKind.Relative));
            }

        }
        private void btn_class_luk_Click(object sender, RoutedEventArgs e)
        {
            _zbran = 2;
            if (cbx_class.SelectedIndex == 0 && _zbran == 2)
            {
                obr_hrac = 2;
                player.Source = new BitmapImage(new Uri($"imgs/img{obr_hrac}.png", UriKind.Relative));
            }
            else if (cbx_class.SelectedIndex == 1 && _zbran == 2)
            {
                obr_hrac = 5;
                player.Source = new BitmapImage(new Uri($"imgs/img{obr_hrac}.png", UriKind.Relative));
            }
            else
            {
                obr_hrac = 8;
                player.Source = new BitmapImage(new Uri($"imgs/img{obr_hrac}.png", UriKind.Relative));
            }
        }
        private void btn_class_hul_Click(object sender, RoutedEventArgs e)
        {
            _zbran = 3;
            if (cbx_class.SelectedIndex == 0 && _zbran == 3)
            {
                obr_hrac = 3;
                player.Source = new BitmapImage(new Uri($"imgs/img{obr_hrac}.png", UriKind.Relative));
            }
            else if (cbx_class.SelectedIndex == 1 && _zbran == 3)
            {
                obr_hrac = 6;
                player.Source = new BitmapImage(new Uri($"imgs/img{obr_hrac}.png", UriKind.Relative));
            }
            else
            {
                obr_hrac = 9;
                player.Source = new BitmapImage(new Uri($"imgs/img{obr_hrac}.png", UriKind.Relative));
            }
        }
        private void btn_class_horda_Click(object sender, RoutedEventArgs e)
        {
            border_color.BorderBrush = new SolidColorBrush(Colors.Red);

            _frakce = 2;
        }
        private void btn_class_aliance_Click(object sender, RoutedEventArgs e)
        {
            border_color.BorderBrush = new SolidColorBrush(Colors.Cyan);

            _frakce = 1;
        }
        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32.SaveFileDialog();
            dialog.DefaultExt = ".xml";
            dialog.Filter = "XML documents (.xml)|*.xml";

            Nullable<bool> result = dialog.ShowDialog();

            data_to_save data = new data_to_save
            {
                Meno = txt_input.Text.ToString(),
                Rasa = cbx_class.SelectedIndex,
                Zbran = _zbran,
                Frakce = _frakce,
                ObrHrac = obr_hrac,
            };

            if (result == true)
            {                
                XmlSerializer serializer = new XmlSerializer(typeof(data_to_save));
                using (TextWriter writer = new StreamWriter(dialog.FileName))
                {
                    serializer.Serialize(writer, data);
                }
            }
        }        
    }
}