using KennisbeursGrimbergen.Entities;

namespace KennisbeursGrimbergen.Data;

public class ActivityRepository : BaseRepository<Activity>
{
    public ActivityRepository(KGContext context) : base(context)
    {
        //
    }

    public Activity FindOne() => _context.Activities.First();

    public Activity FindById(long Id)
    {
        var activity = _context.Activities
            .FirstOrDefault(a => a.Id == Id);
        return activity;
    }

    public Activity[] FindAll()
    {
        var activities = _context.Activities
            .ToArray();
        return activities;
    }
}
