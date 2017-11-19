using GastouderAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GastouderAdmin.Controllers
{
    public class GastouderController : ApiController
    {
        public HttpResponseMessage GetAllGastouders()
        {
            using (GastouderAdminDbContext db = new GastouderAdminDbContext())
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent(Newtonsoft.Json.Linq.JArray.FromObject(db.Gastouders.ToList()).ToString(), System.Text.Encoding.UTF8, "application/json")
                };
            }
        }

        public IHttpActionResult GetGastouder(int id)
        {
            using (GastouderAdminDbContext db = new GastouderAdminDbContext())
            {
                var gastouder = db.Gastouders.FirstOrDefault((p) => p.Id == id);
                if (gastouder == null)
                {
                    return NotFound();
                }
                return Ok(gastouder);
            }
        }
    }

}
