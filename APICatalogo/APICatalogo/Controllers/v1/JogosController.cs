using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICatalogo.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class JogosController : ControllerBase
    {
        //-----------------------------------------CONSULTA----------------------------------------------------------------//
        [HttpGet]
        public async Task<ActionResult<List<object>>> Obter()
        {
            return Ok();
        }



        //-----------------------------------------CONSULTA ESPECIFICA------------------------------------------------------//
        [HttpGet("{idJogo:guid}")]
        public async Task<ActionResult<object>> Obter(Guid idJogo)
        {
            return Ok();
        }



        //-----------------------------------------CRIAR------------------------------------------------------------------//
        [HttpPost]
        public async Task<ActionResult<object>> InserirJogo(object jogo)
        {
            return Ok();
        }



        //-----------------------------------------ATUALIZAÇÃO------------------------------------------------------------//
        //ATUALIZA O TODO
        [HttpPut("{idJogo:guid}")]
        public async Task<ActionResult> AtualizarJogo(Guid idJogo, object jogo)
        {
            return Ok();
        }



        //-----------------------------------------ATUALIZAÇÃO ESPECIFICA-----------------------------------------------//
        //ATUALIZA ALGO ESPECIFICO
        [HttpPatch("{idJogo:guid}/preco/{preco:double}")]
        public async Task<ActionResult> AtualizarJogo(Guid idJogo, double preco)
        {
            return Ok();
        }



        //-----------------------------------------DELETE--------------------------------------------------------------//
        [HttpDelete("{idJogo:guid}")]
        public async Task<ActionResult> ApagarJogo(Guid idJogo)
        {
            return Ok();
        }
    }
}
