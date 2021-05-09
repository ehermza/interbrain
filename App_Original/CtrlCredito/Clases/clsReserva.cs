using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CtrldeCredito
{
    public class clsReserva
    {
//        private frmActividad FORM;
        private clsMysqlConexion obj_mysql = new clsMysqlConexion();

//        private long TimeStamp;
        private int IDRES;        // ID
        private string idSala;   	
		private string DNI;
		private string nombreyape;
        private string fechayhora;  // format(yy/MM/dd HH:mm:ss)
		private string comentario;
        private char btCancel;      

        public clsReserva()
        {
        }

        public void setAtributos(string _sala, string _doc, string _dtime, string _name, string _dtlle)
        {
//            DateTime dt = DateTime.Now;
 //         this.fechayhora = DateTime.Now.ToString(@"yy/MM/dd HH:mm:ss");
            this.fechayhora = _dtime;
            this.idSala     = _sala;
            this.DNI        = _doc;
			this.nombreyape = _name;
			this.comentario = _dtlle;
        }

        public int InsertToDataBase()
        {
            String dts_formulario =
                String.Format("\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",'0'",
                    this.fechayhora, this.idSala, this.DNI, this.nombreyape, this.comentario);
            Console.WriteLine(dts_formulario);
            string listvar = "fechayhora, id_sala, id_doc, nombre, comentario, bt_cancel";
            return
                obj_mysql.InsertarDatos("reserva", listvar, dts_formulario);
        }

        public DataTable getDtReservas()
        {

            String atributos = "fechayhora, nombre, id_sala, id_doc, id_reserva";

            return new clsMysqlConexion().getReservas(atributos);

        }

        public int Cancelar(string id_reserva)
        {
            return new clsMysqlConexion().setCancelReserva(id_reserva);

        }

        public String blExisteReserva(String horario, String sala)
        {
            return obj_mysql.getThisReserva(horario, sala);
        }

        public void SetCdgoTarjeta(string cdgo)
        {
            Console.WriteLine(cdgo);
        }
    }
}
