using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project11.Models
{
    public class LogEntry
    {
        public DateTime DateTime { get; set; }
        public Guid Guid { get; } = new Guid();
        public string Title { get; set; }
        public string Text { get; set; }
        public IList<int> LinkedImageIDs { get; set; }
    }
}
