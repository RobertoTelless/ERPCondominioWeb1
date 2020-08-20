using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;

namespace ApplicationServices.Interfaces
{
    public interface IUnidadeAppService : IAppServiceBase<UNIDADE>
    {
        Int32 ValidateCreate(UNIDADE item, USUARIO usuario, Int32? idAss);
        Int32 ValidateEdit(UNIDADE item, UNIDADE itemAntes, USUARIO usuario, Int32? idAss);
        Int32 ValidateEdit(UNIDADE item, UNIDADE itemAntes);
        Int32 ValidateDelete(UNIDADE item, USUARIO usuario, Int32? idAss);
        Int32 ValidateReativar(UNIDADE item, USUARIO usuario, Int32? idAss);

        UNIDADE GetItemById(Int32 id);
        List<UNIDADE> GetAllItens(Int32? idAss);
        //List<NOTIFICACAO> GetAllItensAdm(Int32? idAss);
        //Int32 ExecuteFilter(Int32? idCat, String titulo, DateTime? data, String texto, Int32? idAss, out List<NOTIFICACAO> objeto);
        List<TIPO_UNIDADE> GetAllTipos();
    }
}
