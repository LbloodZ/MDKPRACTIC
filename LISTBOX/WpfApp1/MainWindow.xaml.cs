using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lstbox.Items.Add(edits.Text);
            edits.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lstbox.Items.Remove(lstbox.SelectedItem);
        }

        private void RemoveAt(object sender, RoutedEventArgs e)
        {
            lstbox.Items.RemoveAt(Convert.ToInt32(edits_1.Text));
        }

        private void Insert(object sender, RoutedEventArgs e)
        {
            lstbox.Items.Insert(Convert.ToInt32(edits_2.Text), edits_3.Text);
        }
    }
}
