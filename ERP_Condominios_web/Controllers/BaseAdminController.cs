using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApplicationServices.Interfaces;
using EntitiesServices.Model;
using System.Globalization;
using ERP_Condominios_web.App_Start;
using EntitiesServices.Work_Classes;
using AutoMapper;
using Erp_Condominio.ViewModels;
using System.IO;
using System.Collections;

namespace ERP_Condominios_web.Controllers
{
    public class BaseAdminController : Controller
    {
        private readonly IUsuarioAppService baseApp;
        private readonly INoticiaAppService notiApp;
        private readonly ILogAppService logApp;
        private readonly INotificacaoAppService notfApp;
        private readonly ICargoAppService carApp;
        private readonly IUsuarioAppService usuApp;
        //private readonly ICentroCustoAppService cuApp;
        private readonly IConfiguracaoAppService confApp;

        private String msg;
        private Exception exception;
        USUARIO objeto = new USUARIO();
        USUARIO objetoAntes = new USUARIO();
        List<USUARIO> listaMaster = new List<USUARIO>();

        public BaseAdminController(IUsuarioAppService baseApps, ILogAppService logApps, INoticiaAppService notApps, INotificacaoAppService notfApps, IUsuarioAppService usuApps, IConfiguracaoAppService confApps, ICargoAppService carApps)
        {
            baseApp = baseApps;
            logApp = logApps;
            notiApp = notApps;
            notfApp = notfApps;
            usuApp = usuApps;
            confApp = confApps;
            carApp = carApps;
        }

        public ActionResult CarregarAdmin()
        {
            Int32? idAss = (Int32)Session["IdAssinante"];
            List<USUARIO> usuarios = baseApp.GetAllUsuarios(idAss);
            List<LOG> logs = logApp.GetAllItens(idAss);

            ViewBag.Usuarios = usuarios.Count;
            ViewBag.Logs = logs.Count;
            ViewBag.UsuariosLista = usuarios;
            ViewBag.LogsLista = logs;
            return View();
        }

        public ActionResult CarregarLandingPage()
        {
            return View();
        }

        public JsonResult GetRefreshTime()
        {
            Int32? idAss = (Int32)Session["IdAssinante"];
            return Json(confApp.GetItemByAssinante(idAss).CONF_NR_REFRESH_DASH);
        }

        public JsonResult GetConfigNotificacoes()
        {
            USUARIO usuario = (USUARIO)Session["UserCredentials"];
            Int32? idAss = (Int32)Session["IdAssinante"];
            bool hasNotf;
            var hash = new Hashtable();
            USUARIO usu = usuApp.GetItemById(usuario.USUA_CD_ID);
            CONFIGURACAO conf = confApp.GetItemByAssinante(idAss);

            if (baseApp.GetAllItensUser(usu.USUA_CD_ID, idAss).Count > 0)
            {
                hasNotf = true;
            }
            else
            {
                hasNotf = false;
            }

            hash.Add("CONF_NM_ARQUIVO_ALARME", conf.CONF_NM_ARQUIVO_ALARME);
            hash.Add("NOTIFICACAO", hasNotf);
            return Json(hash);
        }

        public ActionResult CarregarBase()
        {
            // Carrega listas
            USUARIO usu = (USUARIO)Session["UserCredentials"];
            Int32? idAss = (Int32)Session["IdAssinante"];

            Session["Perfis"] = baseApp.GetAllPerfis();
            Session["Usuarios"] = usuApp.GetAllUsuarios(idAss);
            Session["UFs"] = baseApp.GetAllUF();
            Session["TiposPessoa"] = baseApp.GetAllTiposPessoa();
            Session["Cargos"] = carApp.GetAllItens();

            Session["ListaUsuario"] = null;
            Session["MensUsuario"] = 0;
            Session["ListaLog"] = null;
            Session["MensLog"] = 0;
            Session["ListaNoticia"] = null;
            Session["MensNoticia"] = 0;
            Session["MensAcesso"] = 0;
            Session["MensNotificacao"] = 0;
            Session["VoltaNotificacao"] = 1;
            Session["ListaNotificacao"] = null;
            Session["IdVolta"] = 0;

            UsuarioViewModel vm = Mapper.Map<USUARIO, UsuarioViewModel>(usu);

            Session["Notificacoes"] = baseApp.GetAllItensUser(usu.USUA_CD_ID, idAss);
            Session["ListasNovas"] = baseApp.GetNotificacaoNovas(usu.USUA_CD_ID, idAss);
            Session["NovasNotificacoes"] = ((List<NOTIFICACAO>)Session["Notificacoes"]).Where(p => p.NOTI_IN_VISTA == 0).Count();
            Session["Nome"] = usu.USUA_NM_NOME;
            if ((Int32)Session["NovasNotificacoes"] > 0)
            {
                ModelState.AddModelError("", ERP_Condominio.ResourceManager.GetString("M0093", CultureInfo.CurrentCulture));
            }

            Session["Noticias"] = notiApp.GetAllItensValidos();
            Session["NoticiasNumero"] = ((List<NOTICIA>)Session["Noticias"]).Count;

            Session["Logs"] = logApp.GetAllItensUsuario(usu.USUA_CD_ID, idAss).Count;

            ViewBag.Logs = (Int32)Session["Logs"];
            ViewBag.NovasNotificacoes = (Int32)Session["NovasNotificacoes"];
            ViewBag.NoticiasNumero = (Int32)Session["NoticiasNumero"];
            ViewBag.Noticias = ((List<NOTICIA>)Session["Noticias"]).ToList();

            String frase = String.Empty;
            String nome = usu.USUA_NM_NOME.Substring(0, usu.USUA_NM_NOME.IndexOf(" "));
            if (DateTime.Now.Hour <= 12)
            {
                frase = "Bom dia, " + nome;
            }
            else if (DateTime.Now.Hour > 12 & DateTime.Now.Hour <= 18)
            {
                frase = "Boa tarde, " + nome;
            }
            else
            {
                frase = "Boa noite, " + nome;
            }
            Session["Greeting"] = frase;
            Session["Foto"] = usu.USUA_AQ_FOTO;

            return View(vm);
        }

        public ActionResult CarregarDesenvolvimento()
        {
            return View();
        }

        public ActionResult VoltarDashboard()
        {
            return RedirectToAction("CarregarBase", "BaseAdmin");
        }

        public ActionResult MontarFaleConosco()
        {
            return View();
        }
    }
}