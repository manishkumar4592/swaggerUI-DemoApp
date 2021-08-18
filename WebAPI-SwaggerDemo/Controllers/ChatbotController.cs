using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_SwaggerDemo.Controllers
{
    public class ChatbotController : ApiController
    {
        // GET: api/Chatbot
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Chatbot/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Chatbot
        public dynamic Post([FromBody]string value)
        {
            return new Employee
            {
                EmployeeId = 1,
                FirstName = "Manish",
                LastName = "Kumar",
                City = "Jaipur",
                ZipCoe = "302004"
            };
        }

        // PUT: api/Chatbot/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Chatbot/5
        public void Delete(int id)
        {
        }

        #region ///   Classes   ///
        public class Employee
        {
            public int EmployeeId { get; set; }

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string City { get; set; }

            public string ZipCoe { get; set; }

        }
        #endregion

    }
}
