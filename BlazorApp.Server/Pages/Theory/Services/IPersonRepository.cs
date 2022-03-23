namespace BlazorApp.Server.Pages.Theory.Services;
public interface IPersonRepository
{
    List<Person> GetPersonsByFilter(string filter = null);
    Person GetPersonbyId(int Id);
}
