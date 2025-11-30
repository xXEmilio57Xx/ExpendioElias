using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Equipo_Laboratorio.Formularios;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Equipo_Laboratorio
{
   public partial class Menu : Form
   {

      int x, y;
      bool movimiento = false;
      public Menu()
      {
         InitializeComponent();
      }


      public void AbrirFormHijo(Object formhijo)
      {
         if (panelContenedor.Controls.Count > 0)
            panelContenedor.Controls.RemoveAt(0);

         Form fh = formhijo as Form;
         fh.TopLevel = false;
         fh.Dock = DockStyle.Fill;

         panelContenedor.Controls.Add(fh);
         panelContenedor.Tag = fh;
         fh.Show();
      }


      private void Menu_Load(object sender, EventArgs e)
      {
         //AbrirFormHijo(new Venta());
      }

      //----------------------------------------------------------------

      private void bntCerrar_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void btnMinimizar_Click(object sender, EventArgs e)
      {
         this.WindowState = FormWindowState.Minimized;
      }

      //-------------------------------------------------------------------

      private void btnVenta_Click(object sender, EventArgs e)
      {
         AbrirFormHijo(new Venta());
      }

      private void btnProducto_Click(object sender, EventArgs e)
      {
         AbrirFormHijo(new Producto());
      }


      //======MOVIMIENTOS DEL FORMULARIO=============

      private void panelSuperior_MouseUp(object sender, MouseEventArgs e)
      {
         movimiento = false;
      }

      private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
      {
         movimiento = true;
         x = e.X;
         y = e.Y;
      }

      private void panelSuperior_MouseMove(object sender, MouseEventArgs e)
      {
         if (movimiento)
         {
            this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
         }
      }
   }
}
