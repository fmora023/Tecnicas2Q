using Quiz2.Enums;

namespace Quiz2
{
    /// <summary>
    /// Different algorithms for different purposes.
    /// ****************  HAY UN EJERCICIO CON ERRORES  ****************
    /// </summary>
    public static class Algorithms
    {
        /// <summary>
        /// Sums the specified x and y values.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        public static int Sum(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// Divs the specified x / y.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException">Divisor cannot be zero.</exception>
        public static int Div(int x, int y)
        {
            if (y == 0)
            {
                throw new ArgumentException("Divisor cannot be zero.");
            }

            return x / y;
        }

        /// <summary>
        /// Sums the digits of the input.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>the sum of the digits</returns>
        public static int SumDigits(int input)
        {
            if (input == 0)
            {
                return -1;
            }

            var sum = 0;
            while (input != 0)
            {
                sum += input % 10;
                input /= 10;
            }

            return sum;
        }

        /// <summary>
        /// Converts the temperature.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="temperatureInput">The temperature input.</param>
        /// <param name="temperatureOutput">The temperature output.</param>
        /// <returns></returns>
        public static int ConvertTemperature(int value, Temperature temperatureInput, Temperature temperatureOutput)
        {
            switch (temperatureInput, temperatureOutput)
            {
                case (Temperature.Celsius, Temperature.Fahrenheit):
                    return (value * 9 / 5) + 32;

                case (Temperature.Celsius, Temperature.Kelvin):
                    return value + 273;

                case (Temperature.Fahrenheit, Temperature.Celsius):
                    return (value - 32) * 5 / 9;

                case (Temperature.Fahrenheit, Temperature.Kelvin):
                    return (value - 32) * 5 / 9 + 273;

                case (Temperature.Kelvin, Temperature.Celsius):
                    return value - 273;

                case (Temperature.Kelvin, Temperature.Fahrenheit):
                    return (value - 273) * 9 / 5 + 32;

                default:
                    return -1;
            }
        }

        /// <summary>
        /// Replaces the specified full string.
        /// </summary>
        /// <param name="fullStr">The full string.</param>
        /// <param name="replace">The replace.</param>
        /// <param name="replacement">The replacement.</param>
        /// <returns></returns>
        public static string Replace(string fullStr, char replace, char replacement)
        {
            var output = fullStr;
            for (var i = 0; i < fullStr.Length; i++)
            {
                if (fullStr[i] == replace)
                {
                    output = output.Remove(i, 1).Insert(i, replacement.ToString());
                }
            }

            return fullStr;
        }

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
        /// <returns> An PairImpair element with the results.</returns>
        public static PairImpair GetParImpar(List<int> input)
        {
            var result = new PairImpair();

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

        /// <summary>
        /// Occurrences of the specified input.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>A dicctionary with the elements and its occurrences.</returns>
        public static Dictionary<string, int> Occurrences(string input)
        {
            var result = new Dictionary<string, int>();
            var array = input.ToLower().Split(' ');
            foreach (var item in array)
            {
                if (result.ContainsKey(item.ToLower()))
                {
                    result[item]++;
                }
                else
                {
                    result.Add(item, 1);
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
