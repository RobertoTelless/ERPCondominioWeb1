using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;
using EntitiesServices.Work_Classes;

namespace ModelServices.Interfaces.EntitiesServices
{
    public interface IUnidadeService : IServiceBase<UNIDADE>
    {
        Int32 Create(UNIDADE item, LOG log);
        Int32 Create(UNIDADE item);
        Int32 Edit(UNIDADE item, LOG log);
        Int32 Edit(UNIDADE item);
        Int32 Delete(UNIDADE item, LOG log);

        UNIDADE GetItemById(Int32 id);
        List<UNIDADE> GetAllItens(Int32? idAss);
        //List<UNIDADE> GetAllItensAdm(Int32? idAss);
        //List<UNIDADE> ExecuteFilter(Int32? idCat, String titulo, DateTime? data, String texto, Int32? idAss);
        List<TIPO_UNIDADE> GetAllTipos();
    }
}
