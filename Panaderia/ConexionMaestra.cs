using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panaderia
{
    internal class ConexionMaestra
    {
        //Conexion a la base de datos
        public static OdbcCommand consulta;
        public static OdbcDataReader leer;
        public static OdbcConnection conexion;
        DataSet ds;
        DataSet cuadricula = new DataSet();
        public static string str_Con
        = "DRIVER={MySQL ODBC 5.3 ANSI Driver}; USER=root; PASSWORD=12345; PORT=3306; DATABASE=panaderia";

        //Creacion de metodos para el poder consultar e insertar la base de datos
        public static void conectar()
        {
            conexion = new OdbcConnection(str_Con);
            conexion.Open();
            consulta = new OdbcCommand();
            consulta.Connection = conexion;
            MessageBox.Show("conectado");
        }

        public static void ejecutar(string SQL)
        {
            consulta.CommandType = CommandType.Text;
            consulta.CommandText = SQL;
            leer = consulta.ExecuteReader();

        }
        public static void gred(DataGridView tabla, string SQL)
        {

            ejecutar(SQL);
            leer.Close();
            DataSet cuadricula = new DataSet();
            OdbcDataAdapter adaptador = new OdbcDataAdapter(consulta);
            adaptador.Fill(cuadricula, "DATOS");
            tabla.DataSource = cuadricula;
            tabla.DataMember = "DATOS";
        }
        public static void llenaCombo(ComboBox lista, string SQL)
        {
            ejecutar(SQL);
            lista.Items.Clear();
            while (leer.Read())
            {
                lista.Items.Add(leer[0].ToString());
            }
            leer.Close();

        }
    }
}
