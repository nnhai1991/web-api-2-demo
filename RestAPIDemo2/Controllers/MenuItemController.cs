using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestAPIDemo2.Models;

namespace RestAPIDemo2.Controllers
{
    public class MenuItemController : ApiController
    {
        MenuContext db = new MenuContext();
        // GET api/<controller>
        public IEnumerable<menu_item> Get()
        {
            return db.menu_item.AsEnumerable<menu_item>();
        }

        // GET api/<controller>/5
        public menu_item Get(int id)
        {
            return db.menu_item.Find(id);
        }

        // POST api/<controller>
        public void Post([FromBody]menu_item value)
        {
            db.menu_item.Add(value);
            db.SaveChanges();
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]menu_item value)
        {
            db.Entry(value).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            db.menu_item.Remove(db.menu_item.Find(id));
            db.SaveChanges();
        }
    }
}