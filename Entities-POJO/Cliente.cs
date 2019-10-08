using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_POJO
{
    

    public class Cliente : BaseEntity
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string FechaNacimiento { get; set; }
        public string EstadoCivil { get; set; }
        public string Genero { get; set; }

        public Cliente(string[] infoArray)
        {
            if (infoArray != null && infoArray.Length >= 6)
            {
                Cedula = infoArray[0];
                Nombre = infoArray[1];
                Apellido = infoArray[2];
                FechaNacimiento = infoArray[3];
                EstadoCivil = infoArray[4];
                Genero = infoArray[5];
            }
            else
            {
                throw new Exception("All values are require[cedula,nombre,apellido,fecha de nacimiento, estado civil, genero]");
            }

        }
        public Cliente(string id)
        {
            Cedula = id;
        }
        public int getAge()
        {
            //not implemented
            return 0;
        }

    }
}

