using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klingon.Methods
{
    public class DesafioKlingon
    {
        private char[] _alfabetoKlingon = { 'k', 'b', 'w', 'r', 'q', 'd', 'n', 'f', 'x', 'j', 'm', 'l', 'v', 'h', 't', 'c', 'g', 'z', 'p', 's' };
        private char[] _alfabeto = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y' };

        public int GetPreposicoes(string texto)
        {
            String[] listaB = texto.Split(' ');
            int qtdPreposicoes = 0;
            foreach (var palavra in listaB)
            {
                if (palavra.Length == 3 && (!palavra.EndsWith("s") && !palavra.EndsWith("l") && !palavra.EndsWith("f") && !palavra.EndsWith("w") && !palavra.EndsWith("k")) && !palavra.Contains("d"))
                    qtdPreposicoes++;
            }

            return qtdPreposicoes;
        }

        public int GetVerbos(string texto, bool primeira)
        {
            String[] listaB = texto.Split(' ');
            int qtdVerbos = 0;
            int qtdPrimeira = 0;
            foreach (var palavra in listaB)
            {
                if (palavra.Length >= 8 && (palavra.EndsWith("s") || palavra.EndsWith("l") || palavra.EndsWith("f") || palavra.EndsWith("w") || palavra.EndsWith("k")))
                {
                    qtdVerbos++;

                    if ((!palavra.StartsWith("s") && !palavra.StartsWith("l") && !palavra.StartsWith("f") && !palavra.StartsWith("w") && !palavra.StartsWith("k")))
                        qtdPrimeira++;
                }
            }

            if (primeira)
                return qtdPrimeira;
            else
                return qtdVerbos;
        }

        public int GetNumerosBonitos(string texto)
        {
            String[] listaB = texto.Split(' ');
            int qtdeNumerosBonitos = 0;
            foreach (var palavra in listaB)
            {
                long numero = 0;
                long peso = 1;
                foreach (var letra in palavra)
                {
                    numero += Array.IndexOf(_alfabetoKlingon, letra) * peso;
                    peso *= 20;
                }
                if (numero >= 440566 && numero % 3 == 0)
                {
                    qtdeNumerosBonitos++;
                }
            }
            return qtdeNumerosBonitos;
        }
    }
}
    

