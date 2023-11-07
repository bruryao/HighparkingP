using HighparkingProject.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HighparkingProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoicingController : ControllerBase
    {
        private static List<Invoicing> i = new List<Invoicing> { new Invoicing {Id="444" ,Enter= DateTime.Now, Exiting= DateTime.Now, Date= DateTime.Now, Payment=6.8,Dwell_time= DateTime.Now ,Kind=Status.premium} };
        // GET: api/<InvoicingController>
        static int counter = 1;
        [HttpGet]
        public IEnumerable<Invoicing> Get()
        {
            return i;
        }

        // GET api/<InvoicingController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<InvoicingController>
        [HttpPost]
        public void Post([FromBody] Invoicing c)
        {
            i.Add(new Invoicing {Id=c.Id,Enter=c.Enter,Exiting=c.Exiting,Date=c.Date,Payment=c.Payment,Dwell_time=c.Dwell_time,Kind=c.Kind });
            counter++;

        }
        

        // PUT api/<InvoicingController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Invoicing e)
        {
            Invoicing c = i.Find(x => x.Id.Equals(id));
            if (c != null)
            {
                c.Enter =e.Enter;
                c.Exiting = e.Exiting;
                c.Date =e.Date;
                c.Payment =e.Payment;
                c.Dwell_time = e.Dwell_time;
                
                c.Kind = e.Kind;
               

            }
        }

        // DELETE api/<InvoicingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Invoicing c = i.Find(eve => eve.Id.Equals(id));
            if (c != null)
            {
               i.Remove(c);
                counter--;
            }
        }
    }
}
