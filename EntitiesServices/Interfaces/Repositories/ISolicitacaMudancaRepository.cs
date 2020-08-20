using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;

namespace ModelServices.Interfaces.Repositories
{
    public interface ISolicitacaoMudancaRepository : IRepositoryBase<SOLICITACAO_MUDANCA>
    {
        List<SOLICITACAO_MUDANCA> GetAllItens();
        List<SOLICITACAO_MUDANCA> GetAllUnidade(Int32 id);
        SOLICITACAO_MUDANCA GetItemById(Int32 id);
    }
}
