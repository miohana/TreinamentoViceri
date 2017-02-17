using Fatec.Treinamento.Data.Repositories;
using Fatec.Treinamento.Model;
using Fatec.Treinamento.Model.Enum;
using Fatec.Treinamento.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

using Microsoft.Owin.Host.SystemWeb;

namespace Fatec.Treinamento.Web.Controllers
{
    public class AdminUsuariosController : Controller
    {
        [AllowAnonymous]
        [HttpGet]
        public ActionResult Index()
        {

            ModificaUsuarioViewModel model = new ModificaUsuarioViewModel();

            using (var repo = new PerfilRepository())
            {
                var lista = repo.Listar();
                model.ListaPerfil = (from x in lista
                                     select new SelectListItem
                                     {
                                         Text = x.Nome,
                                         Value = x.Id.ToString()
                                     });
            }

            return View(model);

        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Index(ModificaUsuarioViewModel model)
        {
            if (ModelState.IsValid)
            {
                using (AdminUsuarioRepository repo = new AdminUsuarioRepository())
                {
                    var id = repo.ConsultarIdUsuario(model.Email);

                    if (id > 0)
                    {
                        var usuario = new Usuario
                        {
                            Perfil = new Perfil { Id = (int)model.IdPerfil },
                            Id = id
                        };

                        repo.AlterarVisibilidade(usuario);
                    }
                    else { 
                        //TODO: Enviar mensagem de email inválido.
                    } 
                }
                //TODO: logar o usuario
                return RedirectToAction("Index", "Home");
            }
            else {
                // Se chegou aqui, temos um problema. Devolvo o model para o form novamente.
                return View(model);
            }
        }





        private Perfil AtualizarPerfil(Perfil perfil)
        {
            using (PerfilRepository repo = new PerfilRepository())
            {

                perfil.Nome = "Nome Atualizado";
                repo.Atualizar(perfil);

                var perfilAtualizado = repo.Obter(perfil.Id);

                return perfilAtualizado;
            }
        }


    }
}