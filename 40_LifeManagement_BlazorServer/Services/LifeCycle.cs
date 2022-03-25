namespace _40_LifeManagement_BlazorServer.Services;
public class LifeCycle : ITransient, IScoped, ISingleton
{
    private string _guid;
    public LifeCycle()
    {
        _guid = Guid.NewGuid().ToString();  
    }

    public string GetGuid()
    {
        return _guid;
    }
}
