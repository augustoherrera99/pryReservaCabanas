using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySP2Cabañas
{
    public partial class frmReservaCabañas : Form
    {
        public frmReservaCabañas()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        public float PrecioBase = 0;
        public const float BaseA = 20;
        public const float BaseB = 34;
        const float cocina = 1;
        const float heladera = 1.5f;
        const float television = 2;
        float Total = 0;

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Tipo = cmbTipo.Text;

            if (Tipo == "A")
            {
                cmbPersonas.Items.Clear();
                for (int i = 1; i < 5; i++)
                {
                    cmbPersonas.Items.Add(i);
                }
                cmbPersonas.SelectedIndex = 0;
            }

            if (Tipo == "B")
            {
                cmbPersonas.Items.Clear();
                for (int i = 1; i < 9; i++)
                {
                    cmbPersonas.Items.Add(i);
                }
                cmbPersonas.SelectedIndex = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTipo.SelectedIndex = 0;
            cmbPersonas.SelectedIndex = 0;
            txtDias.Text = "1";
            chkCocina.Checked = false;
            chkHeladera.Checked = false;
            chkTelevision.Checked = false;
        }

        private void optTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            cmbTarjetas.Enabled = true;
            cmbTarjetas.SelectedIndex = 0;
        }

        private void optEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            cmbTarjetas.Enabled = false;
            cmbTarjetas.SelectedIndex = -1;
        }

        private void txtDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefonos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '+'))
            {
                e.Handled = true;
            }
        }

        private void txtDias_TextChanged(object sender, EventArgs e)
        {
            if (txtDias.Text != "0" && txtNombre.Text != "" && txtTelefonos.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtDias.Text != "0" && txtNombre.Text != "" && txtTelefonos.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void txtTelefonos_TextChanged(object sender, EventArgs e)
        {
            if (txtDias.Text != "0" && txtNombre.Text != "" && txtTelefonos.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedIndex == 0)
            {
                PrecioBase = BaseA;
            }
            else
            {
                PrecioBase = BaseB;
            }

            int Personas = Int32.Parse(cmbPersonas.Text);

            int Dias = Int32.Parse(txtDias.Text);

            PrecioBase = PrecioBase + Personas;

            float Recargo = 0;

            float Adicionales = 0;

            if (chkCocina.Checked == true)
            {
                Adicionales = Adicionales + cocina;
            }

            if (chkHeladera.Checked == true)
            {
                Adicionales = Adicionales + heladera;
            }

            if (chkTelevision.Checked == true)
            {
                Adicionales = Adicionales + television;
            }

            Total = (PrecioBase + Adicionales) * Dias;

            if (optTarjeta.Checked == true)
            {
                if (cmbTarjetas.SelectedIndex == 0)
                {
                    Recargo = Total * 0.1f;
                }
                else
                {
                    Recargo = Total * 0.2f;
                }
                Total = Total + Recargo;
            }

            MessageBox.Show("Total = US$" + Total.ToString(), "Importe de la reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmbTipo.SelectedIndex = 0;
            cmbPersonas.SelectedIndex = 0;
            txtDias.Text = "1";
            chkCocina.Checked = false;
            chkHeladera.Checked = false;
            chkTelevision.Checked = false;
            optEfectivo.Checked = true;
            txtNombre.Text = "";
            txtTelefonos.Text = "";

        }
    }
}
