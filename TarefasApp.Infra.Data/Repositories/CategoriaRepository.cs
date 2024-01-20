using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarefasApp.Domain.Entities;
using TarefasApp.Domain.Interfaces.Repositories;

namespace TarefasApp.Infra.Data.Repositories
{
    /// <summary>
    /// Classe de repositório de dados para Categoria
    /// </summary>
    public class CategoriaRepository : BaseRepository<Categoria>, ICategoriaRepository
    {

    }
}



