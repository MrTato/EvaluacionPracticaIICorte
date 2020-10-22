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
using ProyectoWebAPI.Models;

namespace ProyectoWebAPI.Controllers
{
    public class UnitMeasuresController : ApiController
    {
        private AdventureWorks2019Entities db = new AdventureWorks2019Entities();

        // GET: api/UnitMeasures
        public IQueryable<UnitMeasure> GetUnitMeasure()
        {
            return db.UnitMeasure;
        }

        // GET: api/UnitMeasures/5
        [ResponseType(typeof(UnitMeasure))]
        public IHttpActionResult GetUnitMeasure(string id)
        {
            UnitMeasure unitMeasure = db.UnitMeasure.Find(id);
            if (unitMeasure == null)
            {
                return NotFound();
            }

            return Ok(unitMeasure);
        }

        // PUT: api/UnitMeasures/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUnitMeasure(string id, UnitMeasure unitMeasure)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != unitMeasure.UnitMeasureCode)
            {
                return BadRequest();
            }

            db.Entry(unitMeasure).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UnitMeasureExists(id))
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

        // POST: api/UnitMeasures
        [ResponseType(typeof(UnitMeasure))]
        public IHttpActionResult PostUnitMeasure(UnitMeasure unitMeasure)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.UnitMeasure.Add(unitMeasure);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (UnitMeasureExists(unitMeasure.UnitMeasureCode))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = unitMeasure.UnitMeasureCode }, unitMeasure);
        }

        // DELETE: api/UnitMeasures/5
        [ResponseType(typeof(UnitMeasure))]
        public IHttpActionResult DeleteUnitMeasure(string id)
        {
            UnitMeasure unitMeasure = db.UnitMeasure.Find(id);
            if (unitMeasure == null)
            {
                return NotFound();
            }

            db.UnitMeasure.Remove(unitMeasure);
            db.SaveChanges();

            return Ok(unitMeasure);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UnitMeasureExists(string id)
        {
            return db.UnitMeasure.Count(e => e.UnitMeasureCode == id) > 0;
        }
    }
}