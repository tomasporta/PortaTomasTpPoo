
using Practico01.Entidades;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace frmPiramides
{
    public partial class frmPiramides : Form
    {
        private int cantidadPiramides = 0;

        public frmPiramides()
        {
            InitializeComponent();
            lblCantidad.Text = "Total Pirámides: 0"; // Inicializar el contador
        }

        private void btoOk_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                var altura = int.Parse(txtAltura.Text);
                var lado = int.Parse(txtLado.Text);
                PiramideCuadrada r = new PiramideCuadrada(altura, lado);

                var context = new ValidationContext(r);
                var errors = new List<ValidationResult>();

                var isValid = Validator.TryValidateObject(r, context, errors, true);
                if (isValid)
                {
                    MessageBox.Show(r.ToString(), "Mensaje", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    AgregarPiramideCuadrada(r);
                    InicializarControles();
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var error in errors)
                    {
                        sb.AppendLine($"{error.ErrorMessage}");
                    }
                    MessageBox.Show(sb.ToString(), "Errores", MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                    txtAltura.SelectAll();
                    txtLado.Focus();
                }
            }

        }

        private void InicializarControles()
        {
            txtLado.Clear();
            txtAltura.Clear();
            txtLado.Focus();
        }

        private void AgregarPiramideCuadrada(PiramideCuadrada r)
        {
            lstPiramides.Items.Add(r.MostrarInfo());
            
            cantidadPiramides++; // Incrementar contador
            lblCantidad.Text = $"Total Pirámides: {cantidadPiramides}";
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!int.TryParse(txtAltura.Text, out _))
            {
                valido = false;
                errorProvider1.SetError(txtLado, "Lado mal ingresado");
            }
            if (!int.TryParse(txtAltura.Text, out _))
            {
                valido = false;
                errorProvider1.SetError(txtAltura, "Altura  mal ingresada");
            }
            return valido;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }
    }
}
