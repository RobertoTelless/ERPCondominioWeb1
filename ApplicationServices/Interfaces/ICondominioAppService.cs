using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;

namespace ApplicationServices.Interfaces
{
    public interface ICondominioAppService : IAppServiceBase<CONDOMINIO>
    {
        //Int32 ValidateCreate(CONDOMINIO item, USUARIO usuario, Int32? idAss);
        //Int32 ValidateEdit(CONDOMINIO item, CONDOMINIO itemAntes, USUARIO usuario, Int32? idAss);
        //Int32 ValidateEdit(CONDOMINIO item, CONDOMINIO itemAntes);
        //Int32 ValidateDelete(CONDOMINIO item, USUARIO usuario, Int32? idAss);
        //Int32 ValidateReativar(CONDOMINIO item, USUARIO usuario, Int32? idAss);

        CONDOMINIO GetItemById(Int32 id);
        List<CONDOMINIO> GetAllItens();
        CONDOMINIO GetItemByNome(String nome);
    }
}
