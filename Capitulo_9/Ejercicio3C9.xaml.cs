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
    /// Interaction logic for Ejercicio3C9.xaml
    /// </summary>
    public partial class Ejercicio3C9 : Window
    {
        public struct Pet
        {
            public string TipoPet;
            public string NombrePet;

            public Pet(string PtipoPet, string PnombrePet)
            {
                TipoPet = PtipoPet;
                NombrePet = PnombrePet;
            }

              public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Tipo pet: {0}\n Nombre pet: {1}\n", 
                TipoPet, NombrePet);
                return sb.ToString();
            }
        }
        public struct OwnerPet
        {
            public string Nombre;
            public int Edad;
            public string Dirrecion;
            public string Telefono;
   

            public OwnerPet(string Onombre, int Oedad, string Odireccion, string Otelefono, string pTipopet, string pNombrePet)
            {
                Nombre = Onombre;
                Edad =Oedad;
                Dirrecion = Odireccion;
                Telefono = Otelefono;

                Pet pet= new Pet(pTipopet, pNombrePet);
            }

              public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Nombre: {0}\n Edad: {1}\n Direcion: {2}\n Telefono: {3}", 
                Nombre, Edad, Dirrecion, Telefono);
                return sb.ToString();
            }
            
        }

        private OwnerPet ownerPet = new OwnerPet();
        public Ejercicio3C9()
        {
            InitializeComponent();
            this.DataContext = ownerPet;
        }
        
        OwnerPet due = new OwnerPet();
        Pet mascota = new Pet();
        public void GuardarOP()
        {
            due = new OwnerPet(NombreduenoTextBox.Text, int.Parse(EdadTextBox.Text), 
            DirecionTextBox.Text, TelefonoTextBox.Text, TipopetTextBox.Text, NombrePetTextBox.Text);
            mascota = new Pet(TipopetTextBox.Text, NombrePetTextBox.Text);
        }
        public void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            GuardarOP();
            MessageBox.Show("Se guardado correctamente", "Informacion");
        }
        public void MostarButton_Click(object sender, RoutedEventArgs e)
        {
            InformacionListBox.Items.Add(due);
            
            InformacionListBox.Items.Add(mascota);
        }
    }
}
