using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios
{
    internal class Carro
    {
        public string? Fabricante { get; set; }
        public string? Modelo { get; set; }
        private int ano;
        public int Ano {
            get { return ano; }
        
            set {
                int anoMinimo = 1960;
                int anoMaximo = 2023;

                if(value >= anoMinimo && value <= anoMaximo)
                {
                    ano = value;
                }
                else
                {
                    Console.WriteLine($"O ano deve estar entre {anoMinimo} e {anoMaximo}.");
                }
            } }
        public string? DescricaoDetalhada => $"O carro de {Modelo} é do fabricante {Fabricante} que foi fabricado no ano de {Ano}.";
        public void Acelerar()
        {
            Console.WriteLine("Acelerei");
        }
        public void Frear()
        {
            Console.WriteLine("Freei");
        }

        public void Buzinar()
        {
            Console.WriteLine("Bii Bii!");
        }
    }
}
