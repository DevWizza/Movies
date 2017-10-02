using System;
using System.Threading.Tasks;

namespace Movies.Services
{
    public interface IFileService
    {
        Task<string> GetFile(string fileName);
    }
}
