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
    }
}
