using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestAPIDemo2.Models;

namespace RestAPIDemo2.Controllers
{
    public class MenuCategoryController : ApiController
    {
        MenuContext db = new MenuContext();
        // GET api/<controller>
        public IEnumerable<menu_category> Get()
        {
            return db.menu_category.AsEnumerable<menu_category>();
        }

        // GET api/<controller>/5
        public menu_category Get(int id)
        {
            return db.menu_category.Find(id);
        }

        // POST api/<controller>
        public void Post([FromBody]menu_category value)
        {
            db.menu_category.Add(value);
            db.SaveChanges();
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]menu_category value)
        {
            db.Entry(value).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            db.menu_category.Remove(db.menu_category.Find(id));
            db.SaveChanges();
        }

    }
}