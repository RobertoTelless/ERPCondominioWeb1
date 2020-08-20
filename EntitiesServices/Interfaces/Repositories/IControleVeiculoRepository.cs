using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;

namespace ModelServices.Interfaces.Repositories
{
    public interface IControleVeiculoRepository : IRepositoryBase<CONTROLE_VEICULO>
    {
        List<CONTROLE_VEICULO> GetAllItens();
        CONTROLE_VEICULO GetItemById(Int32 id);
        CONTROLE_VEICULO GetByPlaca(String placa);
        List<CONTROLE_VEICULO> GetAllItensFull();
    }
}
