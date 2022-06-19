using KennisbeursGrimbergen.Entities;

namespace KennisbeursGrimbergen.Data;

public abstract class BaseRepository<TEntity> where TEntity : Entity
{
    public KGContext _context { get; }

    public BaseRepository(KGContext context)
    {
        _context = context;
    }

    public TEntity? FindById(long id) => _context
        .Set<TEntity>()
        .Where(entity => entity.Id == id)
        .FirstOrDefault();

    public void Create(TEntity entity)
    {
        _context.Set<TEntity>().Add(entity);
        _context.SaveChanges();
    }

    public void Update(TEntity entity)
    {
        _context.Set<TEntity>().Update(entity);
        _context.SaveChanges();
    }

    public void Delete(TEntity entity)
    {
        _context.Set<TEntity>().Remove(entity);
        _context.SaveChanges();
    }
}
