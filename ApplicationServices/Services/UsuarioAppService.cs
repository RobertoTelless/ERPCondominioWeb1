using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;
using EntitiesServices.Work_Classes;
using ApplicationServices.Interfaces;
using ModelServices.Interfaces.EntitiesServices;
using CrossCutting;
using System.Text.RegularExpressions;

namespace ApplicationServices.Services
{
    public class UsuarioAppService : AppServiceBase<USUARIO>, IUsuarioAppService
    {
        private readonly IUsuarioService _usuarioService;
        private readonly INotificacaoService _notiService;

        public UsuarioAppService(IUsuarioService usuarioService, INotificacaoService notiService): base(usuarioService)
        {
            _usuarioService = usuarioService;
            _notiService = notiService;
        }

        public USUARIO GetByEmail(String email, Int32? idAss)
        {
            return _usuarioService.GetByEmail(email, idAss);
        }

        public USUARIO GetByLogin(String login, Int32? idAss)
        {
            return _usuarioService.GetByLogin(login, idAss);
        }

        public List<USUARIO> GetAllUsuariosAdm(Int32? idAss)
        {
            return _usuarioService.GetAllUsuariosAdm(idAss);
        }

        public List<USUARIO> GetAllUsuariosAdm()
        {
            return _usuarioService.GetAllUsuariosAdm();
        }

        public USUARIO GetItemById(Int32 id)
        {
            return _usuarioService.GetItemById(id);
        }

        public List<USUARIO> GetAllUsuarios(Int32? idAss)
        {
            return _usuarioService.GetAllUsuarios(idAss);
        }

        public List<USUARIO> GetAllItens(Int32? idAss)
        {
            return _usuarioService.GetAllItens(idAss);
        }

        public List<UF> GetAllUF()
        {
            return _usuarioService.GetAllUF();
        }

        public List<NOTIFICACAO> GetAllItensUser(Int32 id, Int32? idAss)
        {
            return _usuarioService.GetAllItensUser(id, idAss);
        }

        public List<NOTICIA> GetAllNoticias()
        {
            return _usuarioService.GetAllNoticias();
        }

        public List<NOTIFICACAO> GetNotificacaoNovas(Int32 id, Int32? idAss)
        {
            return _usuarioService.GetNotificacaoNovas(id, idAss);
        }

        public List<USUARIO> GetAllItensBloqueados(Int32? idAss)
        {
            return _usuarioService.GetAllItensBloqueados(idAss);
        }

        public List<USUARIO> GetAllItensAcessoHoje(Int32? idAss)
        {
            return _usuarioService.GetAllItensAcessoHoje(idAss);
        }

        public USUARIO_ANEXO GetAnexoById(Int32 id)
        {
            return _usuarioService.GetAnexoById(id);
        }

        public Int32 ValidateCreate(USUARIO usuario, USUARIO usuarioLogado, Int32? idAss)
        {
            try
            {
                // Verifica senhas
                if (usuario.USUA_NM_SENHA != usuario.USUA_NM_SENHA_CONFIRMA)
                {
                    return 1;
                }

                // Verifica Email
                if (!ValidarItensDiversos.IsValidEmail(usuario.USUA_NM_EMAIL))
                {
                    return 2;
                }

                // Verifica existencia prévia
                if (_usuarioService.GetByEmail(usuario.USUA_NM_EMAIL, idAss) != null)
                {
                    return 3;
                }
                if (_usuarioService.GetByLogin(usuario.USUA_NM_LOGIN, idAss) != null)
                {
                    return 4;
                }

                //Completa campos de usuários
                //usuario.USUA_NM_SENHA = Cryptography.Encode(usuario.USUA_NM_SENHA);
                usuario.USUA_IN_BLOQUEADO = 0;
                usuario.USUA_IN_PROVISORIA = 0;
                usuario.USUA_IN_LOGIN_PROVISORIO = 0;
                usuario.USUA_NR_ACESSOS = 0;
                usuario.USUA_NR_FALHAS = 0;
                usuario.USUA_DT_ALTERACAO = null;
                usuario.USUA_DT_BLOQUEIO = null;
                usuario.USUA_DT_TROCA_SENHA = null;
                usuario.USUA_DT_ACESSO = DateTime.Now;
                usuario.USUA_DT_CADASTRO = DateTime.Today.Date;
                usuario.USUA_IN_ATIVO = 1;
                usuario.USUA_DT_ULTIMA_FALHA = DateTime.Now;
                usuario.COND_CD_ID = idAss.Value;

                // Monta Log
                LOG log = new LOG
                {
                    LOG_DT_DATA = DateTime.Now,
                    USUA_CD_ID = usuarioLogado.USUA_CD_ID,
                    COND_CD_ID = idAss.Value,
                    LOG_NM_OPERACAO = "AddUSUA",
                    LOG_TX_REGISTRO = Serialization.SerializeJSON<USUARIO>(usuario),
                    LOG_IN_ATIVO = 1
                };


                // Persiste
                Int32 volta = _usuarioService.CreateUser(usuario, log);
                return volta;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Int32 ValidateCreateAssinante(USUARIO usuario, USUARIO usuarioLogado, Int32? idAss)
        {
            try
            {
                // Verifica senhas
                if (usuario.USUA_NM_SENHA != usuario.USUA_NM_SENHA_CONFIRMA)
                {
                    return 1;
                }

                // Verifica Email
                if (!ValidarItensDiversos.IsValidEmail(usuario.USUA_NM_EMAIL))
                {
                    return 2;
                }

                // Verifica existencia prévia
                if (_usuarioService.GetByEmail(usuario.USUA_NM_EMAIL, idAss) != null)
                {
                    return 3;
                }
                if (_usuarioService.GetByLogin(usuario.USUA_NM_LOGIN, idAss) != null)
                {
                    return 4;
                }

                //Completa campos de usuários
                //usuario.USUA_NM_SENHA = Cryptography.Encode(usuario.USUA_NM_SENHA);
                usuario.USUA_IN_BLOQUEADO = 0;
                usuario.USUA_IN_PROVISORIA = 0;
                usuario.USUA_IN_LOGIN_PROVISORIO = 0;
                usuario.USUA_NR_ACESSOS = 0;
                usuario.USUA_NR_FALHAS = 0;
                usuario.USUA_DT_ALTERACAO = null;
                usuario.USUA_DT_BLOQUEIO = null;
                usuario.USUA_DT_TROCA_SENHA = null;
                usuario.USUA_DT_ACESSO = DateTime.Now;
                usuario.USUA_DT_CADASTRO = DateTime.Today.Date;
                usuario.USUA_IN_ATIVO = 1;
                usuario.USUA_DT_ULTIMA_FALHA = DateTime.Now;
                usuario.COND_CD_ID = idAss.Value;

                // Monta Log
                LOG log = new LOG
                {
                    LOG_DT_DATA = DateTime.Now,
                    USUA_CD_ID = usuarioLogado.USUA_CD_ID,
                    COND_CD_ID = idAss.Value,
                    LOG_NM_OPERACAO = "AddUSUA",
                    LOG_TX_REGISTRO = Serialization.SerializeJSON<USUARIO>(usuario),
                    LOG_IN_ATIVO = 1
                };


                // Persiste
                Int32 volta = _usuarioService.CreateUser(usuario, log);
                return volta;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Int32 ValidateEdit(USUARIO usuario, USUARIO usuarioAntes, USUARIO usuarioLogado, Int32? idAss)
        {
            try
            {
                // Verifica Email
                if (!ValidarItensDiversos.IsValidEmail(usuario.USUA_NM_EMAIL))
                {
                    return 1;
                }

                // Verifica existencia prévia
                USUARIO usu = _usuarioService.GetByEmail(usuario.USUA_NM_EMAIL, idAss);
                if (usu != null)
                {
                    if (usu.USUA_CD_ID != usuario.USUA_CD_ID)
                    {
                        return 2;
                    }
                }
                usu = _usuarioService.GetByLogin(usuario.USUA_NM_LOGIN, idAss);
                if (usu != null)
                {
                    if (usu.USUA_CD_ID != usuario.USUA_CD_ID)
                    {
                        return 3;
                    }
                }

                //Acerta campos de usuários
                usuario.USUA_DT_ALTERACAO = DateTime.Now;
                usuario.USUA_IN_ATIVO = 1;

                // Monta Log
                LOG log = new LOG
                {
                    LOG_DT_DATA = DateTime.Now,
                    USUA_CD_ID = usuarioLogado.USUA_CD_ID,
                    COND_CD_ID = idAss.Value,
                    LOG_NM_OPERACAO = "EditUSUA",
                    LOG_TX_REGISTRO = Serialization.SerializeJSON<USUARIO>(usuario),
                    LOG_TX_REGISTRO_ANTES = Serialization.SerializeJSON<USUARIO>(usuarioAntes),
                    LOG_IN_ATIVO = 1
                };


                // Persiste
                Int32 volta = _usuarioService.EditUser(usuario);
                return volta;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Int32 ValidateEdit(USUARIO usuario, USUARIO usuarioLogado, Int32? idAss)
        {
            try
            {
                // Verifica Email
                if (!ValidarItensDiversos.IsValidEmail(usuario.USUA_NM_EMAIL))
                {
                    return 1;
                }

                // Verifica existencia prévia
                USUARIO usu = _usuarioService.GetByEmail(usuario.USUA_NM_EMAIL, idAss);
                if (usu != null)
                {
                    if (usu.USUA_CD_ID != usuario.USUA_CD_ID)
                    {
                        return 2;
                    }
                }
                usu = _usuarioService.GetByLogin(usuario.USUA_NM_LOGIN, idAss);
                if (usu != null)
                {
                    if (usu.USUA_CD_ID != usuario.USUA_CD_ID)
                    {
                        return 3;
                    }
                }

                //Acerta campos de usuários
                usuario.USUA_DT_ALTERACAO = DateTime.Now;
                usuario.USUA_IN_ATIVO = 1;

                // Persiste
                Int32 volta = _usuarioService.EditUser(usuario);
                return volta;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public Int32 ValidateDelete(USUARIO usuario, USUARIO usuarioLogado, Int32? idAss)
        {
            try
            {
                // Verifica integridade
                if (usuario.AGENDA.Count > 0 || usuario.AMBIENTE_CHAVE.Count > 0 || usuario.AUTORIZACAO_ACESSO.Count > 0 || usuario.CONTA_PAGAR.Count > 0 || usuario.CONTA_RECEBER.Count > 0 || usuario.ENCOMENDA.Count > 0)
                {
                    return 1;
                }
                if (usuario.LISTA_NEGRA.Count > 0 || usuario.RESERVA.Count > 0 || usuario.SOLICITACAO_MUDANCA.Count > 0)
                {
                    return 1;
                }

                // Acerta campos de usuários
                usuario.USUA_DT_ALTERACAO = DateTime.Now;
                usuario.USUA_IN_ATIVO = 0;
                usuario.CONDOMINIO = null;

                // Monta Log
                LOG log = new LOG
                {
                    LOG_DT_DATA = DateTime.Now,
                    USUA_CD_ID = usuarioLogado.USUA_CD_ID,
                    COND_CD_ID = idAss,
                    LOG_NM_OPERACAO = "DelUSUA",
                    LOG_TX_REGISTRO = Serialization.SerializeJSON<USUARIO>(usuario),
                    LOG_IN_ATIVO = 1
                };

                // Persiste
                return _usuarioService.EditUser(usuario);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Int32 ValidateReativar(USUARIO usuario, USUARIO usuarioLogado, Int32? idAss)
        {
            try
            {
                // Verifica integridade

                // Acerta campos de usuários
                usuario.USUA_DT_ALTERACAO = DateTime.Now;
                usuario.USUA_IN_ATIVO = 1;
                usuario.CONDOMINIO = null;

                // Monta Log
                LOG log = new LOG
                {
                    LOG_DT_DATA = DateTime.Now,
                    USUA_CD_ID = usuarioLogado.USUA_CD_ID,
                    COND_CD_ID = idAss,
                    LOG_NM_OPERACAO = "ReatUSUA",
                    LOG_TX_REGISTRO = Serialization.SerializeJSON<USUARIO>(usuario),
                    LOG_IN_ATIVO = 1
                };

                // Persiste
                return _usuarioService.EditUser(usuario);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Int32 ValidateBloqueio(USUARIO usuario, USUARIO usuarioLogado, Int32? idAss)
        {
            try
            {
                //Acerta campos de usuários
                usuario.USUA_DT_BLOQUEIO = DateTime.Today;
                usuario.USUA_IN_BLOQUEADO = 1;
                usuario.CONDOMINIO = null;

                // Monta Log
                LOG log = new LOG
                {
                    LOG_DT_DATA = DateTime.Now,
                    USUA_CD_ID = usuarioLogado.USUA_CD_ID,
                    COND_CD_ID = idAss.Value,
                    LOG_NM_OPERACAO = "BlqUSUA",
                    LOG_TX_REGISTRO = Serialization.SerializeJSON<USUARIO>(usuario),
                    LOG_IN_ATIVO = 1
                };

                // Persiste
                return _usuarioService.EditUser(usuario);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Int32 ValidateDesbloqueio(USUARIO usuario, USUARIO usuarioLogado, Int32? idAss)
        {
            try
            {
                //Acerta campos de usuários
                usuario.USUA_DT_BLOQUEIO = DateTime.Now;
                usuario.USUA_IN_BLOQUEADO = 0;
                usuario.CONDOMINIO = null;

                // Monta Log
                LOG log = new LOG
                {
                    LOG_DT_DATA = DateTime.Now,
                    COND_CD_ID = idAss.Value,
                    USUA_CD_ID = usuarioLogado.USUA_CD_ID,
                    LOG_NM_OPERACAO = "DbqUSUA",
                    LOG_TX_REGISTRO = Serialization.SerializeJSON<USUARIO>(usuario),
                    LOG_IN_ATIVO = 1
                };

                // Persiste
                return _usuarioService.EditUser(usuario);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Int32 ValidateLogin(String login, String senha, out USUARIO usuario, Int32? idAss)
        {
            try
            {
                usuario = new USUARIO();
                // Checa senha
                if (String.IsNullOrEmpty(senha))
                {
                    return 9;
                }
                // Checa login
                if (String.IsNullOrEmpty(login))
                {
                    return 1;
                }
                usuario = _usuarioService.GetByLogin(login, idAss);
                if (usuario == null)
                {
                    usuario = new USUARIO();
                    return 2;
                }

                // Verifica se está ativo
                if (usuario.USUA_IN_ATIVO != 1)
                {
                    return 3;
                }

                // Verifica se está bloqueado
                if (usuario.USUA_IN_BLOQUEADO == 1)
                {
                    return 4;
                }

                // verifica senha proviória
                if (usuario.USUA_IN_PROVISORIA == 1)
                {
                    if (usuario.USUA_IN_LOGIN_PROVISORIO == 0)
                    {
                        usuario.USUA_IN_LOGIN_PROVISORIO = 1;
                    }
                    else
                    {
                        return 5;
                    }
                }

                // Verifica credenciais
                Boolean retorno = _usuarioService.VerificarCredenciais(senha, usuario);
                if (!retorno)
                {
                    if (usuario.USUA_NR_FALHAS <= _usuarioService.CarregaConfiguracao(idAss).CONF_NR_FALHAS_DIA)
                    {
                        if (usuario.USUA_DT_ULTIMA_FALHA != null)
                        {
                            if (usuario.USUA_DT_ULTIMA_FALHA.Value.Date != DateTime.Now.Date)
                            {
                                usuario.USUA_DT_ULTIMA_FALHA = DateTime.Now.Date;
                                usuario.USUA_NR_FALHAS = 1;
                            }
                            else
                            {
                                usuario.USUA_NR_FALHAS++;
                            }
                        }
                        else
                        {
                            usuario.USUA_DT_ULTIMA_FALHA = DateTime.Today.Date;
                            usuario.USUA_NR_FALHAS = 1;
                        }

                    }
                    else if (usuario.USUA_NR_FALHAS > _usuarioService.CarregaConfiguracao(idAss).CONF_NR_FALHAS_DIA)
                    {
                        usuario.USUA_DT_BLOQUEIO = DateTime.Today.Date;
                        usuario.USUA_IN_BLOQUEADO = 1;
                        usuario.USUA_NR_FALHAS = 0;
                        usuario.USUA_DT_ULTIMA_FALHA = DateTime.Today.Date;
                        Int32 voltaBloqueio = _usuarioService.EditUser(usuario);
                        return 6;
                    }
                    Int32 volta = _usuarioService.EditUser(usuario);
                    return 7;
                }

                // Atualiza acessos e data do acesso
                usuario.USUA_NR_ACESSOS = ++usuario.USUA_NR_ACESSOS;
                usuario.USUA_DT_ACESSO = DateTime.Now.Date;
                Int32 voltaAcesso = _usuarioService.EditUser(usuario);
                return 0;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Int32 ValidateChangePassword(USUARIO usuario, Int32? idAss)
        {
            try
            {
                // Checa preenchimento
                if (String.IsNullOrEmpty(usuario.USUA_NOVA_SENHA))
                {
                    return 3;
                }
                if (String.IsNullOrEmpty(usuario.USUA_NM_SENHA_CONFIRMA))
                {
                    return 4;
                }

                // Verifica se senha igual a anterior
                if (usuario.USUA_NM_SENHA == usuario.USUA_NOVA_SENHA)
                {
                    return 1;
                }

                // Verifica se senha foi confirmada
                if (usuario.USUA_NOVA_SENHA != usuario.USUA_NM_SENHA_CONFIRMA)
                {
                    return 2;
                }

                //Completa e acerta campos 
                //usuario.USUA_NM_SENHA = Cryptography.Encode(usuario.USUA_NM_NOVA_SENHA);
                usuario.USUA_NM_SENHA = usuario.USUA_NOVA_SENHA;
                usuario.USUA_DT_TROCA_SENHA = DateTime.Now.Date;
                usuario.USUA_IN_BLOQUEADO = 0;
                usuario.USUA_IN_PROVISORIA = 0;
                usuario.USUA_IN_LOGIN_PROVISORIO = 0;
                usuario.USUA_NR_ACESSOS = 0;
                usuario.USUA_NR_FALHAS = 0;
                usuario.USUA_DT_ALTERACAO = null;
                usuario.USUA_DT_BLOQUEIO = null;
                usuario.USUA_DT_TROCA_SENHA = null;
                usuario.USUA_DT_ACESSO = DateTime.Now;
                usuario.USUA_DT_CADASTRO = DateTime.Now;
                usuario.USUA_IN_ATIVO = 1;
                usuario.USUA_DT_ULTIMA_FALHA = null;
                usuario.COND_CD_ID = idAss.Value;

                // Gera Notificação
                NOTIFICACAO noti = new NOTIFICACAO();
                noti.CANO_CD_ID = 1;
                noti.COND_CD_ID = idAss;
                noti.NOTI_DT_EMISSAO = DateTime.Today;
                noti.NOTI_DT_CADASTRO = DateTime.Today.Date;
                noti.NOTI_DT_VALIDADE = DateTime.Today.Date.AddDays(30);
                noti.NOTI_IN_VISTA = 0;
                noti.NOTI_NM_TITULO = "Alteração de Senha";
                noti.NOTI_IN_ATIVO = 1;
                noti.NOTI_TX_TEXTO = "ATENÇÃO: A sua senha foi alterada em " + DateTime.Today.Date.ToLongDateString() + ".";
                noti.USUA_CD_ID = usuario.USUA_CD_ID;
                noti.NOTI_IN_ENVIADA = 1;
                noti.NOTI_IN_STATUS = 1;
                noti.NOTI_IN_NIVEL = 1;
                Int32 volta1 = _notiService.Create(noti);


                //Monta Log
                LOG log = new LOG
                {
                    LOG_DT_DATA = DateTime.Now,
                    COND_CD_ID = idAss.Value,
                    USUA_CD_ID = usuario.USUA_CD_ID,
                    LOG_NM_OPERACAO = "ChangePWD",
                    LOG_TX_REGISTRO = Serialization.SerializeJSON<USUARIO>(usuario),
                };

                // Persiste
                return _usuarioService.EditUser(usuario);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Int32 GenerateNewPassword(String email, Int32? idAss)
        {
            // Checa email
            if (!ValidarItensDiversos.IsValidEmail(email))
            {
                return 1;
            }
            USUARIO usuario = _usuarioService.RetriveUserByEmail(email);
            if (usuario == null)
            {
                return 2;
            }

            // Verifica se usuário está ativo
            if (usuario.USUA_IN_ATIVO == 0)
            {
                return 3;
            }

            // Verifica se usuário não está bloqueado
            if (usuario.USUA_IN_BLOQUEADO == 1)
            {
                return 4;
            }

            // Gera nova senha
            String senha = Cryptography.GenerateRandomPassword(6);

            // Atauliza objeto
            //usuario.USUA_NM_SENHA = Cryptography.Encode(senha);
            usuario.USUA_NM_SENHA = senha;
            usuario.USUA_IN_PROVISORIA = 1;
            usuario.USUA_DT_ALTERACAO = DateTime.Now;
            usuario.USUA_DT_TROCA_SENHA = DateTime.Now;
            usuario.USUA_IN_LOGIN_PROVISORIO = 0;

            // Recupera template e-mail
            String header = _usuarioService.GetTemplate("NEWPWD").TEMP_TX_CABECALHO;
            String body = _usuarioService.GetTemplate("NEWPWD").TEMP_TX_CORPO;
            String data = _usuarioService.GetTemplate("NEWPWD").TEMP_TX_DADOS;

            // Prepara dados do e-mail  
            header = header.Replace("{Nome}", usuario.USUA_NM_NOME);
            data = data.Replace("{Data}", usuario.USUA_DT_TROCA_SENHA.Value.ToLongDateString());
            data = data.Replace("{Senha}", usuario.USUA_NM_SENHA);

            // Concatena
            String emailBody = header + body + data;

            // Monta e-mail
            Email mensagem = new Email();
            CONFIGURACAO conf = _usuarioService.CarregaConfiguracao(idAss);
            mensagem.ASSUNTO = "Geração de Nova Senha";
            mensagem.CORPO = emailBody;
            mensagem.DEFAULT_CREDENTIALS = false;
            mensagem.EMAIL_DESTINO = usuario.USUA_NM_EMAIL;
            mensagem.EMAIL_EMISSOR = conf.CONF_NM_EMAIL_EMISSOR;
            mensagem.ENABLE_SSL = true;
            mensagem.NOME_EMISSOR = "ERP_Condominio ";
            mensagem.PORTA = conf.CONF_NM_PORTA_SMTP;
            mensagem.PRIORIDADE = System.Net.Mail.MailPriority.High;
            mensagem.SENHA_EMISSOR = conf.CONF_NM_SENHA_EMAIL_EMISSOR;
            mensagem.SMTP = conf.CONF_NM_HOST_SMTP;

            // Envia e-mail
            Int32 voltaMail = CommunicationPackage.SendEmail(mensagem);

            // Atualiza usuario
            Int32 volta = _usuarioService.EditUser(usuario);

            // Retorna sucesso
            return 0;
        }

        public Int32 ExecuteFilter(Int32? perfilId, String nome, String login, String email, Int32? idCargo, Int32? idAss, out List<USUARIO> objeto)
        {
            try
            {
                objeto = new List<USUARIO>();
                Int32 volta = 0;

                // Processa filtro
                objeto = _usuarioService.ExecuteFilter(perfilId, nome, login, email, idCargo, idAss);
                if (objeto.Count == 0)
                {
                    volta = 1;
                }
                return volta;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<PERFIL> GetAllPerfis()
        {
            List<PERFIL> lista = _usuarioService.GetAllPerfis();
            return lista;
        }
    }
}
