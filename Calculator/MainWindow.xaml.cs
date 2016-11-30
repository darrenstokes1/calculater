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

namespace Calculator
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

            

        private void add_Click(object sender, RoutedEventArgs e)
        {
            var input1 = float.Parse(this.input1.Text);
            var input2 = float.Parse(this.input2.Text);
            var answer = input1 + input2;
            this.answer.Content = answer;
        }

        private void subtract_Click(object sender, RoutedEventArgs e)
        {
            var input1 = float.Parse(this.input1.Text); // Get 1st input from user
            var input2 = float.Parse(this.input2.Text); // Get 2nd input from user
            var answer = input1 - input2; // Subtract 2 numbers together
            this.answer.Content = answer; // Returns answer
        }
        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            var input1 = float.Parse(this.input1.Text); // get fi
            var input2 = float.Parse(this.input2.Text);
            var answer = input1 * input2;
            this.answer.Content = answer;
        }
        private void divide_Click(object sender, RoutedEventArgs e)
        {
            var input1 = float.Parse(this.input1.Text);
            var input2 = float.Parse(this.input2.Text);
            var answer = input1 / input2;
            this.answer.Content = answer;
        }
        private void mod_Click(object sender, RoutedEventArgs e)
        {
            var input1 = float.Parse(this.input1.Text);
            var input2 = float.Parse(this.input2.Text);
            var answer = input1 % input2;
            this.answer.Content = answer;
        }

       
    }
}
