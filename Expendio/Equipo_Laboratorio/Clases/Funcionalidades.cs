using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Equipo_Laboratorio.Clases
{
 
   public class Funcionalidades
   {

      Menu menu = new Menu();
      Conexion c = new Conexion();
      SqlCommand command;
      SqlDataReader reader;
      SqlDataAdapter adapter;


      public void LlenarDtgv(DataGridView dtgv, string tabla, string filtro)
      {
         Conexion c = new Conexion();
         string query = $"SELECT * FROM {tabla} {filtro}";
         SqlDataAdapter adapter = new SqlDataAdapter(query, c.GetConexion());
         DataTable dt = new DataTable();

         try
         {
            c.AbrirConexion();

            adapter.Fill(dt);
            dtgv.DataSource = dt;

            c.CerrarConexion();

         }
         catch (Exception ex)
         {
            MessageBox.Show($"Ocurrio un Error: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }

      }

      public void AbrirFormHijo(Object formhijo)
      {
         if (menu.panelContenedor.Controls.Count > 0)
            menu.panelContenedor.Controls.RemoveAt(0);

         Form fh = formhijo as Form;
         fh.TopLevel = false;
         fh.Dock = DockStyle.Fill;

         menu.panelContenedor.Controls.Add(fh);
         menu.panelContenedor.Tag = fh;
         fh.Show();
      }

      public void OperacionSobreCantidad(DataGridView dtgv, string operacion)
      {

         DataGridViewRow row = dtgv.CurrentRow;

         int cantidad = int.Parse(row.Cells["CANTIDAD"].Value.ToString());
         double precio = Convert.ToDouble(row.Cells["PRECIO"].Value.ToString());

         cantidad = operacion == "+" ? cantidad + 1 :  cantidad - 1;

         row.Cells["CANTIDAD"].Value = cantidad.ToString();
         row.Cells["SUBTOTAL"].Value = (cantidad * precio).ToString();

         if (cantidad == 0)
            dtgv.Rows.Remove(row);

      }


      public double CalcularSubtotal(DataGridView dtgv)
      {
         double subtotal = 0;

         for (int i = 0; i < dtgv.Rows.Count; i++)
         {

            if (!dtgv.Rows[i].IsNewRow)
            {
               subtotal += Convert.ToDouble(dtgv.Rows[i].Cells["SUBTOTAL"].Value.ToString());
            }
              
         }

         return subtotal;
      }


      public double Descuento(TextBox txtSubtotal, TextBox txtDescuento)
      {
         double descuento = Convert.ToDouble(txtDescuento.Text);
         double subtotal = Convert.ToDouble(txtSubtotal.Text);
         double rebaja = 0;

         if (descuento >= 0 && !string.IsNullOrEmpty(txtDescuento.Text))
            rebaja = (subtotal * (.100 - (descuento / 100)));

         else if (descuento == 0)
            return subtotal;

         return rebaja;
      }


      public DataTable GetComboInfo(string query)
      {

         DataTable dt = new DataTable();
         adapter = new SqlDataAdapter(query, c.GetConexion());

         adapter.Fill(dt);

         return dt;
      }



   }
}
