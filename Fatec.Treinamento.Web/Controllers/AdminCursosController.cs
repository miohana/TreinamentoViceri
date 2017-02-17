using Fatec.Treinamento.Data.Repositories;
using Fatec.Treinamento.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fatec.Treinamento.Web.Models;

namespace Fatec.Treinamento.Web.Controllers
{
    // Obs: Colocando o atributo [Authorize] no controller, garante que todas as actions so podem ser
    // acessadas quando o usuário estiver autorizado a utilizar.
    // Quando informo o parametro "Roles", indico que só quem tiver o perfil administrador poderá acessar.

    //[Authorize(Roles="Administrador")]
    public class AdminCursosController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var repo = new CursoRepository();

            var lista = repo.Listar();

            return View(lista);
        }

        [HttpGet]
        public ActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar(Curso curso)
        {
            using (var repo = new CursoRepository())
            {
                var inserido = repo.Inserir(curso);

                if (inserido.Id == 0)
                {
                    ModelState.AddModelError("", "Erro");
                }

            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            using (var repo = new CursoRepository())
            {
                var curso = repo.Obter(id);

                return View(curso);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Curso curso)
        {
            using (var repo = new CursoRepository())
            {
                curso = repo.Atualizar(curso);

                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public ActionResult Excluir(int id)
        {
            using (var repo = new CursoRepository())
            {
                repo.Excluir(id);

                return RedirectToAction("Index");
            }
        }
    }
}