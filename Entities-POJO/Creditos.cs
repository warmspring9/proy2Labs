using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_POJO
{
    public class Creditos : BaseEntity
    {
        public Double Monto { get; set; }
        public Double Tasa { get; set; }
        public string Nombre { get; set; }
        public Double Cuota { get; set; }
        public string FechaInicio { get; set; }
        public string Estado { get; set; }
        public Double SaldoOperacion { get; set; }

        public Creditos(string[] infoArray)
        {
            if (infoArray != null && infoArray.Length >= 7)
            {
                try
                {
                    Monto = Convert.ToDouble(infoArray[0]);
                }
                catch (Exception e)
                {
                    throw new Exception("El monto debe ser un numero");
                }
                try
                {
                    Tasa = Convert.ToDouble(infoArray[1]);
                }
                catch (Exception e)
                {
                    throw new Exception("El tasa debe ser un numero");
                }
                Nombre = infoArray[2];
                try
                {
                    Cuota = Convert.ToDouble(infoArray[3]);
                }
                catch (Exception e)
                {
                    throw new Exception("La cuota debe ser un numero");
                }
                FechaInicio = infoArray[4];
                Estado = infoArray[5];
                try
                {
                    SaldoOperacion = Convert.ToDouble(infoArray[6]);
                }
                catch (Exception e)
                {
                    throw new Exception("El saldo de operacion debe ser un numero");
                }



            }
            else
            {
                throw new Exception("All values are require[monto,tasa,nombre,cuota, fecha de inicio, estado, saldo de operacion]");
            }
        }
        public Creditos(double pMonto, double pTasa, string pNombre,double pCuota, string pFecha_inicio, string pEstado, double pSaldoOperacion)
        {
                try
                {
                    Monto = Convert.ToDouble(pMonto);
                }
                catch (Exception e)
                {
                    throw new Exception("El monto debe ser un numero");
                }
                try
                {
                    Tasa = Convert.ToDouble(pTasa);
                }
                catch (Exception e)
                {
                    throw new Exception("El tasa debe ser un numero");
                }
                Nombre = pNombre;
                try
                {
                    Cuota = Convert.ToDouble(pCuota);
                }
                catch (Exception e)
                {
                    throw new Exception("La cuota debe ser un numero");
                }
                FechaInicio = pFecha_inicio;
                Estado = pEstado;
                try
                {
                    SaldoOperacion = Convert.ToDouble(pSaldoOperacion);
                }
                catch (Exception e)
                {
                    throw new Exception("El saldo de operacion debe ser un numero");
                }
        }
        public Creditos(string nombre)
        {
            Nombre = nombre;
        }

        public Creditos()
        {
           
        }
    }

}
