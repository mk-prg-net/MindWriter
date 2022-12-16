using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Metadata;
using ApiCtrl = System.Web.Http.Controllers;
using static Newtonsoft.Json.Linq.Extensions;

namespace AspNet_ParamBinding.Models
{
    public class MyJSONParameterBinding
        : ApiCtrl.HttpParameterBinding
    {

        string JsonParameterName;


        /// <summary>
        /// mko, 15.12.2022
        /// </summary>
        /// <param name="descr"></param>
        /// <param name="JsonParameterName"></param>
        public MyJSONParameterBinding(ApiCtrl.HttpParameterDescriptor descr, string JsonParameterName)
            : base(descr)
        {
            this.JsonParameterName = JsonParameterName;
        }
        /// <summary>
        /// mko, 15.12.2022
        /// Deserialisiert folgendes Format
        /// 
        /// [
        ///     {
        ///         'FTYPE': 1,
        ///         'FDEF': [99, 200, 300]
        ///     },
        ///     
        ///     {
        ///         'FTYPE': 2,
        ///         'FDEF': {
        ///             'BEGIN': "2022-12-01", 
        ///             'END': "2023-01-31"
        ///         }
        ///     }
        /// ]
        /// 
        /// </summary>
        /// <param name="metadataProvider"></param>
        /// <param name="actionContext"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override async Task ExecuteBindingAsync(ModelMetadataProvider metadataProvider, HttpActionContext actionContext, CancellationToken cancellationToken)
        {
            var content = actionContext.Request.Content;

            var strJson = await content.ReadAsStringAsync();

            // Json Parsen

            var mainArray = Newtonsoft.Json.Linq.JArray.Parse(strJson);
            var filterList = new List<IFilterDef>();
            foreach (var elem in mainArray)
            {
                var ftype = elem["FTYPE"].ToObject<long>();
                switch (ftype)
                {
                    case 1:
                        var arr = elem["FDEF"].ToArray().Select<Newtonsoft.Json.Linq.JToken, long>(jtok => jtok.ToObject<long>()).ToArray();
                        var subset = new SubSetFilter(arr);
                        filterList.Add(subset);
                        break;
                    case 2:
                        var _timePeriod = elem["FDEF"].ToObject<_TimePeriod>();
                        var timePeriod = new TimePeriodFilter(_timePeriod);
                        filterList.Add(timePeriod);
                        break;
                    default:
                        break;
                }
            }

            SetValue(actionContext, filterList);

        }
    }
}