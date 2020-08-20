using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;

namespace ModelServices.Interfaces.Repositories
{
    public interface ITipoProdutoRepository : IRepositoryBase<TIPO_PRODUTO>
    {
        List<TIPO_PRODUTO> GetAllItens();
        TIPO_PRODUTO GetItemById(Int32 id);
    }
}
