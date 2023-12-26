using System;
using System.Collections.Generic;
using System.Data;
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


    public class DataList
    {
        public string name { get; }
        public string surname { get; }
        public string number { get; }

        public DataList(string n, string sr, string nm)
        {
            name = n;
            surname = sr;
            number = nm;
        }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public class MyTable
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Number { get; set; }

            public MyTable(string _name, string _surname, string _number)
            {
                this.Name = _name;
                this.Surname = _surname;
                this.Number = _number;
            }

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataList list = new DataList(name.Text, surname.Text, number.Text);
            dg.Items.Add(list);
            name.Clear();
            surname.Clear();
            number.Clear();
        }
    }
}
