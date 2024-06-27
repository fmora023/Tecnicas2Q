using DemoClase.Utilities;

namespace DemoClase
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            var list = new List<int> { 10, 2, 3, 54, 5, 6, 9, 1 };
            
            var menor = Ejercicios.GetMenor(list);
            Console.WriteLine($"El menor es: {menor}");

            var summatory = Ejercicios.GetElementsSum(list);
            Console.WriteLine($"La suma de los elementos es: {summatory}");

            var par_impar = Ejercicios.GetParImpar(list);

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}