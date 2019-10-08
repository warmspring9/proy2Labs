using Entities_POJO;
using DataAcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class CuentasManager
    {
        private DataAcess.Crud.CrudLauncher crud;

        private DataAcess.Mapper.CuentasMapper mapCuentas;

        public CuentasManager()
        {
            crud = new DataAcess.Crud.CrudLauncher();
            mapCuentas = new DataAcess.Mapper.CuentasMapper();
        }

        public void Create(Cuentas cuentas)
        {

            crud.Create(mapCuentas.GetCreateStatement(cuentas));

        }


        public List<Cuentas> RetrieveAll()
        {

            return mapCuentas.BuildObjects(crud.RetrieveAll(mapCuentas.GetRetriveAllStatement()));
        }

        public Cuentas RetrieveById(Cuentas cuentas)
        {
            return mapCuentas.BuildObject(crud.Retrieve(mapCuentas.GetRetriveStatement(cuentas)));
        }

        public void Update(Cuentas cuentas)
        {
            crud.Update(mapCuentas.GetUpdateStatement(cuentas));
        }

        public void Delete(Cuentas cuentas)
        {
            crud.Delete(mapCuentas.GetDeleteStatement(cuentas));
        }
    }
}
