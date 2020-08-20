using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;

namespace ModelServices.Interfaces.Repositories
{
    public interface IAmbienteRepository : IRepositoryBase<AMBIENTE>
    {
        List<AMBIENTE> GetAllItens();
        AMBIENTE GetByNome(String nome);
        AMBIENTE GetItemByID(Int32 id);
        List<AMBIENTE> GetAllAmbientes();
    }
}

