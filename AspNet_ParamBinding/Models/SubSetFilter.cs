using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNet_ParamBinding.Models
{
    public class SubSetFilter
        : IFilterDef
    {
        public SubSetFilter(long[] subSet)
        {
            SubSet = subSet;
        }

        public long FDEF => 1;

        public long[] SubSet { get; }
    }
}