using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNet_ParamBinding.Models
{
    public class TimePeriodFilter
        : TimePeriod,
        IFilterDef
    {
        internal TimePeriodFilter(_TimePeriod _timePeriod)
            : base(_timePeriod)
        {
        }        

        public long FDEF => 2;
    }
}