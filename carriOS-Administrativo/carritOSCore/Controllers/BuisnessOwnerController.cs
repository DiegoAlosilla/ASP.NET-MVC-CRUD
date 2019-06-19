using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using carritOSCore.Model.Entities;
using Microsoft.EntityFrameworkCore;
using carritOSCore.Model.Service;
using carritOSCore.Model.ServiceImpl;

namespace carritOSCore.Controllers
{
    [Produces("application/json")]
    [Route("api/BuisnessOwner")]
    public class BuisnessOwnerController : Controller
    {
        private readonly ApplicationDbContext context;
        private IBuisnessOwnerService buisnessownerService;
        public BuisnessOwnerController(ApplicationDbContext context)
        {
            this.context = context;
            buisnessownerService = new BuisnessOwnerServiceImpl(context);
        }

        [HttpGet]
        public IEnumerable<BuisnessOwner> Get()
        {
            var buisnessOwner = buisnessownerService.FindAll();
            return buisnessOwner.ToList();
        }

        [HttpGet("{id}", Name = "create buisnessOwner")]
        public IActionResult GetById(int id)
        {
            
            var buisnessOwner = buisnessownerService.FindById(id);

            if (buisnessOwner == null)
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
                buisnessownerService.Save(buisnessOwner);               
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

            buisnessownerService.Update(buisnessOwner);
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var buisnessOwner = buisnessownerService.FindById(id);

            if (buisnessOwner == null)
            {
                return NotFound();
            }

            buisnessownerService.Delete(buisnessOwner);
            return Ok(buisnessOwner);
        }

    }
}
