using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Data;
//using System.Windows.Forms;

/*
 * @author: ehermza
 * 
 */

namespace CtrldeCredito
{
    public class clsMysqlConexion
    {
        // Declaramos las variables:
        public static MySqlConnection MySqlCnn = new MySqlConnection();
        public static MySqlCommand MySqlCmd = new MySqlCommand();
//        public static MySqlDataReader MySqlReader;
        public static string CadenaDeConexion = "Server=localhost;Port=3306;Database=probando;Uid=root;Password=";

        public clsMysqlConexion()
        {            
            Conectar();
        }

        static void Conectar()
        {
            try {
                MySqlCnn.ConnectionString = CadenaDeConexion;
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
            }
        }

        public void Desconectar() {
            MySqlCnn.Close();
//            Console.WriteLine("\nConexión finalizada");
        }

        private DataTable dt;
//        public DataTable BuscarActividadTbl(String varnames, String dt_init, String dt_final, String cdgotarjeta, bool blterm, bool bladmin)
        public DataTable getReservas(String varnames)
        {
            String tl = "SELECT {0} FROM `reserva` WHERE bt_cancel LIKE '0'";
            String SENTENCIA = String.Format(tl, varnames);
            //Console.WriteLine(SENTENCIA);
            try
            {
                if (MySqlCnn.State == ConnectionState.Closed){
                    MySqlCnn.Open();
                }
                // Establecemos cuál será la conexión
                MySqlCmd.Connection = MySqlCnn;
                MySqlCmd.CommandText = SENTENCIA;
                MySqlDataAdapter adaptador = new MySqlDataAdapter(MySqlCmd);
                dt = new DataTable();
                adaptador.Fill(dt);
                //dtgv.DataSource = dt;
                MySqlCnn.Close();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            return dt;
        }
        public String getThisReserva(String dtstring, String sala)
        {
            String nombreyape = "";
            String tl = "SELECT * FROM `reserva` WHERE bt_cancel LIKE '0' AND fechayhora LIKE \'{0}\' AND id_sala LIKE \'{1}\'";
            String SENTENCIA = String.Format(tl, dtstring, sala);

            Console.WriteLine(SENTENCIA);
            try
            {
                if (MySqlCnn.State == ConnectionState.Closed)
                {
                    MySqlCnn.Open();
                }
                // Establecemos cuál será la conexión
                MySqlCmd.Connection = MySqlCnn;
                MySqlCmd.CommandText = SENTENCIA;
                MySqlDataReader MySqlReader = MySqlCmd.ExecuteReader();

                while (MySqlReader.Read()) {
                    nombreyape += MySqlReader["nombre"].ToString();
                }
                MySqlCnn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return nombreyape;
        }

        public int Modificar(String tblname, String listvar, String datos, String key, String kvalue)
        {
            try
            {
                // Abrimos la conexión
                if (MySqlCnn.State == ConnectionState.Closed){
                    MySqlCnn.Open();
                }
                // Establecemos cuál será la conexión
                MySqlCmd.Connection = MySqlCnn;
                String strquery = String.Format("UPDATE {0} SET ", tblname);
                String strwhere = String.Format(" WHERE {0}='{1}'", key, kvalue);  // al final
                String[] aListCampos = listvar.Split(',');
                String[] aListDatos = datos.Split(',');
                for (int i = 0; i < aListCampos.Length; i++)
                {
                    String jl= (aListDatos.Length - 1 == i) ? strwhere : ", ";
                    strquery += String.Format("{0}='{1}'{2}", aListCampos[i], aListDatos[i], jl);
                }
                /*
                System.Windows.Forms.MessageBox.Show(strquery, "Sentencia MYSQL");       // quitar!!!
                */
                MySqlCmd.CommandText = strquery;
                int l = MySqlCmd.ExecuteNonQuery();
                MySqlCnn.Close();

                return l;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            return -1;
        }

        public int InsertarDatos(String tblname, String listvar, String datos)
        {
            try {
                // Abrimos la conexión
                if (MySqlCnn.State == ConnectionState.Closed) {
                    MySqlCnn.Open();
                }
                // Establecemos cuál será la conexión
                MySqlCmd.Connection = MySqlCnn;
                String tl = String.Format("INSERT INTO {0}({1}) VALUES({2})", tblname, listvar, datos);
                Console.WriteLine(tl);

                MySqlCmd.CommandText = tl;
                int l= MySqlCmd.ExecuteNonQuery();
                MySqlCnn.Close();

                return l;
            }
            catch (Exception ex){
                Console.WriteLine(ex);
            }

            return -1;
        }	//OK

        public int setCancelReserva(string IdReserva)
        {
            try
            {
                // Abrimos la conexión
                if (MySqlCnn.State == ConnectionState.Closed){
                    MySqlCnn.Open();
                }
                // Establecemos cuál será la conexión
                MySqlCmd.Connection = MySqlCnn;
                String tl = String.Format("UPDATE `reserva` SET bt_cancel='1' WHERE id_reserva LIKE {0}", IdReserva);
                Console.WriteLine(tl);

                MySqlCmd.CommandText = tl;
                int l = MySqlCmd.ExecuteNonQuery();
                MySqlCnn.Close();

                return l;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return -1;
        }	//OK


        public int getPersona(clsPersona objCliente)     
        {
            // Obtiene datos del cliente desde base datos y 
            //  llena atributos del objeto objCliente.
            int fbk = -1;
//            clsEjecutor oEjecutor = null;
            try
            {
                // Abrimos la conexión
                if (MySqlCnn.State == ConnectionState.Closed) {
                    MySqlCnn.Open();
                }
                // Establecemos cuál será la conexión
                MySqlCmd.Connection = MySqlCnn;
                MySqlCmd.CommandText = String.Format("SELECT * FROM `usuario` WHERE `id_doc` LIKE '{0}'", objCliente.DNI);
                MySqlDataReader rd= MySqlCmd.ExecuteReader();
                while (rd.Read())
                {
                    fbk += 1;
                    objCliente.setAtributos(
                        rd.GetString("id_doc"),
                        rd.GetString("nombre"),
                        rd.GetString("telefono"),
                        rd.GetString("estado"),
                        rd.GetString("detalle"),
                        rd.GetChar("blocked")
                    );
                    break;
                }                
                MySqlCnn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return fbk;

        }   //OK!

        public string getCoincidencia(String docNumber)
        {       /*      
                 * Verificar si existe en bdts registrada con el dni == docNumber
                 */
            string DNI = "";     
            string SENTENCIA = String.Format("SELECT * FROM `persona` WHERE id_doc LIKE \'{0}\' ", docNumber);
            try
            {
                if (MySqlCnn.State == ConnectionState.Closed)
                {
                    MySqlCnn.Open();
                }
                // Establecemos cuál será la conexión
                MySqlCmd.Connection = MySqlCnn;
                MySqlCmd.CommandText = SENTENCIA;
                MySqlDataReader MySqlReader = MySqlCmd.ExecuteReader();

                while (MySqlReader.Read())
                {
                    DNI += MySqlReader["id_doc"].ToString();
                }
                MySqlCnn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return DNI;
        }   //OK

        public String getSentencia(String tblname, String varnames, String[] arraydatos)
        {
            String[] atributos = varnames.Split(',');
//            String[] arraydato = datosTextBox.Split(',');

            String SENTENCIA = String.Format("SELECT {0} FROM `{1}` ", varnames, tblname);
            String jl = "";
            for (int i = 0; i < arraydatos.Length; i++)
            {
                String property= atributos[i];              // nombre atributo de tabla ejecutor
                String strTextBox = arraydatos[i];
                if (strTextBox != "")
                {
                    jl += (jl != "") ? "AND " : "WHERE ";
                    jl += String.Format("{0} LIKE '{1}' ", property, strTextBox);
                }
            }
            SENTENCIA += jl;
            SENTENCIA += (jl == "") ? "WHERE blocked= 0" : "AND blocked= 0";

            return SENTENCIA;
        }

    }
}
