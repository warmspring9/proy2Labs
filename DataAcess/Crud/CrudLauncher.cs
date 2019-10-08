using System;
using System.Collections.Generic;
using Entities_POJO;
using DataAcess.Mapper;
using DataAcess.Dao;

namespace DataAcess.Crud
{
    public class CrudLauncher
    {
        private SqlDao dao;

        public CrudLauncher() : base()
        {
            dao = SqlDao.GetInstance();
        }

        public void Create(SqlOperation sqlOperation)
        {
            dao.ExecuteProcedure(sqlOperation);
        }

      

        public Dictionary<string,Object> Retrieve(SqlOperation sqlOperation)
        {
            var lstResult = dao.ExecuteQueryProcedure(sqlOperation);
            var dic = new Dictionary<string, object>();
            dic = lstResult[0];
            /*if (lstResult.Count > 0)
            {
                dic = lstResult[0];
                var objs = mapper.BuildObject(dic);
                return (T)Convert.ChangeType(objs, typeof(T));
            }
            */
            Console.WriteLine(dic.ToString());
            return dic;
        }

        public List<Dictionary<string,object>> RetrieveAll(SqlOperation sqlOperation)
        {             
            var lstResult = dao.ExecuteQueryProcedure(sqlOperation);
            Console.WriteLine(lstResult.ToString());
            return lstResult;
        }

        public void Update(SqlOperation sqlOperation)
        {
            dao.ExecuteProcedure(sqlOperation);
        }

        public void Delete(SqlOperation sqlOperation)
        {
            dao.ExecuteProcedure(sqlOperation);
        }
    }
}
