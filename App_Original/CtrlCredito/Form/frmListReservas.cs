using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CtrldeCredito
{
    public partial class frmListReservas : Form
    {
        private clsReserva objRES;

        public frmListReservas(clsReserva objeto)
        {
            objRES = objeto;
            InitializeComponent();

        }


        private void frmListReservas_Load(object sender, EventArgs e)
        {
            dtgv.DataSource = objRES.getDtReservas();
            // LISTAR TODAS LAS RESERVAS

            int l = dtgv.Columns.Count;
            for (int i = 0; i < l; i++)
            {
                //Console.WriteLine(dtgv.Columns[i].Width);
                dtgv.Columns[i].Width = 130;
            }

        }

        private void btcancel_Click(object sender, EventArgs e)
        {

            string t = ""; string p = "";

            foreach (DataGridViewRow r in dtgv.SelectedRows)
            {
                t = r.Cells["id_reserva"].Value.ToString();
                p = r.Cells["nombre"].Value.ToString();
            }
            if (t.Length == 0)
            {
                MessageBox.Show("Primero debes seleccionar una fila.","Cancelar",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string msje = String.Format("Estás seguro que quieres Cancelar la Reserva de: {0}", p);
            if(
            MessageBox.Show(msje, "Cancelar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            // CANCELAR RESERVA
            if ( objRES.Cancelar(t) > 0 )
            {
                MessageBox.Show("Reserva Cancelada con Exito!", "RESERVAS",
                   MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            this.Close();
        }

        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void selectedRowsButton_Click(object sender, System.EventArgs e)
        {

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
