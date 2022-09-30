using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contribuintes.Entities
{
    internal abstract class Pessoa
    {
        //Auto Properties
        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        //Constructors
        public Pessoa()
        {

        }

        public Pessoa(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        //Methods
        public abstract double Impostos();
    }
}
