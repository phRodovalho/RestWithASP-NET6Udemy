using RestWithASP_NET6Udemy.Model;
using RestWithASP_NET6Udemy.Services.Implementations;

namespace RestWithASP_NET6Udemy.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
