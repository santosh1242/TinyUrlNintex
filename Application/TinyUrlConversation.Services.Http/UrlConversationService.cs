using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace TinyUrlConversation.Services.Http
{
    [RoutePrefix("api/UrlConversation")]
    public class UrlConversationService : ApiController
    {

        [HttpGet]
        [Route("ConvertMainUrlToTinyUrl")]
        public string ConvertMainUrlToTinyUrl(string urlvalue)
        {
            try
            {
                return "output from UrlConversation";
            }
            catch (Exception ex)
            {
                // Repack to Http error.
                var httpError = new HttpResponseMessage()
                {
                    StatusCode = (HttpStatusCode)422,
                    ReasonPhrase = ex.Message
                };

                throw new HttpResponseException(httpError);
            }
        }

    }
}
