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

namespace Laske
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((tulos.Text == "0") || (isOperationPerformed)) {
                tulos.Clear();
            }
            isOperationPerformed = false;
            Button button = (Button)sender;
            tulos.Text = tulos.Text + button.Content;
        }

        private void operator_click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Content.ToString();
            resultValue = Double.Parse(tulos.Text);
            lableCurrentOperation.Content = resultValue + " " + operationPerformed;
            isOperationPerformed = true;
        }

        private void equal(object sender, RoutedEventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    tulos.Text = (resultValue + Double.Parse(tulos.Text)).ToString();
                    break;
                case "-":
                    tulos.Text = (resultValue - Double.Parse(tulos.Text)).ToString();
                    break;
                case "*":
                    tulos.Text = (resultValue * Double.Parse(tulos.Text)).ToString();
                    break;
                case "/":
                    tulos.Text = (resultValue / Double.Parse(tulos.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void clearTulos(object sender, RoutedEventArgs e)
        {
            tulos.Text = "0";
        }
    }
}
