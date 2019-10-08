using Entities_POJO;
using DataAcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class ClienteManager
    {
        private DataAcess.Crud.CrudLauncher crud;

        private DataAcess.Mapper.ClienteMapper mapCliente;

    public ClienteManager()
    {
        crud = new DataAcess.Crud.CrudLauncher();
        mapCliente = new DataAcess.Mapper.ClienteMapper();
    }

    public void Create(Cliente cliente)
    {

        crud.Create(mapCliente.GetCreateStatement(cliente));

    }


    public List<Cliente> RetrieveAll()
    {
            
            return mapCliente.BuildObjects(crud.RetrieveAll(mapCliente.GetRetriveAllStatement()));
    }

    public Cliente RetrieveById(Cliente cliente)
    {
        return mapCliente.BuildObject(crud.Retrieve(mapCliente.GetRetriveStatement(cliente)));
    }

    public void Update(Cliente cliente)
    {
        crud.Update(mapCliente.GetUpdateStatement(cliente));
    }

    public void Delete(Cliente cliente)
    {
        crud.Delete(mapCliente.GetDeleteStatement(cliente));
    }
}
}
