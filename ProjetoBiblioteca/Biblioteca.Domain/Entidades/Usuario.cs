using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Biblioteca.Domain.Entidades
{
    public class Usuario
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [MaxLength(20)]
        public string Telefone { get; set; }
        public ICollection<Aluguel> Alugueis { get; set; }

    }
}
