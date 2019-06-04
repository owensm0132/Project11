using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project11.Models
{
    public enum MileStoneStatus
    {
        NotStarted,
        InProgress,
        Completed
    };

    public class MileStone
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public MileStoneStatus Status { get; set; }
    }
}
