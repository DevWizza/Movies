using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Movies.Services
{
    public interface IJsonReaderService
    {
        Task<T> GetStringAsJsonObjectAsync<T>(string fileName);
    }
}
