using Entities_POJO;
using DataAcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class DireccionesManager
    {
        private DataAcess.Crud.CrudLauncher crud;

        private DataAcess.Mapper.DireccionesMapper mapDirecciones;

        public DireccionesManager()
        {
            crud = new DataAcess.Crud.CrudLauncher();
            mapDirecciones = new DataAcess.Mapper.DireccionesMapper();
        }

        public void Create(Direcciones direcciones)
        {

            crud.Create(mapDirecciones.GetCreateStatement(direcciones));

        }


        public List<Direcciones> RetrieveAll()
        {

            return mapDirecciones.BuildObjects(crud.RetrieveAll(mapDirecciones.GetRetriveAllStatement()));
        }

        public Direcciones RetrieveById(Direcciones direcciones)
        {
            return mapDirecciones.BuildObject(crud.Retrieve(mapDirecciones.GetRetriveStatement(direcciones)));
        }

        public void Update(Direcciones direcciones)
        {
            crud.Update(mapDirecciones.GetUpdateStatement(direcciones));
        }

        public void Delete(Direcciones direcciones)
        {
            crud.Delete(mapDirecciones.GetDeleteStatement(direcciones));
        }
    }
}
