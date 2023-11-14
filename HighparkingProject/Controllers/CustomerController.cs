using HighparkingProject.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HighparkingProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly DataContext _context;
        private static List<Customers> customer = new List<Customers> { new Customers { Id="9876543",Name="Adam" ,Phon="055", Mail ="",Code=122, Credit ="", Bit ="654",Kind=Status.Regular, Point =0} };
       
        public CustomerController(DataContext context)
        {
            _context=context; 

        }

        static int counter = 1;
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Customers> Get()
        {
            return _context.ListCustomer;
        }

        // GET api/<ValuesController>/5
       [HttpGet("{id}")]
       public ActionResult<Customers> Get(int id)
       {
            // return "value";
            var cust = _context.ListCustomer.Find((x => x.Id.Equals(id))) ;
            if(cust == null)
            {
                return NotFound();
            }
            return Ok(cust);    
        }

        // POST api/<ValuesController>
        [HttpPost]
       
        public void Post([FromBody] Customers c)
        {
            customer.Add(new Customers {Id =c.Id, Name=c.Name,Phon=c.Phon,Mail=c.Mail,Code=c.Code,Credit=c.Credit, Bit =c.Bit, Kind = c.Kind, Point =c.Point });
            counter++;

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
        public void Delete(int id)
        {
            Customers c = customer.Find(eve => eve.Id.Equals(id));
            if(c != null) {
            customer.Remove(c);
            counter--;
            }
            
        }
    }
}
