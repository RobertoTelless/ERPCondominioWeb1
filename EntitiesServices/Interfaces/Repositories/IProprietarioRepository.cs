using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;

namespace ModelServices.Interfaces.Repositories
{
    public interface IProprietarioRepository : IRepositoryBase<PROPRIETARIO>
    {
        List<PROPRIETARIO> GetAllItens();
        PROPRIETARIO GetByUnidade(Int32 id);
        PROPRIETARIO GetItemById(Int32 id);
    }
}
