using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWF13
{
    public partial class frmClinica : Form
    {
        int numero = 0;
        string tipoSangre;
        public frmClinica()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //---Habilitar Controles
            txtPaciente.Enabled = true;
            gpbAnalisis.Enabled = true;
            gpbCondicion.Enabled = true;
            gpbEspecialidad.Enabled = true;
            //---Limpiar Controles
            txtPaciente.Clear();
            nudCostoAnalisis.Value = 0;
            nudCostoConsulta.Value = 20;
            nudDescuento.Value = 0;
            nudNetoPagar.Value = 0;
            nudSubTotal.Value = 0;
            chkOrina.Checked = false;
            chkSangre.Checked = false;
            rbtOdontologia.Checked = true;
            rbtTipoA1.Checked = true;
            rbtCondicionA.Checked = true;
            lblTipo.Text = "";
            //--Generar Numero
            numero = numero + 1;
            txtNumero.Text = numero.ToString("000000");
            txtPaciente.Focus();
            btnGuardar.Enabled = true;
            btnNuevo.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtPaciente.Text.Trim().Length >= 3)
            {
                nudSubTotal.Value = nudCostoConsulta.Value + nudCostoAnalisis.Value;
                if (rbtCondicionB.Checked) nudDescuento.Value = nudSubTotal.Value * (decimal)0.05;
                else if (rbtCondicionC.Checked) nudDescuento.Value = nudSubTotal.Value * (decimal)0.25;
                else if (rbtCondicionD.Checked) nudDescuento.Value = nudSubTotal.Value * (decimal)0.35;
                else if (rbtCondicionE.Checked) nudDescuento.Value = nudSubTotal.Value * (decimal)0.50;
                nudNetoPagar.Value = nudSubTotal.Value - nudDescuento.Value;
                if (chkSangre.Checked) lblTipo.Text = tipoSangre;
                else lblTipo.Text = "";
                //---Deshabiltar controles
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                txtPaciente.Enabled = false;
                gpbAnalisis.Enabled = false;
                gpbCondicion.Enabled = false;
                gpbEspecialidad.Enabled = false;
            }
            else
            {
                MessageBox.Show("Complete el Nombre del Paciente...", "Clinita Internacional", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPaciente.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalcularCostoConsulta(object sender, EventArgs e)
        {
            if (rbtOdontologia.Checked) nudCostoConsulta.Value = 20;
            else if(rbtOftalmologia.Checked) nudCostoConsulta.Value = 35;
            else if (rbtPediatria.Checked) nudCostoConsulta.Value = 25;
            else if (rbtGinecologia.Checked) nudCostoConsulta.Value = 50;
            else if (rbtMedicina.Checked) nudCostoConsulta.Value = 30;
        }

        private void CalcularCostoAnalisis(object sender, EventArgs e)
        {
            decimal costo = 0;
            if (chkSangre.Checked) costo = 20;
            if (chkOrina.Checked) costo = costo + 15;
            nudCostoAnalisis.Value = costo;
        }

        private void DeterminarTipoSangre(object sender, EventArgs e)
        {
            tipoSangre = ((RadioButton)sender).Text;
        }
    }
}
