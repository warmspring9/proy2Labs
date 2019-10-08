using DataAcess.Dao;
using Entities_POJO;
using System.Collections.Generic;

namespace DataAcess.Mapper
{
    public class ClienteMapper : EntityMapper, ISqlStaments
    {
        private const string DB_COL_CEDULA = "Cedula";
        private const string DB_COL_NOMBRE = "Nombre";
        private const string DB_COL_LAST_APELLIDO = "Apellido";
        private const string DB_COL_FECHA_NACIMIENTO = "Fecha_nacimiento";
        private const string DB_COL_LAST_ESTADOCIV = "estado_civil";
        private const string DB_COL_GENERO = "genero";


        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_CLIENTE_PR" };

            var c = (Cliente)entity;
            operation.AddVarcharParam(DB_COL_CEDULA, c.Cedula);
            operation.AddVarcharParam(DB_COL_NOMBRE, c.Nombre);
            operation.AddVarcharParam(DB_COL_LAST_APELLIDO, c.Apellido);
            operation.AddVarcharParam(DB_COL_FECHA_NACIMIENTO, c.FechaNacimiento);
            operation.AddVarcharParam(DB_COL_LAST_ESTADOCIV, c.EstadoCivil);
            operation.AddVarcharParam(DB_COL_GENERO, c.Genero);

            return operation;
        }


        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_CLIENTE_PR" };

            var c = (Cliente)entity;
            operation.AddVarcharParam(DB_COL_CEDULA, c.Cedula);

            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_CLIENTE_PR" };
            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_CLIENTE_PR" };

            var c = (Cliente)entity;
            operation.AddVarcharParam(DB_COL_CEDULA, c.Cedula);
            operation.AddVarcharParam(DB_COL_NOMBRE, c.Nombre);
            operation.AddVarcharParam(DB_COL_LAST_APELLIDO, c.Apellido);
            operation.AddVarcharParam(DB_COL_FECHA_NACIMIENTO, c.FechaNacimiento);
            operation.AddVarcharParam(DB_COL_LAST_ESTADOCIV, c.EstadoCivil);
            operation.AddVarcharParam(DB_COL_GENERO, c.Genero);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_CLIENTE_PR" };

            var c = (Cliente)entity;
            operation.AddVarcharParam(DB_COL_CEDULA, c.Cedula);
            return operation;
        }

        public List<Cliente> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<Cliente>();

            foreach (var row in lstRows)
            {
                var cliente = BuildObject(row);
                lstResults.Add(cliente);
            }

            return lstResults;
        }

        public Cliente BuildObject(Dictionary<string, object> row)
        {
            var infoArray = new string[6];

            infoArray[0] = GetStringValue(row, DB_COL_CEDULA);
            infoArray[1] = GetStringValue(row, DB_COL_NOMBRE);
            infoArray[2] = GetStringValue(row, DB_COL_LAST_APELLIDO);
            infoArray[3] = GetStringValue(row, DB_COL_FECHA_NACIMIENTO);
            infoArray[4] = GetStringValue(row, DB_COL_LAST_ESTADOCIV);
            infoArray[5] = GetStringValue(row, DB_COL_GENERO);

            var cliente = new Cliente(infoArray);

            return cliente;
        }

    }
}
