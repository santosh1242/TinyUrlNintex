using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace TinyUrlConversationApp.Controllers
{
    [RoutePrefix("api/Url12")]
    public class Url12Controller : ApiController
    {
        [HttpPost]
        [Route("GetUrlDetails")]
        public string GetUrlDetails(string url)
        {
            return null;
        }
    }
}