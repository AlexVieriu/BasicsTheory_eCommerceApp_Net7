namespace _40_LifeManagement_BlazorServer.Services;
public class ScopedService : IScoped
{
    private string _guid;
    public ScopedService()
    {
        _guid = Guid.NewGuid().ToString();
    }

    public string GetGuid()
    {
        return _guid;
    }
}
