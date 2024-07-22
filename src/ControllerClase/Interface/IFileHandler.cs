using ModelClase.Interface;

namespace ControllerClase.Interface
{
    /// <summary>
    /// Interface for file handle.
    /// </summary>
    public interface IFileHandler
    {
        /// <summary>
        /// Loads the file.
        /// </summary>
        /// <param name="filePath">The filePath.</param>
        string LoadFile(string filePath);

        /// <summary>
        /// Loads the people.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        List<IPersona> LoadPeople(string path);

        /// <summary>
        /// Saves the file.
        /// </summary>
        /// <param name="path">The path.</param>
        bool SaveFile(string path);
    }
}
