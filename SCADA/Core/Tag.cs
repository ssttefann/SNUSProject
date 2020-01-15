using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Core
{
    [DataContract]
    [KnownType(typeof(AnalogTag))]
    [KnownType(typeof(DigitalTag))]
    public class Tag
    {
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string address { get; set; }
        [DataMember]
        public int scanTime { get; set; }
        [DataMember]
        public bool on { get; set; }
        [DataMember]
        public double Value { get; set; }
    }

    [DataContract]
    public class DigitalTag : Tag
    {

    }

    [DataContract]
    public class AnalogTag : Tag
    {
        [DataMember]
        public double lowLimit { get; set; }
        [DataMember]
        public double highLimit { get; set; }
    }
}