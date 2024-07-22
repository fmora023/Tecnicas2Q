using ControllerClase.Interface;
using ModelClase;
using ModelClase.Interface;

namespace ControllerClase
{
    /// <summary>
    /// Implements the File handle.
    /// </summary>
    /// <seealso cref="ControllerClase.Interface.IFileHandler" />
    public class FileController : IFileHandler
    {
        /// <summary>
        /// Loads the file.
        /// </summary>
        /// <param name="filePath">The filePath.</param>
        /// <returns>The content of a file</returns>
        public string LoadFile(string filePath)
        {
            var content = File.ReadAllText(filePath);
            return content;
        }

        /// <summary>
        /// Loads the people.
        /// </summary>
        /// <param name="path">The filePath.</param>
        /// <returns>A list of People from the file.</returns>
        public List<IPersona> LoadPeople(string path)
        {
            var result = new List<IPersona>();
            var content = this.LoadFile(path);
            var lines = content.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                var person = new Person();
                person.Name = parts[0];
                person.LastName = parts[1];
                person.Country = parts[2];
                result.Add(person);
            }

            return result;
        }

        /// <summary>
        /// Saves the file.
        /// </summary>
        /// <param name="path">The filePath.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool SaveFile(string path)
        {
            throw new NotImplementedException();
        }
    }
}
