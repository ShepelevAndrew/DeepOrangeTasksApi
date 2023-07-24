using Microsoft.AspNetCore.Http;

namespace DeepOrangeTasks.Application.Common.Interfaces.BlobStorage;

public interface IBlobStorageService
{
    Task<bool> GetBlobAsync(string name);
    Task<bool> UploadBlobAsync(IFormFile file);
    Task<bool> DeleteBlobAsync(string name);
}