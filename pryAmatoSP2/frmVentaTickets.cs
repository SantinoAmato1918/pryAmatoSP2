using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryAmatoSP2
{
    public partial class frmVentaTickets : Form
    {
        public frmVentaTickets()
        {
            InitializeComponent();
        }

        private void txtNumeroTicket_TextChanged(object sender, EventArgs e)
        {
            if (txtNumeroTicket.Text != "")
            {
                cmbTipoTicket.Enabled = true;
            }
            else
                cmbTipoTicket.Enabled = false;
            btnRegistrar.Enabled = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Variables
            string numero = txtNumeroTicket.Text;
            string tipo = cmbTipoTicket.Text;
            string fecha = dtpFecha.Text;

            //Mensaje
            lstVentas.Items.Add($"{fecha} - {numero} - {tipo}");

            //Limpiar
            txtNumeroTicket.Clear();
            cmbTipoTicket.SelectedIndex = -1;

            //Desabilitar
            cmbTipoTicket.Enabled = false;
            btnRegistrar.Enabled = false;

            //Focus
            txtNumeroTicket.Focus();
        }

        private void frmVentaTickets_Load(object sender, EventArgs e)
        {

        }

        private void lblNumeroTicket_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipoTicket_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoTicket.Text != "")
            {
                btnRegistrar.Enabled = true;
            }
            else
                btnRegistrar.Enabled = false;
        }

        private void txtNumeroTicket_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
