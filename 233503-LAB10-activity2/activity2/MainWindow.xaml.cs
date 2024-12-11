using System.Windows;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox1_Checked(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "Checkbox 1 is checked.";
        }

        private void CheckBox1_Unchecked(object sender, RoutedEventArgs e)
        {
            textBox1.Text = ""; 
        }

        private void CheckBox2_Checked(object sender, RoutedEventArgs e)
        {
            textBox2.Text = "Checkbox 2 is checked.";
        }

        private void CheckBox2_Unchecked(object sender, RoutedEventArgs e)
        {
            textBox2.Text = ""; 
        }
    }
}