using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.StrategyPattern
{
    public class BetterAddContext : IComment
    {
        public string ShowComment()
        {
            return"Better to add some data.";
        }
    }
}
