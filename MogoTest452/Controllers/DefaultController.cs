using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MongoDB.Driver;

namespace MogoTest452.Controllers
{
    public class DefaultController : ApiController
    {
        private const string connectionString = "mongodb://nems:123456@10.201.60.204";
        private IMongoClient _mongoClient;
        public DefaultController()
        {
        }

        [Route("api/default/dowork")]
        [HttpGet]
        public IHttpActionResult DoWork()
        {
            try
            {
                _mongoClient = new MongoClient(connectionString);
                return Ok("ok");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
