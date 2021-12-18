using ProjetoFinal.Models.Enuns;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal.Models
{
    public class Usuario
    {
        [Key]
        public string Login { get; set; }
        public string Senha { get; set; }
        public Status Enumeracao { get; set; }

        public Usuario() 
        { 
        }

        public Usuario(string login, string senha, Status enumeracao)
        {
            Login = login;
            Senha = senha;
            Enumeracao = enumeracao;
        }
    }
}
