namespace BlabberApp.Domain
{
    public interface IDataStore
    {
        bool Create(IDatum datum);

        IDatum Read(ISpeciman speciman);

        bool Update(IDatum datum);

        bool Delete(int idx);
    }
}