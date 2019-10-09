using api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Entities_POJO;
using Testing;
using Exceptions;

namespace api.Controllers
{
    public class CuentasController : ApiController
    {

        ApiResponse apiResp = new ApiResponse();

        // GET api/cliente
        // Retrieve
        public IHttpActionResult Get()
        {

            apiResp = new ApiResponse();
            var mng = new CuentasManager();
            apiResp.Data = mng.RetrieveAll();

            return Ok(apiResp);
        }

        // GET api/cliente/5
        // Retrieve by id
        public IHttpActionResult Get(string id)
        {
            try
            {
                var mng = new CuentasManager();
                var cliente = new Cuentas(id);

                cliente = mng.RetrieveById(cliente);
                apiResp = new ApiResponse();
                apiResp.Data = cliente;
                return Ok(apiResp);
            }
            catch (BussinessException bex)
            {
                return InternalServerError(new Exception(bex.ExceptionId + "-" + bex.AppMessage.Message));
            }
        }

        // POST api/cliente
        // CREATE
        public IHttpActionResult Post(Cuentas cliente)
        {

            try
            {
                var mng = new CuentasManager();
                mng.Create(cliente);

                apiResp = new ApiResponse();
                apiResp.Message = "Action was executed.";

                return Ok(apiResp);
            }
            catch (BussinessException bex)
            {
                return InternalServerError(new Exception(bex.ExceptionId + "-"
                    + bex.AppMessage.Message));
            }
        }

        // PUT
        // UPDATE
        public IHttpActionResult Put(Cuentas cliente)
        {
            try
            {
                var mng = new CuentasManager();
                mng.Update(cliente);

                apiResp = new ApiResponse();
                apiResp.Message = "Action was executed.";

                return Ok(apiResp);
            }
            catch (BussinessException bex)
            {
                return InternalServerError(new Exception(bex.ExceptionId + "-" + bex.AppMessage.Message));
            }
        }

        // DELETE ==
        public IHttpActionResult Delete(string id)
        {
            try
            {
                var mng = new CuentasManager();
                var cliente = new Cuentas(id);
                mng.Delete(cliente);

                apiResp = new ApiResponse();
                apiResp.Message = "Action was executed.";

                return Ok(apiResp);
            }
            catch (BussinessException bex)
            {
                return InternalServerError(new Exception(bex.ExceptionId + "-" + bex.AppMessage.Message));
            }
        }
    }
}
