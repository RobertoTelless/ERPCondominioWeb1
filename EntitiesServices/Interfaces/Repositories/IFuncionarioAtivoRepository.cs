using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;

namespace ModelServices.Interfaces.Repositories
{
    public interface IFuncionarioAtivoRepository : IRepositoryBase<FUNCIONARIO_ATIVO>
    {
        List<FUNCIONARIO_ATIVO> GetAllItens();
        FUNCIONARIO_ATIVO GetByNome(String nome);
        FUNCIONARIO_ATIVO GetAtual();
        FUNCIONARIO_ATIVO GetItemByID(Int32 id);
    }
}
