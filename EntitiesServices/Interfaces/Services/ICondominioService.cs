using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;
using EntitiesServices.Work_Classes;

namespace ModelServices.Interfaces.EntitiesServices
{
    public interface ICondominioService : IServiceBase<CONDOMINIO>
    {
        Int32 Create(CONDOMINIO item, LOG log);
        Int32 Create(CONDOMINIO item);
        Int32 Edit(CONDOMINIO item, LOG log);
        Int32 Edit(CONDOMINIO item);
        Int32 Delete(CONDOMINIO item, LOG log);

        CONDOMINIO GetItemById(Int32 id);
        List<CONDOMINIO> GetAllItens();
        CONDOMINIO GetItemByNome(String nome);
    }
}
