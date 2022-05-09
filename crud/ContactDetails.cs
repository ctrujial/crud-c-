using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud
{
    public partial class ContactDetails : Form
    {
        private CapaReglaDeNegocios _CapaReglaDeNegocios;
        public ContactDetails()
        {
            InitializeComponent();
            _CapaReglaDeNegocios = new CapaReglaDeNegocios();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();//ya que estamos en el mismo formulario solo necesitamos cerrarlo.
        }

        private void ContactDetails_Load(object sender, EventArgs e)
        {

        }

        private void btonGuardar_Click(object sender, EventArgs e)
        {
            Contactos contactos = new Contactos();
            contactos.nombre = txtNombre.Text;
            contactos.apellido = txtApellido.Text;
            contactos.contacto = txtCelContacto.Text;
            contactos.direccion = txtDireccion.Text;

            _CapaReglaDeNegocios.guadarContacto(contactos);
        }
    }
}
