using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;

namespace ModelServices.Interfaces.Repositories
{
    public interface IEntradaSaidaRepository : IRepositoryBase<ENTRADA_SAIDA>
    {
        List<ENTRADA_SAIDA> GetAllItens();
        List<ENTRADA_SAIDA> GetByUnidade(Int32 id);
        ENTRADA_SAIDA GetByNome(String nome);
        ENTRADA_SAIDA GetByDocumento(String documento);
        List<ENTRADA_SAIDA> ExecuteFilter(String nome, String documento, DateTime? data, Int32? unidadeId);
        ENTRADA_SAIDA GetItemByID(Int32 id);
        List<ENTRADA_SAIDA> GetAllItensCorrente();
    }
}
