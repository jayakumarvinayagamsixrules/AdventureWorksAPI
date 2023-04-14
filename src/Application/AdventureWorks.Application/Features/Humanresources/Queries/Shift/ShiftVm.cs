using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.Application.Features.Humanresources.Queries.Shift
{
    public class ShiftVm
    {
        public string Name { get; set; } = null!;       
        public TimeSpan StartTime { get; set; }      
        public TimeSpan EndTime { get; set; }
    }
}
