using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;
using Microsoft.Win32;
using Timer = System.Timers.Timer;

namespace Color_change
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private System.Timers. Timer _timer;
        public MainWindow()
        {
            InitializeComponent();
            _timer = new Timer(50);
        }

        private void _timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            this.Dispatcher.Invoke(() =>
            {
                Brush x1 = r0c0.Background;
                Brush x2 = r0c1.Background;
                Brush x3 = r0c2.Background;

                Brush y1 = r1c0.Background;
                Brush y2 = r1c1.Background;
                Brush y3 = r1c2.Background;

                Brush z1 = r2c0.Background;
                Brush z2 = r2c1.Background;
                Brush z3 = r2c2.Background;

                r0c1.Background = x1;
                r0c2.Background = x2;

                r1c2.Background = x3;
                r2c2.Background = y3;
                r2c1.Background = z3;

                r2c0.Background = z2;
                r1c0.Background = z1;
                r0c0.Background = y1;
            });
        }

        private void Windowld(object sender, RoutedEventArgs e)
        {
            _timer.Elapsed += _timer_Elapsed;
            _timer.Start();
        }


    }
}
