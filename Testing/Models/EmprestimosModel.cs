using System;

namespace Testing.Models
{
    public class ErrorViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do Recebedor!")]
        public string Recebedor { get; set; }

        [Required(ErrorMessage = "Digite o nome do Fornecedor!")]
        public string Fornecedor { get; set; }

        [Required(ErrorMessage = "Digite o nome do Livro Emprestado!")]
        public string LivroEmprestado { get; set; }

        public DateTime DataUltimaAtt { get; set; } = DateTime.Now
    }
}