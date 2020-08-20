using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;

namespace ModelServices.Interfaces.Repositories
{
    public interface IMovimentoEstoqueRepository : IRepositoryBase<MOVIMENTO_ESTOQUE>
    {
        List<MOVIMENTO_ESTOQUE> GetAllItensByProduto(Int32 id);
        MOVIMENTO_ESTOQUE GetItemById(Int32 id);
    }
}
