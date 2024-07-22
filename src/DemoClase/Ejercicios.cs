using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClase.Utilities
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

        /// <summary>
        /// Gets the sum of the elements of a list.
        /// </summary>
        /// <param name="input"></param>
        /// <returns> the sum of the elements.</returns>
        public static int GetElementsSum(List<int> input)
        {
            var result = 0;

            if (ValidateInput(input))
            {
                foreach (var item in input)
                {
                    result += item;
                }
            }

            return result;
        }

        /// <summary>
        /// Gets the par and impar elements of a list.
        /// </summary>
        /// <param name="input"></param>
        /// <returns> An Ejercicio3 element with the results.</returns>
        public static Ejercicio3 GetParImpar(List<int> input)
        {
            var result = new Ejercicio3();

            if (ValidateInput(input))
            {
                foreach (var element in input)
                {
                    if (element % 2 == 0)
                    {
                        result.Pares.Add(element);
                    }
                    else
                    {
                        result.Impares.Add(element);
                    }
                }
            }            

            return result;
        }

        private static bool ValidateInput(List<int> input)
        {
            if (input == null || input.Count == 0)
            {
                return false;
            }

            return true;
        }
    }
}
