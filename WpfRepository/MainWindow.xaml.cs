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

namespace WpfRepository
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

        private void addBtn_MouseEnter(object sender, RoutedEventArgs e)
        {
            popup.IsOpen = true;
        }

        private void addBtn_MouseLeave(object sender, RoutedEventArgs e)
        {
            popup.IsOpen = false;
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            StackPanel stackPnl = new StackPanel();
            stackPnl = fullNoAlc;
            RadioButton radBtn = new RadioButton();
            stackPnl.Children.Add(radBtn);
            //Пытался сделать по нажатию добавлять кнопку в конкретный стек не вышло пока что
            
        }
    }
}
