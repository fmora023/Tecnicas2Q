using ModelClase.Interface;
using System.Text;

namespace ControllerClase
{
    /// <summary>
    /// Handles the Users/Persona.
    /// </summary>
    public class UserController
    {
        private string FileName { get; set; } = "Users.csv";
        private int UserCount { get; set; } = 100;
        private FileController FileController { get; set; } = new FileController();

        /// <summary>
        /// Gets the users.
        /// </summary>
        /// <returns>The list of the system's users.</returns>
        public List<IPersona> GetUsers()
        {
            var filePath = this.GetFile();
            var result = this.FileController.LoadPeople(filePath);
            return result;
        }

        private string GetFile()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), this.FileName);
            if (!File.Exists(filePath))
            {
                this.GenerateUsers(filePath, this.UserCount);
            }

            return filePath;
        }

        private void GenerateUsers(string filePath, int data)
        {
            var names = new string[] { "Leiver", "Jarlet", "Luis", "Monserrat", "Angelo", "Oscar", "David", "Francisco", "Jonathan" };
            var lastNames = new string[] { "Gonzalez", "Perez", "Gomez", "Garcia", "Hernandez", "Lopez", "Martinez", "Rodriguez", "Sanchez" };
            var country = new string[] { "Colombia", "Mexico", "Argentina", "Chile", "Peru", "Ecuador", "Venezuela", "Bolivia", "Uruguay" };

            var random = new Random();

            using (var sw = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                sw.WriteLine("Name,Lastname,Country");
                var rowCount = 0;

                for (int i = 0, j = 0, k = 0; rowCount < data; k++, i++, j++)
                {
                    if (names.Length - 1 == i || lastNames.Length - 1 == j || country.Length - 1 == k)
                    {
                        i = 0;
                        j = 0;
                        k = 0;
                    }

                    var nameRand = random.Next(0, names.Length);
                    var lastNameRand = random.Next(0, lastNames.Length);
                    var countryRand = random.Next(0, country.Length);

                    sw.WriteLine($"{names[nameRand]},{lastNames[lastNameRand]},{country[countryRand]}");
                    rowCount++;
                }
            }
        }
    }
}
