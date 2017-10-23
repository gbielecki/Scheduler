using Scheduler.Logic.Domain.Compositions;
using System;

namespace Scheduler.Logic
{
    public class Note : INotification
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public DateTime ReminderDateTime { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsArchivized { get; set; }
    }
}
