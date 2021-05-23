using System;
using System.Collections.Generic;
using castles.Models;
using castles.Services;
using Microsoft.AspNetCore.Mvc;


namespace castles.Controllers
{
    [ApiController]
    //NOTE ask about this in private so as to not embarrass me in front of class
    [Route("api/[controller]")]
    public class KnightsController : ControllerBase
    {
        private readonly KnightsService _service;

        public KnightsController(KnightsService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Knight>> GetAll()
        {
            try
            {
                IEnumerable<Knight> knights = _service.GetAll();
                return Ok(knights);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet("{id}")]
        public ActionResult<Knight> GetById(int id)
        {
            try
            {
                Knight knight = _service.GetById(id);
                return Ok(knight);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        public ActionResult<Knight> Create([FromBody] Knight newKnight)
        {
            try
            {
                Knight knight = _service.Create(newKnight);
                return Ok(knight);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut("{id}")]
        public ActionResult<Knight> Update(int id, [FromBody] Knight update)
        {
            try
            {
                update.Id = id;
                Knight updated = _service.Update(update);
                return Ok(updated);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<String> DeleteKnight(int id)
        {
            try
            {
                _service.DeleteKnight(id);
                return Ok("Delorted");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}