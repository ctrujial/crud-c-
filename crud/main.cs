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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        #region eventos botones
        private void Search_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btonSearch_Click(object sender, EventArgs e)
        {
            //agregar
            openContactDetails();//aca lo instanciamos ya que lo creamos como private para encapsularlo

        }
        #endregion

        #region metodo privado boton agregar
        private void openContactDetails()// lo creamos tipo void porque solo ejecutara lineas de codigo no devolvera valores
        {
            ContactDetails contactDetails = new ContactDetails();//aca llamamos el otro forms como una clase
            contactDetails.ShowDialog();//para abrir el formulario por encima del main
        }
        #endregion

       
    }
}
