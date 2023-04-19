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
    /// <summary>
    /// Interakční logika pro Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {        
        private bool dark_mode = false;
        public Window2(bool _dark_mode)
        {
            dark_mode = _dark_mode;
            InitializeComponent();
            border_color.Visibility = Visibility.Hidden;
            if (dark_mode == true)
            {
                this.Background = Brushes.Black;

                final_lbl.Foreground = Brushes.White;
                final_lbl.Background = Brushes.Black;               
            }
            
        }
        private void btn_load_Click(object sender, RoutedEventArgs e)
        {            
            var dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.DefaultExt = ".xml";
            dialog.Filter = "XML documents (.xml)|*.xml";

            Nullable<bool> result = dialog.ShowDialog();

            if (result == true)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(data_to_save));
                using (TextReader reader = new StreamReader(dialog.FileName))
                {
                    border_color.Visibility = Visibility.Visible;
                    data_to_save data = (data_to_save)serializer.Deserialize(reader);
                    
                    final_lbl.Content = data.Meno;           
                    
                    if(data.Frakce == 1)
                    {
                        border_color.BorderBrush = new SolidColorBrush(Colors.Cyan);
                    }
                    else
                    {
                        border_color.BorderBrush = new SolidColorBrush(Colors.Red);
                    }
                    final_image.Source = new BitmapImage(new Uri($"imgs/img{data.ObrHrac}.png", UriKind.Relative));
                }
            }
        }
    }
}
