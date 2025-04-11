using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Domain.Entidades
{
    public class Livro
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(150)]
        public string Titulo { get; set; }

        [Range(1000, 2100)]
        public int AnoPublicacao { get; set; }

        [Required]
        public Guid AutorId { get; set; }
        public Autor Autor { get; set; }
        public ICollection<Aluguel> Alugueis { get; set; }
    }
}
