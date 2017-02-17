using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatec.Treinamento.Model
{
    public class Curso
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O Nome deve ter ao menos 6 caracteres.", MinimumLength = 6)]
        public string Nome { get; set; }

        public int Classificacao { get; set; }

    }
}
