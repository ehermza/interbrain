using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
//using System.Text.RegularExpressions;

namespace CtrldeCredito
{
    public class clsPersona 
    {
        private clsMysqlConexion objmysql = new clsMysqlConexion();

        private string documento;
        private string nombre;
        private string apellido;
        private string telefono;
        private string estado;   
        private string detalle;
        private char blocked;
        private bool blCteExiste;
        //OK

        public clsPersona(String idt)
        {
            this.documento = idt;
        }

        public void SetDtsBaseDatos()
        {
            // Llenar this con datos obtenidos de mysql, si no esta registrado: return -1;
            this.blCteExiste = (objmysql.getPersona(this) != -1);
        }

        public void setAtributos( String idt,
            String _nombre, String _telef,  String _state, String _dtalle, char _blBlock)
        {
            this.documento  = idt;
            this.nombre     = _nombre;
            this.telefono   = _telef;
            this.estado     = _state;
            this.detalle    = _dtalle;
            this.blocked    = _blBlock;
        }   //OK

        public int Modificar()
        {
            String listvar = "id_doc,nombre,apellido,estado,detalle,telefono,blocked";
            String valores = String.Format(
                "{0},{1},{2},{3},{4},{5},{6}",
                this.documento,  // {0}
                this.nombre,       // {1}
                this.apellido,     // {2}
                this.estado,       // {3}
                this.detalle,      // {4}
                this.telefono,     // {5}
                this.blocked       //{6}
                );
            return objmysql.Modificar("PERSONA", listvar, valores, "id_doc", this.documento);
        }
/*
        public int Eliminar()
        {
            return objmysql.OcultarObj("Usuario", "id_tarjeta", this.CdgoTarjeta);
        }
        */
        public int Insertar()
        {
            String listvar = "id_doc,nombre,apellido,estado,detalle,telefono,blocked";
            String valores = String.Format(
                "\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",0",
                this.documento,     // {0}
                this.nombre,       // {1}
                this.apellido,     // {2}
                this.estado,       // {3}
                this.detalle,      // {4}
                this.telefono     // {5}
                //this.blocked,       //{6}
            );

            return objmysql.InsertarDatos("PERSONA", listvar, valores);
        }   //OK

        public void BlockPersona()
        {
            string listvar= "blocked";
            //objmysql.Modificar("PERSONA", listvar, 'b', "id_doc", this.documento);
        }   //REVISAR
//        private string fechayhora;  // format(yy/MM/dd HH:mm:ss)

        public bool setReserva(){
            //REVISAR
            return true;
        }

        public string getCoincidencia()     // from frmCliente.DarAltaTarjeta()
        {
            return
                objmysql.getCoincidencia(this.documento);
        }

        public string Nombre
        {
            get { return this.nombre; }
        }
        public string Apellido
        {
            get { return this.apellido; }
        }
        public string Detalle
        {
            get { return this.detalle; }
        }
        public string Telefono
        {
            get { return this.telefono; }
        }
        public string DNI
        {
            get { return this.documento; }
        }
        public string Estado
        {
            get { return this.estado; }
        }
        public char Saldo
        {   //REVISAR
            get { return this.blocked; }
        }
        public bool getExisteCte()
        {
            return this.blCteExiste; 
        }

    }
}

