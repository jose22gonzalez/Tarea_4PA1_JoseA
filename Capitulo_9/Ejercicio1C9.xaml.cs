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
    /// Interaction logic for Ejercicio1C9.xaml
    /// </summary>
    public partial class Ejercicio1C9 : Window
    {
        public struct ProductosTienda
        {
            int IdProducto;
            string NombresProducto;
            int CantProducto;
            int PrecioProducto;

            public ProductosTienda(int Pproductoid, string pNombresProducto, int pCantProducto, int PprecioProducto)
            {
                IdProducto = Pproductoid;
                NombresProducto = pNombresProducto;
                CantProducto = pCantProducto;
                PrecioProducto = PprecioProducto;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("ProductoID: {0}\n Nombre: {1}\n Cantidad: {2}\n Precio: {3}", 
                IdProducto, NombresProducto, CantProducto, PrecioProducto);
                return sb.ToString();
            }
        }
        public Ejercicio1C9()
        {
            InitializeComponent();
        }

        public void GuardarProducto_ClickButton(object sender, RoutedEventArgs e)
        {
           Guardar();
           MessageBox.Show("Se ha guardado correctamente", "Exito");
        }

        public void MostarProductos_ClickButton(object sender, RoutedEventArgs e)
        {
            int Idproducto = Convert.ToInt32(ProductoIDTextBox.Text);
            int Cantproducto = Convert.ToInt32(CantidadProductoTextBox.Text);
            int Precioproducto = Convert.ToInt32(PrecioProducto.Text);
            ProductosTienda producto = new ProductosTienda(Idproducto,NombreProductoTextBox.Text, Cantproducto, Precioproducto);
            Productos.Items.Add(producto);
        }

        public void Guardar()
        {
            int Idproducto = Convert.ToInt32(ProductoIDTextBox.Text);
            int Cantproducto = Convert.ToInt32(CantidadProductoTextBox.Text);
            int Precioproducto = Convert.ToInt32(PrecioProducto.Text);
            ProductosTienda producto = new ProductosTienda(Idproducto,NombreProductoTextBox.Text, Cantproducto, Precioproducto);
        }

    }
}
