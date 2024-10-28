using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Models
{
    public class EmprestimoModel
    {
        // modelo do banco de dados 
        public int Id { get; set; }
        public string Recebedor { get; set; }
        public string Fornecedor { get; set; }
        public string LivroEmprestado { get; set; }
        public DateTime DataEmprestimo { get; set; } = DateTime.Now; //data atual
    }
}