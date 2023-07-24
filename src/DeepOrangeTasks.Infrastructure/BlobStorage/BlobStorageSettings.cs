namespace DeepOrangeTasks.Infrastructure.BlobStorage;

public class BlobStorageSettings
{
    public const string SectionName = "BlobStorageSettings";
    public string BlobConnection { get; init; } = null!;
    public string Container { get; init; } = null!;
}