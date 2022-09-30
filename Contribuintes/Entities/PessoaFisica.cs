using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Contribuintes.Entities
{
    internal class PessoaFisica : Pessoa
    {
        //Auto Properties
        public double GastoComSaude { get; set; }
        
        //Constructors
        public PessoaFisica()
        {

        }

        public PessoaFisica(string nome, double rendaAnual,double gastoComSaude) 
            : base(nome, rendaAnual)
        {
            GastoComSaude = gastoComSaude;
        }

        //methods
        public override double Impostos()
        {
            double imposto;
            if (RendaAnual < 20000)
            {
                imposto = (RendaAnual * 0.15) - GastoComSaude * 0.5;
            }
            else
            {
                imposto = (RendaAnual * 0.25) - GastoComSaude * 0.5; 
            }
            return imposto;
        }
    }
}
