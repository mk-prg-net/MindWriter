using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Metadata;
using ApiCtrl = System.Web.Http.Controllers;
using static Newtonsoft.Json.Linq.Extensions;


namespace AspNet_ParamBinding.Models
{
    /// <summary>
    /// mko, 15.12.2022
    /// </summary>
    public class FilterListParameterBindingRule
    {
        public static HttpParameterBinding GetRule(HttpParameterDescriptor paramDescriptor)
        {
            HttpParameterBinding ret = null;

            if(paramDescriptor.ParameterName == "FilterList")
            {
                ret = new MyJSONParameterBinding(paramDescriptor, "FilterList");
            }

            return ret;
        }
    }
}