using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Equipo_Laboratorio.Busquedas;
using Equipo_Laboratorio.Clases;

namespace Equipo_Laboratorio
{
   public partial class Venta : Form
   {

      Funcionalidades fn = new Funcionalidades();
      Productos producto = new Productos();
      double subtotal = 0;


      public Venta()
      {
         InitializeComponent();
      }


      private void Venta_Load(object sender, EventArgs e)
      {
         txtCodigo.Focus();

         dtgvVenta.Columns.Add("CODIGO", "SKU");
         dtgvVenta.Columns.Add("ARTICULO", "ARTICULO");
         dtgvVenta.Columns.Add("CATEGORIA", "CATEGORIA");
         dtgvVenta.Columns.Add("PRECIO", "PRECIO");
         dtgvVenta.Columns.Add("CANTIDAD", "CANTIDAD");
         dtgvVenta.Columns.Add("SUBTOTAL", "SUBTOTAL"); 

      }


      private void txtProducto_Enter(object sender, EventArgs e)
      {
         if (txtCodigo.Text == "Codigo")
            txtCodigo.Text = "";
      }

      private void txtCodigo_Leave(object sender, EventArgs e)
      {
         if (txtCodigo.Text == "")
            txtCodigo.Text = "Codigo";
      }




      //ACCIONES SOBRE PRODUCTO
      #region 

      private void btnBuscar_Click(object sender, EventArgs e)
      {
         BuscarProducto busqueda = new BuscarProducto();
         busqueda.ShowDialog();

         if (busqueda.DialogResult == DialogResult.OK)
         {
            dtgvVenta.Rows.Add(null, busqueda.codigo, busqueda.nombre, busqueda.categoria, busqueda.precio, busqueda.cantidad, busqueda.subtotal);
            subtotal = Convert.ToDouble(busqueda.subtotal);

          txtSubtotal.Text = fn.CalcularSubtotal(dtgvVenta).ToString();
         }

        
         txtTotal.Text = txtSubtotal.Text;
         txtCodigo.Focus();

      }


      private void txtDescuento_KeyUp(object sender, KeyEventArgs e)
      {
         


      }


      #endregion

      //BOTONES OPERACIONALES
      #region
      private void btnMas_Click(object sender, EventArgs e)
      {

         if (dtgvVenta.CurrentRow != null)
         {
            fn.OperacionSobreCantidad(dtgvVenta, "+");

            txtSubtotal.Text = fn.CalcularSubtotal(dtgvVenta).ToString();
            txtTotal.Text = fn.Descuento(txtSubtotal, txtDescuento).ToString();

            txtCodigo.Focus();
         }
         else
            MessageBox.Show("Seleccione un articulo", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

      }


      private void btnMenos_Click(object sender, EventArgs e)
      {

         if (dtgvVenta.CurrentRow != null)
         {
            fn.OperacionSobreCantidad(dtgvVenta, "-");

            txtSubtotal.Text = fn.CalcularSubtotal(dtgvVenta).ToString();
            txtTotal.Text = fn.Descuento(txtSubtotal, txtDescuento).ToString();

            txtCodigo.Focus();
         }
         else
            MessageBox.Show("Seleccione un articulo", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

      }

      private void btnIgual_Click(object sender, EventArgs e)
      {

      }
      #endregion

      private void dtgvVenta_CellClick(object sender, DataGridViewCellEventArgs e)
      {

         if (e.ColumnIndex == 0)
            dtgvVenta.Rows.RemoveAt(e.RowIndex);

         txtCodigo.Focus();
      }


      private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
      {

         if (e.KeyCode == Keys.Enter)
         {
            List<Productos> listProducto = producto.BuscarProducto($"WHERE CODIGO = {txtCodigo.Text}");

            foreach (Productos i in listProducto)
            {
               dtgvVenta.Rows.Add(null, i.codigo, i.producto.ToString(), i.categoria.ToString(), i.precio.ToString(), i.cantidad.ToString(), i.precio.ToString(), i.subtotal.ToString());
            }

            e.SuppressKeyPress = true;
            txtSubtotal.Text = fn.CalcularSubtotal(dtgvVenta).ToString();
            txtTotal.Text = fn.Descuento(txtSubtotal, txtDescuento).ToString();
            txtCodigo.Focus();
            txtCodigo.Clear();

         }
      }

      private void txtDescuento_Enter(object sender, EventArgs e)
      {
            txtDescuento.Clear();
      }
   }
}
