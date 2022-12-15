using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AspNet_ParamBinding.Controllers
{
    public class FilterDefController : ApiController
    {
        [HttpPost]
        public string FilterAndSort(List<Models.IFilterDef> FilterList)
        {
            Debug.WriteLine(FilterList);

            return "ok";
        }

    }
}
