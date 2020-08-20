using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;

namespace ModelServices.Interfaces.Repositories
{
    public interface IListaNegraRepository : IRepositoryBase<LISTA_NEGRA>
    {
        List<LISTA_NEGRA> GetAllItens();
        List<LISTA_NEGRA> GetNegraUnidade(Int32 id);
        LISTA_NEGRA GetItemById(Int32 id);
        LISTA_NEGRA GetByNome(String nome);
        List<LISTA_NEGRA> ExecuteFilter(String nome, String documento, DateTime data, Int32? unidade);
    }
}
