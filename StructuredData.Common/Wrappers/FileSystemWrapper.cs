using System.ComponentModel.Composition;
using System.IO;
using StructuredData.Common.interfaces;

namespace StructuredData.Common.Wrappers
{
    [Export(typeof(IFileSystem))]
    public class FileSystemWrapper : IFileSystem
    {
        public bool Exists(string fileFullPath)
        {
            return File.Exists(fileFullPath);

        }

        public string ReadAllText(string fileFullPath)
        {
            return File.ReadAllText(fileFullPath);
        }
    }
}