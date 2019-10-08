using Entities_POJO;
using DataAcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class CreditosManager
    {
        private DataAcess.Crud.CrudLauncher crud;

        private DataAcess.Mapper.CreditosMapper mapCreditos;

        public CreditosManager()
        {
            crud = new DataAcess.Crud.CrudLauncher();
            mapCreditos = new DataAcess.Mapper.CreditosMapper();
        }

        public void Create(Creditos creditos)
        {

            crud.Create(mapCreditos.GetCreateStatement(creditos));

        }


        public List<Creditos> RetrieveAll()
        {

            return mapCreditos.BuildObjects(crud.RetrieveAll(mapCreditos.GetRetriveAllStatement()));
        }

        public Creditos RetrieveById(Creditos creditos)
        {
            return mapCreditos.BuildObject(crud.Retrieve(mapCreditos.GetRetriveStatement(creditos)));
        }

        public void Update(Creditos creditos)
        {
            crud.Update(mapCreditos.GetUpdateStatement(creditos));
        }

        public void Delete(Creditos creditos)
        {
            crud.Delete(mapCreditos.GetDeleteStatement(creditos));
        }
    }
}
