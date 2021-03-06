using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;

namespace ModelServices.Interfaces.Repositories
{
    public interface ITipoVeiculoRepository : IRepositoryBase<TIPO_VEICULO>
    {
        List<TIPO_VEICULO> GetAllItens();
        TIPO_VEICULO GetItemById(Int32 id);
    }
}
