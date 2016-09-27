namespace StructuredData.Common.interfaces
{
    public interface IFileSystem
    {
        bool Exists(string fileFullPath);
        string ReadAllText(string fileFullPath);
    }
}