namespace ProjectC_DataAccess;

public class Repository<T>
{
    private readonly List<T> _store = new();

    public void Add(T entity) => _store.Add(entity);

    public IReadOnlyList<T> GetAll() => _store.AsReadOnly();
}
