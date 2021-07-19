using API.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace API.Controllers
{
    public class FormData : ApiController
    {
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/FormData/SaveFormData")]
        public HttpResponseMessage SaveFormData(FormDataViewModel Model)
        {
            // serialize JSON to a string and then write string to a file
            if (Model.FirstName!="" && Model.LastName!="" && Model.DateOfBirth!=null)
            {
                System.IO.File.WriteAllText(System.Web.Hosting.HostingEnvironment.MapPath("~/Files/FormData.json"), JsonConvert.SerializeObject(Model));
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NoContent);
            }
           
        }

    }
}
