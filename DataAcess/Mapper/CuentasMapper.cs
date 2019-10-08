using DataAcess.Dao;
using Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAcess.Mapper
{
    public class CuentasMapper: EntityMapper, ISqlStaments
    {
        private const string DB_COL_NOMBRE = "NOMBRE";
        private const string DB_COL_MONEDA = "MONEDA";
        private const string DB_COL_SALDO = "Saldo";

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_CUENTA_PR" };

            var c = (Cuentas)entity;
            operation.AddVarcharParam(DB_COL_NOMBRE, c.Nombre);
            operation.AddVarcharParam(DB_COL_MONEDA, c.Moneda);
            operation.AddDoubleParam(DB_COL_SALDO, c.Saldo);


            return operation;
        }


        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_CUENTAS_PR" };

            var c = (Cuentas)entity;
            operation.AddVarcharParam(DB_COL_NOMBRE, c.Nombre);

            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_CUENTAS_PR" };
            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_CUENTA_PR" };

            var c = (Cuentas)entity;
            operation.AddVarcharParam(DB_COL_NOMBRE, c.Nombre);
            operation.AddVarcharParam(DB_COL_MONEDA, c.Moneda);
            operation.AddDoubleParam(DB_COL_SALDO, c.Saldo);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_CUENTAS_PR" };

            var c = (Cuentas)entity;
            operation.AddVarcharParam(DB_COL_NOMBRE, c.Nombre);
            return operation;
        }

        public List<Cuentas> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<Cuentas>();

            foreach (var row in lstRows)
            {
                var cuenta = BuildObject(row);
                lstResults.Add(cuenta);
            }

            return lstResults;
        }

        public Cuentas BuildObject(Dictionary<string, object> row)
        {
            string p1 = GetStringValue(row, DB_COL_NOMBRE);
            string p2 = GetStringValue(row, DB_COL_MONEDA);
            double p3 = GetDoubleValue(row, DB_COL_SALDO);
            
            var cuenta = new Cuentas(p1,p2,p3);

            return cuenta;
        }

    }
}
