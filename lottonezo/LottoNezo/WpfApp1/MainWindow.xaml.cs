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

namespace WpfApp1
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<string> lottoszamok;
        public List<string> WinSzam;

        public MainWindow()
        {
            InitializeComponent();
            lottoszamok = new List<string>();
            WinSzam = new List<string>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            lottoszamok.Add(numbers.Text);
            numbers.Clear();

            teszt.Clear();
            for (int i = 0; i < lottoszamok.Count; i++)
            {
                teszt.Text += lottoszamok[i] + "\n";
            }
        }

        private void WinSzG_Click(object sender, RoutedEventArgs e)
        {
            WinSzam = WinSz.Text.Split(' ').ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Eredmeny.Clear();
            for (int i = 0; i < lottoszamok.Count; i++)
            {
                int a = 0;
                string[] b = lottoszamok[i].Split(' '); //tippek
                for (int j = 0; j < WinSzam.Count; j++)
                {
                    for (int f = 0; f < b.Length; f++)
                    {
                        if (b[f] == WinSzam[j])
                        {
                            a++;
                        }
                    }
                }

                Eredmeny.Text += string.Format("{0}. sorban ennyi eggyezés van: {1} \n", i+1, a);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            teszt.Clear();
            lottoszamok.Clear();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            WinSz.Clear();
            WinSzam.Clear();
        }
    }
}
