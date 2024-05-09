using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModuloApi.Contexts;
using ModuloApi.Models;

namespace ModuloApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;

        public ContatoController(AgendaContext context)
        {
            _context = context; //injeção de dependência
        }


        [HttpPost]
        public IActionResult Criar(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return CreatedAtAction(nameof(BuscarPorId), new { id = contato.Id }, contato);
        }


        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            var contato = _context.MeusContatos.Find(id);

            if (contato == null) return NotFound();

            return Ok(contato);
        }


        [HttpGet("BuscarContatoPorNome")]
        public IActionResult BuscarPorNome(string nome)
        {
            var listaDeContatos = _context.MeusContatos.Where(x => x.Nome.Contains(nome));
            return Ok(listaDeContatos);
        }



        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Contato contato)
        {
            var contatoDoBanco = _context.MeusContatos.Find(id);

            if(contatoDoBanco == null) return NotFound();

            contatoDoBanco.Nome = contato.Nome;
            contatoDoBanco.Telefone = contato.Telefone;
            contatoDoBanco.Ativo = contato.Ativo;

            _context.MeusContatos.Update(contatoDoBanco);
            _context.SaveChanges();

            return Ok(contatoDoBanco);
        }



        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var contatoASerExcluido = _context.MeusContatos.Find(id);

            if(contatoASerExcluido == null) return NotFound();

            _context.MeusContatos.Remove(contatoASerExcluido);
            _context.SaveChanges();

            //return Ok(contatoASerExcluido);
            return NoContent();
        }
    }
}