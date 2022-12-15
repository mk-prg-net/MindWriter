using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNet_ParamBinding.Models
{
    /// <summary>
    /// mko, 15.12.2022
    /// Hilfsklasse zum Einlesen aus JSon
    /// </summary>
    internal class _TimePeriod
    {
        public string BEGIN { get; set; }
        public string END { get; set; }

    }

    /// <summary>
    /// mko, 15.12.2022
    /// Geschäftsobjekt
    /// </summary>
    public class TimePeriod
    {
        internal TimePeriod(_TimePeriod period)
        {
            Begin = DateTime.Parse(period.BEGIN);
            End = DateTime.Parse(period.END);
        }

        public TimePeriod(DateTime begin, DateTime end)
        {
            Begin = begin;
            End = end;
        }

        public DateTime Begin { get; }
        public DateTime End { get; }
    }



}