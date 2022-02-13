/*
Hacer un programa que muestre la hora
del día en formato AM/FM seguida del
año, el día y el mes actual.
*/
using System;
using System.Windows;


namespace Tarea_4PA1_JoseA.Capitulo_8
{
    /// <summary>
    /// Interaction logic for Ejercicio3.xaml
    /// </summary>
    public partial class Ejercicio3 : Window
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        public void MostrarFecha_ClickButton(object sender, RoutedEventArgs e)
        {
            string formatoFecha, formatoHora;
            formatoHora = String.Format("{0:hh:mm tt}", DateTime.Now);
            formatoFecha = String.Format("{0:yyyy/d/M}", DateTime.Now);
            HoraTextBox.Text = formatoHora;
            FechaTextBox.Text = formatoFecha;
        }
    }
}
