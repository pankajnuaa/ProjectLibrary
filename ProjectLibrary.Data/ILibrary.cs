using System;
using System.Collections.Generic;
using System.Text;
using ProjectLibrary.Core;

namespace ProjectLibrary.Data
{
    public interface ILibraryData
    {
        IEnumerable<Library> GetAlLibraries();
    }

    public class InMemoryLibraryData : ILibraryData
    {
        private List<Library> libraries;
        public InMemoryLibraryData()
        {
            libraries = new List<Library>()
            {
                new Library() {BookId = 1, Author = "J. R. R. Tolkien", BookName = "Lord of the Rings",Genre = Genres.Fantacy},
                new Library() {BookId = 2, Author = "Ray Bradbury", BookName = "Fahrenheit 451",Genre = Genres.ScienceFiction},
                new Library() {BookId = 3, Author = "Agatha Christie", BookName = "Murder on the Orient Express",Genre = Genres.Mystery},
            };
        }
        public IEnumerable<Library> GetAlLibraries()
        {
            return libraries;
        }
    }
}
