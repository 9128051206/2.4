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

namespace _2._4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDouble = rateDollar * sumDollar;
            resSum.Text = resDouble.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEvro = Convert.ToDouble(rate1.Text);
            double sumEvro = Convert.ToDouble(sum1.Text);
            double resEvro = rateEvro * sumEvro;
            resSum1.Text = resEvro.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGr = Convert.ToDouble(rate2.Text);
            double sumGr = Convert.ToDouble(sum2.Text);
            double resGr = rateGr * sumGr;
            resSum2.Text = resGr.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDram = Convert.ToDouble(rate3.Text);
            double sumDram = Convert.ToDouble(sum3.Text);
            double resDram = rateDram * sumDram;
            resSum3.Text = resDram.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double rateInches = Convert.ToDouble(rate4.Text);            
            double resInches = rateInches * 0.025;
            resSum4.Text = resInches.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double ratePounds = Convert.ToDouble(rate5.Text);
            double resPounds = ratePounds * 0.3;
            resSum5.Text = resPounds.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double rateMiles = Convert.ToDouble(rate6.Text);
            double resMiles = rateMiles * 1609.34;
            resSum6.Text = resMiles.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double rateVerst = Convert.ToDouble(rate7.Text);
            double resVerst = rateVerst * 1066.8;
            resSum7.Text = resVerst.ToString();
        }
    }
}
