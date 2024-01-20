using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarefasApp.Domain.Entities;

namespace TarefasApp.Domain.Interfaces.Services
{
    public interface ITarefaDomainService
    {
        void Add(Tarefa tarefa);
        void Update(Tarefa tarefa);
        void Delete(Tarefa tarefa);

        List<Tarefa> GetAll(DateTime dataMin, DateTime dataMax);
        Tarefa GetById(Guid id);
    }
}



