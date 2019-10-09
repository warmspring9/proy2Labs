using api.Models;
using Entities_POJO;
using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Testing;

namespace api.Controllers
{
    public class CreditosController : ApiController
    {

        ApiResponse apiResp = new ApiResponse();

        // GET api/cliente
        // Retrieve
        public IHttpActionResult Get()
        {

            apiResp = new ApiResponse();
            var mng = new CreditosManager();
            apiResp.Data = mng.RetrieveAll();

            return Ok(apiResp);
        }

        // GET api/cliente/5
        // Retrieve by id
        public IHttpActionResult Get(string id)
        {
            try
            {
                var mng = new CreditosManager();
                var cliente = new Creditos(id);

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
        public IHttpActionResult Post(Creditos creditos)
        {

            try
            {
                var mng = new CreditosManager();
                mng.Create(creditos);

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
        public IHttpActionResult Put(Creditos cliente)
        {
            try
            {
                var mng = new CreditosManager();
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
                var mng = new CreditosManager();
                var cliente = new Creditos(id);
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