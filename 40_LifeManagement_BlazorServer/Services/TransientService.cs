namespace _40_LifeManagement_BlazorServer.Services;
public class TransientService : ITransient
{
    private string _guid;
    public TransientService()
    {
        _guid = Guid.NewGuid().ToString();
    }

    public string GetGuid()
    {
        return _guid;
    }  
}
