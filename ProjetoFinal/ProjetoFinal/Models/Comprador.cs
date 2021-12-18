using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal.Models
{
    public class Comprador
    {
        [Key]
        public double Cpf { get; set; }
        public string Primeiro_nome { get; set; }
        public string Sobrenome { get; set; }
        public double Telefone { get; set; }
        public ICollection<Usuario> Comprador_usuario { get; set; } = new List<Usuario>();


        public Comprador() 
        { 
        }

        public Comprador(double cpf, string primeiro_nome, string sobrenome, double telefone)
        {
            Cpf = cpf;
            Primeiro_nome = primeiro_nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }
    }
}
