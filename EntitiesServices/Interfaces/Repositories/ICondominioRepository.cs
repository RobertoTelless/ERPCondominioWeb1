using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;

namespace ModelServices.Interfaces.Repositories
{
    public interface ICondominioRepository : IRepositoryBase<CONDOMINIO>
    {
        List<CONDOMINIO> GetAllItens();
        CONDOMINIO GetByNome(String nome);
        CONDOMINIO GetItemByID(Int32 id);
    }
}

