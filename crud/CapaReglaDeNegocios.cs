using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud
{
    public class CapaReglaDeNegocios
    {

        private CapaDeAccesoDatos _CapaDeAccesoDatos;

        public CapaReglaDeNegocios()
        {
            _CapaDeAccesoDatos = new CapaDeAccesoDatos();
        }
        public Contactos guadarContacto(Contactos contactos)
        {
            if(contactos.id == 0)
            {
                _CapaDeAccesoDatos.ingresarContacto(contactos);
            }
            //else
            //{
              //  _CapaDeAccesoDatos.actualizarContacto(contactos);
            //}
            return contactos;
        }
    }
}
