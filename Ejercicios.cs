using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClase
{
    /// <summary>
    /// Ejercicios de clase.
    /// </summary>
    public static class Ejercicios
    {
        /// <summary>
        /// Gets the menor element in a list.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>the minor element.</returns>
        public static int GetMenor(List<int> input)
        {
            if (input == null || input.Count == 0)
            {
                throw new ArgumentException("The input is null or empty");
            }

            var result = input[0];
            for (var index = 1; index < input.Count; index++)
            {
                if (input[index] < result)
                {
                    result = input[index];
                }
            }

            return result;
        }
    }
}
