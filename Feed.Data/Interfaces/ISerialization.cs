namespace Feed.Data.Interfaces
{
    public interface ISerialization
    {
        T Deserialize<T>(string xml) where T : class;
    }
}