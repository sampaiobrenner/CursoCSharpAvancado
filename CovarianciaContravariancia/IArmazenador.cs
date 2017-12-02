using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianciaContravariancia
{
    interface IArmazenador<in T> //Contravariancia
    {
        /// <summary>
        /// Armazenador genérico
        /// </summary>
        /// <param name="item"></param>
        void Armazenar(T item);
    }
}
