/*5. Hacer un programa que le solicite al
usuario dos cadenas y luego las muestre
en orden alfabético.*/
using System.Collections.Generic;
using System.Linq;
using System.Windows;


namespace Tarea_4PA1_JoseA.Capitulo_8
{
    /// <summary>
    /// Interaction logic for Ejercicio5.xaml
    /// </summary>
    public partial class Ejercicio5 : Window
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        public void MostrarCadena_ClickButton(object sender, RoutedEventArgs e)
        {
            string[] cadenas = { Texto1TextBox.Text, Texto2TextBox.Text };

            IEnumerable<string> OrdenAlfabetico =
            from cadena in cadenas
            orderby cadena 
            select cadena;
            foreach (string s in OrdenAlfabetico)
            {
               MostrarTexto.Items.Add(s);
            }
        }
    }
}
