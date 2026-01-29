using Avalonia.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaApplication5
{
    public class WindowService
    {
        private MainWindow _currentWindow;
        private readonly Dictionary<string, MainWindow> _windows = new();

        public void RegisterWindow(string key, MainWindow window)
        {
            _windows[key] = window;
        }

        public void SwitchToWindow(string key)
        {
            if (_currentWindow != null)
            {
                _currentWindow.Hide();
            }

            if (_windows.TryGetValue(key, out var window))
            {
                window.Show();
                _currentWindow = window;
            }
        }
    }
}
