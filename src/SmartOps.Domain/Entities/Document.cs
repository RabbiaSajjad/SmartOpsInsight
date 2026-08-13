namespace SmartOps.Domain.Entities;

public class Document
{
    public Guid Id { get; private set; }

    public string Title { get; private set; }

    public string FileName { get; private set; }

    public string ContentType { get; private set; }

    public string Source { get; private set; }

    public DateTime CreatedAt { get; private set; }

    public Document(
        string title,
        string fileName,
        string contentType,
        string source)
    {
        Id = Guid.NewGuid();
        Title = title;
        FileName = fileName;
        ContentType = contentType;
        Source = source;
        CreatedAt = DateTime.UtcNow;
    }
}