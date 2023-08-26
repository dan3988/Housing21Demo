namespace Demo.Website.Exceptions;

public class NotFoundException : Exception
{
    public string ObjectName { get; }

    public int ObjectId { get; }

    public NotFoundException(string objectName, int objectId) : base($"Could not find {objectName} with ID {objectId}")
    {
        ObjectName = objectName;
        ObjectId = objectId;
    }
}
