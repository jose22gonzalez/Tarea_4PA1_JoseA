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
using Tarea_4PA1_JoseA.Capitulo_8;
using Tarea_4PA1_JoseA.Capitulo_9;

namespace Tarea_4PA1_JoseA
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

        //Capitulo 8
        public void Ejercicio3C8_MenuClick(object sender, RoutedEventArgs e)
        {
            //Ejercicio 3
            Ejercicio3 ejercicio3 = new Ejercicio3();
            ejercicio3.Show();
        }

        public void Ejercicio5C8_MenuClick(object sender, RoutedEventArgs e)
        {
            //Ejercicio 5
            Ejercicio5 ejercicio5 = new Ejercicio5();
            ejercicio5.Show();
        }

        //Capitulo 9

        public void Ejercicio1C9_MenuClick(object sender, RoutedEventArgs e)
        {
            Ejercicio1C9 ejercicio1C9 = new Ejercicio1C9();
            ejercicio1C9.Show();
        }

        public void Ejercicio3C9_MenuClick(object sender, RoutedEventArgs e)
        {
            Ejercicio3C9 ejercicio3C9 = new Ejercicio3C9();
            ejercicio3C9.Show();
        }

        public void Ejercicio4C9_MenuClick(object sender, RoutedEventArgs e)
        {
            Ejercicio4C9 ejercicio4C9 = new Ejercicio4C9();
            ejercicio4C9.Show();
        }
    }
}
