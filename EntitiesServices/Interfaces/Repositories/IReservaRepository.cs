using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;

namespace ModelServices.Interfaces.Repositories
{
    public interface IReservaRepository : IRepositoryBase<RESERVA>
    {
        List<RESERVA> GetAllItens();
        RESERVA GetItemById(Int32 id);
        RESERVA GetByNome(String nome);
        List<RESERVA> ExecuteFilter(Int32? ambiente, Int32? tipo,  String nome, DateTime data, Int32? unidade);
        List<RESERVA> GetReservaUnidade(Int32 id);
        List<RESERVA> GetReservaUnidadeAll(Int32 id);
    }
}
