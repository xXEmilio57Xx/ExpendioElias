using Equipo_Laboratorio.Clases;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Equipo_Laboratorio.Busquedas
{
   public partial class BuscarProducto : Form
   {

      Funcionalidades fn = new Funcionalidades();

      bool pdtSeleccionado = false;
      public string codigo = "";
      public string nombre = "";
      public string categoria = "";
      public string precio = "";
      public string cantidad = "";
      public string inventario = "";
      public string subtotal = "";

      public BuscarProducto()
      {
         InitializeComponent();
      }

      private void BuscarProducto_Load(object sender, EventArgs e)
      {
         fn.LlenarDtgv(dtgvProducto, "VW_PRODUCTO", "");
      }


      private void btnAñadir_Click(object sender, EventArgs e)
      {
         try
         {

            if (!pdtSeleccionado)
            {
               MessageBox.Show("Selecciona un producto Primero", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               return;
            }

            nombre = txtNombre.Text;
            categoria = txtCategoria.Text;
            precio = txtPrecio.Text;
            cantidad = txtCantidad.Text;
            inventario = txtInventario.Text;
            subtotal = (Convert.ToDouble(precio) * Convert.ToDouble(cantidad)).ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();
         }
         catch (Exception ex) { MessageBox.Show($"Error: {ex.Message}"); };
      }

   
      private void txtBusqueda_Enter(object sender, EventArgs e)
      {
         if (txtBusqueda.Text == "Nombre Producto")
            txtBusqueda.Text = "";
      }

      private void txtBusqueda_Leave(object sender, EventArgs e)
      {
         if (txtBusqueda.Text == "")
            txtBusqueda.Text = "Nombre Producto";
      }

      private void btnBuscar_Click(object sender, EventArgs e)
      {
         string filtro = "";

         if (rbtnNombre.Checked == true) filtro = $"WHERE ARTICULO LIKE '%{txtBusqueda.Text}%'";
         if (rbtnCodigo.Checked == true) filtro = $"WHERE CODIGO = '{txtBusqueda.Text}'";
         if (rbtnCategoria.Checked == true) filtro = $"WHERE CATEGORIA LIKE '%{txtBusqueda.Text}%'";

         fn.LlenarDtgv(dtgvProducto, "VW_PRODUCTO", filtro);
      }

      private void dtgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
      {
         DataGridViewRow row = dtgvProducto.Rows[e.RowIndex];

         codigo = row.Cells[0].Value.ToString();
         txtNombre.Text = row.Cells[1].Value.ToString();
         txtCategoria.Text = row.Cells[2].Value.ToString();
         txtPrecio.Text = row.Cells[3].Value.ToString();
         txtInventario.Text = row.Cells[4].Value.ToString();

         pdtSeleccionado = true;
      }

   }
}
