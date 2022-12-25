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
using System.IO;

namespace First
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
            Mw.Background = new SolidColorBrush(Colors.Green);
        }
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Mw.Background = new SolidColorBrush(Colors.Purple);
        }
        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Mw.Background = new SolidColorBrush(Colors.Yellow);
        }
        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Mw.Background = new SolidColorBrush(Colors.Red);
        }
        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            Mw.Background = new SolidColorBrush(Colors.Pink);
        }
        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Черноморцев Марк ПР-31","О нас");
        }
        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            Mw.Close();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Черноморцев Марк ПР-31", "О нас");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Mw.Close();
        }

        private void Green(object sender, RoutedEventArgs e)
        {
            Mw.Background = new SolidColorBrush(Colors.Green);
        }

        private void Purple(object sender, RoutedEventArgs e)
        {
            Mw.Background = new SolidColorBrush(Colors.Purple);
        }

        private void Yellow(object sender, RoutedEventArgs e)
        {
            Mw.Background = new SolidColorBrush(Colors.Yellow);
        }

        private void Red(object sender, RoutedEventArgs e)
        {
            Mw.Background = new SolidColorBrush(Colors.Red);
        }

        private void Pink(object sender, RoutedEventArgs e)
        {
            Mw.Background = new SolidColorBrush(Colors.Pink);
        }

        private void About(object sender, MouseEventArgs e)
        {
            statusbar.Text = "О нас";

        }

        private void Close(object sender, MouseEventArgs e)
        {
            statusbar.Text = "Закрыть";
        }

        private void StatusBar_MouseEnter(object sender, MouseEventArgs e)
        {
            statusbar.Text = "Строка состояния";
        }

        private void StatusBar_MouseLeave(object sender, MouseEventArgs e)
        {
            statusbar.Text = "";
        }

        private void ChangeColor(object sender, MouseEventArgs e)
        {
            statusbar.Text = "Изменить цвет";
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            statusbar.Text = "Зелёный";
        }

        private void Button_MouseEnter_1(object sender, MouseEventArgs e)
        {
            statusbar.Text = "Фиолетовый";
        }

        private void Button_MouseEnter_2(object sender, MouseEventArgs e)
        {
            statusbar.Text = "Жёлтый";
        }

        private void Button_MouseEnter_3(object sender, MouseEventArgs e)
        {
            statusbar.Text = "Красный";
        }

        private void Button_MouseEnter_4(object sender, MouseEventArgs e)
        {
            statusbar.Text = "Розовый";
        }

        private void MenuItem_MouseEnter(object sender, MouseEventArgs e)
        {
            statusbar.Text = "Файл";
        }
    }
}
