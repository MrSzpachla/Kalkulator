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

namespace Kalkulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String input = "";
        String numb = string.Empty;
        String numb2 = string.Empty;
        String typ = string.Empty;
        double wynik = 0;
        double a = 0;
        double b = 0;
        double minus = 0;
        bool w = false;
        
        public MainWindow()
        {
            InitializeComponent();
            Wynik.Content = "0";

        }

        private void Przycisk0_Click(object sender, RoutedEventArgs e)
        {
            input = (string)Wynik.Content;
            if (input.Length < 23)
            {
                if (w == true)
                {
                    w = false;
                    input = "";
                }
                if ((string)Wynik.Content != "0" && (string)Wynik.Content != "")
                {
                    input += "0";
                    this.Wynik.Content = input;
                }
            }
            else
            {
                E.Content = "E";
            }
        }

        private void Przycisk1_Click(object sender, RoutedEventArgs e)
        {
            input = (string)Wynik.Content;
            if (input.Length < 23)
            {
                if(w == true)
                {
                    w = false;
                    input = "";
                }
                if ((string)Wynik.Content != "0")
                {
                    input += "1";
                    Wynik.Content = input;
                }
                else
                {
                    input = "";
                    input += "1";
                    Wynik.Content = input;
                }
            }
            else
            {
                E.Content = "E";
            }
        }

        private void Przycisk2_Click(object sender, RoutedEventArgs e)
        {
            input = (string)Wynik.Content;
            if (input.Length < 23)
            {
                if (w == true)
                {
                    w = false;
                    input = "";
                }
                input = (string)Wynik.Content;
                if (input.Length < 23)
                {
                    if ((string)Wynik.Content != "0")
                    {
                        input += "2";
                        Wynik.Content = input;
                    }
                    else
                    {
                        input = "";
                        input += "2";
                        Wynik.Content = input;
                    }
                }
            }
            else
            {
                E.Content = "E";
            }
        }

        private void Przycisk3_Click(object sender, RoutedEventArgs e)
        {
            input = (string)Wynik.Content;
            if (input.Length < 23)
            {
                if (w == true)
                {
                    w = false;
                    input = "";
                }
                if ((string)Wynik.Content != "0")
                {
                    input += "3";
                    Wynik.Content = input;
                }
                else
                {
                    input = "";
                    input += "3";
                    Wynik.Content = input;
                }
            }
            else
            {
                E.Content = "E";
            }
        }

        private void Przycisk4_Click(object sender, RoutedEventArgs e)
        {
            input = (string)Wynik.Content;
            if (input.Length < 23)
            {
                if (w == true)
                {
                    w = false;
                    input = "";
                }
                if ((string)Wynik.Content != "0")
                {
                    input += "4";
                    Wynik.Content = input;
                }
                else
                {
                    input = "";
                    input += "4";
                    Wynik.Content = input;
                }
            }
            else
            {
                E.Content = "E";
            }
        }

        private void Przycisk5_Click(object sender, RoutedEventArgs e)
        {
            input = (string)Wynik.Content;
            if (input.Length < 23)
            {
                if (w == true)
                {
                    w = false;
                    input = "";
                }
                if ((string)Wynik.Content != "0")
                {
                    input += "5";
                    Wynik.Content = input;
                }
                else
                {
                    input = "";
                    input += "5";
                    Wynik.Content = input;
                }
            }
            else
            {
                E.Content = "E";
            }
        }

        private void Przycisk6_Click(object sender, RoutedEventArgs e)
        {
            input = (string)Wynik.Content;
            if (input.Length < 23)
            {
                if (w == true)
                {
                    w = false;
                    input = "";
                }
                if ((string)Wynik.Content != "0")
                {
                    input += "6";
                    Wynik.Content = input;
                }
                else
                {
                    input = "";
                    input += "6";
                    Wynik.Content = input;
                }
            }
            else
            {
                E.Content = "E";
            }
        }

        private void Przycisk7_Click(object sender, RoutedEventArgs e)
        {
            if (w == true)
            {
                w = false;
                input = "";
            }
            input = (string)Wynik.Content;
            if (input.Length < 23)
            {
                if ((string)Wynik.Content != "0")
                {
                    input += "7";
                    Wynik.Content = input;
                }
                else
                {
                    input = "";
                    input += "7";
                    Wynik.Content = input;
                }
            }
            else
            {
                E.Content = "E";
            }
        }

        private void Przycisk8_Click(object sender, RoutedEventArgs e)
        {
            input = (string)Wynik.Content;
            if (input.Length < 23)
            {
                if (w == true)
                {
                    w = false;
                    input = "";
                }
                if ((string)Wynik.Content != "0")
                {
                    input += "8";
                    Wynik.Content = input;
                }
                else
                {
                    input = "";
                    input += "8";
                    Wynik.Content = input;
                }
            }
            else
            {
                E.Content = "E";
            }
        }

        private void Przycisk9_Click(object sender, RoutedEventArgs e)
        {
            input = (string)Wynik.Content;
            if (input.Length < 23)
            {
                if (w == true)
                {
                    w = false;
                    input = "";
                }
                if ((string)Wynik.Content != "0")
                {
                    input += "9";
                    Wynik.Content = input;
                }
                else
                {
                    input = "";
                    input += "9";
                    Wynik.Content = input;
                }
            }
            else
            {
                E.Content = "E";
            }
        }

        private void PrzyciskPlus_Click(object sender, RoutedEventArgs e)
        {
            input = (string)Wynik.Content;
            if (input.Length < 23)
            {
                numb = input;
                typ = "+";
                input = "0";
                Wynik.Content = input;
                input = "";
            }
        }

        private void PrzyciskMinus_Click(object sender, RoutedEventArgs e)
        {
            input = (string)Wynik.Content;
            if (input.Length < 23)
            {
                numb = input;
                typ = "-";
                input = "0";
                Wynik.Content = input;
                input = "";
            }
        }

        private void PrzyciskMnoz_Click(object sender, RoutedEventArgs e)
        {
            input = (string)Wynik.Content;
            if (input.Length < 23)
            {
                numb = input;
                typ = "*";
                input = "0";
                Wynik.Content = input;
                input = "";
            }
        }
        
        private void PrzyciskDziel_Click(object sender, RoutedEventArgs e)
        {
            input = (string)Wynik.Content;
            if (input.Length < 23)
            {
                numb = input;
                typ = "/";
                input = "0";
                Wynik.Content = input;
                input = "";
            }
        }
        private void PrzyciskWynik_Click(object sender, RoutedEventArgs e)
        {
            input = (string)Wynik.Content;
            if (input.Length < 23)
            {
                numb2 = input;
                Double.TryParse(numb, out a);
                Double.TryParse(numb2, out b);
                if (typ == "+")
                {
                    wynik = a + b;
                    input = wynik.ToString();
                    Wynik.Content = wynik.ToString();
                }
                else if (typ == "-")
                {
                    wynik = a - b;
                    input = wynik.ToString();
                    Wynik.Content = wynik.ToString();
                }
                else if (typ == "*")
                {
                    wynik = a * b;
                    input = wynik.ToString();
                    Wynik.Content = wynik.ToString();

                }
                else if (typ == "/")
                {
                    if (b != 0)
                    {
                        wynik = a / b;
                        input = wynik.ToString();
                        Wynik.Content = wynik.ToString();
                    }
                    else
                    {
                        wynik = 0;
                        numb = string.Empty;
                        numb2 = string.Empty;
                        input = "0";
                        Wynik.Content = "!DZIEL PRZEZ ZERO!";
                    }
                }
            }
            w = true;
            
        }
        private void PrzyciskC_Click(object sender, RoutedEventArgs e)
        {
            wynik = 0;
            numb = string.Empty;
            numb2 = string.Empty;
            input = "0";
            Wynik.Content = input;
            input = "";
            E.Content = "";
            w = false;
        }

        private void PrzyciskK_Click(object sender, RoutedEventArgs e)
        {
            input = (string)Wynik.Content;
            if (w == true)
            {
                w = false;
                input = "0";
            }
            if (input.Length < 23)
            {
                if (input.ToLower().IndexOf(",") < 0)
                {
                    input += ",";
                    Wynik.Content = input;
                }
            }
            
        }

        private void PrzyciskLM_Click(object sender, RoutedEventArgs e)
        {
            input = (string)Wynik.Content;
            if (input.Length < 23)
            {
                if ((string)Wynik.Content != "0")
                {
                    if (Convert.ToDouble(input) > 0)
                    {
                        input = '-' + input;
                        Wynik.Content = input;
                    }
                    else if (Convert.ToDouble(input) < 0)
                    {
                        Double.TryParse(input, out minus);
                        minus = minus * -1;
                        input = Convert.ToString(minus);
                        Wynik.Content = input;

                    }
                }
            }
        }
    }
}
