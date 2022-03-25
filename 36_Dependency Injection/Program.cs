var user =  new User();
user.Add();

var user_IoC_1= new User_IoC(new OracleDataBase());
user_IoC_1.Add();

var user_IoC_2 = new User_IoC(new MySqlDataBase());
user_IoC_2.Add();


//Bussiness Layer
//1. Procedural Programming(Concrete implementation -> bad way)
public class User
{
    SqlServerDataBase db;
    public User()
    {
        db= new SqlServerDataBase();
    }
    public void Add()
    {
        db.Persiste();
    }
}

//2. Investion of Control - IoC (Abstract implementation -> good way)
public class User_IoC
{
    private readonly IDataBase _db;

    public User_IoC(IDataBase db)
    {
        _db = db;
    }

    public void Add()
    {
        _db.Persiste();
    }
}

// Database Access Layer

public class SqlServerDataBase // -> bad way
{
    public void Persiste()
    {
        Console.WriteLine("SqlServer DataBase");
    }
}

public class OracleDataBase : IDataBase// -> good way
{
    public void Persiste()
    {
        Console.WriteLine("Oracle DataBase");
    }
}

public class MySqlDataBase : IDataBase
{
    public void Persiste()
    {
        Console.WriteLine("MySql DataBase");
    }
}

public interface IDataBase
{
    public void Persiste();
}
