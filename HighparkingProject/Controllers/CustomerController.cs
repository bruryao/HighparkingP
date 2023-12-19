using Soild.core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Xml.Linq;
using Soild.data;
using Soild.srvice;
using Soild.core.Service;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HighparkingProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
       // private readonly Idatacontext _context;
        private readonly ICustumerservice userService;
        private static List<Customers> customer = new List<Customers> { new Customers { Id = "987654", Name = "Adam", Phon = "055", Mail = "", Code = 122, Credit = "", Bit = "654", Kind = Status.Regular, Point = 0 } };
        static int counter = 1;
        public CustomerController(ICustumerservice user)
        {
            userService = user;

        }


        // GET: api/<ValuesController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(userService.GetAllCustomers());
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
       public ActionResult<Customers> Get(string id)
       {
            //.ListCustomer.Find(x => x.Id==(id));
            // return "value";
            var cust =userService.GetIdCustomers(id);
            if (cust == null)
            {
                return NotFound();
            }
            return Ok(cust);    
        }

        // POST api/<ValuesController>
        [HttpPost]
       
        public ActionResult  Post([FromBody] Customers c)
        {
            if (c.Id.ToString().Length != 9)
            {
                return BadRequest();
            }
            customer.Add(new Customers {Id =c.Id, Name=c.Name,Phon=c.Phon,Mail=c.Mail,Code=c.Code,Credit=c.Credit, Bit =c.Bit, Kind = c.Kind, Point =c.Point });
            counter++;
            return Ok();

        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customers eve)
        {
            Customers c = customer.Find(x => x.Id .Equals(id));
            if (c != null)
            {
                c.Name = eve.Name;
                c.Phon = eve.Phon;
                c.Mail = eve.Mail;
                c.Code = eve.Code;
                c.Credit = eve.Credit;
                c.Bit = eve.Bit;
                c.Kind = eve.Kind;  
                c.Point = eve.Point;
               
            }
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            Customers c = customer.Find(eve => eve.Id.Equals(id));
            if(c != null) {
            customer.Remove(c);
            counter--;
            }
            
        }
    }

    
}
