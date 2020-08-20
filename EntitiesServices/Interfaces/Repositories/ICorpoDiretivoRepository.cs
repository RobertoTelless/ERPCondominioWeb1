using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;

namespace ModelServices.Interfaces.Repositories
{
    public interface ICorpoDiretivoRepository : IRepositoryBase<CORPO_DIRETIVO>
    {
        List<CORPO_DIRETIVO> GetAllItens();
        List<CORPO_DIRETIVO> GetCorpoDashboard();
        CORPO_DIRETIVO GetItemByID(Int32 id);
        List<CORPO_DIRETIVO> GetAllItensFull();
    }
}
