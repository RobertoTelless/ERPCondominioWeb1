using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;

namespace ModelServices.Interfaces.Repositories
{
    public interface IConvidadoRepository : IRepositoryBase<CONVIDADO>
    {
        List<CONVIDADO> GetAllItens();
        CONVIDADO GetByNome(String nome);
        CONVIDADO GetItemByID(Int32 id);
    }
}
