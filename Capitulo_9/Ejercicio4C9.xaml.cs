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

namespace Tarea_4PA1_JoseA.Capitulo_9
{
    /// <summary>
    /// Interaction logic for Ejercicio4C9.xaml
    /// </summary>
    public partial class Ejercicio4C9 : Window
    {
        enum TipoNeumatico 
        {
            NeumaticoVerano = 1, 
            NeumáticosInvierno, 
            NeumaticosAllSeason, 
            NeumaticoDeportivo,
            NeumaticoPista, 
            NeumatocTodoTerreno
            };
        public Ejercicio4C9()
        {
            InitializeComponent();
        }

        public void MostrarButton_Click(object sender, RoutedEventArgs e)
        {
           int mineumaticoD = (int)TipoNeumatico.NeumaticoDeportivo;
           string mineumatico1 = "Neumatico Deportivo " + mineumaticoD;

           int mineumaticoP = (int)TipoNeumatico.NeumaticoPista;
           string  mineumatico2 = "Neumatico Deportivo " + mineumaticoP;

           int mineumaticoA = (int)TipoNeumatico.NeumaticosAllSeason;
           string mineumatico3 = "Neumatico All Season " + mineumaticoA;

           int mineumaticoV = (int)TipoNeumatico.NeumaticoVerano;
           string mineumatico4 = "Nemutico Verrano " + mineumaticoV;

           int mineumaticoT = (int)TipoNeumatico.NeumatocTodoTerreno;
           string mineumatico5 = "Neumatico Todo Terreno " + mineumaticoT;

           int mineumaticoI = (int)TipoNeumatico.NeumáticosInvierno;
           string mineumatico6 = "Neumatico Invierno " + mineumaticoI;

           TipoNeumaticoListBox.Items.Add(mineumatico1);
           TipoNeumaticoListBox.Items.Add(mineumatico2);
           TipoNeumaticoListBox.Items.Add(mineumatico3);
           TipoNeumaticoListBox.Items.Add(mineumatico4);
           TipoNeumaticoListBox.Items.Add(mineumatico5);
           TipoNeumaticoListBox.Items.Add(mineumatico6);
            
        }
    }
}
