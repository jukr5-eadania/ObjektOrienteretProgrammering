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

namespace ToDoList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RemoveBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            RemoveBtn.Foreground = new SolidColorBrush(Color.FromRgb(255, 0, 0));
        }

        private void RemoveBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            RemoveBtn.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
        }

        private void AddBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            AddBtn.Foreground = new SolidColorBrush(Color.FromRgb(0, 255, 0));
        }

        private void AddBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            AddBtn.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            string newtask = Input.Text;
            if (string.IsNullOrEmpty(newtask))
            {
                MessageBox.Show("Please input a task");
            }
            else
            {
                MessageBox.Show(newtask);
            }
        }
    }
}
