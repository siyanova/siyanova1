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

namespace siyanova1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool regis = false;
        bool shift = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void Start_button_Click_1(object sender, RoutedEventArgs e)
        {
            Start_button.IsEnabled = false;
            Stop_button.IsEnabled = true;

            output.Focusable = true;
            output.Focus();
            
        }

        private void Stop_button_Click(object sender, RoutedEventArgs e)
        {
            Start_button.IsEnabled = true;
            Stop_button.IsEnabled = false;
            output.Focusable = false;
        }
        private void output_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.E) 
            {
                BorderE.Background = new SolidColorBrush(Colors.White);
                output.Text += TextE.Text;
            }
            else if (e.Key == Key.R)
            {
                BorderR.Background = new SolidColorBrush(Colors.White);
                output.Text += TextR.Text;
            }
            else if (e.Key == Key.D)
            {
                BorderD.Background = new SolidColorBrush(Colors.White);
                output.Text += TextD.Text;
            }
            else if (e.Key == Key.F)
            {
                BorderF.Background = new SolidColorBrush(Colors.White);
                output.Text += TextF.Text;
            }
            if (e.Key == Key.CapsLock) {
                if (regis == false)
                {
                    TextE.Text = TextE.Text.ToUpper();
                    TextR.Text = TextR.Text.ToUpper();
                    TextD.Text = TextD.Text.ToUpper();
                    TextF.Text = TextF.Text.ToUpper();
                    regis = true;
                }
                else {
                    TextE.Text = TextE.Text.ToLower();
                    TextR.Text = TextR.Text.ToLower();
                    TextD.Text = TextD.Text.ToLower();
                    TextF.Text = TextF.Text.ToLower();
                    regis = false;
                }
            }
            if (e.Key == Key.LeftShift)
            {
                TextE.Text = TextE.Text.ToUpper();
                TextR.Text = TextR.Text.ToUpper();
                TextD.Text = TextD.Text.ToUpper();
                TextF.Text = TextF.Text.ToUpper();
                shift = true;
            }
        }
        private void output_KeyUp(object sender, KeyEventArgs e) {
            if (e.Key == Key.E) {
                BorderE.Background = new SolidColorBrush(Colors.LightYellow);
            }
            else if (e.Key == Key.R)
            {
                BorderR.Background = new SolidColorBrush(Colors.LightCoral); ;
            }
            else if (e.Key == Key.D)
            {
                BorderD.Background = new SolidColorBrush(Colors.LightSalmon);
            }
            else if (e.Key == Key.F)
            {
                BorderF.Background = new SolidColorBrush(Colors.LightGreen);
            }
            if (e.Key == Key.LeftShift) {
                TextE.Text = TextE.Text.ToLower();
                TextR.Text = TextR.Text.ToLower();
                TextD.Text = TextD.Text.ToLower();
                TextF.Text = TextF.Text.ToLower();
                shift = false;
            }
        }
    }
}
