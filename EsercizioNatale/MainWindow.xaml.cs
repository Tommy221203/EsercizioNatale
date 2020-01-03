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

namespace EsercizioNatale
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(txtnumero1.Text);
            double b = double.Parse(txtnumero2.Text);
            if(cmbCalcolo.SelectedIndex==0)
            {
                double somma = a + b;
                txtrisultato.Text = $"{somma}";
            }
            if(cmbCalcolo.SelectedIndex==1)
            {
                double sottrazione = a - b;
                txtrisultato.Text = $"{sottrazione}";
            }
            if(cmbCalcolo.SelectedIndex==2)
            {
                double moltiplicazione = a * b;
                txtrisultato.Text = $"{moltiplicazione}";
            }
            if(cmbCalcolo.SelectedIndex==3)
            {
                double divisione = a / b;
                txtrisultato.Text = $"{divisione}";
            }
        }
    }
}
