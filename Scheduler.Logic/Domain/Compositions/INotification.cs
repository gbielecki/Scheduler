
namespace Scheduler.Logic.Domain.Compositions
{
    public interface INotification
    {
        int Id { get; set; }
        string Content { get; set; }
        bool IsDeleted { get; set; }
        bool IsArchivized { get; set; }
    }
}
