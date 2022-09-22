using CustomerApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        CustomerDbContext db = new CustomerDbContext();
        [HttpGet]
        public IEnumerable<Customertbl> get()
        {
            return db.Customertbls;
        }
        [HttpPost]
        public IActionResult post(Customertbl customer)
        {
            db.Customertbls.Add(customer);
            db.SaveChanges();
            return Ok(new { status = "your record is added suceessfully" });
        }
        [HttpPut]
        public IActionResult put(Customertbl customer)
        {
            db.Customertbls.Update(customer);
            db.SaveChanges();
            return Ok(new { status = "your record is updated suceessfully" });
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var customer = db.Customertbls.Where(x => x.Id == id).FirstOrDefault();
            db.Customertbls.Remove(customer);
            db.SaveChanges();
            return Ok(new { status = "your record is deleted suceessfully" });
        }
    }
}
