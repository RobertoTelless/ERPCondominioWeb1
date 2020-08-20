using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;

namespace ModelServices.Interfaces.Repositories
{
    public interface IEncomendaRepository : IRepositoryBase<ENCOMENDA>
    {
        List<ENCOMENDA> GetAllItens();
        List<ENCOMENDA> GetEncomendaUnidade(Int32 id);
        List<ENCOMENDA> GetEncomendaUnidadeAll(Int32 id);
        List<ENCOMENDA> GetItensDashboard();
        ENCOMENDA GetItemById(Int32 id);
        List<ENCOMENDA> GetAllItensFull();
    }
}
