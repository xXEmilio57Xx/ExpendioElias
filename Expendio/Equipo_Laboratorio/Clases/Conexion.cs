using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Equipo_Laboratorio.Clases
{
   public class Conexion
   {

      SqlConnection conexion = new SqlConnection("server = DESKTOP-QHU6U8H\\SQLEXPRESS; database = EXPENDIO; integrated security = true;");

      public void AbrirConexion()
      {
         conexion.Open();
      }

      public void CerrarConexion()
      {
         conexion.Close();
      }

      public SqlConnection GetConexion()
      {
         return conexion;
      }


   }
}
