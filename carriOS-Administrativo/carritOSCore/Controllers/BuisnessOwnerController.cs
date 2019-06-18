using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using carritOSCore.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace carritOSCore.Controllers
{
    [Produces("application/json")]
    [Route("api/BuisnessOwner")]
    public class BuisnessOwnerController : Controller
    {
        private readonly ApplicationDbContext context;
        public BuisnessOwnerController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<BuisnessOwner> Get()
        {
            return context.buisnessOwners.ToList();
        }

        [HttpGet("{id}", Name = "create buisnessOwner")]
        public IActionResult GetById(int id)
        {
            var buisnessOwner = context.buisnessOwners.FirstOrDefault(c => c.Id == id);

            if(buisnessOwner == null)
            {
                return NotFound();
            }

            return Ok(buisnessOwner);
        }

        [HttpPost]
        public IActionResult Post ([FromBody] BuisnessOwner buisnessOwner)
        {
            if(ModelState.IsValid)
            {
                context.buisnessOwners.Add(buisnessOwner);
                context.SaveChanges();
                return new CreatedAtRouteResult("create buisnessOwner", new  { id = buisnessOwner.Id });
            }
            return BadRequest(ModelState);
        }


        [HttpPut("{id}")]
        public IActionResult Put([FromBody] BuisnessOwner buisnessOwner, int id)
        {
            if (buisnessOwner.Id != id)
            {
                return BadRequest();
            }

            context.Entry(buisnessOwner).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var pais = context.buisnessOwners.FirstOrDefault(x => x.Id == id);

            if (pais == null)
            {
                return NotFound();
            }

            context.buisnessOwners.Remove(pais);
            context.SaveChanges();
            return Ok(pais);
        }

    }
}
