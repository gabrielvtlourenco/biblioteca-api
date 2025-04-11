using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Domain.Entidades
{
    public class Autor
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [MaxLength(50)]
        public string Nacionalidade { get; set; }
        public ICollection<Livro> Livros { get; set; }
    }
}
