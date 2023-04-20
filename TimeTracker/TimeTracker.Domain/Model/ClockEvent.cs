using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.Domain.Model
{
    public class ClockEvent
    {
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }
        public ClockEventType Type { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }

}
