using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contribuintes.Entities
{
    internal class PessoaJuridica : Pessoa
    {
        public int NumeroDeFuncionarios { get; set; }

        //Constructors
        public PessoaJuridica()
        {

        }

        public PessoaJuridica(string nome, double rendaAnual, int numeroDeFuncionarios)
            : base(nome, rendaAnual)
        {
            NumeroDeFuncionarios = numeroDeFuncionarios;
        }

        //Methods
        public override double Impostos()
        {
            double imposto;
            if (NumeroDeFuncionarios > 10)
            {
                imposto = RendaAnual * 0.14;
            }
            else
            {
                imposto = RendaAnual * 0.16;
            }
            return imposto;
        }
    }
}
