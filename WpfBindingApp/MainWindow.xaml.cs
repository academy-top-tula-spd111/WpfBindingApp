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

namespace WpfBindingApp
{
    public class User
    {
        public string? Name { set; get; }
        public User() { Name = null; }
        public User(string name)
        {
            Name = name;
        }
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        //User user;
        public MainWindow()
        {
            InitializeComponent();
            //user = new User("Bob");
            //Binding binding = new Binding();
            //binding.Source = user;
            //binding.Path = new PropertyPath("Name");
            //binding.Mode = BindingMode.TwoWay;
            //binding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            //txtBox.SetBinding(TextBox.TextProperty, binding);
        }


        private void btn_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(user.Name);
            //user.Name = "Joe";
        }
    }
}
