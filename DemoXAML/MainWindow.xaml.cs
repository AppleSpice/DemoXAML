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

namespace DemoXAML
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string yourNameOutput;
        double mathNumber1;
        double mathNumber2;
        double mathFinalAnswer;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            yourNameOutput = YourName.Text;
            ChangeMe.Text = yourNameOutput;

            mathNumber1 = double.Parse(number1.Text);
            mathNumber2 = double.Parse(number2.Text);
            mathFinalAnswer = mathNumber1 + mathNumber2;

            MathAnswer.Text = Convert.ToString(mathFinalAnswer);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ChangeMe.Text = "";
            YourName.Text = "";
            number1.Text = "";
            number2.Text = "";
            MathAnswer.Text = "";
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            //this.Close();
            //or 
            Environment.Exit(0);
        }
    }
}
