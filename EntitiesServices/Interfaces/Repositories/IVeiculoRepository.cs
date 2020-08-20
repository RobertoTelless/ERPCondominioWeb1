using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;

namespace ModelServices.Interfaces.Repositories
{
    public interface IVeiculoRepository : IRepositoryBase<VEICULO>
    {
        List<VEICULO> GetAllItens();
        List<VEICULO> GetByUnidade(Int32 id);
        VEICULO GetByPlaca(String placa);
        List<VEICULO> ExecuteFilter(Int32? tipo, String placa, String marca, Int32? unidadeId);
        VEICULO GetItemByID(Int32 id);
    }
}
