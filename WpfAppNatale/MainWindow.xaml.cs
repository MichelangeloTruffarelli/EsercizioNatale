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

namespace WpfAppNatale
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
        private const string file_name = "txtfile.txt";


        private void Button_Click(object sender, RoutedEventArgs e)
        { 
            try
            {
                double Num1 = double.Parse(TxtNum1.Text);
                double Num2 = double.Parse(TxtNum2.Text);
                double risultato = 0;
                string operatore = "";
                if (CmbOperazioni.SelectedIndex == 0)
                {
                    operatore = "somma";
                    double somma = Num1 + Num2;
                    risultato = somma;
                    NumRisultato.Text = $"{somma}";
                }
                if (CmbOperazioni.SelectedIndex == 1)
                {
                    operatore = "sottrazione";
                    double sottrazione = Num1 - Num2;
                    risultato = sottrazione;
                    NumRisultato.Text = $"{sottrazione}";
                }
                if (CmbOperazioni.SelectedIndex == 2)
                {
                    operatore = "moltiplicazione";
                    double moltiplicazione = Num1 * Num2;
                    risultato = moltiplicazione;
                    NumRisultato.Text = $"{moltiplicazione}";
                }
                if (CmbOperazioni.SelectedIndex == 3)
                {
                    operatore = "divisione";
                    double divisione = Num1 / Num2;
                    if (Num2 == 0)
                    {
                        MessageBox.Show("Non puoi dividere il numero per 0");
                        NumRisultato.Text = "Immpossibile";
                    }
                    else
                    {
                        NumRisultato.Text = $"{risultato}";
                        risultato = divisione;
                    }
                }
                using (StreamWriter t = new StreamWriter(file_name, true))
                {
                    t.WriteLine($"{Num1}      {Num2}     {operatore}     {risultato}");
                }
            }
            catch (FormatException) 
            {
                MessageBox.Show("Inserire solo numeri");
            }
        }
    }
}
