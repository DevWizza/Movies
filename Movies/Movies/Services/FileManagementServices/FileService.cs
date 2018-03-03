using System;
using System.Reflection;
using System.Threading.Tasks;

namespace Movies.Services
{
    public class FileService : IFileService
    {
        public FileService()
        {
        }

        public async Task<string> GetFile(string fileName)
        {
            var assembly = typeof(FileService).GetTypeInfo().Assembly;

            var stream = assembly.GetManifestResourceStream(fileName);

            string content = null;

            using (var reader = new System.IO.StreamReader(stream))
            {
                content = await reader.ReadToEndAsync();
            }

            return content;
        }
    }
}
