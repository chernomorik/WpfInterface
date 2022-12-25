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

namespace FirstTwo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            dr.Color = Colors.Green;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            dr.Color = Colors.Purple;
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            dr.Color = Colors.Yellow;
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            dr.Color = Colors.Red;
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            dr.Color = Colors.Pink;
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            InkCanvas.EditingMode = InkCanvasEditingMode.Ink;
        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            InkCanvas.EditingMode = InkCanvasEditingMode.Select;
        }

        private void MenuItem_Click_8(object sender, RoutedEventArgs e)
        {
            InkCanvas.Strokes.Clear();
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            InkCanvas.EditingMode = InkCanvasEditingMode.EraseByPoint;
        }

        private void sl_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (null != sl && dr != null)
            {
                dr.Width = sl.Value; 
                dr.Height = sl.Value;
            }
        }

        private void MenuItem_Click_9(object sender, RoutedEventArgs e)
        {
            Mw.Close();
        }
    }
}
