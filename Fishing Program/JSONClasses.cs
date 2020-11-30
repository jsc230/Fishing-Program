using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_Program
{

    public class Rootobject
    {
        public string name { get; set; }
        public string declaredType { get; set; }
        public string scope { get; set; }
        public Value value { get; set; }
        public bool nil { get; set; }
        public bool globalScope { get; set; }
        public bool typeSubstituted { get; set; }
    }

    public class Value
    {
        public Queryinfo queryInfo { get; set; }
        public Timesery[] timeSeries { get; set; }
    }

    public class Queryinfo
    {
        public string queryURL { get; set; }
        public Criteria criteria { get; set; }
        public Note[] note { get; set; }
    }

    public class Criteria
    {
        public string locationParam { get; set; }
        public string variableParam { get; set; }
        public object[] parameter { get; set; }
    }

    public class Note
    {
        public object value { get; set; }
        public string title { get; set; }
    }

    public class Timesery
    {
        public Sourceinfo sourceInfo { get; set; }
        public Variable variable { get; set; }
        public Value1[] values { get; set; }
        public string name { get; set; }
    }

    public class Sourceinfo
    {
        public string siteName { get; set; }
        public Sitecode[] siteCode { get; set; }
        public Timezoneinfo timeZoneInfo { get; set; }
        public Geolocation geoLocation { get; set; }
        public object[] note { get; set; }
        public object[] siteType { get; set; }
        public Siteproperty[] siteProperty { get; set; }
    }

    public class Timezoneinfo
    {
        public Defaulttimezone defaultTimeZone { get; set; }
        public Daylightsavingstimezone daylightSavingsTimeZone { get; set; }
        public bool siteUsesDaylightSavingsTime { get; set; }
    }

    public class Defaulttimezone
    {
        public string zoneOffset { get; set; }
        public string zoneAbbreviation { get; set; }
    }

    public class Daylightsavingstimezone
    {
        public string zoneOffset { get; set; }
        public string zoneAbbreviation { get; set; }
    }

    public class Geolocation
    {
        public Geoglocation geogLocation { get; set; }
        public object[] localSiteXY { get; set; }
    }

    public class Geoglocation
    {
        public string srs { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }
    }

    public class Sitecode
    {
        public string value { get; set; }
        public string network { get; set; }
        public string agencyCode { get; set; }
    }

    public class Siteproperty
    {
        public string value { get; set; }
        public string name { get; set; }
    }

    public class Variable
    {
        public Variablecode[] variableCode { get; set; }
        public string variableName { get; set; }
        public string variableDescription { get; set; }
        public string valueType { get; set; }
        public Unit unit { get; set; }
        public Options options { get; set; }
        public object[] note { get; set; }
        public float noDataValue { get; set; }
        public object[] variableProperty { get; set; }
        public string oid { get; set; }
    }

    public class Unit
    {
        public string unitCode { get; set; }
    }

    public class Options
    {
        public Option[] option { get; set; }
    }

    public class Option
    {
        public string name { get; set; }
        public string optionCode { get; set; }
    }

    public class Variablecode
    {
        public string value { get; set; }
        public string network { get; set; }
        public string vocabulary { get; set; }
        public int variableID { get; set; }
        public bool _default { get; set; }
    }

    public class Value1
    {
        public Value2[] value { get; set; }
        public Qualifier[] qualifier { get; set; }
        public object[] qualityControlLevel { get; set; }
        public Method[] method { get; set; }
        public object[] source { get; set; }
        public object[] offset { get; set; }
        public object[] sample { get; set; }
        public object[] censorCode { get; set; }
    }

    public class Value2
    {
        public string value { get; set; }
        public string[] qualifiers { get; set; }
        public DateTime dateTime { get; set; }
    }

    public class Qualifier
    {
        public string qualifierCode { get; set; }
        public string qualifierDescription { get; set; }
        public int qualifierID { get; set; }
        public string network { get; set; }
        public string vocabulary { get; set; }
    }

    public class Method
    {
        public string methodDescription { get; set; }
        public int methodID { get; set; }
    }

}
