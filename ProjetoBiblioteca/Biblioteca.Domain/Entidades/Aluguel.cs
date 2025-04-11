using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Domain.Entidades
{
    public class Aluguel
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public Guid UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        [Required]
        public Guid LivroId { get; set; }
        public Livro Livro { get; set; }

        [Required]
        public DateTime DataAluguel { get; set; }
        public DateTime? DataDevolucao { get; set; }
    }
}
