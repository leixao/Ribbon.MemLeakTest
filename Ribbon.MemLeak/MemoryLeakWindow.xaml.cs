using Fluent;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Ribbon.MemLeak
{
    public partial class MemoryLeakWindow : RibbonWindow
    {
        public MemoryLeakWindow()
        {
            InitializeComponent();
        }

        public bool ClearCommand { get; set; } = false;

        private void RibbonWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Dispatcher.InvokeAsync(Close, System.Windows.Threading.DispatcherPriority.Background);
        }

        private void RibbonWindow_Closed(object sender, EventArgs e)
        {
            if (ClearCommand)
            { 
                Btn.Command = null;
            }
        }
    }
}
