using DataAcess.Dao;
using Entities_POJO;
using System.Collections.Generic;

namespace DataAcess.Mapper
{
    public class CreditosMapper : EntityMapper, ISqlStaments
    {
        private const string DB_COL_CEDULA = "Monto";
        private const string DB_COL_TASA = "Tasa";
        private const string DB_COL_NOMBRE = "Nombre";
        private const string DB_COL_Cuota = "Cuota";
        private const string DB_COL_FECHA_INICIO = "Fecha_Inicio";
        private const string DB_COL_ESTADO = "Estado";
        private const string DB_COL_SALDO_OPERACION = "Saldo_Operacion";


        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_CREDITOS_PR" };

            var c = (Creditos)entity;
            operation.AddDoubleParam(DB_COL_CEDULA, c.Monto);            
            operation.AddDoubleParam(DB_COL_TASA, c.Tasa);
            operation.AddVarcharParam(DB_COL_NOMBRE, c.Nombre);
            operation.AddDoubleParam(DB_COL_Cuota, c.Cuota);
            operation.AddVarcharParam(DB_COL_FECHA_INICIO, c.FechaInicio);
            operation.AddVarcharParam(DB_COL_ESTADO, c.Estado);
            operation.AddDoubleParam(DB_COL_SALDO_OPERACION, c.SaldoOperacion);

            return operation;
        }


        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_CREDITOS_PR" };

            var c = (Creditos)entity;
            operation.AddVarcharParam(DB_COL_NOMBRE, c.Nombre);

            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_CREDITOS_PR" };
            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_CREDITOS_PR" };

            var c = (Creditos)entity;
            operation.AddDoubleParam(DB_COL_CEDULA, c.Monto);            
            operation.AddDoubleParam(DB_COL_TASA, c.Tasa);
            operation.AddVarcharParam(DB_COL_NOMBRE, c.Nombre);
            operation.AddDoubleParam(DB_COL_Cuota, c.Cuota);
            operation.AddVarcharParam(DB_COL_FECHA_INICIO, c.FechaInicio);
            operation.AddVarcharParam(DB_COL_ESTADO, c.Estado);
            operation.AddDoubleParam(DB_COL_SALDO_OPERACION, c.SaldoOperacion);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_CREDITOS_PR" };

            var c = (Creditos)entity;
            operation.AddVarcharParam(DB_COL_NOMBRE, c.Nombre);
            return operation;
        }

        public List<Creditos> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<Creditos>();

            foreach (var row in lstRows)
            {
                var credito = BuildObject(row);
                lstResults.Add(credito);
            }

            return lstResults;
        }

        public Creditos BuildObject(Dictionary<string, object> row)
        {

            double p1 = GetDoubleValue(row, DB_COL_CEDULA);
            double p2 = GetDoubleValue(row, DB_COL_TASA);
            string p3 = GetStringValue(row, DB_COL_NOMBRE);
            double p4 = GetDoubleValue(row, DB_COL_Cuota);
            string p5 = GetStringValue(row, DB_COL_FECHA_INICIO);
            string p6 = GetStringValue(row, DB_COL_ESTADO);
            double p7 = GetDoubleValue(row, DB_COL_SALDO_OPERACION);

            var credito = new Creditos(p1,p2,p3,p4,p5,p6,p7);

            return credito;
        }

    }
}
