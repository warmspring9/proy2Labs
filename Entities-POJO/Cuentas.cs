using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_POJO
{
    public class Cuentas : BaseEntity
    {
        public string Nombre { get; set; }
        public string Moneda { get; set; }
        public float Saldo { get; set; }

        public Cuentas(string[] infoArray)
        {
            if (infoArray != null && infoArray.Length >= 3)
            {
                Nombre = infoArray[0];
                Moneda = infoArray[1];
                try
                {
                    Saldo = Convert.ToSingle(infoArray[2]);
                }
                catch (Exception e){
                    throw new Exception("El saldo debe ser un numero");
                }
            }
            else
            {
                throw new Exception("All values are require[nombre, moneda, saldo]");
            }
        }
        public Cuentas(string pNombre, string pMoneda, double pSaldo)
        {
            Nombre = pNombre;
            Moneda = pMoneda;
            try
            {
                Saldo = Convert.ToSingle(pSaldo);
            }
            catch (Exception e)
            {
                throw new Exception("El saldo debe ser un numero");
            }

        }
        public Cuentas(string nombre)
        {
            Nombre = nombre;
        }

        public Cuentas()
        {
            //Nombre = nombre;
        }
    }
}
