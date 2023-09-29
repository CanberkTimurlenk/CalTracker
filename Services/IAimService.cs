using Entities.Concrete;

namespace Services
{
    public interface IAimService
    {
        IEnumerable<Aim> GetAll();
    }
}