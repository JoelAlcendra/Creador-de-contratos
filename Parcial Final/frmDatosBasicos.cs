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
    public partial class frmDatosBasicos : Form
    {
        List<DatosBasicos> ListaDatosBasicos = new List<DatosBasicos>();

        private DatosBasicos OBJDATOSBASICOS;




        public frmDatosBasicos()
        {
            InitializeComponent();
        }

        private void dtpFechaNac_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OBJDATOSBASICOS = new DatosBasicos();

            OBJDATOSBASICOS.Identificacion.ToString(txtId.Text);
            OBJDATOSBASICOS.Nombre = txtNombre.Text;
            OBJDATOSBASICOS.Apellidos = txtApellidos.Text;
            OBJDATOSBASICOS.Direccion = txtDireccion.Text;
            OBJDATOSBASICOS.Celular = txtCelular.Text;
            OBJDATOSBASICOS.CorreoElectronico = txtCorreo.Text;

            OBJDATOSBASICOS.TipoId = cmbTipoId.Text;
            OBJDATOSBASICOS.EstadoCivil = cmbEstadoCivil.Text;

            if (rdbMasculino.Checked == true)
            {
                OBJDATOSBASICOS.Sexo = rdbMasculino.Text;
            }
            else if (rdbFemenino.Checked == true)
            {
                OBJDATOSBASICOS.Sexo = rdbFemenino.Text;
            }
            else
            {
                MessageBox.Show("Obligatorio seleccionar el sexo ");
                return;
            }

            OBJDATOSBASICOS.FecNac = dtpFechaNac.Value.Date;

            ListaDatosBasicos.Add(OBJDATOSBASICOS);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            if (ValidarId() == false || ValidarNombre() == false || ValidarApellido() == false || ValidarDireccion() == false || ValidarCelular() == false || ValidarTipoId() == false || ValidarFechaNac() == false || ValidarEstadocivil() == false || ValidarCorreo() == false)
            {
                return;
            }


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string json = JsonConvert.SerializeObject(ListaDatosBasicos);

                System.IO.File.WriteAllText(saveFileDialog1.FileName, json);

                MessageBox.Show("Archivo grabado con exito!");
            }

            if (rdbMasculino.Checked == true)
            {
                OBJDATOSBASICOS.Sexo = rdbMasculino.Text;
            }
            else if (rdbFemenino.Checked == true)
            {
                OBJDATOSBASICOS.Sexo = rdbFemenino.Text;
            }
            else
            {
                MessageBox.Show("Obligatorio seleccionar el sexo ");
                return;

            }
        }

        private void btnCrearContrato_Click(object sender, EventArgs e)
        {
            if (validarRegistro() == true)
            {
                frmContratos FORMDATOSBASICOS = new frmContratos();
                FORMDATOSBASICOS.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe registrarse primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private bool validarRegistro()
        {
            if (ListaDatosBasicos.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void frmDatosBasicos_Load(object sender, EventArgs e)
        {

        }

        private void rdbMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtId_Validating(object sender, CancelEventArgs e)
        {
            ValidarId();
        }

        private bool ValidarId()
        {
            int id;

            if (!int.TryParse(txtId.Text, out id) || txtId.Text == "")
            {
                errorProvider1.SetError(txtId, "ingresar una identifiacion valida");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtId, "");
                return true;
            }
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            ValidarNombre();
        }

        private bool ValidarNombre()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "ingresar un nombre");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
                return true;
            }
        }

        private void txtApellidos_Validating(object sender, CancelEventArgs e)
        {
            ValidarApellido();
        }

        private bool ValidarApellido()
        {
            if (string.IsNullOrEmpty(txtApellidos.Text))
            {
                errorProvider1.SetError(txtApellidos, "ingresar un apellido");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtApellidos, "");
                return true;
            }
        }

        private void txtDireccion_Validating(object sender, CancelEventArgs e)
        {
            ValidarDireccion();
        }

        private bool ValidarDireccion()
        {
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                errorProvider1.SetError(txtDireccion, "ingresar una Direccion");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtDireccion, "");
                return true;
            }
        }

        private void txtCelular_Validating(object sender, CancelEventArgs e)
        {
            ValidarCelular();
        }

        private bool ValidarCelular()
        {
            int celular;

            if (!int.TryParse(txtCelular.Text, out celular) || txtCelular.Text == "")
            {
                errorProvider1.SetError(txtCelular, "ingresar su numero de celular correcto");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtCelular, "");
                return true;
            }
        }

         private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            ValidarCorreo();
        }

        private bool ValidarCorreo()
        {
            if (string.IsNullOrEmpty(txtCorreo.Text))
            {
                errorProvider1.SetError(txtCorreo, "ingresar un correo");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtCorreo, "");
                return true;
            }
        }

        private void cmbTipoId_Validating(object sender, CancelEventArgs e)
        {
            ValidarTipoId();
        }

        private bool ValidarTipoId()
        {
            if (string.IsNullOrEmpty(cmbTipoId.Text))
            {
                errorProvider1.SetError(cmbTipoId, "Seleccionar su tipo de id ");
                return false;
            }
            else
            {
                errorProvider1.SetError(cmbTipoId, "");
                return true;
            }
        }

        private void dtpFechaNac_Validating(object sender, CancelEventArgs e)
        {
            ValidarFechaNac();
        }
        private bool ValidarFechaNac()
        {
            if (string.IsNullOrEmpty(dtpFechaNac.Text))
            {
                errorProvider1.SetError(dtpFechaNac, "Seleccionar su fecha de nacimiento");
                return false;
            }
            else
            {
                errorProvider1.SetError(dtpFechaNac, "");
                return true;
            }
        }

        private void cmbEstadoCivil_Validating(object sender, CancelEventArgs e)
        {
            ValidarEstadocivil();
        }

        private bool ValidarEstadocivil()
        {
            if (string.IsNullOrEmpty(cmbEstadoCivil.Text))
            {
                errorProvider1.SetError(cmbEstadoCivil, "Seleccionar su Estado civil");
                return false;
            }
            else
            {
                errorProvider1.SetError(cmbEstadoCivil, "");
                return true;
            }
        }

       
    }
}
