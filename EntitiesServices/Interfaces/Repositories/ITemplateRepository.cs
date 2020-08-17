using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;

namespace ModelServices.Interfaces.Repositories
{
    public interface ITemplateRepository : IRepositoryBase<TEMPLATE>
    {
        List<TEMPLATE> GetAllItens(Int32? idAss);
        TEMPLATE GetItemById(Int32 id);
        TEMPLATE GetItemByCode(String code, Int32? idAss);
        TEMPLATE GetItemByCode(String code);
        List<TEMPLATE> GetAllItensAdm(Int32? idAss);
    }
}
