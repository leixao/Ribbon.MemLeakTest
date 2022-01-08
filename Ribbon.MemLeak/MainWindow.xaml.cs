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

namespace Ribbon.MemLeak
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void CreateMemoryLeakWindow(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 25; ++i)
            {
                var wnd = new MemoryLeakWindow();
                wnd.Show();
                await Task.Delay(100);
            }
        }

        private async void CreateNormalWindow(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 25; ++i)
            {
                var wnd = new NormalWindow();
                wnd.Show();
                await Task.Delay(100);
            }
        }

        private async void CreateNormal1Window(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 25; ++i)
            {
                var wnd = new Normal1Window();
                wnd.Show();
                await Task.Delay(100);
            }
        }

        private async void CreateNormal2Window(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 25; ++i)
            {
                var wnd = new MemoryLeakWindow { ClearCommand = true };
                wnd.Show();
                await Task.Delay(100);
            }
        }

        private void GCCollect(object sender, RoutedEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
