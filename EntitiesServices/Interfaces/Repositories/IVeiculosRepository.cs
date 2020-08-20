using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;

namespace ModelServices.Interfaces.Repositories
{
    public interface IListaConvidadoRepository : IRepositoryBase<LISTA_CONVIDADO>
    {
        List<LISTA_CONVIDADO> GetAllItens();
        LISTA_CONVIDADO GetByNome(String nome);
        List<LISTA_CONVIDADO> ExecuteFilter(DateTime data, String nome, Int32? reserva, Int32? unidadeId);
        LISTA_CONVIDADO GetItemByID(Int32 id);
    }
}
