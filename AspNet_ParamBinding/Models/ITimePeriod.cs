using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNet_ParamBinding.Models
{
    public interface ITimePeriod
    {
        DateTime Begin { get; }
        DateTime End { get; }

    }
}
