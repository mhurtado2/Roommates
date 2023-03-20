using Roommates_2nd_version_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roommates_2nd_version_.Models
{
    public class ChoreCount
    {
        public Roommate Roommate { get; set; }
        public RoommateChore RoommateChore { get; set; }
        public int NumChores { get; set; }
    }
}
