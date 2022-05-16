using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.StrategyPattern
{
    public class EmptyContext : IComment
    {
        public string ShowComment()
        {
            return "The table is empty.";
        }
    }
}
