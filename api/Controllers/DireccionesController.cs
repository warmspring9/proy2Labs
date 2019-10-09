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
    public class DireccionesController : ApiController
    {

        ApiResponse apiResp = new ApiResponse();

        // GET api/cliente
        // Retrieve
        public IHttpActionResult Get()
        {

            apiResp = new ApiResponse();
            var mng = new DireccionesManager();
            apiResp.Data = mng.RetrieveAll();

            return Ok(apiResp);
        }

        // GET api/cliente/5
        // Retrieve by id
        public IHttpActionResult Get(string id)
        {
            try
            {
                var mng = new DireccionesManager();
                var cliente = new Direcciones(id);

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
        public IHttpActionResult Post(Direcciones direcciones)
        {

            try
            {
                var mng = new DireccionesManager();
                mng.Create(direcciones);

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
        public IHttpActionResult Put(Direcciones cliente)
        {
            try
            {
                var mng = new DireccionesManager();
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
                var mng = new DireccionesManager();
                var direcciones = new Direcciones(id);
                mng.Delete(direcciones);

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
