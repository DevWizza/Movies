using System;
using System.Threading.Tasks;
using Movies.Services;
using Newtonsoft.Json;

namespace Movies.Services
{
    public class JsonReaderService : IJsonReaderService
    {
        readonly IFileService _fileService;

        public JsonReaderService(IFileService fileService)
        {
            _fileService = fileService;
        }

        public async Task<T> GetStringAsJsonObjectAsync<T>(string fileName)
        {
            return await Task.Run(async() => {

                var json = await _fileService.GetFile(fileName);

                return JsonConvert.DeserializeObject<T>(json);
            });
        }
    }
}
