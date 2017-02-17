using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatec.Treinamento.Model
{
    public class Mensagem
    {
        public int Id { get; set; }
        
        public string Assunto { get; set; }

        public string Remetente { get; set; }
        
        public string Destinatario { get; set; }

        public string Message { get; set; }

        public string IdUsuario { get; set; }
    }
}
