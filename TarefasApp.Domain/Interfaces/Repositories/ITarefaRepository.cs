using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarefasApp.Domain.Entities;

namespace TarefasApp.Domain.Interfaces.Repositories
{
    /// <summary>
    /// Interface para os métodos do repositório de tarefa
    /// </summary>
    public interface ITarefaRepository : IBaseRepository<Tarefa>
    {
        List<Tarefa> GetAll(DateTime dataMin, DateTime dataMax);
    }
}

