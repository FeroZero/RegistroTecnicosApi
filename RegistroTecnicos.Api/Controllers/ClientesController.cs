using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tecnicos.Abstractions;
using Tecnicos.Data.Models;
using Tecnicos.Domain.DTO;

namespace RegistroTecnicos.Api.Controllers
{
	[Route("api/[controller]")]
    [ApiController]
    public class ClientesController(IClientesService clientesService) : ControllerBase
    {
        // GET: api/Clientes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClientesDto>>> GetClientes()
        {
            return await clientesService.Listar(c => true);
        }

        // GET: api/Clientes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ClientesDto>> GetClientes(int id)
        {

            return await clientesService.Buscar(id);
        }

        // PUT: api/Clientes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClientes(int id, ClientesDto clientesDto)
        {
            if (id != clientesDto.ClienteId)
            {
                return BadRequest();
            }
            await clientesService.Guardar(clientesDto);
            return NoContent();
        }

        // POST: api/Clientes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Clientes>> PostClientes(ClientesDto clientesDto)
        {
            await clientesService.Guardar(clientesDto);
            return CreatedAtAction("GetClientes", new { id = clientesDto.ClienteId }, clientesDto);
        }

        // DELETE: api/Clientes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClientes(int id)
        {
            await clientesService.Eliminar(id);
            return NoContent();
        }
    }
}
