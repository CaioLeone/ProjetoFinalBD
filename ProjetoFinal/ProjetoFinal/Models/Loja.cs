using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal.Models
{
    public class Loja
    {
        [Key]
        public double Cnpj { get; set; }
        public string Nome { get; set; }
        public double Num_Vendas { get; set; }
        public ICollection<Usuario> Loja_usuario { get; set; } = new List<Usuario>();


        public Loja() 
        { 
        }

        public Loja(double cnpj, string nome, double num_Vendas)
        {
            Cnpj = cnpj;
            Nome = nome;
            Num_Vendas = num_Vendas;
        }
    }
}
