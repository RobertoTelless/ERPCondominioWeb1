using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;

namespace ModelServices.Interfaces.Repositories
{
    public interface IAutorizacaoAcessoRepository : IRepositoryBase<AUTORIZACAO_ACESSO>
    {
        List<AUTORIZACAO_ACESSO> GetAllItens();
        List<AUTORIZACAO_ACESSO> GetByUnidade(Int32 id);
        List<AUTORIZACAO_ACESSO> GetAcessosUnidade(Int32 id);
        List<AUTORIZACAO_ACESSO> GetItensDashboard();
        AUTORIZACAO_ACESSO GetByNome(String nome);
        List<AUTORIZACAO_ACESSO> ExecuteFilter(DateTime data, String nome, String empresa, Int32? unidadeId);
        AUTORIZACAO_ACESSO GetItemByID(Int32 id);
    }
}
