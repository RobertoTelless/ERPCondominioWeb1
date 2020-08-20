using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;

namespace ModelServices.Interfaces.Repositories
{
    public interface IMoradorRepository : IRepositoryBase<MORADOR>
    {
        List<MORADOR> GetAllItens();
        MORADOR GetByNome(String nome);
        MORADOR GetByCPF(String cpf);
        List<MORADOR> ExecuteFilter(String nome, String cpf, String email, Int32? unidadeId);
        MORADOR GetItemByID(Int32 id);
        List<MORADOR> GetByUnidade(Int32 id);
        List<MORADOR> GetByUnidadeAll(Int32 id);
    }
}
