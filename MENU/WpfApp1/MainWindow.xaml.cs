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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            status.Items.Add("");
        }

        private void MenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            if (status.Items[0] == "")
            {
                status.Items[0] = "Выбор цвета фона";
            }
        }

        private void MenuItem_MouseLeave(object sender, MouseEventArgs e)
        {
            status.Items[0] = "";
        }

        private void MenuItem_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (status.Items[0] != "Выбрать красный цвет фона")
            {
                status.Items[0] = "Выбрать красный цвет фона";
            }
        }

        private void MenuItem_MouseLeave_1(object sender, MouseEventArgs e)
        {
            status.Items[0] = "";
        }

        private void MenuItem_MouseMove_2(object sender, MouseEventArgs e)
        {
            if (status.Items[0] != "Выбрать синий цвет фона")
            {
                status.Items[0] = "Выбрать синий цвет фона";
            }
        }

        private void MenuItem_MouseLeave_2(object sender, MouseEventArgs e)
        {
            status.Items[0] = "";
        }

        private void MenuItem_MouseMove_3(object sender, MouseEventArgs e)
        {
            if (status.Items[0] != "Выбрать желтый цвет фона")
            {
                status.Items[0] = "Выбрать желтый цвет фона";
            }
        }

        private void MenuItem_MouseLeave_3(object sender, MouseEventArgs e)
        {
            status.Items[0] = "";
        }

        private void MenuItem_MouseMove_4(object sender, MouseEventArgs e)
        {
            if (status.Items[0] != "Выбрать зеленый цвет фона")
            {
                status.Items[0] = "Выбрать зеленый цвет фона";
            }
        }

        private void MenuItem_MouseLeave_4(object sender, MouseEventArgs e)
        {
            status.Items[0] = "";
        }

        private void MenuItem_MouseMove_5(object sender, MouseEventArgs e)
        {
            if (status.Items[0] != "Информация о разработчике")
            {
                status.Items[0] = "Информация о разработчике";
            }
        }

        private void MenuItem_MouseLeave_5(object sender, MouseEventArgs e)
        {
            status.Items[0] = "";
        }

        private void MenuItem_MouseMove_6(object sender, MouseEventArgs e)
        {
            if (status.Items[0] == "")
            {
                status.Items[0] = "Управление программой";
            }
        }

        private void MenuItem_MouseLeave_6(object sender, MouseEventArgs e)
        {
            status.Items[0] = "";
        }

        private void MenuItem_MouseMove_7(object sender, MouseEventArgs e)
        {
            if (status.Items[0] == "")
            {
                status.Items[0] = "Закрыть программу";
            }
        }

        private void MenuItem_MouseLeave_7(object sender, MouseEventArgs e)
        {
            status.Items[0] = "";
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.Red;
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.Blue;
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.Yellow;
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.Green;
        }

        private void MenuItem_MouseMove_8(object sender, MouseEventArgs e)
        {
            if (status.Items[0] != "Выбрать белый цвет фона")
            {
                status.Items[0] = "Выбрать белый цвет фона";
            }
        }

        private void MenuItem_MouseLeave_8(object sender, MouseEventArgs e)
        {
            status.Items[0] = "";
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.White;
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Е.П.Зырянова", "Разработчик", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
