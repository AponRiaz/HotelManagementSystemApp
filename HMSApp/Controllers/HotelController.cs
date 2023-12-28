using BLL.DTOs;
using BLL.Services;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HMSApp.Controllers
{
    public class HotelController : ApiController
    {
        [HttpGet]
        [Route("api/hotels/all")]
        public HttpResponseMessage Hotels()
        {
            try
            {
                var data = HotelService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }

            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/hotels/{id}")]
        public HttpResponseMessage Get(int id)
        {

            try
            {
                var data = HotelService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }

            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

       



    }
}