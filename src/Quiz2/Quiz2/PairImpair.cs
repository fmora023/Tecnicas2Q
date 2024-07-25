using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2
{
    /// <summary>
    /// PairImpair class.
    /// </summary>
    public class PairImpair
    {
        /// <summary>
        /// Gets or sets the pares.
        /// </summary>
        public List<int> Pares { get; set; }

        /// <summary>
        /// Gets or sets the impares.
        /// </summary>
        public List<int> Impares { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PairImpair"/> class.
        /// </summary>
        public PairImpair()
        {
            Pares = new List<int>();
            Impares = new List<int>();
        }
    }
}
