using Ecommerce.Models;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
    public class CategoryController : ControllerBase
    {
        EcommerceContext db = new EcommerceContext();
        //Enter data 
        [HttpPost]
        public IActionResult post(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
            return Ok(new { status = "your record is added suceessfully" });
        }
        //Update 
        [HttpPut]
        public IActionResult put(Category category)
        {
            db.Categories.Update(category);
            db.SaveChanges();
            return Ok(new { status = "your record is updated suceessfully" });
        }
        //Delete
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var category = db.Categories.Where(x => x.Cid == id).FirstOrDefault();
            db.Categories.Remove(category);
            db.SaveChanges();
            return Ok(new { ststus = "your record is deleted suceessfully" });
        }
        //Show
        [HttpGet]
        public IEnumerable<Category> get()
        {
            return db.Categories;
        }
    }
}
