using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor.CRUD.Sample.Api.Data;
using Blazor.CRUD.Sample.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blazor.CRUD.Sample.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly SportsContext _sportsContext;

        public PlayerController(SportsContext sportsContext)
        {
            _sportsContext = sportsContext;
        }

        [HttpGet]
        [Route("all")]
        public IActionResult GetAll()
        {
            var result = _sportsContext.Player.ToList();
            return Ok(result);
        }

        [HttpPost]
        [Route("save")]
        public IActionResult Save(Player player)
        {
            _sportsContext.Player.Add(player);
            _sportsContext.SaveChanges();
            return Ok();
        }

        [HttpGet]
        [Route("get_by_id")]
        public IActionResult GetById(int id)
        {
            var result = _sportsContext.Player.Where(_ => _.Id == id).FirstOrDefault();
            return Ok(result);
        }

        [HttpPost]
        [Route("update")]
        public IActionResult Update(Player player)
        {
            _sportsContext.Player.Update(player);
            _sportsContext.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        [Route("delete")]
        public IActionResult Delete(int id)
        {
            Player playerToDelete = _sportsContext.Player.Where(_ => _.Id == id).FirstOrDefault();
            if(playerToDelete != null)
            {
                _sportsContext.Player.Remove(playerToDelete);
                _sportsContext.SaveChanges();
            }
            return Ok(_sportsContext.Player.ToList());
        }
    }
}