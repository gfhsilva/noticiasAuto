using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using noticiasAuto.Models;

namespace noticiasAuto.Controllers
{
    public class Noticias1Controller : ApiController
    {
        private NoticiasDB db = new NoticiasDB();

        // GET: api/Noticias1
        public IQueryable<Noticias> GetNoticias()
        {
            return db.Noticias;
        }

        // GET: api/Noticias1/5
        [ResponseType(typeof(Noticias))]
        public IHttpActionResult GetNoticias(int id)
        {
            Noticias noticias = db.Noticias.Find(id);
            if (noticias == null)
            {
                return NotFound();
            }

            return Ok(noticias);
        }

        // PUT: api/Noticias1/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutNoticias(int id, Noticias noticias)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != noticias.IdNoticia)
            {
                return BadRequest();
            }

            db.Entry(noticias).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NoticiasExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Noticias1
        [ResponseType(typeof(Noticias))]
        public IHttpActionResult PostNoticias(Noticias noticias)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Noticias.Add(noticias);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = noticias.IdNoticia }, noticias);
        }

        // DELETE: api/Noticias1/5
        [ResponseType(typeof(Noticias))]
        public IHttpActionResult DeleteNoticias(int id)
        {
            Noticias noticias = db.Noticias.Find(id);
            if (noticias == null)
            {
                return NotFound();
            }

            db.Noticias.Remove(noticias);
            db.SaveChanges();

            return Ok(noticias);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NoticiasExists(int id)
        {
            return db.Noticias.Count(e => e.IdNoticia == id) > 0;
        }
    }
}