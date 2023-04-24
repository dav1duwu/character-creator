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
using System.Windows.Automation.Provider;

namespace chara_crt
{
    
    public partial class MainWindow : Window
    {        
        public bool _dark_mode = false;

        public static string _uwu = "0";

        static string cesta_souboru = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        static string cesta_ = cesta_souboru + "\\chara_crt";

        public MainWindow()
        {
            InitializeComponent();

            if(Directory.Exists(cesta_))
            {
                if (File.Exists(cesta_ + "\\settings.txt"))
                {
                    string obsah_souboru = File.ReadAllText(cesta_ + "\\settings.txt");
                    if (obsah_souboru.Contains("0"))
                    {                        
                        _dark_mode= false;
                        this.Background = Brushes.White;
                        uwu.Foreground = Brushes.Black;
                        uwu.Background = Brushes.White;
                    }
                    else
                    {
                        _dark_mode = true;
                        this.Background = Brushes.Black;
                        uwu.Foreground = Brushes.White;
                        uwu.Background = Brushes.Black;
                    }
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter(cesta_ + "\\settings.txt"))
                    {
                        writer.WriteLine(_uwu);
                    }
                }
            }
            else
            {               
                Directory.CreateDirectory(cesta_);
                File.Create("\\settings.txt");                
                File.WriteAllText(cesta_ + "\\settings.txt", _uwu);
            }
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
            _uwu = "1";
            using (StreamWriter writer = new StreamWriter(cesta_ + "\\settings.txt"))
            {
                writer.WriteLine(_uwu);
            }
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

            _dark_mode = false;
            _uwu = "0";
            using (StreamWriter writer = new StreamWriter(cesta_ + "\\settings.txt"))
            {
                writer.WriteLine(_uwu);
            }
        }
        private void btn_load_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2(_dark_mode);
            window2.Show();
        }
    }
}
