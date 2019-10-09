using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_POJO
{
    public class Direcciones : BaseEntity
    {
        public string Provincia { get; set; }
        public string Canton { get; set; }
        public string Distrito { get; set; }

        public Direcciones(string[] infoArray)
        {
            if (infoArray != null && infoArray.Length >= 3)
            {
                Provincia = infoArray[0];
                Canton = infoArray[1];
                Distrito = infoArray[2];
            }
            else
            {
                throw new Exception("All values are require[cedula,nombre,apellido,fecha de nacimiento, estado civil, genero]");
            }

        }
        public Direcciones(string Provincia)
        {
            this.Provincia = Provincia;
        }
        public Direcciones()
        {
        }
    }
}
