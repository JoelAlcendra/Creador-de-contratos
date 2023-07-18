using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_Final
{
    public partial class frmContratos : Form
    {

        List<Contratos> ListaContratos = new List<Contratos>();

        List<DatosBasicos> ListaDatosBasicos;



        private DatosBasicos OBJDATOSBASICOS;
        private Contratos OBJCONTRATOS;

        public frmContratos()
        {
            InitializeComponent();

        }

        private void frmContratos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string json = JsonConvert.SerializeObject(ListaContratos);

                System.IO.File.WriteAllText(saveFileDialog1.FileName, json);

                MessageBox.Show("Contrato grabado y guardado con exito!");
            }
        }

        private void btnGrabarContrato_Click(object sender, EventArgs e)
        {
            OBJCONTRATOS = new Contratos();

            OBJCONTRATOS.NumeroContrato.ToString(txtNumContrato.Text);
            OBJCONTRATOS.Nombre = txtNombre.Text;
            OBJCONTRATOS.Apellidos = txtApellidos.Text;
            OBJCONTRATOS.Identificacion.ToString(txtId.Text);
            OBJCONTRATOS.SueldoBasico.ToString(txtSueldoBasico.Text);

            OBJCONTRATOS.FecIngreso = dtpFechaIngreso.Value.Date;
            OBJCONTRATOS.FecRetiro = dtnFechaRetiro.Value.Date;

            OBJCONTRATOS.FormaPago = cmbFormaPago.Text;
            OBJCONTRATOS.EstadoEmpleado = cmbEstadoEmpleado.Text;
            OBJCONTRATOS.TipoContrato = cmbTipoContrato.Text;
            OBJCONTRATOS.EstadoContrato = cmbEstadoContrato.Text;

            ListaContratos.Add(OBJCONTRATOS);
        }

        private void txtNumContrato_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
