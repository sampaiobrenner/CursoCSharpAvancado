using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosExtensao
{
    public static class StringExtensions 
    {
        public static string InverterCaixas(this string texto, bool estadoInicial)
        {
            bool isUpperCase = estadoInicial;
            string resultado = "";

            for (int i = 0; i < texto.Length; i++)
            {               
                resultado += isUpperCase ? texto[i].ToString().ToUpper() : texto[i].ToString().ToLower();
                isUpperCase = !isUpperCase;
            }

            return resultado;


        }
    }
}
