using System.Linq.Expressions;
using Tecnicos.Domain.DTO;

namespace Tecnicos.Abstractions
{
	public interface IClientesService
	{
		Task<bool> Guardar(ClientesDto cliente);
		Task<bool> Eliminar(int clienteId);
		Task<ClientesDto> Buscar(int id);
		Task<List<ClientesDto>> Listar(Expression<Func<ClientesDto, bool>> criterio);
		Task<bool> ExisteCliente(int id, string nombres);
	}
}
