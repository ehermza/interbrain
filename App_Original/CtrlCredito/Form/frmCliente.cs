using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace CtrldeCredito
{
    public partial class frmCliente : Form
    {
        private clsVerifCampos verifcampos = new clsVerifCampos();

        private const string ALERT_EXIST = "El usuario ya existe en la base de datos.\n Intente ingresando un username distinto.";
        private const string ALERT_OK = "La reserva se ha registrado exitosamente a la Base de Datos";
        private const string ALERT_RESERVA_EX = "Ya existe una reserva anterior hecha por: {0}. \nPor favor elija otro horario.";

        private clsPersona objCliente;
        private clsReserva objReserva;

        private bool blExisteCte;
        private string strCamposError = "ND";
        private bool blReadOnly = true;

        //        public frmCliente(clsEjecutor _Cliente, bool blReadOnly)
        public frmCliente()

        {	/* MUESTRA FORMULARIO CON LOS DATOS CORRESPONDIENTES 
				AL EJECUTOR (INDICADO EN EL 2d ARGUMENTO.) PARA MODIFICARLOS */
            InitializeComponent();
            //objCliente = new clsPersona("");
            objReserva = new clsReserva();
            
            this.tbNombre.Text = "";
            this.tbDocNumber.Text = "";
            this.tbDetalle.Text = "";
            this.tbCelular.Text = "";
            this.label1.Text = "GESTION DE RESERVAS SALON COMERCIAL";
            this.btOK.Enabled = false;

            cbSalas.Items.Add("SALA 1: NARANJA");
            cbSalas.Items.Add("SALA 2: NEGRO");
            cbSalas.Items.Add("SALA 3: ROJO");
            cbSalas.Items.Add("SALA 4: MARRON");
        }
        public void AddPersonatoDb()
        {
            objCliente.setAtributos(
                tbDocNumber.Text, tbNombre.Text, tbCelular.Text, "", tbDetalle.Text, '0'
            );
            if (objCliente.Insertar() == -1)
            {     // Error al intentar ingresar datos a mysql.
                MessageBox.Show(ALERT_EXIST, "ADVERTENCIA",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;     // algo salió mal!
            }

        }
        public void AddNuevaReserva()
        {
            String sala_eleg = cbSalas.SelectedItem.ToString();

            objReserva.setAtributos(
                sala_eleg, tbDocNumber.Text, dtimepick.Text, tbNombre.Text, tbDetalle.Text
                );
            objReserva.InsertToDataBase();

             MessageBox.Show(ALERT_OK, "Nuevo REGISTRO insertado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool blExisteReserva()
        {
            String horario = dtimepick.Value.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine(horario);

            String id_sala = cbSalas.SelectedItem.ToString();

            String nombreyape = objReserva.blExisteReserva(horario, id_sala);
            if (nombreyape.Length == 0)
            {
                return false;
            }
            String tl = String.Format(ALERT_RESERVA_EX, nombreyape);
            MessageBox.Show(tl, "OCUPADO",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return true;
        }

        private void btOK_Click(object sender, EventArgs e)
        {	/* 
			CONFIRMAR DATOS INGRESADOS EN FORMULARIO PARA INGRESAR/MODIFICAR EN BASE DATOS */
            if (cbSalas.SelectedItem == null) { 
                return;
            }
            if ( blExisteReserva() ) { 
                 return;
           }
            objCliente = new clsPersona(this.tbDocNumber.Text);
            if ( objCliente.getCoincidencia()!= "")
            {
                AddPersonatoDb();
            }
            AddNuevaReserva();

            GotoMain();
        }

        private void GotoMain() {
            //            this.Close();
            tbDocNumber.Text = "";
            tbNombre.Text = "";
            tbDetalle.Text = "";
            tbCelular.Text = "";

        }

        private void btCancel_Click(object sender, EventArgs e) {
            this.Close();
            //GotoMain();
        }

        private void ReportarError(char letra)
        {
            if (strCamposError.IndexOf(letra)!= -1) {
                return;
            }
            strCamposError += letra;
            btOK.Enabled = false;
//            Console.WriteLine("strCamposError: " + strCamposError);
        }

        private void QuitarError(char letra)
        {
            if (strCamposError.IndexOf(letra) == -1) {
                return;
            }
            String[] arraystr = strCamposError.Split(letra);
            strCamposError = string.Concat(arraystr);

            if("".Equals(strCamposError))
                btOK.Enabled = true;
//            Console.WriteLine("strCamposError: " + strCamposError);
        }

        private void MostrarAdvertencia(String ErrorMsgBox, TextBox tbox, char l)
        {
            tbox.BackColor = (ErrorMsgBox.Length != 0) ? Color.MistyRose : Color.White;
            if ("".Equals(ErrorMsgBox))
            {
                QuitarError(l);
                EP1.SetError(tbox, String.Empty);
                return;         // salir!
            }
            ReportarError(l);
            EP1.SetError(tbox, ErrorMsgBox);            
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
//            dtimepick.Value = DateTime
        }

       private void tbNombre_TextChanged(object sender, EventArgs e)
       {
           string ErrorMsgBox = verifcampos.RevCtresNombre(tbNombre.Text);
           MostrarAdvertencia(ErrorMsgBox, tbNombre, 'N');
       }

       private void tbDetalle_TextChanged(object sender, EventArgs e)
       {    /*
           string ErrorMsgBox = verifcampos.RevisarCorreo(tbDetalle.Text);
           MostrarAdvertencia(ErrorMsgBox, tbDetalle, 'E');
            */
       }

       private void tbDocNumber_TextChanged(object sender, EventArgs e)
       {
           string ErrorMsgBox = verifcampos.RevDocNumber(tbDocNumber.Text);
           MostrarAdvertencia(ErrorMsgBox, tbDocNumber, 'D');
       }

       private void tbCelular_TextChanged(object sender, EventArgs e)
       {
           string ErrorMsgBox = verifcampos.RevCtresNumber(tbCelular.Text);
           MostrarAdvertencia(ErrorMsgBox, tbCelular, 'C');
       }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmListReservas(objReserva).Show();

        }

        private void cbSalas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}