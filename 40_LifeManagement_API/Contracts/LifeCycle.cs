namespace _40_LifeManagement_API.Contracts;
public class LifeCycle : ITransient, IScoped, ISingleton
{
    private string _guid;
    public LifeCycle()
    {
        _guid = Guid.NewGuid().ToString();
    }
    public string GenerateGuid()
    {
        return _guid;
    }
}
