using Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class Controller
    {
        public Controller() { 
            Console.WriteLine("hola");
        }

        public static void Delete(string op, string id)
        {

            switch (op)
            {
                case "a":
                    ClienteManager clientMng = new ClienteManager();
                    Cliente cl = new Cliente(id);
                    cl = clientMng.RetrieveById(cl);
                    if (cl != null)
                    {
                        clientMng.Delete(cl);
                    }
                    break;
                case "b":

                    CuentasManager cuentasMng = new CuentasManager();
                    Cuentas cu = new Cuentas(id);
                    cu = cuentasMng.RetrieveById(cu);
                    if (cu != null)
                    {

                        cuentasMng.Delete(cu);
                    }
                    break;
                case "c":
                    CreditosManager creditosMng = new CreditosManager();
                    Creditos cr = new Creditos(id);
                    cr = creditosMng.RetrieveById(cr);
                    if (cr != null)
                    {
                        creditosMng.Delete(cr);
                    }
                    break;
                case "d":
                    DireccionesManager direcMng = new DireccionesManager();
                    Direcciones di = new Direcciones(id);
                    di = direcMng.RetrieveById(di);
                    if (di != null)
                    {
                        direcMng.Delete(di);
                    }
                    break;
            }


        }
        public static void update(string op, String[] values)
        {

            switch (op)
            {
                case "a":
                    ClienteManager clientMng = new ClienteManager();
                    Cliente cl = new Cliente(values[0]);
                    cl = clientMng.RetrieveById(cl);
                    if (cl != null)
                    {
                        cl.Nombre = values[1];
                        cl.Apellido = values[2];
                        cl.FechaNacimiento = values[3];
                        cl.EstadoCivil = values[4];
                        cl.Genero = values[5];

                        clientMng.Update(cl);
                        Console.WriteLine("client was updated");
                    }
                    else
                    {
                        throw new Exception("client not registered");
                    }
                    break;
                case "b":

                    CuentasManager cuentasMng = new CuentasManager();
                    Cuentas cu = new Cuentas(values[0]);
                    cu = cuentasMng.RetrieveById(cu);
                    if (cu != null)
                    {

                        cu.Moneda = values[1];
                        cu.Saldo = float.Parse(values[2]);

                        cuentasMng.Update(cu);
                        Console.WriteLine("account was updated");
                    }
                    else
                    {
                        throw new Exception("account not registered");
                    }
                    break;
                case "c":
                    CreditosManager creditosMng = new CreditosManager();
                    Creditos cr = new Creditos(values[0]);
                    cr = creditosMng.RetrieveById(cr);
                    if (cr != null)
                    {
                        cr.Monto = Double.Parse(values[1]);
                        cr.Tasa = Double.Parse(values[2]);
                        cr.Cuota = Double.Parse(values[3]);
                        cr.FechaInicio = values[4];
                        cr.Estado = values[5];
                        cr.SaldoOperacion = Double.Parse(values[6]);

                        creditosMng.Update(cr);
                        Console.WriteLine("Credit was updated");
                    }
                    else
                    {
                        throw new Exception("Credit not registered");
                    }
                    break;
                case "d":
                    DireccionesManager direcMng = new DireccionesManager();
                    Direcciones di = new Direcciones(values[0]);
                    di = direcMng.RetrieveById(di);
                    if (di != null)
                    {
                        di.Canton = values[1];
                        di.Distrito = values[2];

                        direcMng.Update(di);
                        Console.WriteLine("Direction was updated");
                    }
                    else
                    {
                        throw new Exception("direction not registered");
                    }
                    break;
            }
        }

        public static string Retrive(string op, string id)
        {

            switch (op)
            {
                case "a":
                    ClienteManager clientMng = new ClienteManager();
                    Cliente cl = new Cliente(id);
                    cl = clientMng.RetrieveById(cl);
                    if (cl != null)
                    {

                        return cl.GetEntityInformation();
                    }
                    break;
                case "b":

                    CuentasManager cuentasMng = new CuentasManager();
                    Cuentas cu = new Cuentas(id);
                    cu = cuentasMng.RetrieveById(cu);
                    if (cu != null)
                    {

                        return cu.GetEntityInformation();
                    }
                    break;
                case "c":
                    CreditosManager creditosMng = new CreditosManager();
                    Creditos cr = new Creditos(id);
                    cr = creditosMng.RetrieveById(cr);
                    if (cr != null)
                    {

                        return cr.GetEntityInformation();
                    }
                    break;
                case "d":
                    DireccionesManager direcMng = new DireccionesManager();
                    Direcciones di = new Direcciones(id);
                    di = direcMng.RetrieveById(di);
                    if (di != null)
                    {

                        return di.GetEntityInformation();
                    }
                    break;
            }
            return "Not found";


        }

        public static string[] RetrieveAll(string op)
        {
            List<String> res = new List<string>();
            switch (op)
            {

                case "a":
                    ClienteManager clientMng = new ClienteManager();
                    foreach (var c in clientMng.RetrieveAll())
                    {
                        res.Add(c.GetEntityInformation());
                    }
                    break;
                case "b":

                    CuentasManager cuentasMng = new CuentasManager();
                    foreach (var c in cuentasMng.RetrieveAll())
                    {
                        res.Add(c.GetEntityInformation());
                    }
                    break;
                case "c":
                    CreditosManager creditosMng = new CreditosManager();
                    foreach (var c in creditosMng.RetrieveAll())
                    {
                        res.Add(c.GetEntityInformation());
                    }
                    break;
                case "d":
                    DireccionesManager direcMng = new DireccionesManager();
                    foreach (var c in direcMng.RetrieveAll())
                    {
                        res.Add(c.GetEntityInformation());
                    }
                    break;
            }
            return res.ToArray();


        }

        public static string GetOption()
        {
            string option;
            Console.WriteLine("Select an object");
            Console.WriteLine("a) Customer");
            Console.WriteLine("b) Accounts");
            Console.WriteLine("c) Credits");
            Console.WriteLine("d) Directions");
            option = Console.ReadLine();
            option.ToLower();
            option.Trim();
            if ("abcd".Contains(option) && option.Length == 1)
            {
                return option;
            }
            else
            {
                throw new Exception("Valor invalido");
            }

        }

        public static void Create(String op, String[] values)
        {
            switch (op)
            {
                case "a":
                    ClienteManager clientMng = new ClienteManager();
                    Cliente cl = new Cliente(values);
                    clientMng.Create(cl);
                    break;
                case "b":
                    CuentasManager cuentasMng = new CuentasManager();
                    Cuentas cu = new Cuentas(values);
                    cuentasMng.Create(cu);
                    break;
                case "c":
                    CreditosManager creditosMng = new CreditosManager();
                    Creditos cr = new Creditos(values);
                    creditosMng.Create(cr);
                    break;
                case "d":
                    DireccionesManager direcMng = new DireccionesManager();
                    Direcciones di = new Direcciones(values);
                    direcMng.Create(di);
                    break;
            }
        }
    }

}
