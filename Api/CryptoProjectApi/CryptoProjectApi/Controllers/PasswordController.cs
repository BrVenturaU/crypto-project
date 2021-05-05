using CryptoProjectApi.Entity;
using CryptoProjectApi.Interfaces;
using CryptoProjectApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CryptoProjectApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PasswordController : ControllerBase
    {
        private readonly IAccessService _accessService;

        public PasswordController(IAccessService accessService)
        {
            _accessService = accessService;
        }

        [HttpGet("salt")]
        [ProducesResponseType(typeof(PasswordLogWithSalt), (int) HttpStatusCode.OK)]
        public async Task<ActionResult> GetSalted()
        {
            var logs = await _accessService.Get<PasswordLogWithSalt>();
            return Ok(logs);
        }

        [HttpGet("no-salt")]
        [ProducesResponseType(typeof(PasswordLogWithoutSalt), (int)HttpStatusCode.OK)]
        public async Task<ActionResult> GetWithoutSalt()
        {
            var logs = await _accessService.Get<PasswordLogWithoutSalt>();
            return Ok(logs);
        }

        [HttpGet("salt/{id:int}", Name = "GetSaltById")]
        [ProducesResponseType(typeof(PasswordLogWithSalt), (int)HttpStatusCode.OK)]
        public async Task<ActionResult> GetSaltById(int id)
        {
            var log = await _accessService.GetById<PasswordLogWithSalt>(id);
            if (log == null)
                return NotFound("Registro no encontrado");
            return Ok(log);
        }

        [HttpGet("no-salt/{id:int}", Name = "GetWithoutSaltById")]
        [ProducesResponseType(typeof(PasswordLogWithSalt), (int)HttpStatusCode.OK)]
        public async Task<ActionResult> GetWithoutSaltById(int id)
        {
            var log = await _accessService.GetById<PasswordLogWithoutSalt>(id);
            if (log == null)
                return NotFound("Registro no encontrado");
            return Ok(log);
        }

        [HttpPost("salt")]
        [ProducesResponseType(typeof(PasswordLogWithSalt), (int)HttpStatusCode.Created)]
        public async Task<ActionResult> PostSalt([FromBody] PasswordBaseDto passwordDto)
        {
            var log = await _accessService.Create<PasswordLogWithSalt>(passwordDto);
            
            return Created("GetSaltById", log);
        }

        [HttpPost("no-salt")]
        [ProducesResponseType(typeof(PasswordLogWithoutSalt), (int)HttpStatusCode.Created)]
        public async Task<ActionResult> PostWithoutSalt([FromBody] PasswordBaseDto passwordDto)
        {
            var log = await _accessService.Create<PasswordLogWithoutSalt>(passwordDto);

            return Created("GetWithoutSaltById", log);
        }

        [HttpPut("salt/{id:int}")]
        [ProducesResponseType(typeof(PasswordLogWithSalt), (int)HttpStatusCode.OK)]
        public async Task<ActionResult> PutWithSalt(int id, PasswordSaltDto passwordDto)
        {
            var (log, code) = await _accessService.UpdatePassword<PasswordLogWithSalt>(id, passwordDto);
            if (code == 404)
                return NotFound("Registro no encontrado");
            if (code == 400)
                return BadRequest("Contraseña actual incorrecta.");

            return Ok(log);
        }

        [HttpPut("no-salt/{id:int}")]
        [ProducesResponseType(typeof(PasswordLogWithoutSalt), (int)HttpStatusCode.OK)]
        public async Task<ActionResult> PutWithoutSalt(int id, PasswordSaltDto passwordDto)
        {
            var (log, code) = await _accessService.UpdatePassword<PasswordLogWithoutSalt>(id, passwordDto);
            if (code == 404)
                return NotFound("Registro no encontrado");
            if (code == 400)
                return BadRequest("Contraseña actual incorrecta.");

            return Ok(log);
        }
    }
}
