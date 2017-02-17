using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fatec.Treinamento.Model;

namespace Fatec.Treinamento.Web.Models
{
    /// <summary>
    /// Um viewmodel serve para trabalhar com os dados na view.
    /// Esse viewmodel é usado para obter os dados de registro de usuario
    /// </summary>
    public class ModificaUsuarioViewModel
    {
        [Required(ErrorMessage = "O campo {0} é Obrigatório.")]
        [EmailAddress(ErrorMessage = "O campo Email deve conter um endereço de email válido.")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        public IEnumerable<SelectListItem> ListaPerfil { get; set; }

        public int IdPerfil { get; set; }


    }
}