using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.StrategyPattern
{
    public class EnoughContext : IComment
    {
        public string ShowComment()
        {
            return "We have enough data.";
        }
    }
}
