// <copyright file="FileUtils.cs" company="Telerik academy">
// Telerik academy homework for high quality classes - Task 02.Utils
// </copyright>
namespace Utils
{
    using System;

    /// <summary>
    /// Represents the File utilities class which
    /// works with strings which contain file directory and naming data.
    /// </summary>
    public static class FileUtils
    {
        /// <summary>
        /// Gets the file extension from a string
        /// which contains file directory and naming data.
        /// </summary>
        /// <param name="path">The name of the file.</param>
        /// <returns>
        /// Returns a string containing the file extension(all charecters after the last '.' in the file name)
        /// or System.String.Empty if the file has no extension information.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">Thrown when the path is null, empty or whitespace.</exception>
        public static string GetFileExtension(string path)
        {
            if (string.IsNullOrEmpty(path) || string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentNullException("The path can't be null, empty or whitespace.");
            }

            int indexOfLastDot = path.LastIndexOf(".");
            
            if (indexOfLastDot == -1)
            {
                return string.Empty;
            }

            string extension = path.Substring(indexOfLastDot + 1);

            return extension;
        }

        /// <summary>
        /// Gets the file without the extension, from a string
        /// which contains file directory and naming data.
        /// </summary>
        /// <param name="path">The name of the file without the extension.</param>
        /// <returns>
        /// Returns a string containing the file without the extension. 
        /// </returns>
        /// <exception cref="System.ArgumentNullException">Thrown when the path is null, empty or whitespace.</exception>
        public static string GetFileNameWithoutExtension(string path)
        {
            if (string.IsNullOrEmpty(path) || string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentNullException("The path can't be null, empty or whitespace.");
            }

            int indexOfLastDot = path.LastIndexOf(".");

            if (indexOfLastDot == -1)
            {
                return path;
            }

            string extension = path.Substring(0, indexOfLastDot);

            return extension;
        }
    }
}
