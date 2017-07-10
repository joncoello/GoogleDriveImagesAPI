using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GoogleDriveImagesAPI.Controllers
{
    [RoutePrefix("api/pictures")]
    public class PicturesController : ApiController
    {

        [Route("")]
        public string Get() {
            return "hello world";
        }

    }
}
