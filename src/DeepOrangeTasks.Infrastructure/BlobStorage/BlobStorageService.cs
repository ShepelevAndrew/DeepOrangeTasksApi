using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using DeepOrangeTasks.Application.Common.Interfaces.BlobStorage;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

namespace DeepOrangeTasks.Infrastructure.BlobStorage;

public class BlobStorageService : IBlobStorageService
{
    private readonly BlobServiceClient _blobServiceClient;
    private readonly BlobStorageSettings _blobSettings;

    public BlobStorageService(BlobServiceClient blobServiceClient, IOptions<BlobStorageSettings> blobOptions)
    {
        _blobServiceClient = blobServiceClient;
        _blobSettings = blobOptions.Value;
    }

    public async Task<bool> GetBlobAsync(string name)
    {
        var containerClient = _blobServiceClient.GetBlobContainerClient(_blobSettings.Container);
        var blobClient = containerClient.GetBlobClient(name);

        var data = await blobClient.OpenReadAsync();
        Stream blobContent = data;

        var content = await blobClient.DownloadContentAsync();
        string contentType = content.Value.Details.ContentType;

        return true;
    }

    public async Task<bool> UploadBlobAsync(IFormFile file)
    {
        var containerClient = _blobServiceClient.GetBlobContainerClient(_blobSettings.Container);
        var name = Guid.NewGuid().ToString();
        var blobClient = containerClient.GetBlobClient(name);

        var httpHeaders = new BlobHttpHeaders() {
            ContentType = file.ContentType
        };

        var res = await blobClient.UploadAsync(file.OpenReadStream(), httpHeaders);

        return true;
    }

    public async Task<bool> DeleteBlobAsync(string name)
    {
        var containerClient = _blobServiceClient.GetBlobContainerClient(_blobSettings.Container);
        var blobClient = containerClient.GetBlobClient(name);

        return await blobClient.DeleteIfExistsAsync();
    }
}