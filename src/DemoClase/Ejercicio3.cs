using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClase
{
    /// <summary>
    /// Template for result of Ejercicio3.
    /// </summary>
    public class Ejercicio3
    {
        /// <summary>
        /// Gets or sets the pares.
        /// </summary>
        public List<int> Pares { get;set; }

        /// <summary>
        /// Gets or sets the impares.
        /// </summary>
        public List<int> Impares { get;set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ejercicio3"/> class.
        /// </summary>
        public Ejercicio3()
        {
            Pares = new List<int>();
            Impares = new List<int>();
        }
    }
}
