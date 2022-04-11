namespace _40_LifeManagement_BlazorServer.Services;
public class SingletonService : ISingleton
{
    private string _guid;
    public SingletonService()
    {
        _guid = Guid.NewGuid().ToString();
    }

    public string GetGuid()
    {
        return _guid;
    }
}
