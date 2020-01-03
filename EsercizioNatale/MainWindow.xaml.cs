using System;
using System.Collections.Generic;
using System.IO;
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
        private const string file_name = "txtfile";

        private void Button_Click(object sender, RoutedEventArgs e)

           {
            try
            {
                double a = double.Parse(txtnumero1.Text);
                double b = double.Parse(txtnumero2.Text);
                double risultato=0;
                string operatore = "";
                if (cmbCalcolo.SelectedIndex == 0)
                {
                    operatore = "somma";
                    risultato = a + b;
                    txtrisultato.Text = $"{ risultato}";
                }
                if (cmbCalcolo.SelectedIndex == 1)
                {
                    operatore = "sottrazione";
                    risultato = a - b;
                    txtrisultato.Text = $"{ risultato}";
                }
                if (cmbCalcolo.SelectedIndex == 2)
                {
                    operatore = "moltiplicazione";
                    risultato = a * b;
                    txtrisultato.Text = $"{ risultato}";
                }
                if (cmbCalcolo.SelectedIndex == 3)
                {
                    operatore = "divisione";
                    risultato = a / b;
                    if (b == 0)
                    {
                        MessageBox.Show("Non si può dividere un numero per 0");
                        txtrisultato.Text = "impossibile";
                    }
                    else
                    {
                        txtrisultato.Text = $" {risultato}";
                    }

                }
            using (StreamWriter t = new StreamWriter(file_name, true))
            {
                t.WriteLine($"{a}   {b}   {operatore}   {risultato}");
            }

            } catch(FormatException)
            {
                MessageBox.Show("Inserire solo numeri");
            }
        }
    }
}
