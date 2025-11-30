using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Equipo_Laboratorio.Clases
{
   public class Productos
   {

      public int codigo { get; set; }
      public string producto { get; set; }
      public string categoria { get; set; }
      public double precio { get; set; }
      public int cantidad { get; set; }
      public double subtotal { get; set; }


      Conexion conexion = new Conexion();
      SqlCommand command;
      SqlDataReader reader;
      SqlDataAdapter adapter;

      public Productos()
      {

      }



      public List<Productos> BuscarProducto(string filtro)
      {
         Productos obj = new Productos();
         List<Productos> listproducto = new List<Productos>();
         string query = $"SELECT * FROM VW_PRODUCTO {filtro}";
         command = new SqlCommand(query, conexion.GetConexion());

         try
         {
            conexion.AbrirConexion();

            reader = command.ExecuteReader();


            if (reader.Read())
            {
               obj.codigo = reader.GetInt32(0);
               obj.producto = reader.GetString(1);
               obj.categoria = reader.GetString(2);
               obj.precio = reader.GetDouble(3);
               obj.cantidad = 1;
               obj.subtotal = obj.precio;
               listproducto.Add(obj);

            }
            else
               MessageBox.Show("Producto No Encontrado", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            conexion.CerrarConexion();
         }
         catch (Exception ex)
         {
            MessageBox.Show($"Ocurrio un error: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
         finally { conexion.CerrarConexion(); }

         return listproducto;
      }



      Dictionary<string, int> Empresas = new Dictionary<string, int>()
      {
          // Barcel
          { "075010", 3 },
          { "075011", 3 },
          { "075012", 3 },

          // Gamesa
          { "077010", 4 },
          { "077011", 4 },
          { "077012", 4 },

          // Coca-Cola (Refrescos)
          { "00012", 5 },
          { "04944", 5 },
          { "12512", 5 },
          { "20098", 5 },

          // Tecate (Heineken)
          { "08600", 1 },
          { "08601", 1 },

          // Sabritas (extra)
          { "04780", 3 },
      };



      public void DetectarCat(TextBox txtCodigo, ComboBox cmb)
      {

         try
         {
            string codigo = txtCodigo.Text;

            if (!(int.TryParse(codigo, out int numero)) && string.IsNullOrWhiteSpace(codigo))
               return;

            string empresa = codigo.Substring(3, 5);  //toma 5 caracteres comenzando del indice 3 135791138 = 79113

            if (Empresas.ContainsKey(empresa))
            {
               cmb.SelectedValue = Empresas[empresa];
            }

         }
         catch (Exception ex) { MessageBox.Show($"Ocurrio un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

      }



      public double CalcularGanancia(TextBox txtPrecio, TextBox txtPorcentaje)
      {
         int precio = 0, porcentaje = 0;

         if (
            (string.IsNullOrWhiteSpace(txtPrecio.Text) || string.IsNullOrWhiteSpace(txtPorcentaje.Text))
            ||
            (txtPrecio.Text == "0" || txtPorcentaje.Text == "0")
            )
         {
            MessageBox.Show("Datos Invalidos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return 0;
         }

         else
            precio = int.Parse(txtPrecio.Text);
            porcentaje = int.Parse(txtPorcentaje.Text);

            porcentaje = porcentaje / 100;
            double ganancia = precio * (.100 - porcentaje);
            return precio + ganancia;
      }



   }
}
