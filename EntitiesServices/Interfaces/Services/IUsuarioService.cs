using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;
using EntitiesServices.Work_Classes;

namespace ModelServices.Interfaces.EntitiesServices
{
    public interface IUsuarioService : IServiceBase<USUARIO>
    {
        Int32 CreateUser(USUARIO usuario, LOG log);
        Int32 CreateUser(USUARIO usuario);
        Int32 EditUser(USUARIO usuario, LOG log);
        Int32 EditUser(USUARIO usuario);

        Boolean VerificarCredenciais(String senha, USUARIO usuario);
        USUARIO GetByEmail(String email, Int32? idAss);
        USUARIO GetByLogin(String login, Int32? idAss);
        USUARIO RetriveUserByEmail(String email);
        Int32 VerifyUserSubscription(USUARIO usuario);

        CONFIGURACAO CarregaConfiguracao(Int32? idAss);
        List<USUARIO> GetAllUsuariosAdm(Int32? idAss);
        USUARIO GetItemById(Int32 id);
        List<USUARIO> GetAllUsuarios(Int32? idAss);
        List<PERFIL> GetAllPerfis();
        List<USUARIO> GetAllItens(Int32? idAss);
        List<USUARIO> GetAllItensBloqueados(Int32? idAss);
        List<USUARIO> GetAllItensAcessoHoje(Int32? idAss);
        USUARIO_ANEXO GetAnexoById(Int32 id);
        List<NOTIFICACAO> GetAllItensUser(Int32 id, Int32? idAss);
        List<NOTIFICACAO> GetNotificacaoNovas(Int32 id, Int32? idAss);
        List<NOTICIA> GetAllNoticias();
        List<UF> GetAllUF();
        USUARIO GetAdministrador(Int32? idAss);
        TEMPLATE GetTemplate(String code, Int32? idAss);
        TEMPLATE GetTemplate(String code);
        List<USUARIO> GetAllUsuariosAdm();
        List<USUARIO> ExecuteFilter(Int32? perfilId, String nome, String login, String email, Int32? idCargo, Int32? idAss);
    }
}
