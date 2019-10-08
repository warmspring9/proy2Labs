using DataAcess.Dao;
using Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Mapper
{
    public class DireccionesMapper : EntityMapper, ISqlStaments
    {
        private const string DB_COL_PROVINCIA = "Provincia";
        private const string DB_COL_CANTON = "Canton";
        private const string DB_COL_DISTRITO = "Distrito";

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_DIRECCIONES_PR" };

            var c = (Direcciones)entity;
            operation.AddVarcharParam(DB_COL_PROVINCIA, c.Provincia);
            operation.AddVarcharParam(DB_COL_CANTON, c.Canton);
            operation.AddVarcharParam(DB_COL_DISTRITO, c.Distrito);


            return operation;
        }


        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_DIRECCIONES_PR" };

            var c = (Direcciones)entity;
            operation.AddVarcharParam(DB_COL_PROVINCIA, c.Provincia);

            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_DIRECCIONES_PR" };
            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_DIRECCIONES_PR" };

            var c = (Direcciones)entity;
            operation.AddVarcharParam(DB_COL_PROVINCIA, c.Provincia);
            operation.AddVarcharParam(DB_COL_CANTON, c.Canton);
            operation.AddVarcharParam(DB_COL_DISTRITO, c.Distrito);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_DIRECCIONES_PR" };

            var c = (Direcciones)entity;
            operation.AddVarcharParam(DB_COL_PROVINCIA, c.Provincia);
            return operation;
        }

        public List<Direcciones> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<Direcciones>();

            foreach (var row in lstRows)
            {
                var cuenta = BuildObject(row);
                lstResults.Add(cuenta);
            }

            return lstResults;
        }

        public Direcciones BuildObject(Dictionary<string, object> row)
        {
            var infoArray = new string[6];

            infoArray[0] = GetStringValue(row, DB_COL_PROVINCIA);
            infoArray[1] = GetStringValue(row, DB_COL_CANTON);
            infoArray[2] = GetStringValue(row, DB_COL_DISTRITO);

            var cuenta = new Direcciones(infoArray);

            return cuenta;
        }

    }
}
