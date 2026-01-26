using Avalonia.Controls;
using System;
using System.Runtime.CompilerServices;

namespace AvaloniaApplication5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public int x = 0;
        public int x2 = 0;
        public int x1 = 1;
        public string? y;


        private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            x += x1;
            gog.Text = $"{x}";
        }

        private void g_TextChanged(object? sender, TextChangedEventArgs e)
        {
            y = g.Text;
            if (y == "beluga")
            {
                x1 = 100;
            }
            else if (y == "67")
            {
                x1 = Convert.ToInt32(y);
            }
            else
            {
                x1 = 1;
            }
        }

        private void CheckBox_IsCheckedChanged(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (sas.IsChecked == true)
            {
                if (x2 == 0)
                {
                    x1 *= 5;
                    x2 = 1;
                }

            }
            else
            {
                sas.IsChecked = true;
                sas.IsEnabled = true;
            }
        }
    }
}