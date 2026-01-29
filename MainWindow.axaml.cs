using Avalonia.Controls;
using System;
using System.ComponentModel.Design;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace AvaloniaApplication5
{
    public partial class MainWindow : Window
    {

        public void saver()
        {
            if (s1 == 0)
            {

                try
                {
                    daw = System.IO.File.ReadAllText("sekret1.txt");
                }
                catch
                {
                    System.IO.File.WriteAllText("sekret1.txt", $"{x}");
                }

                x = Convert.ToInt32(daw);

                s1 += 1;
            }
            
            
            
            
            if (obo1 == true)
            {
                oboval1 = 0;
                ob1.Content = "выбрать";
            }
            if (obo2 == true)
            {
                oboval2 = 0;
                ob2.Content = "выбрать";
            }
            if (obo3 == true)
            {
                oboval3 = 0;
                ob3.Content = "выбрать";
            }
        }
        public void o1()
        {
            try
            {
                daw3 = System.IO.File.ReadAllText("obo1.txt");
                obo1 = true;
            }
            catch 
            {
                daw3 = "1";
            }
        }
        public void o2()
        {
            try
            {
                daw3 = System.IO.File.ReadAllText("obo2.txt");
                obo2 = true;
            }
            catch 
            {
                daw3 = "1";
            }
        }
        public void o3()
        {
            try
            {
                daw3 = System.IO.File.ReadAllText("obo3.txt");
                obo3 = true;
            }
            catch 
            {
                daw3 = "1";
            }
        }
        public MainWindow()
        {

            InitializeComponent();
            o1();
            o2();
            o3();
            saver();
            gog.Text = $"{x}";
        }
        public string daw;
        public string daw1;
        public string daw3;
        public bool obo0;
        public bool obo1;
        public bool obo2;
        public bool obo3;
        public int oboval1 = 5000;
        public int oboval2 = 5000;
        public int oboval3 = 5000;

        public int x = 0;
        public int s1 = 0;
        public int s2 = 0;
        public int x3;
        public int x2 = 0;
        public int x1 = 1;
        public string? y;


        private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            x += x1;
            gog.Text = $"{x}";
            System.IO.File.WriteAllText("sekret1.txt", $"{x}");
        }

        private void g_TextChanged(object? sender, TextChangedEventArgs e)
        {
            y = g.Text;
            if (y == "beluga")
            {
                x1 += 100;
                x3 = 100;
            }
            else if (y == "67")
            {
                x1 += Convert.ToInt32(y);
                x3 = Convert.ToInt32(y);
            }
            else
            {
                x1 -= x3;
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

        private void Button_Click_1(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            mag1.IsVisible = true;


        }

        private void Button_Click_2(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            mag1.IsVisible = false;
        }
        private void Oboi_click1(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (oboi1.IsVisible == false)
            {
                if (obo1 == true)
                {
                    oboval1 = 0;
                    ob1.Content = "выбрать";
                }
                
                if (x >= oboval1)
                {
                    x = x - oboval1;
                    obo1 = true;
                    oboi1.IsVisible = true;
                    oboi0.IsVisible = false;
                    oboi2.IsVisible = false;
                    oboi3.IsVisible = false;
                    gog.Text = $"{x}";
                    System.IO.File.WriteAllText("sekret1.txt", $"{x}");
                    System.IO.File.WriteAllText("obo1.txt", $"{x}");
                    ob1.Content = "выбрать";
                }
            }

        }

        private void Oboi_click2(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (oboi2.IsVisible == false)
            {
                if (obo2 == true)
                {
                    oboval2 = 0;
                    ob2.Content = "выбрать";
                }
                if (x >= oboval2)
                {
                    x = x - oboval2;
                    obo2 = true;
                    oboi1.IsVisible = false;
                    oboi0.IsVisible = false;
                    oboi2.IsVisible = true;
                    oboi3.IsVisible = false;
                    gog.Text = $"{x}";
                    System.IO.File.WriteAllText("sekret1.txt", $"{x}");
                    System.IO.File.WriteAllText("obo2.txt", $"{x}");
                    ob2.Content = "выбрать";
                }
            }
            
        }

        private void Oboi_click3(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (oboi3.IsVisible == false)
            {
                if (obo3 == true)
                {
                    oboval3 = 0;
                    ob3.Content = "выбрать";
                }
                if (x >= oboval3)
                {
                    x = x - oboval3;
                    obo3 = true;
                    oboi1.IsVisible = false;
                    oboi0.IsVisible = false;
                    oboi2.IsVisible = false; 
                    oboi3.IsVisible = true;
                    gog.Text = $"{x}";
                    System.IO.File.WriteAllText("sekret1.txt", $"{x}");
                    System.IO.File.WriteAllText("obo3.txt", $"{x}");
                    ob3.Content = "выбрать";
                }
            }
            
        }
    }
}