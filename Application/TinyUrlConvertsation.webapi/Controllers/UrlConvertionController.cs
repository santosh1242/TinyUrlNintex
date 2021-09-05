using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TinyUrlConvertsation.webapi.Controllers
{
    public class UrlConvertionController : ApiController
    {
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