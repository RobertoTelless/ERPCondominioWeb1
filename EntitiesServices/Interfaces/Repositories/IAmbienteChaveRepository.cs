using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;

namespace ModelServices.Interfaces.Repositories
{
    public interface IAmbienteChaveRepository : IRepositoryBase<AMBIENTE_CHAVE>
    {
        List<AMBIENTE_CHAVE> GetAllItens();
        List<AMBIENTE_CHAVE> GetItensDashboard();
        AMBIENTE_CHAVE GetItemById(Int32 id);
        AMBIENTE_CHAVE GetByNome(String nome);
        List<AMBIENTE_CHAVE> GetAllItensFull();
        List<AMBIENTE_CHAVE> GetByUnidade(Int32 id);
        Boolean VerificaChaveUnidade(Int32? id);
    }
}
