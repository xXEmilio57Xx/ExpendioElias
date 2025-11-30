using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Equipo_Laboratorio.Clases;
using Equipo_Laboratorio.Busquedas;

namespace Equipo_Laboratorio.Formularios
{
   public partial class Producto : Form
   {

      Conexion c = new Conexion();
      BuscarProducto Bproducto = new BuscarProducto();
      Funcionalidades fn = new Funcionalidades();
      SqlCommand command = new SqlCommand();
      Productos producto = new Productos();

      int idCat, cantidad;
      string descripcion, id;
      double precio;


      public Producto()
      {
         InitializeComponent();
      }

      private void Producto_Load(object sender, EventArgs e)
      {
         txtCodigo.Focus();
         CargarCmb();
      }

      //======EVENTOS ENTER/LEAVE=======================

      #region

      private void txtCodigo_Enter(object sender, EventArgs e)
      {
         if (txtCodigo.Text == "Codigo")
            txtCodigo.Clear();
      }

      private void txtCodigo_Leave(object sender, EventArgs e)
      {
         if (txtCodigo.Text == "")
            txtCodigo.Text = "Codigo";
      }

      private void txtDescripcion_Enter(object sender, EventArgs e)
      {
         if (txtDescripcion.Text == "Descripcion")
            txtDescripcion.Clear();
      }

      private void txtDescripcion_Leave(object sender, EventArgs e)
      {
         if (txtDescripcion.Text == "")
            txtDescripcion.Text = "Descripcion";
      }

      private void txtPrecio_Enter(object sender, EventArgs e)
      {
         if (txtPrecio.Text == "$Precio")
            txtPrecio.Clear();
      }

      private void txtPrecio_Leave(object sender, EventArgs e)
      {
         if (txtPrecio.Text == "")
            txtPrecio.Text = "$Precio";
      }

      private void txtCantidad_Enter(object sender, EventArgs e)
      {
         if (txtCantidad.Text == "Inventario Cant.")
            txtCantidad.Clear();
      }

      private void txtCantidad_Leave(object sender, EventArgs e)
      {
         if (txtCantidad.Text == "")
            txtCantidad.Text = "Inventario Cant.";
      }

      #endregion


      //===========FUNCIONALIDADES===================

      #region

      public void LimpiarTexto()
      {
         txtCodigo.Text = "Codigo";
         txtDescripcion.Text = "Descripcion";
         txtPrecio.Text = "$Precio";
         txtCantidad.Text = "Inventario Cant.";
         txtPrecioProv.Clear();
         txtPorcentaje.Clear();

         txtCodigo.Focus();
      }



      public void CargarCmb()
      {
         cmbCategoria.DataSource = fn.GetComboInfo("SELECT * FROM CATEGORIA");
         cmbCategoria.DisplayMember = "CAT_DESCRIPCION";
         cmbCategoria.ValueMember = "CAT_ID";
      }

      #endregion


      private void btnOk_Click(object sender, EventArgs e)
      {
         double ganancia = producto.CalcularGanancia(txtPrecioProv, txtPorcentaje);

         if (ganancia != 0)
            txtPrecio.Text = ganancia.ToString();
      }

      private void btnEditar_Click(object sender, EventArgs e)
      {
         Bproducto.ShowDialog();

         if (Bproducto.DialogResult == DialogResult.OK)
         {
            txtCodigo.Text = Bproducto.codigo;
            txtDescripcion.Text = Bproducto.nombre;
            txtPrecio.Text = Bproducto.precio;
            txtCantidad.Text = Bproducto.cantidad;
            string categoria = Bproducto.categoria;

            foreach (DataRowView row in cmbCategoria.Items)
            {
               if (row["CAT_DESCRIPCION"].ToString() == categoria)
                  cmbCategoria.SelectedItem = row;
            }

         }

      }

      private void btnEliminar_Click(object sender, EventArgs e)
      {

         try
         {

            id = txtCodigo.Text;
      
            c.AbrirConexion();

            command.Connection = c.GetConexion();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SP_PRODUCTO";

            command.Parameters.AddWithValue("@OP", 3);
            command.Parameters.AddWithValue("@Codigo", id);
         
            if (command.ExecuteNonQuery() > 0)
               MessageBox.Show("Producto Eliminado", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Information);

         }
         catch (Exception ex) { MessageBox.Show($"Ocurrio un Error: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }

         finally
         {
            c.CerrarConexion();
            txtCodigo.Focus();
            LimpiarTexto();
         }
      }

      private void bntAñadir_Click(object sender, EventArgs e)
      {

         try
         {

            id = txtCodigo.Text;
            idCat = Convert.ToInt32(cmbCategoria.SelectedValue);
            descripcion = txtDescripcion.Text;
            precio = Convert.ToDouble(txtPrecio.Text);
            cantidad = int.Parse(txtCantidad.Text);


            c.AbrirConexion();

            command.Connection = c.GetConexion();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SP_PRODUCTO";

            command.Parameters.AddWithValue("@OP", 2);
            command.Parameters.AddWithValue("@Codigo", id);
            command.Parameters.AddWithValue("@ID_CAT", idCat);
            command.Parameters.AddWithValue("@DESCRIPCION", descripcion);
            command.Parameters.AddWithValue("@PRECIO", precio);
            command.Parameters.AddWithValue("@INVENTARIO", cantidad);

            if (command.ExecuteNonQuery() > 0)
               MessageBox.Show("Producto Registrado", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Information);

         } catch (Exception ex) { MessageBox.Show($"Ocurrio un Error: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }

         finally 
         { 
            c.CerrarConexion();
            txtCodigo.Focus();
            LimpiarTexto();
         }
  
      }


      private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
      {
         if (!(e.KeyCode == Keys.Enter))
            return;

         producto.DetectarCat(txtCodigo, cmbCategoria);
         e.SuppressKeyPress = true;
      }


   }
}
