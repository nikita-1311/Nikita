using Ecommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        EcommerceContext db = new EcommerceContext();
        [HttpPost]
        public IActionResult post(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return Ok(new { status = "your record is added suceessfully" });
        }
        [HttpPut]
        public IActionResult put(Product product)
        {
            db.Products.Update(product);
            db.SaveChanges();
            return Ok(new { status = "your record is updated suceessfully" });
        }
        [HttpDelete]
        public IActionResult Delete(int pid)
        {
            var product = db.Products.Where(y => y.Pid == pid).FirstOrDefault();
            db.Products.Remove(product);
            db.SaveChanges();
            return Ok(new { ststus = "your record is deleted suceessfully" });
        }
        [HttpGet]
        public IEnumerable<Product> get()
        {
            return db.Products;
        }
    }
}
