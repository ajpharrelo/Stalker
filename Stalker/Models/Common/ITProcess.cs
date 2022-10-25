using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stalker.Models.Common
{
    internal interface ITProcess
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string ExecutablePath { get; set; }
        public DateTime StartTime { get; }
        public DateTime ExitTime { get; }
    }
}
