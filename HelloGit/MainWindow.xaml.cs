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

namespace HelloGit
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += (o, a) => 
            {
                Console.WriteLine("this is loaded event");
            };
            Unloaded += (o, a) => 
            {
                Console.WriteLine("this is unloaded event");
            };
            ManipulationDelta += (o, a) => 
            {
                Console.WriteLine("manipulation delta event");
            };
            TouchDown += (o, a) => 
            {
                Console.WriteLine("touch down event");
            };
        }
    }
}
